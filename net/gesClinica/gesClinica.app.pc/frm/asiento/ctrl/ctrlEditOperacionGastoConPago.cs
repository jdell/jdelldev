using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento.ctrl
{
    internal class ctrlEditOperacionGastoConPago : template.frm.edicion.ctrl.EditCtrl
    {
        frmEditOperacionGastoConPago _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Asiento objVO = null;

                Apunte apunteProveedorGasto = null;
                Apunte apunteGasto = null;

                Apunte apunteProveedorMedio = null;
                Apunte apunteMedio = null;

                if (newRecord)
                {
                    objVO = new Asiento();

                    objVO.Apuntes = new List<Apunte>();
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                }
                else
                    objVO = (Asiento)_vista.InnerVO;

                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Observaciones = _vista.txtConcepto.Text;
                objVO.TipoAsiento = tTIPOASIENTO.FACTURA_RECIBIDA;

                apunteProveedorGasto = objVO.Apuntes[0];
                apunteGasto = objVO.Apuntes[1];
                apunteProveedorMedio = objVO.Apuntes[2];
                apunteMedio = objVO.Apuntes[3];

                apunteProveedorGasto.Concepto = _vista.txtConcepto.Text;
                apunteGasto.Concepto = _vista.txtConcepto.Text;
                apunteProveedorMedio.Concepto = _vista.txtConcepto.Text;
                apunteMedio.Concepto = _vista.txtConcepto.Text;

                apunteProveedorGasto.Haber = Convert.ToSingle(_vista.txtImporte.Text);
                apunteGasto.Debe = Convert.ToSingle(_vista.txtImporte.Text);
                apunteMedio.Haber = Convert.ToSingle(_vista.txtImporte.Text);
                apunteProveedorMedio.Debe = Convert.ToSingle(_vista.txtImporte.Text);

                apunteProveedorGasto.SubCuenta = (SubCuenta)_vista.cmbSubcuentaHaber.SelectedItem;
                apunteGasto.SubCuenta = (SubCuenta)_vista.cmbSubcuentaDebe.SelectedItem;
                apunteMedio.SubCuenta = (SubCuenta)_vista.cmbMedio.SelectedItem;
                apunteProveedorMedio.SubCuenta = apunteProveedorGasto.SubCuenta;

                apunteProveedorGasto.ContraPartida = apunteGasto.SubCuenta;
                apunteGasto.ContraPartida = apunteProveedorGasto.SubCuenta;
                apunteMedio.ContraPartida = apunteProveedorMedio.SubCuenta;
                apunteProveedorMedio.ContraPartida = apunteMedio.SubCuenta;

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
                _vista = (frmEditOperacionGastoConPago)frm;
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
                _vista = (frmEditOperacionGastoConPago)frm;
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
                _vista = (frmEditOperacionGastoConPago)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(280, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(360, 11);

                _vista.Text = "Operación Contable - Gasto con pago";
                _vista.labLabelUno.Text = "Proveedor";
                _vista.labLabelDos.Text = "Gasto";
                _vista.txtConcepto.Text = "S/F nº ";

                gesClinica.lib.bl.subcuenta.doGetAllByTipo lnSubCuenta;

                // ********************* Proveedor *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.PROVEEDOR);
                _vista.cmbSubcuentaHaber.DataSource = lnSubCuenta.execute();
                _vista.cmbSubcuentaHaber.DisplayMember = "FullName";
                _vista.cmbSubcuentaHaber.ValueMember = "Codigo";
                _vista.cmbSubcuentaHaber.SelectedIndex = -1;

                // ********************* GastoConPago *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.GASTO);
                _vista.cmbSubcuentaDebe.DataSource = lnSubCuenta.execute();
                _vista.cmbSubcuentaDebe.DisplayMember = "FullName";
                _vista.cmbSubcuentaDebe.ValueMember = "Codigo";
                _vista.cmbSubcuentaDebe.SelectedIndex = -1;

                // ********************* Medio *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.MEDIO);
                _vista.cmbMedio.DataSource = lnSubCuenta.execute();
                _vista.cmbMedio.DisplayMember = "FullName";
                _vista.cmbMedio.ValueMember = "Codigo";
                _vista.cmbMedio.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
