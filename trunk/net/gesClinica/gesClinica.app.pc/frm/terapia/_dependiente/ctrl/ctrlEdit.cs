using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.terapia._dependiente.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Terapia objVO = null;
                //if (newRecord)
                //{
                //    objVO = new Terapia();
                //}
                //else
                //{
                    objVO = (Terapia)_vista.InnerVO;
                //}

                objVO.TerapiaDependiente = (Terapia)_vista.cmbTerapiaDependiente.SelectedItem;

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
                Terapia objVO = (Terapia)obj;

                _vista.InnerVO = objVO;

                lib.bl.terapia.doGetDependiente lnTerapia = new gesClinica.lib.bl.terapia.doGetDependiente(objVO);
                objVO.TerapiaDependiente = lnTerapia.execute();
                if (objVO.TerapiaDependiente != null) _vista.cmbTerapiaDependiente.SelectedValue = objVO.TerapiaDependiente.ID;
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
                Terapia objVO = (Terapia)getObject(ref frm, newRecord);
                //if ((objVO.TerapiaDependiente== null) || (lib.common.constantes.vacio.IsEmpty(objVO.TerapiaDependiente.ID))(
                //{   
                //    lib.bl.terapia.doUnBind lnTerapia = new gesClinica.lib.bl.terapia.doUnBind(objVO, objVO.TerapiaDependiente);
                //    lnTerapia.execute();
                //}
                //else
                //{
                    lib.bl.terapia.doBind lnTerapia = new gesClinica.lib.bl.terapia.doBind(objVO, objVO.TerapiaDependiente);
                    lnTerapia.execute();
                //}
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

                // ********************* Terapia *********************
                gesClinica.lib.bl.terapia.doGetAll lnTerapia = new gesClinica.lib.bl.terapia.doGetAll();
                List<Terapia> list = new List<Terapia>();
                list.Add(new Terapia());
                list.AddRange(lnTerapia.execute());
                _vista.cmbTerapiaDependiente.DataSource = list;
                _vista.cmbTerapiaDependiente.DisplayMember = "Descripcion";
                _vista.cmbTerapiaDependiente.ValueMember = "ID";
                _vista.cmbTerapiaDependiente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
