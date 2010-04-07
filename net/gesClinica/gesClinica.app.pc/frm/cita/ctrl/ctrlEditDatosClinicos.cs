using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlEditDatosClinicos: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditDatosClinicos _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Cita objVO = null;
                if (newRecord)
                    objVO = new Cita();
                else
                    objVO = (Cita)_vista.InnerVO;

                objVO.Sintomas = (!string.IsNullOrEmpty(_vista.txtSintomas.RichTextBox.Text))?_vista.txtSintomas.RichTextBox.Rtf:string.Empty;
                objVO.Diagnostico = (!string.IsNullOrEmpty(_vista.txtDiagnostico.RichTextBox.Text)) ? _vista.txtDiagnostico.RichTextBox.Rtf : string.Empty;
                objVO.Tratamiento = (!string.IsNullOrEmpty(_vista.txtTratamiento.RichTextBox.Text)) ? _vista.txtTratamiento.RichTextBox.Rtf : string.Empty;

                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarDatosPaciente(ref repsol.forms.template.edicion.EditForm frm, Paciente paciente)
        {
            try
            {
                _vista = (frmEditDatosClinicos)frm;
                _vista.txtMuyImportante.Text = paciente.MuyImportante;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarDatos(ref frmEditDatosClinicos frm)
        {
            _vista = (frmEditDatosClinicos)frm;

            _vista.Text = "Datos Clínicos" + " - Teléf. del paciente: ";
            if (_vista.dgCitas.CurrentRow != null)
            {
                Cita objVO = (Cita)_vista.dgCitas.CurrentRow.DataBoundItem;

                _vista.InnerVO = objVO;
                _vista.Text += objVO.Paciente.Telefonos;
                _vista.labPaciente.Text = string.Format("Datos del paciente : {0} - {1} - {2} - Inicio {3}", objVO.Paciente.ToString(), objVO.Paciente.Edad, objVO.Terapia != null ? objVO.Terapia.ToString() : "Cita Telefónica", objVO.Fecha.ToString("HH:mm"), objVO.Paciente.Telefono1);
                _vista.txtMuyImportante.Text = objVO.Paciente.MuyImportante;

                try
                {
                    _vista.txtSintomas.RichTextBox.Rtf = objVO.Sintomas;
                }
                catch
                {
                    _vista.txtSintomas.RichTextBox.Text = objVO.Sintomas;
                }
                try
                {
                    _vista.txtDiagnostico.RichTextBox.Rtf = objVO.Diagnostico;
                }
                catch
                {
                    _vista.txtDiagnostico.RichTextBox.Text = objVO.Diagnostico;
                }
                try
                {
                    _vista.txtTratamiento.RichTextBox.Rtf = objVO.Tratamiento;
                }
                catch
                {
                    _vista.txtTratamiento.RichTextBox.Text = objVO.Tratamiento;
                }

                lib.bl.paciente.doGet lnPaciente = new gesClinica.lib.bl.paciente.doGet(objVO.Paciente);
                objVO.Paciente = lnPaciente.execute();

                if (objVO.Paciente.Mujer)
                    cargarDatosGinecologicos(ref _vista, objVO.Paciente);
                else
                    _vista.tabDatosClinicos.TabPages.Remove(_vista.tpageDatosGinecologicos);

                lib.bl.receta.doGetAll lnReceta = new gesClinica.lib.bl.receta.doGetAll(objVO);
                objVO.Receta = lnReceta.execute();

                #region Cargar Detalle Recetas

                foreach (Receta receta in objVO.Receta)
                {
                    lib.bl.recetadetalle.doGetAll lnRecetaDetalle = new gesClinica.lib.bl.recetadetalle.doGetAll(receta);
                    receta.Detalle = lnRecetaDetalle.execute();
                }

                #endregion

                lib.bl.anexo.doGetAll lnAnexo = new gesClinica.lib.bl.anexo.doGetAll(objVO);
                objVO.Anexo = lnAnexo.execute();
                System.Windows.Forms.Control cAnexo = (System.Windows.Forms.Control)_vista.tpageAnexos;
                _vista._frmAnexos.ShowDocked(ref cAnexo);

                updateHistorial(ref frm);
            }
            else
            {
                _vista.Text += _vista.Paciente.Telefonos;
                _vista.labPaciente.Text = string.Format("Datos del paciente : {0} - {1}", _vista.Paciente.ToString(), _vista.Paciente.Edad);
                _vista.txtMuyImportante.Text = _vista.Paciente.MuyImportante; 
            }
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEditDatosClinicos)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                Cita objVO = (Cita)obj;


                //if (_vista.dgCitas.CurrentCellChanged!=null)
                //_vista.dgCitas.CurrentCellChanged -= new EventHandler(dgCitas_CurrentCellChanged);

                //_vista.dgCitas.CurrentCellChanged += new EventHandler(dgCitas_CurrentCellChanged);

                #region dgCitas

                List<Cita> listCita;

                if (objVO == null) objVO = new Cita(_vista.Paciente);
                if (!_vista.chkSoloMio.Checked)
                {
                    lib.bl.cita.doGetAllPorPaciente lnCitaPaciente = new gesClinica.lib.bl.cita.doGetAllPorPaciente(objVO.Paciente, true);
                    listCita = lnCitaPaciente.execute();
                }
                else
                {
                    lib.bl.cita.doGetAllPorPacienteYTerapeuta lnCitaPaciente = new gesClinica.lib.bl.cita.doGetAllPorPacienteYTerapeuta(objVO.Paciente, lib.bl._common.cache.EMPLEADO, true);
                    listCita = lnCitaPaciente.execute();
                }


                listCita.Sort(sortCitasFechas);
                _vista.dgCitas.DataSource = listCita;
                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgCitas.Columns)
                    col.Visible = false;

                _vista.dgCitas.Columns["Fecha"].Visible = true;
                _vista.dgCitas.Columns["Fecha"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgCitas.Columns["Fecha"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

                _vista.dgCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _vista.dgCitas.AllowUserToResizeRows = false;
                _vista.dgCitas.AllowUserToResizeColumns = false;
                _vista.dgCitas.RowHeadersVisible = false;
                _vista.dgCitas.AllowUserToAddRows = false;
                _vista.dgCitas.AllowUserToDeleteRows = false;
                _vista.dgCitas.AllowUserToOrderColumns = false;
                _vista.dgCitas.ReadOnly = true;

                foreach (System.Windows.Forms.DataGridViewRow row in _vista.dgCitas.Rows)
                {
                    Cita tmp = (Cita)row.DataBoundItem;
                    if ((tmp != null) && (tmp.ID == objVO.ID))
                    {
                        _vista.dgCitas.CurrentCell = row.Cells["Fecha"];
                        break;
                    }
                }
                if ((_vista.dgCitas.CurrentRow == null) && (_vista.dgCitas.Rows.Count > 0))
                    _vista.dgCitas.CurrentCell = _vista.dgCitas.Rows[0].Cells["Fecha"];


                cargarDatos(ref _vista);
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        void dgCitas_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                _vista = (frmEditDatosClinicos)((System.Windows.Forms.Control)sender).FindForm();
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                if (_vista.Loaded)
                {
                    //if (System.Windows.Forms.MessageBox.Show("¿Desea guardar los datos?", _vista.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button3)
                    //    == System.Windows.Forms.DialogResult.Yes)
                    //{
                    //    repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)_vista;
                    //    guardarDatos(ref frm, _vista.IsNewRecord);
                    //}

                    cargarDatos(ref _vista);
                }
            }
            catch (Exception ex)
            {
                pc.template._common.messages.ShowError(ex);
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }

        }

        private int sortCitasFechas(lib.vo.Cita one, lib.vo.Cita other)
        {
            return -one.Fecha.CompareTo(other.Fecha);
        }

        public void editarDatosGinecologicos(ref frmEditDatosClinicos frm)
        {
            try
            {
                _vista = frm;

                Cita cita = (Cita)_vista.InnerVO;
                lib.bl.extpaciente.doGetByPaciente lnExtPaciente = new gesClinica.lib.bl.extpaciente.doGetByPaciente(cita.Paciente);
                ExtPaciente extpaciente = lnExtPaciente.execute();

                extpaciente.frmEdit vVen = new gesClinica.app.pc.frm.extpaciente.frmEdit(extpaciente, cita.Paciente);
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    cargarDatosGinecologicos(ref frm, vVen.Paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarDatosGinecologicos(ref frmEditDatosClinicos frm, Paciente paciente)
        {
            try
            {
                _vista = frm;

                lib.bl.extpaciente.doGetByPaciente lnExtPaciente = new gesClinica.lib.bl.extpaciente.doGetByPaciente(paciente);
                ExtPaciente extpaciente = lnExtPaciente.execute();
                if (extpaciente != null)
                {
                    _vista.txtAbortos.Text = extpaciente.Abortos.ToString();
                    _vista.txtAnticonceptivos.Text = extpaciente.Anticonceptivos.ToString();
                    _vista.txtCesareas.Text = extpaciente.Cesareas.ToString();
                    _vista.txtDismenorrea.Text = extpaciente.Dismenorrea;
                    _vista.txtDispareunemia.Text = extpaciente.Dispareunemia;
                    _vista.txtGestaciones.Text = extpaciente.Gestaciones.ToString();
                    _vista.txtMenarquia.Text = extpaciente.Menarquia.ToString();
                    _vista.txtMenopausia.Text = extpaciente.Menopausia.ToString();
                    _vista.txtMolestiasPelvicas.Text = extpaciente.MolestiasPelvicas;
                    _vista.txtObservaciones.Text = extpaciente.Observaciones;
                    _vista.txtPartos.Text = extpaciente.Partos.ToString();
                    _vista.txtReglaDuracion.Text = extpaciente.ReglaDuracion.ToString();
                    _vista.txtReglaFrecuencia.Text = extpaciente.ReglaFrecuencia.ToString();
                    _vista.txtSindromePremenstrual.Text = extpaciente.SindromePremenstrual;
                    _vista.txtTratamientosHormonales.Text = extpaciente.Hormonas;
                    _vista.txtVivos.Text = extpaciente.Vivos.ToString();
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEditDatosClinicos)frm;
                Cita objVO = (Cita)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.cita.doAdd lnCita = new gesClinica.lib.bl.cita.doAdd(objVO);
                    lnCita.execute();
                }
                else
                {
                    lib.bl.cita.doUpdateDatosClinicos lnCita = new gesClinica.lib.bl.cita.doUpdateDatosClinicos(objVO);
                    lnCita.execute();
                }

                #region dgCitas

                //lib.bl.cita.doGetAllPorPaciente lnCitaPaciente = new gesClinica.lib.bl.cita.doGetAllPorPaciente(objVO.Paciente);
                //List<Cita> listCita = lnCitaPaciente.execute();

                //listCita.Sort(sortCitasFechas);
                //_vista.dgCitas.DataSource = listCita;
                //foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgCitas.Columns)
                //    col.Visible = false;

                //_vista.dgCitas.Columns["Fecha"].Visible = true;
                //_vista.dgCitas.Columns["Fecha"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                //_vista.dgCitas.Columns["Fecha"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

                //_vista.dgCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                //_vista.dgCitas.AllowUserToResizeRows = false;
                //_vista.dgCitas.AllowUserToResizeColumns = false;
                //_vista.dgCitas.RowHeadersVisible = false;
                //_vista.dgCitas.AllowUserToAddRows = false;
                //_vista.dgCitas.AllowUserToDeleteRows = false;
                //_vista.dgCitas.AllowUserToOrderColumns = false;
                //_vista.dgCitas.ReadOnly = true;

                //foreach (System.Windows.Forms.DataGridViewRow row in _vista.dgCitas.Rows)
                //{
                //    Cita tmp = (Cita)row.DataBoundItem;
                //    if ((tmp != null) && (tmp.ID == objVO.ID))
                //    {
                //        _vista.dgCitas.CurrentCell = row.Cells["Fecha"];
                //        break;
                //    }
                //}

                #endregion

                _vista.labInfoGuardado.Text = string.Format("Último guardado : {0}",DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmEditDatosClinicos)frm;

                //TODO: Historial - Ocultamos la pagina del Historial
                //_vista.tabDatosClinicos.TabPages.Remove(_vista.tpageHistoriaCompleta);

                _vista.Aceptar.Location = new System.Drawing.Point(695, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(776, 11);

                _vista.chkSoloMio.Checked = lib.bl._common.cache.EMPLEADO.VerSoloLoMio;

                _vista.dgCitas.CurrentCellChanged += new EventHandler(dgCitas_CurrentCellChanged);
                _vista.dgCitas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgCitas_CellPainting);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void dgCitas_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Cita tmp = (Cita)((System.Windows.Forms.DataGridView)sender).Rows[e.RowIndex].DataBoundItem;
                if (!tmp.Presencial) e.CellStyle.BackColor = System.Drawing.Color.PaleGreen;
            }
        }

        public void updateHistorial(ref frmEditDatosClinicos frm)
        {
            try
            {
                _vista = frm;

                if (
                    (_vista.tabDatosClinicos.SelectedTab == _vista.tpageResumen)
                    ||
                    (_vista.tabDatosClinicos.SelectedTab == _vista.tpageHistoriaCompleta)
                   )
                {
                    //this._vista.txtResumen.TextRTF = _vista.txtSintomas.TextRTF;
                    ////this._vista.txtResumen.AppendRtf(_vista.txtSintomas.TextRTF);
                    //this._vista.txtResumen.AppendRtf(_vista.txtDiagnostico.TextRTF);
                    //this._vista.txtResumen.AppendRtf(_vista.txtTratamiento.TextRTF);                    

                    Cita temp = new Cita();
                    temp.Empleado = ((Cita)_vista.InnerVO).Empleado;
                    temp.Fecha= ((Cita)_vista.InnerVO).Fecha;

                    if (!string.IsNullOrEmpty(_vista.txtSintomas.Text)) temp.Sintomas = _vista.txtSintomas.TextRTF;
                    if (!string.IsNullOrEmpty(_vista.txtDiagnostico.Text)) temp.Diagnostico = _vista.txtDiagnostico.TextRTF;
                    if (!string.IsNullOrEmpty(_vista.txtTratamiento.Text)) temp.Tratamiento = _vista.txtTratamiento.TextRTF;
                    temp.Receta = ((Cita)_vista.InnerVO).Receta;

                    _vista.txtResumen.TextRTF = temp.Resumen;

                    List<Cita> list = (List<Cita>)_vista.dgCitas.DataSource;
                    //TODO: Historial - Resolver que se come la ultima frase de cada resumen.
                    _vista.txtHistoriaCompleta.Text = string.Empty;
                    foreach (Cita cita in list)
                    {

                        #region "Prueba"
                        System.Windows.Forms.RichTextBox txtTmp = new System.Windows.Forms.RichTextBox();
                        Cita citaTmp = cita.GetCopy();
                        if (string.IsNullOrEmpty(cita.Sintomas))
                        {
                            try
                            {
                                txtTmp.Rtf = cita.Sintomas;
                            }
                            catch (Exception)
                            {
                                txtTmp.Text = cita.Sintomas;
                            }
                            citaTmp.Sintomas = txtTmp.Rtf;
                        }
                        if (string.IsNullOrEmpty(cita.Diagnostico))
                        {
                            try
                            {
                                txtTmp.Rtf = cita.Diagnostico;
                            }
                            catch (Exception)
                            {
                                txtTmp.Text = cita.Diagnostico;
                            }
                            citaTmp.Diagnostico = txtTmp.Rtf;
                        }
                        if (string.IsNullOrEmpty(cita.Tratamiento))
                        {
                            try
                            {
                                txtTmp.Rtf = cita.Tratamiento;
                            }
                            catch (Exception)
                            {
                                txtTmp.Text = cita.Tratamiento;
                            }
                            citaTmp.Tratamiento = txtTmp.Rtf;
                        }
                        if (string.IsNullOrEmpty(cita.Prescrito))
                        {
                            citaTmp.Receta = cita.Receta;
                        }
                        #endregion

                        //_vista.txtHistoriaCompleta.AppendRtf(cita.Resumen);
                        _vista.txtHistoriaCompleta.AppendRtf(citaTmp.Resumen);
                    }

                    //_vista.txtHistoriaCompleta.RichTextBox.Rtf = rtbTmp.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cita getCitaTelefonica(ref frmEditDatosClinicos frm)
        {
            try
            {
                _vista = frm;

                Cita tmp = (Cita)_vista.InnerVO;

                if (tmp == null)
                {
                    tmp = new Cita(_vista.Paciente);
                    tmp.Empleado = lib.bl._common.cache.EMPLEADO;
                }
                
                Cita res = new Cita();

                res.Fecha = DateTime.Now;
                res.Empleado = tmp.Empleado;
                res.Duracion = 0;
                res.Presencial = false;
                res.Paciente = tmp.Paciente;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Paciente getPaciente(ref frmEditDatosClinicos frm)
        {
            try
            {
                _vista = frm;

                Cita tmp = (Cita)_vista.InnerVO;
                if (tmp == null) tmp = new Cita(_vista.Paciente);

                Paciente res = tmp.Paciente;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
