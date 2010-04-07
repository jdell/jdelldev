using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.festivo.ctrl
{
    internal class ctrlEdit:template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEdit)frm;

                lib.bl.festivo.doGetAll lnFestivo = new gesClinica.lib.bl.festivo.doGetAll();
                foreach (lib.vo.Festivo festivo in lnFestivo.execute())
                    AddFestivo(ref _vista, festivo);
                
                ActualizarGrid(ref _vista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ActualizarGrid(ref frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                //_vista.monthCalendar.Invalidate();
                //List<lib.vo.Festivo> list = new List<gesClinica.lib.vo.Festivo>();
                //list.AddRange(_vista.Festivos.Values);
                //_vista.dataGridView1.DataSource = list;
                //_vista.dataGridView1.Refresh();
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        public void AddFestivo(ref frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                lib.vo.Festivo festivo = new gesClinica.lib.vo.Festivo();
                festivo.Fecha = _vista.monthCalendar.Date;
                festivo.TipoFestivo = (lib.vo.TipoFestivo)_vista.cmbTipoFestivo.SelectedItem;

                if (festivo.TipoFestivo != null)
                {
                    AddFestivo(ref frm, festivo);

                    ActualizarGrid(ref frm);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AddFestivo(ref frmEdit frm, lib.vo.Festivo festivo)
        {
            try
            {
                _vista = (frmEdit)frm;

                _vista.Festivos.Add(festivo.Fecha, festivo);
                _vista.monthCalendar.Festivos.Add(festivo.Fecha, System.Drawing.Color.FromName(festivo.TipoFestivo.Color));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoveFestivo(ref frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                RemoveFestivo(ref frm, _vista.monthCalendar.Date);
                
                ActualizarGrid(ref frm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void RemoveFestivo(ref frmEdit frm, DateTime fecha)
        {
            try
            {
                _vista = (frmEdit)frm;

                _vista.Festivos.Remove(fecha);
                _vista.monthCalendar.Festivos.Remove(fecha);

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

                List<lib.vo.Festivo> list = new List<gesClinica.lib.vo.Festivo>();
                list.AddRange(_vista.Festivos.Values);

                lib.bl.festivo.doAdd lnFestivo = new gesClinica.lib.bl.festivo.doAdd(list);
                lnFestivo.execute();
                
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

                _vista.Aceptar.Location = new System.Drawing.Point(496, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(577, 11);

                _vista.monthCalendar.Date = DateTime.Now;

                _vista.Festivos.Clear();

                // ********************* TipoFestivo *********************
                gesClinica.lib.bl.tipofestivo.doGetAll lnTipoFestivo = new gesClinica.lib.bl.tipofestivo.doGetAll();
                List<lib.vo.TipoFestivo> listTipoFestivo = lnTipoFestivo.execute();
                _vista.cmbTipoFestivo.DataSource = listTipoFestivo;
                _vista.cmbTipoFestivo.DisplayMember = "Descripcion";
                _vista.cmbTipoFestivo.ValueMember = "ID";
                if (listTipoFestivo.Count>0) _vista.cmbTipoFestivo.SelectedIndex = 0;

            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }
    }
}
