using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.empleado.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Empleado objVO = null;
                if (newRecord)
                {
                    objVO = new Empleado();
                }
                else
                {
                    objVO = (Empleado)_vista.InnerVO;
                }

                objVO.VerSoloLoMio = _vista.chkVerSoloLoMio.Checked;

                objVO.Administrativo = _vista.chkAdministrativo.Checked;
                objVO.Apellido1 = _vista.txtApellido1.Text;
                objVO.Apellido2 = _vista.txtApellido2.Text;
                objVO.Comision = Convert.ToByte(_vista.txtComision.Text);
                objVO.Login = _vista.txtLogin.Text;
                objVO.Nombre = _vista.txtNombre.Text;
                objVO.Terapeuta = _vista.chkTerapeuta.Checked;
                objVO.Gerente = _vista.chkGerente.Checked;
                objVO.Firma = _vista.txtFirma.Text;

                objVO.VerSoloLoMio = _vista.chkVerSoloLoMio.Checked;

                objVO.Color1 = _vista.cmbColor1.SelectedItem.ToString();
                objVO.Color2 = _vista.cmbColor2.SelectedItem.ToString();

                objVO.Empresa = (Empresa)_vista.cmbRazonSocial.SelectedItem;

                objVO.Terapias.Clear();
                foreach (object item in _vista.lboxTarget.Items)
                    objVO.Terapias.Add((Terapia)item);

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
                Empleado objVO = (Empleado)obj;

                _vista.InnerVO = objVO;

                _vista.chkVerSoloLoMio.Checked = objVO.VerSoloLoMio;

                _vista.chkAdministrativo.Checked = objVO.Administrativo;
                _vista.chkTerapeuta.Checked = objVO.Terapeuta;
                _vista.txtApellido1.Text = objVO.Apellido1;
                _vista.txtApellido2.Text = objVO.Apellido2;
                _vista.txtComision.Text = objVO.Comision.ToString();
                _vista.txtLogin.Text = objVO.Login;
                _vista.txtNombre.Text = objVO.Nombre;
                _vista.chkGerente.Checked = objVO.Gerente;
                _vista.txtFirma.Text = objVO.Firma;

                _vista.cmbColor1.SelectedItem = objVO.Color1;
                _vista.cmbColor2.SelectedItem = objVO.Color2;

                if (objVO.Empresa != null) _vista.cmbRazonSocial.SelectedValue = objVO.Empresa.ID;

                lib.bl.terapia.doGetAllOut lnTerapiaOut = new gesClinica.lib.bl.terapia.doGetAllOut(objVO);
                foreach (Terapia terapia in lnTerapiaOut.execute())
                    _vista.lboxSource.Items.Add(terapia);

                lib.bl.terapia.doGetAllIn lnTerapiaIn = new gesClinica.lib.bl.terapia.doGetAllIn(objVO);
                foreach (Terapia terapia in lnTerapiaIn.execute())
                    _vista.lboxTarget.Items.Add(terapia);
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
                _vista = (frmEdit)frm;
                Empleado objVO = (Empleado)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.empleado.doAdd lnEmpleado = new gesClinica.lib.bl.empleado.doAdd(objVO);
                    lnEmpleado.execute();
                }
                else
                {
                    lib.bl.empleado.doUpdate lnEmpleado = new gesClinica.lib.bl.empleado.doUpdate(objVO);
                    lnEmpleado.execute();
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

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);

                // ********************* Empresa *********************
                gesClinica.lib.bl.empresa.doGetAll lnEmpresa = new gesClinica.lib.bl.empresa.doGetAll();
                _vista.cmbRazonSocial.DataSource = lnEmpresa.execute();
                _vista.cmbRazonSocial.DisplayMember = "RazonSocial";
                _vista.cmbRazonSocial.ValueMember = "ID";
                _vista.cmbRazonSocial.SelectedIndex = -1;


                // ********************* Color 1 *********************
                _vista.cmbColor1.DataSource = gesClinica.lib.vo.EstadoCita.Colores();

                // ********************* Color 2 *********************
                _vista.cmbColor2.DataSource = gesClinica.lib.vo.EstadoCita.Colores();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void moverActividades(ref System.Windows.Forms.ListBox lSource, ref System.Windows.Forms.ListBox lTarget)
        {
            try
            {
                foreach (object item in lSource.SelectedItems)
                    lTarget.Items.Add(item);

                int i = 0;
                while ((i=lSource.SelectedItems.Count) > 0)
                {
                    lSource.Items.Remove(lSource.SelectedItems[i-1]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
