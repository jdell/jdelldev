using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.task.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Task objVO = null;
                objVO = (Task)_vista.InnerVO;

                objVO.Completed = _vista.chkCompleted.Checked;
                objVO.Description= _vista.txtDescription.Text;
                objVO.Priority= _vista.chkPriority.Checked;
                objVO.Date = _vista.dtpDate.Value;
                objVO.Staff = (Staff)_vista.cmbStaff.SelectedItem;
                if (objVO.Staff.ID == lib.common.constantes.vacio.ID) objVO.Staff = null;

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
                Task objVO = (Task)obj;

                _vista.InnerVO = objVO;
                _vista.txtDescription.Text = objVO.Description;
                _vista.chkCompleted.Checked = objVO.Completed;
                _vista.chkPriority.Checked = objVO.Priority;
                _vista.dtpDate.Value = objVO.Date;
                if (objVO.Staff!=null) _vista.cmbStaff.SelectedValue = objVO.Staff.ID;
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
                Task objVO = (Task)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.task.doAdd lnTask = new asr.lib.bl.task.doAdd(objVO);
                    lnTask.execute();
                }
                else
                {
                    lib.bl.task.doUpdate lnTask = new asr.lib.bl.task.doUpdate(objVO);
                    lnTask.execute();
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

                lib.bl.staff.doGetAll doStaff = new asr.lib.bl.staff.doGetAll();
                List<Staff> lsStaff = doStaff.execute();
                lsStaff.Insert(0, new Staff());
                _vista.cmbStaff.DataSource = lsStaff;
                _vista.cmbStaff.DisplayMember = "FullName";
                _vista.cmbStaff.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
