using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento.ctrl
{
    internal class ctrlEditSueldosYSalarios : template.frm.edicion.ctrl.EditCtrl
    {
        frmEditSueldosYSalarios _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Asiento objVO = null;

                Apunte apunteSueldoBruto = null;
                Apunte apunteSeguridadSocialEmpresa = null;
                Apunte apunteSueldoNeto = null;
                Apunte apunteRetencion = null;
                Apunte apunteSeguridadSocialAcreedora = null;

                if (newRecord)
                {
                    objVO = new Asiento();

                    objVO.Apuntes = new List<Apunte>();
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                }
                else
                    objVO = (Asiento)_vista.InnerVO;

                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Observaciones = _vista.txtConcepto.Text;
                objVO.TipoAsiento = tTIPOASIENTO.SUELDO;

                apunteSueldoBruto = objVO.Apuntes[0];
                apunteSeguridadSocialEmpresa = objVO.Apuntes[1];
                apunteSueldoNeto = objVO.Apuntes[2];
                apunteRetencion = objVO.Apuntes[3];
                apunteSeguridadSocialAcreedora = objVO.Apuntes[4];

                apunteSueldoBruto.Concepto = _vista.txtConcepto.Text;
                apunteSeguridadSocialEmpresa.Concepto = _vista.txtConcepto.Text;
                apunteSueldoNeto.Concepto = _vista.txtConcepto.Text;
                apunteRetencion.Concepto = _vista.txtConcepto.Text;
                apunteSeguridadSocialAcreedora.Concepto = _vista.txtConcepto.Text;

                apunteSueldoBruto.Debe = Convert.ToSingle(_vista.txtSueldoBruto.Text);
                apunteSeguridadSocialEmpresa.Debe = Convert.ToSingle(_vista.txtSeguridadSocialEmpresa.Text);
                apunteSueldoNeto.Haber = Convert.ToSingle(_vista.txtSueldoNeto.Text);
                apunteRetencion.Haber = Convert.ToSingle(_vista.txtRetencionTrabajador.Text);
                apunteSeguridadSocialAcreedora.Haber = Convert.ToSingle(_vista.txtSeguridadSocialTrabajador.Text) + Convert.ToSingle(_vista.txtSeguridadSocialEmpresa.Text);
                
                apunteSueldoBruto.SubCuenta = (SubCuenta)_vista.cmbSalario.SelectedItem;
                apunteSeguridadSocialEmpresa.SubCuenta = (SubCuenta)_vista.cmbSeguridadSocial.SelectedItem;
                apunteSueldoNeto.SubCuenta = (SubCuenta)_vista.cmbMedioPago.SelectedItem;
                apunteRetencion.SubCuenta = (SubCuenta)_vista.cmbRetencion.SelectedItem;
                apunteSeguridadSocialAcreedora.SubCuenta = (SubCuenta)_vista.cmbSeguridadSocialAcreedora.SelectedItem;

                //apunteServicio.ContraPartida = apunteCliente.SubCuenta;
                //apunteCliente.ContraPartida = apunteServicio.SubCuenta;
                //apunteRetencion.ContraPartida = apunteServicio.SubCuenta;
                //apunteCliente.ContraPartida = apunteServicio.SubCuenta;
                //apunteRetencion.ContraPartida = apunteServicio.SubCuenta;
                
                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateTotal(ref frmEditSueldosYSalarios frm)
        {
            try
            {
                _vista = (frmEditSueldosYSalarios)frm;

                float sueldoNeto = Convert.ToSingle(_vista.txtSueldoBruto.Text)
                    - Convert.ToSingle(_vista.txtSeguridadSocialTrabajador.Text)
                    - Convert.ToSingle(_vista.txtRetencionTrabajador.Text);

                float seguridadSocialTotal = Convert.ToSingle(_vista.txtSeguridadSocialEmpresa.Text)
                    + Convert.ToSingle(_vista.txtSeguridadSocialTrabajador.Text);

                _vista.txtSueldoNeto.Text = sueldoNeto.ToString();
                _vista.txtSeguridadSocialtotal.Text = seguridadSocialTotal.ToString();
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
                _vista = (frmEditSueldosYSalarios)frm;
                Asiento objVO = (Asiento)obj;

                _vista.InnerVO = objVO;

                //_vista.txtConcepto.Text = objVO.Concepto;

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
                _vista = (frmEditSueldosYSalarios)frm;
                Asiento objVO = (Asiento)getObject(ref frm, newRecord);
                Empresa empresa = (Empresa)_vista.cmbRazonSocial.SelectedItem;
                if (newRecord)
                {
                    lib.bl.asiento.doAdd lnAsiento = new gesClinica.lib.bl.asiento.doAdd(objVO, empresa);
                    lnAsiento.execute();
                }
                else
                {
                    lib.bl.asiento.doUpdate lnAsiento = new gesClinica.lib.bl.asiento.doUpdate(objVO);
                    lnAsiento.execute();
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
                _vista = (frmEditSueldosYSalarios)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(356, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(436, 11);

                _vista.txtConcepto.Text = "Mes de ";
                _vista.txtRetencionTrabajador.Text = "0";
                _vista.txtSeguridadSocialEmpresa.Text = "0";
                _vista.txtSeguridadSocialtotal.Text = "0";
                _vista.txtSeguridadSocialTrabajador.Text = "0";
                _vista.txtSueldoBruto.Text = "0";
                _vista.txtSueldoNeto.Text = "0";


                gesClinica.lib.bl.subcuenta.doGetAllByTipo lnSubCuenta;

                // ********************* Medio de Pago *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_MEDIOPAGO);
                _vista.cmbMedioPago.DataSource = lnSubCuenta.execute();
                _vista.cmbMedioPago.DisplayMember = "FullName";
                _vista.cmbMedioPago.ValueMember = "Codigo";
                _vista.cmbMedioPago.SelectedIndex = -1;

                // ********************* Salario *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_SALARIO);
                _vista.cmbSalario.DataSource = lnSubCuenta.execute();
                _vista.cmbSalario.DisplayMember = "FullName";
                _vista.cmbSalario.ValueMember = "Codigo";
                _vista.cmbSalario.SelectedIndex = -1;

                // ********************* Seg. Social *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_SEGURIDADSOCIAL);
                _vista.cmbSeguridadSocial.DataSource = lnSubCuenta.execute();
                _vista.cmbSeguridadSocial.DisplayMember = "FullName";
                _vista.cmbSeguridadSocial.ValueMember = "Codigo";
                _vista.cmbSeguridadSocial.SelectedIndex = -1;

                // ********************* Retencion *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_RETENCION);
                _vista.cmbRetencion.DataSource = lnSubCuenta.execute();
                _vista.cmbRetencion.DisplayMember = "FullName";
                _vista.cmbRetencion.ValueMember = "Codigo";
                _vista.cmbRetencion.SelectedIndex = -1;

                // ********************* Seg. Social Acr *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.SUELDOS_SEGURIDADSOCIALACREEDORA);
                _vista.cmbSeguridadSocialAcreedora.DataSource = lnSubCuenta.execute();
                _vista.cmbSeguridadSocialAcreedora.DisplayMember = "FullName";
                _vista.cmbSeguridadSocialAcreedora.ValueMember = "Codigo";
                _vista.cmbSeguridadSocialAcreedora.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
