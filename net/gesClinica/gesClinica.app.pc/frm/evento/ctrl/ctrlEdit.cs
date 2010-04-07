using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.evento.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Evento objVO = null;
                if (newRecord)
                {
                    objVO = new Evento();
                }
                else
                {
                    objVO = (Evento)_vista.InnerVO;
                }

                objVO.Empleado = (Empleado)_vista.cmbEmpleado.SelectedItem;
                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Descripcion = _vista.txtDescripcion.Text;
                objVO.Duracion = Convert.ToByte(_vista.txtDuracion.Value);
                objVO.Publico = _vista.chkPublico.Checked;
                objVO.Sala = (Sala)_vista.cmbSala.SelectedItem;

                objVO.EstadoEvento = (EstadoEvento)_vista.cmbEstadoEvento.SelectedItem;

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
                Evento objVO = (Evento)obj;

                _vista.InnerVO = objVO;

                _vista.dateFecha.Value = objVO.Fecha;
                if (objVO.Empleado != null) 
                    _vista.cmbEmpleado.SelectedValue = objVO.Empleado.ID;
                else
                    _vista.cmbEmpleado.SelectedValue = lib.bl._common.cache.EMPLEADO.ID;
                _vista.txtDescripcion.Text = objVO.Descripcion;
                _vista.txtDuracion.Value = objVO.Duracion;
                _vista.chkPublico.Checked = objVO.Publico;
                if (objVO.Sala != null) _vista.cmbSala.SelectedValue = objVO.Sala.ID;
                if (objVO.EstadoEvento != null) _vista.cmbEstadoEvento.SelectedValue = objVO.EstadoEvento.ID;
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
                Evento objVO = (Evento)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.evento.doAdd lnEvento = new gesClinica.lib.bl.evento.doAdd(objVO);
                    lnEvento.execute();
                }
                else
                {
                    lib.bl.evento.doUpdate lnEvento = new gesClinica.lib.bl.evento.doUpdate(objVO);
                    lnEvento.execute();
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

                // ********************* Empleado *********************
                gesClinica.lib.bl.empleado.doGetAll lnEmpleado = new gesClinica.lib.bl.empleado.doGetAll();
                _vista.cmbEmpleado.DataSource = lnEmpleado.execute();
                _vista.cmbEmpleado.DisplayMember = "FullName";
                _vista.cmbEmpleado.ValueMember = "ID";
                _vista.cmbEmpleado.SelectedIndex = -1;

                // ********************* Sala *********************
                gesClinica.lib.bl.sala.doGetAll lnSala = new gesClinica.lib.bl.sala.doGetAll();
                _vista.cmbSala.DataSource = lnSala.execute();
                _vista.cmbSala.DisplayMember = "Descripcion";
                _vista.cmbSala.ValueMember = "ID";
                _vista.cmbSala.SelectedIndex = -1;

                // ********************* EstadoEvento *********************
                gesClinica.lib.bl.estadoevento.doGetAll lnEstadoEvento = new gesClinica.lib.bl.estadoevento.doGetAll();
                _vista.cmbEstadoEvento.DataSource = lnEstadoEvento.execute();
                _vista.cmbEstadoEvento.DisplayMember = "Descripcion";
                _vista.cmbEstadoEvento.ValueMember = "ID";
                _vista.cmbEstadoEvento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
