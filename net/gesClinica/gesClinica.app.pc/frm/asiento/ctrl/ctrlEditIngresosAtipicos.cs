using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento.ctrl
{
    internal class ctrlEditIngresosAtipicos : template.frm.edicion.ctrl.EditCtrl
    {
        frmEditIngresosAtipicos _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Asiento objVO = null;

                Apunte apunteServicio = null;
                Apunte apunteCliente = null;
                Apunte apunteRetencion = null;

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
                objVO.TipoAsiento = tTIPOASIENTO.FACTURA_EMITIDA;

                apunteServicio = objVO.Apuntes[0];
                apunteCliente = objVO.Apuntes[1];
                apunteRetencion = objVO.Apuntes[2];

                apunteServicio.Concepto = _vista.txtConcepto.Text;
                apunteCliente.Concepto = _vista.txtConcepto.Text;
                apunteRetencion.Concepto = _vista.txtConcepto.Text;

                apunteServicio.Haber = Convert.ToSingle(_vista.txtImporteServicio.Text);
                apunteCliente.Debe = Convert.ToSingle(_vista.txtImporteCliente.Text);
                apunteRetencion.Debe = Convert.ToSingle(_vista.txtImporteRetencion.Text);

                apunteServicio.SubCuenta = (SubCuenta)_vista.cmbServicio.SelectedItem;
                apunteCliente.SubCuenta = (SubCuenta)_vista.cmbCliente.SelectedItem;
                apunteRetencion.SubCuenta = (SubCuenta)_vista.cmbRetencion.SelectedItem;

                apunteServicio.ContraPartida = apunteCliente.SubCuenta;
                apunteCliente.ContraPartida = apunteServicio.SubCuenta;
                apunteRetencion.ContraPartida = apunteServicio.SubCuenta;

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
                _vista = (frmEditIngresosAtipicos)frm;
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
                _vista = (frmEditIngresosAtipicos)frm;
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
                _vista = (frmEditIngresosAtipicos)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(462, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(542, 11);

                gesClinica.lib.bl.subcuenta.doGetAllByTipo lnSubCuenta;

                // ********************* Servicio *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.SERVICIO);
                _vista.cmbServicio.DataSource = lnSubCuenta.execute();
                _vista.cmbServicio.DisplayMember = "FullName";
                _vista.cmbServicio.ValueMember = "Codigo";
                _vista.cmbServicio.SelectedIndex = -1;

                // ********************* Cliente *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.CLIENTE);
                _vista.cmbCliente.DataSource = lnSubCuenta.execute();
                _vista.cmbCliente.DisplayMember = "FullName";
                _vista.cmbCliente.ValueMember = "Codigo";
                _vista.cmbCliente.SelectedIndex = -1;

                // ********************* Retencion *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.RETENCION);
                _vista.cmbRetencion.DataSource = lnSubCuenta.execute();
                _vista.cmbRetencion.DisplayMember = "FullName";
                _vista.cmbRetencion.ValueMember = "Codigo";
                _vista.cmbRetencion.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
