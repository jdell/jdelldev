using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlAgendaPorSala:template.frm.BaseCtrl
    {
        frmAgendaPorSala _vista = null;

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmAgendaPorSala)frm;

                #region Leyenda

                lib.bl.estadocita.doGetAll lnEstadoCita = new gesClinica.lib.bl.estadocita.doGetAll();
                List<lib.vo.EstadoCita> list = lnEstadoCita.execute();
                foreach (lib.vo.EstadoCita estado in list)
                {
                    System.Windows.Forms.ToolStripLabel item = new System.Windows.Forms.ToolStripLabel(estado.ToString(), repsol.util.image.CreateImage(estado.DrawColor));
                    item.Font = new System.Drawing.Font(item.Font, System.Drawing.FontStyle.Italic);
                    item.ForeColor = System.Drawing.Color.Black;
                    item.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
                    this._vista.tbarLeyenda.Items.Add(item);
                }
                System.Windows.Forms.ToolStripLabel tsbLabelLeyenda = new System.Windows.Forms.ToolStripLabel("Leyenda :");
                tsbLabelLeyenda.ForeColor = System.Drawing.SystemColors.ActiveCaption;
                tsbLabelLeyenda.Font = new System.Drawing.Font(tsbLabelLeyenda.Font, System.Drawing.FontStyle.Bold);
                tsbLabelLeyenda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
                this._vista.tbarLeyenda.Items.Add(tsbLabelLeyenda);

                #endregion

                _vista.calendar.HalfHourHeight = 18;

                _vista.monthCalendar.Date = DateTime.Now;
                _vista.calendar.StartDate = _vista.monthCalendar.Date;
                _vista.calendar.StartHour = lib.bl._common.cache.WorkingHourStart > DateTime.Now.Hour ? lib.bl._common.cache.WorkingHourStart : DateTime.Now.Hour;
                _vista.calendar.WorkingHourEnd = lib.bl._common.cache.WorkingHourEnd;
                _vista.calendar.WorkingHourStart = lib.bl._common.cache.WorkingHourStart;
                _vista.calendar.WorkingMinuteEnd = lib.bl._common.cache.WorkingMinuteEnd;
                _vista.calendar.WorkingMinuteStart = lib.bl._common.cache.WorkingMinuteStart;

                // ********************* Sala *********************
                gesClinica.lib.bl.sala.doGetAll lnSala = new gesClinica.lib.bl.sala.doGetAll();
                _vista.tscmbSala.Items.AddRange(lnSala.execute().ToArray());
                _vista.tscmbSala.SelectedIndex = -1;

                // ********************* Festivos *********************
                lib.bl.festivo.doGetAll lnFestivo = new gesClinica.lib.bl.festivo.doGetAll();
                List<lib.vo.Festivo> listFestivo = lnFestivo.execute();
                foreach (lib.vo.Festivo festivo in listFestivo)
                {
                    _vista.monthCalendar.Festivos.Add(festivo.Fecha, festivo.TipoFestivo.DrawColor);
                    _vista.calendar.Festivos.Add(festivo.Fecha, festivo.TipoFestivo.DrawColor);
                }

                #region Leyenda Festivos

                ////Esto lo hice a prisa y corriendo. es muy mejorable.
                //lib.bl.tipofestivo.doGetAll lnTipoFestivo = new gesClinica.lib.bl.tipofestivo.doGetAll();
                //List<lib.vo.TipoFestivo> listTipoFestivo = lnTipoFestivo.execute();
                //foreach (lib.vo.TipoFestivo tipofestivo in listTipoFestivo)
                //{
                //    System.Windows.Forms.ToolStripLabel item = new System.Windows.Forms.ToolStripLabel(tipofestivo.ToString(), repsol.util.image.CreateImage(tipofestivo.DrawColor));
                //    item.Font = new System.Drawing.Font(item.Font, System.Drawing.FontStyle.Italic);
                //    item.ForeColor = System.Drawing.Color.Black;
                //    item.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
                //    this._vista.tbarLeyenda.Items.Add(item);
                //}
                //System.Windows.Forms.ToolStripLabel tsbLabelLeyendaFestivo = new System.Windows.Forms.ToolStripLabel("Leyenda Festivos :");
                //tsbLabelLeyendaFestivo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
                //tsbLabelLeyendaFestivo.Font = new System.Drawing.Font(tsbLabelLeyenda.Font, System.Drawing.FontStyle.Bold);
                //tsbLabelLeyendaFestivo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
                //this._vista.tbarLeyenda.Items.Add(tsbLabelLeyendaFestivo);

                #endregion
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        public void ConsultaRegistros(ref frmAgendaPorSala frm)
        {
            try
            {
                _vista = (frmAgendaPorSala)frm;

                lib.common.tipos.ParDateTime fecha = new gesClinica.lib.common.tipos.ParDateTime();
                fecha.Desde = _vista.calendar.StartDate;
                fecha.Hasta = _vista.calendar.StartDate.AddDays(_vista.calendar.DaysToShow);

                lib.vo.Sala sala = (lib.vo.Sala)_vista.tscmbSala.SelectedItem;
                //if (sala != null)
                this._vista.calendar.RefreshData(fecha, sala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
