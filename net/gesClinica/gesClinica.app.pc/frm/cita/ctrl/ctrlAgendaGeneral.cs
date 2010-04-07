using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlAgendaGeneral:template.frm.BaseCtrl
    {
        frmAgendaGeneral _vista = null;

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmAgendaGeneral)frm;

                lib.bl._common.cache.RefreshAgenda += new gesClinica.lib.bl._common.cache.RefreshAgendaHandler(cache_RefreshAgenda);

                _vista.monthCalendar.Date = DateTime.Now;
                _vista.monthCalendar.DateChanged +=new EventHandler(monthCalendar_DateChanged);

                #region Leyenda Citas

                lib.bl.estadocita.doGetAll lnEstadoCita = new gesClinica.lib.bl.estadocita.doGetAll();
                List<lib.vo.EstadoCita> list = lnEstadoCita.execute();
                foreach (lib.vo.EstadoCita estado in list)
                {
                    System.Windows.Forms.ToolStripLabel item = new System.Windows.Forms.ToolStripLabel(estado.ToString(), repsol.util.image.CreateImage(estado.DrawColor));
                    item.Font = new System.Drawing.Font(item.Font,  System.Drawing.FontStyle.Italic);
                    item.ForeColor = System.Drawing.Color.Black;
                    item.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
                    this._vista.tbarLeyenda.Items.Add(item);
                }
                System.Windows.Forms.ToolStripLabel tsbLabelLeyenda = new System.Windows.Forms.ToolStripLabel("Leyenda Citas :");
                tsbLabelLeyenda.ForeColor = System.Drawing.SystemColors.ActiveCaption;
                tsbLabelLeyenda.Font = new System.Drawing.Font(tsbLabelLeyenda.Font, System.Drawing.FontStyle.Bold);
                tsbLabelLeyenda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
                this._vista.tbarLeyenda.Items.Add(tsbLabelLeyenda);

                #endregion

                // ********************* Festivos *********************
                lib.bl.festivo.doGetAll lnFestivo = new gesClinica.lib.bl.festivo.doGetAll();
                List<lib.vo.Festivo> listFestivo = lnFestivo.execute();
                foreach (lib.vo.Festivo festivo in listFestivo)
                    _vista.monthCalendar.Festivos.Add(festivo.Fecha, festivo.TipoFestivo.DrawColor);


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

                // ********************* Sala *********************
                gesClinica.lib.bl.sala.doGetAll lnSala = new gesClinica.lib.bl.sala.doGetAll();
               
                _vista.tablePanel.ColumnStyles.Clear();

                #region Muestra las Horas al principio

                System.Windows.Forms.Label labTitleInicial = new System.Windows.Forms.Label();
                labTitleInicial.Text = "Horas";
                labTitleInicial.Size = new System.Drawing.Size(50, labTitleInicial.Height);
                //labTitleInicial.AutoSize = true;
                labTitleInicial.Font = new System.Drawing.Font(labTitleInicial.Font, System.Drawing.FontStyle.Bold);
                labTitleInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                labTitleInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                template.controls.DayView dvInicial = new gesClinica.app.pc.template.controls.DayView();
                dvInicial.DaysToShow = 1;
                dvInicial.HalfHourHeight = 18;
                dvInicial.ShowHourLabel = true;
                dvInicial.StartDate = _vista.monthCalendar.Date;
                dvInicial.StartHour = lib.bl._common.cache.WorkingHourStart > DateTime.Now.Hour ? lib.bl._common.cache.WorkingHourStart : DateTime.Now.Hour;
                dvInicial.ContextMenu = null;

                dvInicial.WorkingHourEnd = lib.bl._common.cache.WorkingHourEnd;
                dvInicial.WorkingHourStart = lib.bl._common.cache.WorkingHourStart;
                dvInicial.WorkingMinuteEnd = lib.bl._common.cache.WorkingMinuteEnd;
                dvInicial.WorkingMinuteStart = lib.bl._common.cache.WorkingMinuteStart;

                //dvInicial.RefreshDayView += new EventHandler(dv_RefreshDayView);

                System.Windows.Forms.VScrollBar vsInicial = (System.Windows.Forms.VScrollBar)dvInicial.Controls[0];
                vsInicial.Scroll += new System.Windows.Forms.ScrollEventHandler(vs_Scroll);
                vsInicial.Visible = false;
                vsInicial.Width = 0;

                this._vista.tablePanel.ColumnCount = 1;
                this._vista.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
                this._vista.tablePanel.Controls.Add(labTitleInicial, 0, 0);
                this._vista.tablePanel.Controls.Add(dvInicial, 0, 1);
                this._vista.tablePanel.AutoScroll = false;

                labTitleInicial.Dock = System.Windows.Forms.DockStyle.Fill;
                dvInicial.Dock = System.Windows.Forms.DockStyle.Fill;

                #endregion


                int i = 2;
                List<lib.vo.Sala> listSala = lnSala.execute();
                foreach (lib.vo.Sala sala in listSala)
                {
                    System.Windows.Forms.Label labTitle = new System.Windows.Forms.Label();
                    labTitle.Text = sala.ToString();
                    labTitle.Font = new System.Drawing.Font(labTitle.Font, System.Drawing.FontStyle.Bold);
                    labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    labTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                    template.controls.DayView dv = new gesClinica.app.pc.template.controls.DayView();
                    dv.Tag = sala;
                    dv.DaysToShow = 1;
                    dv.HalfHourHeight = 18;
                    dv.ShowHourLabel = false;
                    dv.StartDate = _vista.monthCalendar.Date;
                    dv.StartHour = lib.bl._common.cache.WorkingHourStart>DateTime.Now.Hour?lib.bl._common.cache.WorkingHourStart:DateTime.Now.Hour;

                    dv.WorkingHourEnd = lib.bl._common.cache.WorkingHourEnd;
                    dv.WorkingHourStart = lib.bl._common.cache.WorkingHourStart;
                    dv.WorkingMinuteEnd = lib.bl._common.cache.WorkingMinuteEnd;
                    dv.WorkingMinuteStart = lib.bl._common.cache.WorkingMinuteStart;

                    dv.RefreshDayView += new EventHandler(dv_RefreshDayView);

                    System.Windows.Forms.VScrollBar vs = (System.Windows.Forms.VScrollBar)dv.Controls[0];
                    vs.Scroll +=new System.Windows.Forms.ScrollEventHandler(vs_Scroll);
                    //vs.Visible = i > listSala.Count;
                    vs.Visible = false;
                    if (!vs.Visible) vs.Width = 0;

                    this._vista.tablePanel.ColumnCount = i;
                    this._vista.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    this._vista.tablePanel.Controls.Add(labTitle, i-1, 0);
                    this._vista.tablePanel.Controls.Add(dv, i - 1, 1);
                    this._vista.tablePanel.AutoScroll = false;
                    
                    labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
                    dv.Dock = System.Windows.Forms.DockStyle.Fill;


                    foreach (lib.vo.Festivo festivo in listFestivo)
                        dv.Festivos.Add(festivo.Fecha, festivo.TipoFestivo.DrawColor);

                    i++;
                }


                #region Muestra las Horas al Final

                System.Windows.Forms.Label labTitleFinal = new System.Windows.Forms.Label();
                labTitleFinal.Text = "Horas";
                labTitleFinal.Size = new System.Drawing.Size(48 + 17, labTitleFinal.Height);
                //labTitleFinal.AutoSize = true;
                labTitleFinal.Font = new System.Drawing.Font(labTitleFinal.Font, System.Drawing.FontStyle.Bold);
                labTitleFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                labTitleFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                template.controls.DayView dvFinal = new gesClinica.app.pc.template.controls.DayView();
                dvFinal.InvertirHourLabel = true;
                dvFinal.DaysToShow = 1;
                dvFinal.HalfHourHeight = 18;
                dvFinal.ShowHourLabel = true;
                dvFinal.StartDate = _vista.monthCalendar.Date;
                dvFinal.StartHour = lib.bl._common.cache.WorkingHourStart > DateTime.Now.Hour ? lib.bl._common.cache.WorkingHourStart : DateTime.Now.Hour;
                dvFinal.ContextMenu = null;

                dvFinal.WorkingHourEnd = lib.bl._common.cache.WorkingHourEnd;
                dvFinal.WorkingHourStart = lib.bl._common.cache.WorkingHourStart;
                dvFinal.WorkingMinuteEnd = lib.bl._common.cache.WorkingMinuteEnd;
                dvFinal.WorkingMinuteStart = lib.bl._common.cache.WorkingMinuteStart;

                //dvFinal.RefreshDayView += new EventHandler(dv_RefreshDayView);

                System.Windows.Forms.VScrollBar vsFinal = (System.Windows.Forms.VScrollBar)dvFinal.Controls[0];
                vsFinal.Scroll += new System.Windows.Forms.ScrollEventHandler(vs_Scroll);
                vsFinal.Visible = true;
                //vsFinal.Width = 0;

                this._vista.tablePanel.ColumnCount += 1;
                this._vista.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
                this._vista.tablePanel.Controls.Add(labTitleFinal, this._vista.tablePanel.ColumnCount - 1, 0);
                this._vista.tablePanel.Controls.Add(dvFinal, this._vista.tablePanel.ColumnCount - 1, 1);
                this._vista.tablePanel.AutoScroll = false;

                labTitleFinal.Dock = System.Windows.Forms.DockStyle.Fill;
                dvFinal.Dock = System.Windows.Forms.DockStyle.Fill;

                #endregion

                monthCalendar_DateChanged(_vista.monthCalendar, new EventArgs());
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        void cache_RefreshAgenda()
        {
            dv_RefreshDayView(null, null);
        }

        void dv_RefreshDayView(object sender, EventArgs e)
        {
            if (_vista!=null) monthCalendar_DateChanged(_vista.monthCalendar, new EventArgs());
        }

        void vs_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            try
            {
                _vista = (frmAgendaGeneral)((System.Windows.Forms.VScrollBar)sender).FindForm();
                System.Windows.Forms.VScrollBar vs = (System.Windows.Forms.VScrollBar)sender;
                foreach (System.Windows.Forms.Control c in _vista.tablePanel.Controls)
                {
                    if (c is template.controls.DayView)
                    {
                        template.controls.DayView dv = (template.controls.DayView)c;
                        System.Windows.Forms.VScrollBar vsDv = (System.Windows.Forms.VScrollBar)dv.Controls[0];
                        vsDv.Value = vs.Value;
                        dv.Invalidate();
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void monthCalendar_DateChanged(object sender, EventArgs e)
        {
            try
            {
                _vista = (frmAgendaGeneral)((template.controls.MonthCalendar)sender).FindForm();

                if (_vista == null) return;
                foreach (System.Windows.Forms.Control c in _vista.tablePanel.Controls)
                {
                    if (c is template.controls.DayView)
                    {
                        template.controls.DayView dv = (template.controls.DayView)c;
                        dv.StartDate = _vista.monthCalendar.Date;

                        lib.common.tipos.ParDateTime fecha = new gesClinica.lib.common.tipos.ParDateTime();
                        fecha.Desde = dv.StartDate;
                        fecha.Hasta = dv.StartDate.AddDays(dv.DaysToShow);
                                        
                        lib.vo.Sala sala = (lib.vo.Sala)dv.Tag;
                        if (sala != null)
                            dv.RefreshData(fecha, sala);

                    }
                }
            }
            catch (Exception ex)
            {
                //template._common.messages.ShowError(ex);
                throw ex;
            }
        }

        public void ConsultaRegistros(ref frmAgendaGeneral frm)
        {
            try
            {
                _vista = (frmAgendaGeneral)frm;
                /*
                lib.common.tipos.ParDateTime fecha = new gesClinica.lib.common.tipos.ParDateTime();
                fecha.Desde = _vista.calendar.StartDate;
                fecha.Hasta = _vista.calendar.StartDate.AddDays(_vista.calendar.DaysToShow);
                
                lib.vo.Sala sala = (lib.vo.Sala)_vista.tscmbSala.SelectedItem;
                if (sala != null)
                    this._vista.calendar.RefreshData(fecha, sala);
                */
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
