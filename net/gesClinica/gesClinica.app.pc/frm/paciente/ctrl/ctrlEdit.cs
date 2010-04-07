using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.paciente.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Paciente objVO = null;
                if (newRecord)
                {
                    objVO = new Paciente();
                }
                else
                {
                    objVO = (Paciente)_vista.InnerVO;
                }

                objVO.MuyImportante = _vista.txtMuyImportante.Text;

                objVO.Apellido1 = _vista.txtApellido1.Text;
                objVO.Apellido2 = _vista.txtApellido2.Text;
                objVO.Nombre = _vista.txtNombre.Text;
                objVO.EstadoCivil = (EstadoCivil)_vista.cmbEstadoCivil.SelectedItem;
                objVO.Tarifa = (Tarifa)_vista.cmbTarifa.SelectedItem;
                objVO.Mujer = _vista.rbMujer.Checked;

                objVO.NIF = _vista.txtNIF.Text;
                objVO.Hijos = Convert.ToByte(_vista.txtHijos.Value);
                if (_vista.dateFechaNacimiento.Checked) objVO.FechaNacimiento = _vista.dateFechaNacimiento.Value;
                objVO.Profesion = _vista.txtProfesion.Text;
                objVO.RecomendadoPor = _vista.txtRecomendadoPor.Text;
                if (_vista.picFoto.Image != null)
                    objVO.Foto = _vista.picFoto.Image;
                else
                    objVO.Foto = null;

                if (!string.IsNullOrEmpty(_vista.txtSubCuenta.Text))
                    objVO.SubCuenta = new SubCuenta(_vista.txtSubCuenta.Text);
                else
                    objVO.SubCuenta = null;

                objVO.Direccion = _vista.txtDireccion.Text;
                objVO.Localidad = _vista.txtLocalidad.Text;
                objVO.CP= _vista.txtCP.Text;
                objVO.Provincia= _vista.txtProvincia.Text;
                objVO.Profesion = _vista.txtProfesion.Text;
                objVO.Telefono1 = _vista.txtTelefono1.Text;
                objVO.Telefono2 = _vista.txtTelefono2.Text;
                objVO.Telefono3 = _vista.txtTelefono3.Text;
                objVO.Observaciones = _vista.txtObservaciones.Text;

                objVO.NotasAgenda = _vista.txtNotasDeAgenda.Text;

                objVO.Descuentos = (List<Descuento>)_vista.dgDescuentos.DataSource;

                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEdit)frm;
                Paciente objVO = (Paciente)obj;

                _vista.InnerVO = objVO;

                _vista.txtMuyImportante.Text = objVO.MuyImportante;

                _vista.txtApellido1.Text = objVO.Apellido1;
                _vista.txtApellido2.Text = objVO.Apellido2;
                _vista.txtNombre.Text = objVO.Nombre;

                if (objVO.SubCuenta != null) _vista.txtSubCuenta.Text = objVO.SubCuenta.Codigo;

                if (objVO.EstadoCivil != null) _vista.cmbEstadoCivil.SelectedValue = objVO.EstadoCivil.ID;
                if (objVO.Tarifa != null) _vista.cmbTarifa.SelectedValue = objVO.Tarifa.ID;
                _vista.rbHombre.Checked = !objVO.Mujer;
                _vista.rbMujer.Checked = objVO.Mujer;
                _vista.txtNIF.Text = objVO.NIF;
                _vista.txtHijos.Value = objVO.Hijos;
                if (objVO.FechaNacimiento.HasValue)
                {
                    _vista.dateFechaNacimiento.Checked = true;
                    _vista.dateFechaNacimiento.Value = objVO.FechaNacimiento.Value;
                }
                if (objVO.Foto != null)
                    _vista.picFoto.Image = objVO.Foto;
                _vista.txtProfesion.Text = objVO.Profesion;
                _vista.txtRecomendadoPor.Text = objVO.RecomendadoPor;
                _vista.txtDireccion.Text = objVO.Direccion;
                _vista.txtLocalidad.Text = objVO.Localidad;
                _vista.txtCP.Text = objVO.CP;
                _vista.txtProvincia.Text = objVO.Provincia;
                _vista.txtTelefono1.Text = objVO.Telefono1;
                _vista.txtTelefono2.Text = objVO.Telefono2;
                _vista.txtTelefono3.Text = objVO.Telefono3;
                _vista.txtObservaciones.Text = objVO.Observaciones;
                _vista.txtNotasDeAgenda.Text = objVO.NotasAgenda;



                #region dgCitas

                if (lib.bl._common.cache.EMPLEADO.Terapeuta)
                {
                    lib.bl.cita.doGetAllPorPaciente lnCitaPaciente = new gesClinica.lib.bl.cita.doGetAllPorPaciente(objVO,false);
                    List<Cita> listCita = lnCitaPaciente.execute();

                    listCita.Sort(sortCitasFechas);
                    _vista.dgCitas.DataSource = listCita;
                    foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgCitas.Columns)
                        col.Visible = false;

                    _vista.dgCitas.Columns["Fecha"].Visible = true;
                    _vista.dgCitas.Columns["Fecha"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgCitas.Columns["Fecha"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

                    _vista.dgCitas.Columns["Terapia"].Visible = true;
                    _vista.dgCitas.Columns["Terapia"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    _vista.dgCitas.Columns["Terapia"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                    _vista.dgCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    _vista.dgCitas.AllowUserToResizeRows = false;
                    _vista.dgCitas.AllowUserToResizeColumns = false;
                    _vista.dgCitas.RowHeadersVisible = false;
                    _vista.dgCitas.AllowUserToAddRows = false;
                    _vista.dgCitas.AllowUserToDeleteRows = false;
                    _vista.dgCitas.AllowUserToOrderColumns = false;
                    _vista.dgCitas.ReadOnly = true;
                    _vista.dgCitas.MultiSelect = false;
                }
                else
                    _vista.tabPaciente.TabPages.Remove(_vista.tpageDatosClinicos);

                #endregion

                #region dgSaldos

                if (lib.bl._common.cache.EMPLEADO.Administrativo)
                {
                    lib.bl.operacion.doGetAllPorPaciente lnOperacionPaciente = new gesClinica.lib.bl.operacion.doGetAllPorPaciente(objVO);
                    List<Operacion> listOperacion = lnOperacionPaciente.execute();
                    
                    listOperacion.Sort(sortSaldosFechas);
                    _vista.dgSaldos.DataSource = listOperacion;
                    foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgSaldos.Columns)
                        col.Visible = false;

                    _vista.dgSaldos.Columns["Fecha"].Visible = true;
                    _vista.dgSaldos.Columns["Fecha"].DisplayIndex = 0;
                    _vista.dgSaldos.Columns["Fecha"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgSaldos.Columns["Fecha"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

                    _vista.dgSaldos.Columns["DescripcionTerapia"].HeaderText = "Descripción";
                    _vista.dgSaldos.Columns["DescripcionTerapia"].Visible = true;
                    _vista.dgSaldos.Columns["DescripcionTerapia"].DisplayIndex = 1;
                    _vista.dgSaldos.Columns["DescripcionTerapia"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    _vista.dgSaldos.Columns["DescripcionTerapia"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                    _vista.dgSaldos.Columns["Adeudado"].Visible = true;
                    _vista.dgSaldos.Columns["Adeudado"].DisplayIndex = 2;
                    _vista.dgSaldos.Columns["Adeudado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgSaldos.Columns["Adeudado"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgSaldos.Columns["Adeudado"].CellTemplate.Style.Format = "c";

                    _vista.dgSaldos.Columns["Ingresos"].Visible = true;
                    _vista.dgSaldos.Columns["Ingresos"].DisplayIndex = 3;
                    _vista.dgSaldos.Columns["Ingresos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgSaldos.Columns["Ingresos"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgSaldos.Columns["Ingresos"].CellTemplate.Style.Format = "c";

                    _vista.dgSaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    _vista.dgSaldos.AllowUserToResizeRows = false;
                    _vista.dgSaldos.AllowUserToResizeColumns = false;
                    _vista.dgSaldos.RowHeadersVisible = false;
                    _vista.dgSaldos.AllowUserToAddRows = false;
                    _vista.dgSaldos.AllowUserToDeleteRows = false;
                    _vista.dgSaldos.AllowUserToOrderColumns = false;
                    _vista.dgDescuentos.MultiSelect = false;
                    _vista.dgSaldos.ReadOnly = true;

                    objVO.Operaciones = listOperacion;
                    _vista.txtSaldo.Text = objVO.Saldo.ToString("c");

                    lib.bl.paciente.doGetAviones lnAviones = new gesClinica.lib.bl.paciente.doGetAviones(objVO);
                    objVO.setAviones(lnAviones.execute());
                    _vista.txtAviones.Text = objVO.Aviones.ToString();
                }
                else
                    _vista.tabPaciente.TabPages.Remove(_vista.tpageDatosAdministrativos);

                #endregion


                #region dgDescuentos

                //if (lib.bl._common.cache.EMPLEADO.Administrativo)
                //{
                    lib.bl.descuento.doGetAll lnDescuentoPaciente = new gesClinica.lib.bl.descuento.doGetAll(objVO);
                    List<Descuento> listDescuento = lnDescuentoPaciente.execute();

                    _vista.dgDescuentos.DataSource = listDescuento;
                    foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgDescuentos.Columns)
                        col.Visible = false;

                    _vista.dgDescuentos.Columns["Empleado"].Visible = true;
                    _vista.dgDescuentos.Columns["Empleado"].ReadOnly = true;
                    _vista.dgDescuentos.Columns["Empleado"].HeaderText = "Terapeuta";
                    _vista.dgDescuentos.Columns["Empleado"].DisplayIndex = 0;
                    _vista.dgDescuentos.Columns["Empleado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    _vista.dgDescuentos.Columns["Empleado"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                    _vista.dgDescuentos.Columns["Discount"].Visible = true;
                    _vista.dgDescuentos.Columns["Discount"].HeaderText = "Descuento";
                    _vista.dgDescuentos.Columns["Discount"].DisplayIndex = 1;
                    _vista.dgDescuentos.Columns["Discount"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgDescuentos.Columns["Discount"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                    _vista.dgDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
                    _vista.dgDescuentos.AllowUserToResizeRows = false;
                    _vista.dgDescuentos.AllowUserToResizeColumns = false;
                    _vista.dgDescuentos.RowHeadersVisible = false;
                    _vista.dgDescuentos.AllowUserToAddRows = false;
                    _vista.dgDescuentos.AllowUserToDeleteRows = false;
                    _vista.dgDescuentos.AllowUserToOrderColumns = false;
                    _vista.dgDescuentos.MultiSelect = false;
                    _vista.dgDescuentos.ReadOnly = _vista.OnlyView || (!lib.bl._common.cache.EMPLEADO.Administrativo && !lib.bl._common.cache.EMPLEADO.Gerente);
                    _vista.dgDescuentos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dgDescuentos_DataError);
                //}
                //else
                //    _vista.tabPaciente.TabPages.Remove(_vista.tpageDescuentos);

                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void dgDescuentos_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            template._common.messages.ShowWarning("Formato numérico incorrecto!", "Descuentos");
        }

        private int sortCitasFechas(lib.vo.Cita one, lib.vo.Cita other)
        {
            return -one.Fecha.CompareTo(other.Fecha);
        }
        private int sortSaldosFechas(lib.vo.Operacion one, lib.vo.Operacion other)
        {
            return -one.Fecha.CompareTo(other.Fecha);
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEdit)frm;
                Paciente objVO = (Paciente)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.paciente.doAdd lnPaciente = new gesClinica.lib.bl.paciente.doAdd(objVO);
                    lnPaciente.execute();
                }
                else
                {
                    lib.bl.paciente.doUpdate lnPaciente = new gesClinica.lib.bl.paciente.doUpdate(objVO);
                    lnPaciente.execute();
                }
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
                _vista = (frmEdit)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(448, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(534, 11);

                _vista.txtSubCuenta.Text = lib.bl._common.cache.DefaultSubCuentaPaciente;

                // ********************* EstadoCivil *********************
                gesClinica.lib.bl.estadocivil.doGetAll lnEstadoCivil = new gesClinica.lib.bl.estadocivil.doGetAll();
                _vista.cmbEstadoCivil.DataSource = lnEstadoCivil.execute();
                _vista.cmbEstadoCivil.DisplayMember = "Descripcion";
                _vista.cmbEstadoCivil.ValueMember = "ID";
                _vista.cmbEstadoCivil.SelectedIndex = -1;

                // ********************* Tarifa *********************
                gesClinica.lib.bl.tarifa.doGetAll lnTarifa = new gesClinica.lib.bl.tarifa.doGetAll();
                _vista.cmbTarifa.DataSource = lnTarifa.execute();
                _vista.cmbTarifa.DisplayMember = "Descripcion";
                _vista.cmbTarifa.ValueMember = "ID";
                if (_vista.cmbTarifa.Items.Count>0) _vista.cmbTarifa.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
