using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento.ctrl
{
    internal class ctrlEditPrestamo : template.frm.edicion.ctrl.EditCtrl
    {
        frmEditPrestamo _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Asiento objVO = null;

                Apunte apunteIntereses = null;
                Apunte apunteAmortizacion = null;
                Apunte apunteCuentaCargo = null;

                if (newRecord)
                {
                    objVO = new Asiento();

                    objVO.Apuntes = new List<Apunte>();
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                }
                else
                    objVO = (Asiento)_vista.InnerVO;

                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Observaciones = _vista.txtConcepto.Text;
                objVO.TipoAsiento = tTIPOASIENTO.PRESTAMO;

                apunteIntereses = objVO.Apuntes[0];
                apunteAmortizacion = objVO.Apuntes[1];
                apunteCuentaCargo = objVO.Apuntes[2];

                apunteIntereses.Concepto = _vista.txtConcepto.Text + " [Intereses]";
                apunteAmortizacion.Concepto = _vista.txtConcepto.Text + " [Amortización]";
                apunteCuentaCargo.Concepto = _vista.txtConcepto.Text + " [Cuota]";

                apunteIntereses.Debe = Convert.ToSingle(_vista.txtImporteIntereses.Text);
                apunteAmortizacion.Debe = Convert.ToSingle(_vista.txtImporteAmortizacion.Text);
                apunteCuentaCargo.Haber = Convert.ToSingle(_vista.txtImporteCuentaCargo.Text);

                apunteIntereses.SubCuenta = (SubCuenta)_vista.cmbIntereses.SelectedItem;
                apunteAmortizacion.SubCuenta = (SubCuenta)_vista.cmbAmortizacion.SelectedItem;
                apunteCuentaCargo.SubCuenta = (SubCuenta)_vista.cmbCuentaCargo.SelectedItem;

                apunteIntereses.ContraPartida = apunteCuentaCargo.SubCuenta;
                apunteAmortizacion.ContraPartida = apunteCuentaCargo.SubCuenta;
                apunteCuentaCargo.ContraPartida = apunteIntereses.SubCuenta;

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
                _vista = (frmEditPrestamo)frm;
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
                _vista = (frmEditPrestamo)frm;
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
                _vista = (frmEditPrestamo)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(462, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(542, 11);

                _vista.txtConcepto.Text = "Préstamo ";

                gesClinica.lib.bl.subcuenta.doGetAllByTipo lnSubCuenta;

                // ********************* Intereses *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.PRESTAMO_INTERESES);
                _vista.cmbIntereses.DataSource = lnSubCuenta.execute();
                _vista.cmbIntereses.DisplayMember = "FullName";
                _vista.cmbIntereses.ValueMember = "Codigo";
                _vista.cmbIntereses.SelectedIndex = -1;

                // ********************* Amortizacion *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.PRESTAMO_AMORTIZACION);
                _vista.cmbAmortizacion.DataSource = lnSubCuenta.execute();
                _vista.cmbAmortizacion.DisplayMember = "FullName";
                _vista.cmbAmortizacion.ValueMember = "Codigo";
                _vista.cmbAmortizacion.SelectedIndex = -1;

                // ********************* Cuenta de cargo *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.PRESTAMO_CUENTACARGO);
                _vista.cmbCuentaCargo.DataSource = lnSubCuenta.execute();
                _vista.cmbCuentaCargo.DisplayMember = "FullName";
                _vista.cmbCuentaCargo.ValueMember = "Codigo";
                _vista.cmbCuentaCargo.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void updateCuentaCargo(ref frmEditPrestamo frm)
        {
            try
            {
                _vista = frm;

                float intereses = Convert.ToSingle(_vista.txtImporteIntereses.Text);
                float amortizacion = Convert.ToSingle(_vista.txtImporteAmortizacion.Text);
                float cargoCuenta = intereses + amortizacion;
                _vista.txtImporteCuentaCargo.Text = cargoCuenta.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
