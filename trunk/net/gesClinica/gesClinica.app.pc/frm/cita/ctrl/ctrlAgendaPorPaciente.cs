using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlAgendaPorPaciente:template.frm.BaseCtrl
    {
        frmAgendaPorPaciente _vista = null;

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmAgendaPorPaciente)frm;

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

                // ********************* Dias Marcados *********************
                lib.bl.cita.doGetAllPorPaciente lnPaciente = new gesClinica.lib.bl.cita.doGetAllPorPaciente(_vista.Paciente,false);
                foreach (lib.vo.Cita cita in lnPaciente.execute())
                {
                    if (!_vista.monthCalendar.Festivos.ContainsKey(cita.Fecha.Date)) _vista.monthCalendar.Festivos.Add(cita.Fecha.Date, System.Drawing.Color.LightPink);
                    //_vista.calendar.Festivos.Add(cita.Fecha, System.Drawing.Color.Yellow);
                }
                _vista.tsbInfo.Text = _vista.Paciente.ToString();
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        public void ConsultaRegistros(ref frmAgendaPorPaciente frm)
        {
            try
            {
                _vista = (frmAgendaPorPaciente)frm;

                lib.common.tipos.ParDateTime fecha = new gesClinica.lib.common.tipos.ParDateTime();
                fecha.Desde = _vista.calendar.StartDate;
                fecha.Hasta = _vista.calendar.StartDate.AddDays(_vista.calendar.DaysToShow);

                this._vista.calendar.RefreshData(fecha, _vista.Paciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
