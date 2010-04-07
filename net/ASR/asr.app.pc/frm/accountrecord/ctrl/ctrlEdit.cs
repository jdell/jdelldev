using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.accountrecord.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                AccountRecord objVO = null;
                objVO = (AccountRecord)_vista.InnerVO;

                objVO.Amount = Convert.ToSingle(_vista.txtAmount.Text);
                objVO.Client = (Client)_vista.txtClient.Tag;
                objVO.Date = _vista.dtpDate.Value;
                objVO.Incoming= _vista.rbIncoming.Checked;
                objVO.Reference = _vista.txtReference.Text;
                objVO.Activity = (Activity)_vista.cmbActivity.SelectedItem;
                objVO.Description = objVO.Activity.Description;
               
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
                AccountRecord objVO = (AccountRecord)obj;

                _vista.InnerVO = objVO;
                _vista.txtAmount.Text = objVO.Amount.ToString();
                if (objVO.Client != null)
                {
                    _vista.txtClient.Tag = objVO.Client;
                    _vista.txtClient.Text = objVO.Client.FullName;
                }
                _vista.dtpDate.Value = objVO.Date;
                //_vista.txtDescription.Text = objVO.Description;
                _vista.rbIncoming.Checked = objVO.Incoming;
                _vista.rbOutgoing.Checked = !objVO.Incoming;
                _vista.txtReference.Text = objVO.Reference;

                reloadActivities(ref frm);

                if (objVO.Activity != null) _vista.cmbActivity.SelectedValue = objVO.Activity.ID;
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
                AccountRecord objVO = (AccountRecord)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.accountrecord.doAdd lnAccountRecord = new asr.lib.bl.accountrecord.doAdd(objVO);
                    lnAccountRecord.execute();
                }
                else
                {
                    lib.bl.accountrecord.doUpdate lnAccountRecord = new asr.lib.bl.accountrecord.doUpdate(objVO);
                    lnAccountRecord.execute();
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

                //_template._common.extend.SelectOnEnter(ref _vista.txtDescription);
                template._common.extend.SelectOnEnter(ref _vista.txtAmount);


                //lib.bl.activity.doGetAll doActivity = new asr.lib.bl.activity.doGetAll();
                //_vista.cmbActivity.DataSource = doActivity.execute();
                //_vista.cmbActivity.DisplayMember = "Description";
                //_vista.cmbActivity.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void reloadActivities(ref repsol.forms.template.edicion.EditForm frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                if (_vista.Client != null)
                {
                    lib.bl.activity.doGetAllIncomes doActivity = new asr.lib.bl.activity.doGetAllIncomes(_vista.Client, _vista.rbIncoming.Checked);
                    _vista.cmbActivity.DataSource = doActivity.execute();
                    _vista.cmbActivity.DisplayMember = "Description";
                    _vista.cmbActivity.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
