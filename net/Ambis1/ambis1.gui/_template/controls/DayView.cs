using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.controls
{
    internal class DayView: Calendar.DayView
    {
        private System.Windows.Forms.ContextMenuStrip cmenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsbNuevaCita;
        private System.Windows.Forms.ToolStripMenuItem tsbModificarCita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsbCambiarEstado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsbBorrarCita;
        private System.Windows.Forms.ToolStripMenuItem tsbCopiarCita;
        private System.Windows.Forms.ToolStripMenuItem tsbVerCita;
        private System.Windows.Forms.ToolStripMenuItem tsbAtenderCita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuCitas;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuEventos;
        private System.Windows.Forms.ToolStripMenuItem tsbNuevoEvento;
        private System.Windows.Forms.ToolStripMenuItem tsbVerEvento;
        private System.Windows.Forms.ToolStripMenuItem tsbModificarEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsbBorrarEvento;
        private System.Windows.Forms.ToolStripMenuItem tsbCopiarPortapapelesCita;
        private System.Windows.Forms.ToolStripMenuItem tsbCopiarPortapapelesEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsbPegarPortapapelesCita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsbPegarPortapapelesEvento;
        private System.Windows.Forms.ToolStripMenuItem tsbAñadirNotas;
        private System.Windows.Forms.Label labNotas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsbProgramarCitas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuGenerarRecibo;
        private System.Windows.Forms.ToolStripMenuItem tsbCambiarSala;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuVerPaciente;

        public event EventHandler RefreshDayView;

        private bool _invertirHourLabel = false;

        public bool InvertirHourLabel
        {
            get { return _invertirHourLabel; }
            set { _invertirHourLabel = value; }
        }

        public DayView():base()
        {
            InitializeComponent();

            this.tsbNuevaCita.Click += new EventHandler(tsbNuevaCita_Click);
            this.tsbModificarCita.Click += new EventHandler(tsbModificarCita_Click);
            this.tsbBorrarCita.Click += new EventHandler(tsbBorrarCita_Click);
            this.tsbCopiarCita.Click += new EventHandler(tsbCopiarCita_Click);
            this.tsbVerCita.Click += new EventHandler(tsbVerCita_Click);
            this.tsbAtenderCita.Click += new EventHandler(tsbAtenderCita_Click);
            this.tsbCopiarPortapapelesCita.Click += new EventHandler(tsbCopiarPortapapelesCita_Click);
            this.tsbPegarPortapapelesCita.Click += new EventHandler(tsbPegarPortapapelesCita_Click);
            this.tsbAñadirNotas.Click += new EventHandler(tsbAñadirNotas_Click);
            this.tsbProgramarCitas.Click += new EventHandler(tsbProgramarCitas_Click);
            this.tsbMenuGenerarRecibo.Click += new EventHandler(tsbMenuGenerarRecibo_Click);

            this.tsbMenuVerPaciente.Click += new EventHandler(tsbMenuVerPaciente_Click);

            lib.bl.estadocita.doGetAll lnEstadoCita = new asr.lib.bl.estadocita.doGetAll();
            List<lib.vo.EstadoCita> listEstado = lnEstadoCita.execute();
            foreach (lib.vo.EstadoCita estado in listEstado)
            {
                System.Windows.Forms.ToolStripMenuItem item = new System.Windows.Forms.ToolStripMenuItem(estado.ToString(), repsol.util.image.CreateImage(estado.DrawColor));
                item.Tag = estado;
                item.Click += new EventHandler(itemEstado_Click);
                this.tsbCambiarEstado.DropDownItems.Add(item);
                if (estado.GeneraRecibo)
                    this.cmenuOpciones.Items.Add(item);
            }
            
            lib.bl.sala.doGetAll lnSala = new asr.lib.bl.sala.doGetAll();
            List<lib.vo.Sala> listSala = lnSala.execute();
            foreach (lib.vo.Sala sala in listSala)
            {
                System.Windows.Forms.ToolStripMenuItem item = new System.Windows.Forms.ToolStripMenuItem(sala.ToString());
                item.Tag = sala;
                item.Click += new EventHandler(itemSala_Click);
                this.tsbCambiarSala.DropDownItems.Add(item);
            }
            
            this.tsbNuevoEvento.Click += new EventHandler(tsbNuevoEvento_Click);
            this.tsbVerEvento.Click += new EventHandler(tsbVerEvento_Click);
            this.tsbModificarEvento.Click += new EventHandler(tsbModificarEvento_Click);
            this.tsbBorrarEvento.Click += new EventHandler(tsbBorrarEvento_Click);
            this.tsbCopiarPortapapelesEvento.Click += new EventHandler(tsbCopiarPortapapelesEvento_Click);
            this.tsbPegarPortapapelesEvento.Click += new EventHandler(tsbPegarPortapapelesEvento_Click);

            this.Controls.Add(labNotas);
        }

        void tsbMenuVerPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.paciente.frmEdit vVen = new asr.app.pc.frm.paciente.frmEdit(getFullPaciente(this.AppointmentToCita(this.SelectedAppointment)), false);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private lib.vo.Paciente getFullPaciente(lib.vo.Cita cita)
        {
            try
            {
                lib.bl.paciente.doGet lnPaciente = new asr.lib.bl.paciente.doGet(cita.Paciente);
                return lnPaciente.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void tsbMenuGenerarRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //asr.app.pc.frm.operacion.frmEdit vVen = new asr.app.pc.frm.operacion.frmEdit(AppointmentToCita(this.SelectedAppointment));
                //vVen.ShowDialog();

                lib.bl.operacion.doGenerate lnOperacionGenerate = new asr.lib.bl.operacion.doGenerate(AppointmentToCita(this.SelectedAppointment));
                lib.bl.operacion.doAdd lnOperacionAdd = new asr.lib.bl.operacion.doAdd(lnOperacionGenerate.execute());
                lnOperacionAdd.execute();
                //template._common.messages.ShowInfo("Recibo generado", "Recibos");

                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbProgramarCitas_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = this.SelectionStart.CompareTo(DateTime.MinValue) == 0 ? DateTime.Now : this.SelectionStart;

                asr.app.pc.frm.cita.frmEditProgramada vVen = new asr.app.pc.frm.cita.frmEditProgramada(fecha, (lib.vo.Sala)this.Tag);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());

            }
            catch (Exception ex)
            {   
                template._common.messages.ShowError(ex);
            }
        }

        void tsbAñadirNotas_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEditNotas vVen = new asr.app.pc.frm.cita.frmEditNotas((lib.vo.Cita)this.SelectedAppointment.Tag);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #region Portapapeles

        private static lib.vo.Cita _portapapelesCita = null;
        private void setPortapapeles(lib.vo.Cita cita)
        {
            _portapapelesCita = cita;
        }
        private lib.vo.Cita getPortapapelesCita(bool clear)
        {
            lib.vo.Cita res = _portapapelesCita;
            if (clear)
                _portapapelesCita = null;
            return res;
        }

        void tsbPegarPortapapelesCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (getPortapapelesCita(false) == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.CLIPBOARD_EMPTY, this.Text);
                    return;
                }

                lib.vo.Cita objVO = getPortapapelesCita(false);
                objVO.Sala = (lib.vo.Sala)this.Tag;
                objVO.Fecha = this.SelectionStart.CompareTo(DateTime.MinValue) == 0 ? DateTime.Now : this.SelectionStart;

                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit(objVO);
                if (vVen.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                    getPortapapelesCita(false);
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        void tsbCopiarPortapapelesCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                setPortapapeles((lib.vo.Cita)this.SelectedAppointment.Tag);                
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


        private static lib.vo.Evento _portapapelesEvento = null;
        private void setPortapapeles(lib.vo.Evento evento)
        {
            _portapapelesEvento = evento;
        }
        private lib.vo.Evento getPortapapelesEvento(bool clear)
        {
            lib.vo.Evento res = _portapapelesEvento;
            if (clear)
                _portapapelesEvento = null;
            return res;
        }

        void tsbPegarPortapapelesEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (getPortapapelesEvento(false) == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.CLIPBOARD_EMPTY, this.Text);
                    return;
                }

                lib.vo.Evento objVO = getPortapapelesEvento(false);
                objVO.Fecha = this.SelectionStart.CompareTo(DateTime.MinValue) == 0 ? DateTime.Now : this.SelectionStart;

                asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit(objVO);
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    getPortapapelesEvento(false);
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        void tsbCopiarPortapapelesEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                setPortapapeles((lib.vo.Evento)this.SelectedAppointment.Tag);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #endregion

        void tsbBorrarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(asr.app.pc._common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if (borrarEvento((lib.vo.Evento)this.SelectedAppointment.Tag))
                        RefreshDayView(this, new EventArgs());
                    else
                        template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbModificarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit((lib.vo.Evento)this.SelectedAppointment.Tag, false);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbVerEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit((lib.vo.Evento)this.SelectedAppointment.Tag, true);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbNuevoEvento_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = this.SelectionStart.CompareTo(DateTime.MinValue) == 0 ? DateTime.Now : this.SelectionStart;

                asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit(fecha);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbAtenderCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEditDatosClinicos vVen = new asr.app.pc.frm.cita.frmEditDatosClinicos((lib.vo.Cita)this.SelectedAppointment.Tag);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        [System.ComponentModel.DefaultValue(true)]
        public bool ShowHourLabel
        {
            get
            {
                return (this.HourLabelWidth != 0);
            }
            set
            {
                if (value)
                {
                    this.HourLabelWidth = 50;
                    //this.Renderer = new Calendar.Office12Renderer(this);
                    this.Renderer = new OwnOffice12Renderer(this);
                }
                else
                {
                    this.HourLabelWidth = 1;
                    this.Renderer = new OwnOffice12Renderer(this);
                }
            }
        }

        void tsbVerCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit((lib.vo.Cita)this.SelectedAppointment.Tag, true);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbCopiarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit((lib.vo.Cita)this.SelectedAppointment.Tag);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void itemEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Desea cambiar el estado de la cita?", "Agenda", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                //{
                System.Windows.Forms.ToolStripMenuItem item = (System.Windows.Forms.ToolStripMenuItem)sender;
                lib.vo.EstadoCita estado = (lib.vo.EstadoCita)item.Tag;
                lib.vo.Cita cita = AppointmentToCita(this.SelectedAppointment);
                if ((cita.EstadoCita.ID != estado.ID) )
                {
                    //if ((!lib.bl._common.cache.EMPLEADO.Gerente) && (cita.Facturada))
                    //    throw new lib.bl._exceptions.validatingException("La cita ya ha sido facturada y no puede ser modificada. Borre la operación asociada y vuelva a intentarlo.");

                    cita.EstadoCita = estado;

                    lib.bl.cita.doUpdate lnCita = new asr.lib.bl.cita.doUpdate(cita);
                    lnCita.execute();
                    
                    //if ((cita.EstadoCita.GeneraRecibo) && (!cita.Facturada)) tsbMenuGenerarRecibo_Click(this.tsbMenuGenerarRecibo, e);
                    
                    if (RefreshDayView != null) RefreshDayView(this, new EventArgs());
                  }
                //}

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        //private void anularOperación()
        //{
        //    try
        //    {
        //        ctrl.ctrlCajaDiaria ctrl = new asr.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
        //        frmCajaDiaria frm = (frmCajaDiaria)this;

        //        if (ctrl.getOperacionSeleccionada(frm) == null)
        //        {
        //            template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
        //            return;
        //        }
        //        if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
        //        {
        //            if ((bool)ctrl.BorrarRegistro(ref frm))
        //                RefreshData();
        //            else
        //                template._common.messages.ShowWarning(_common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        template._common.messages.ShowError(ex);
        //    }
        //}

        void itemSala_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Desea cambiar el estado de la cita?", "Agenda", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                //{
                System.Windows.Forms.ToolStripMenuItem item = (System.Windows.Forms.ToolStripMenuItem)sender;
                lib.vo.Sala sala = (lib.vo.Sala)item.Tag;
                lib.vo.Cita cita = AppointmentToCita(this.SelectedAppointment);
                if (cita.Sala.ID != sala.ID)
                {
                    cita.Sala = sala;

                    lib.bl.cita.doUpdate lnCita = new asr.lib.bl.cita.doUpdate(cita);
                    lnCita.execute();
                    if (RefreshDayView != null) RefreshDayView(this, new EventArgs());
                }
                //}

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        public void RefreshData(lib.common.tipos.ParDateTime fecha, lib.vo.Sala sala)
        {
            try
            {
                this.Appointments.Clear();
                if (fecha != null)
                {
                    if (sala != null)
                    {
                        asr.lib.bl.evento.doGetAllPorFechaYSala lnEvento = new asr.lib.bl.evento.doGetAllPorFechaYSala(fecha,sala);
                        List<lib.vo.Evento> listEvento = lnEvento.execute();
                        foreach (lib.vo.Evento evento in listEvento)
                            this.Appointments.Add(this.EventoToAppointment(evento));

                        asr.lib.bl.cita.doGetAllPorFechaYSala lnCita = new asr.lib.bl.cita.doGetAllPorFechaYSala(fecha, sala);
                        List<lib.vo.Cita> listCita = lnCita.execute();
                        foreach (lib.vo.Cita cita in listCita)
                            if (cita.Presencial) this.Appointments.Add(this.CitaToAppointment(cita));
                    }
                }

                this.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RefreshData(lib.common.tipos.ParDateTime fecha, lib.vo.Paciente paciente)
        {
            try
            {
                this.Appointments.Clear();
                if ((fecha != null) && (paciente!=null))
                {
                    asr.lib.bl.cita.doGetAllPorFechaYPaciente lnCita = new asr.lib.bl.cita.doGetAllPorFechaYPaciente(fecha, paciente);
                    List<lib.vo.Cita> listCita = lnCita.execute();
                    foreach (lib.vo.Cita cita in listCita)
                        if (cita.Presencial) this.Appointments.Add(this.CitaToAppointment(cita));
                }

                this.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<Calendar.Appointment> _appointments = new List<Calendar.Appointment>();

        public List<Calendar.Appointment> Appointments
        {
            get { return _appointments; }
            set { _appointments = value; }
        }

        private void Handler_ResolveAppointments(object sender, Calendar.ResolveAppointmentsEventArgs args)
        {
            try
            {
                List<Calendar.Appointment> tmp = new List<Calendar.Appointment>();
                foreach (Calendar.Appointment ap in this.Appointments)
                {
                    if ((ap.StartDate >= args.StartDate) && (ap.StartDate <= args.EndDate)) tmp.Add(ap);
                }
                args.Appointments = tmp;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void Handler_NewAppointment(object sender, Calendar.NewAppointmentEventArgs args)
        {
            try
            {
                Calendar.Appointment tmp = new Calendar.Appointment();
                tmp.StartDate = args.StartDate;
                tmp.EndDate = args.EndDate;
                tmp.Title = args.Title;
                this.Appointments.Add(tmp);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private asr.lib.vo.Cita AppointmentToCita(Calendar.Appointment ap)
        {
            try
            {
                asr.lib.vo.Cita res = (asr.lib.vo.Cita)ap.Tag;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Calendar.Appointment CitaToAppointment(asr.lib.vo.Cita cita)
        {
            try
            {
                Calendar.Appointment res = new Calendar.Appointment();

                res.Tag = cita;
                res.BorderColor = System.Drawing.Color.FromName(cita.EstadoCita.Color);
                res.Color = System.Drawing.Color.FromName(cita.EstadoCita.Color);
                res.StartDate = cita.Fecha;
                res.EndDate = cita.Fecha.AddMinutes(cita.Duracion);
                res.Locked = true;
                res.Title = cita.ToString();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private asr.lib.vo.Evento AppointmentToEvento(Calendar.Appointment ap)
        {
            try
            {
                asr.lib.vo.Evento res = (asr.lib.vo.Evento)ap.Tag;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Calendar.Appointment EventoToAppointment(asr.lib.vo.Evento evento)
        {
            try
            {
                Calendar.Appointment res = new Calendar.Appointment();
                
                res.Tag = evento;
                res.BorderColor = System.Drawing.Color.LightYellow;
                res.Color = System.Drawing.Color.LightYellow;
                res.StartDate = evento.Fecha;
                res.EndDate = evento.Fecha.AddMinutes(evento.Duracion);
                res.Locked = true;
                res.Title = evento.ToString();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void tsbBorrarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(asr.app.pc._common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if (borrarCita((lib.vo.Cita)this.SelectedAppointment.Tag))
                        RefreshDayView(this, new EventArgs());
                    else
                        template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private bool borrarCita(lib.vo.Cita objVO)
        {
            try
            {
                lib.bl.cita.doDelete lnCita = new asr.lib.bl.cita.doDelete(objVO);
                lnCita.execute();

                return true;
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }
        private bool borrarEvento(lib.vo.Evento objVO)
        {
            try
            {
                lib.bl.evento.doDelete lnEvento = new asr.lib.bl.evento.doDelete(objVO);
                lnEvento.execute();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void tsbModificarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SelectedAppointment==null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit((lib.vo.Cita)this.SelectedAppointment.Tag, false);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbNuevaCita_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = this.SelectionStart.CompareTo(DateTime.MinValue) == 0 ? DateTime.Now : this.SelectionStart;
                
                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit(fecha, (lib.vo.Sala)this.Tag);
                vVen.ShowDialog();
                RefreshDayView(this, new EventArgs());
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmenuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbMenuCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAtenderCita = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAñadirNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevaCita = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbVerCita = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbModificarCita = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCopiarCita = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopiarPortapapelesCita = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPegarPortapapelesCita = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbProgramarCitas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCambiarEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCambiarSala = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBorrarCita = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMenuEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbNuevoEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbVerEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbModificarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopiarPortapapelesEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPegarPortapapelesEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBorrarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMenuVerPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMenuGenerarRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.labNotas = new System.Windows.Forms.Label();
            this.cmenuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmenuOpciones
            // 
            this.cmenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMenuCitas,
            this.tsbMenuEventos,
            this.toolStripSeparator9,
            this.tsbMenuVerPaciente,
            this.toolStripSeparator8,
            this.tsbMenuGenerarRecibo});
            this.cmenuOpciones.Name = "cmenuOpciones";
            this.cmenuOpciones.Size = new System.Drawing.Size(187, 104);
            this.cmenuOpciones.Opening += new System.ComponentModel.CancelEventHandler(this.cmenuOpciones_Opening);
            // 
            // tsbMenuCitas
            // 
            this.tsbMenuCitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAtenderCita,
            this.tsbAñadirNotas,
            this.toolStripSeparator3,
            this.tsbNuevaCita,
            this.tsbVerCita,
            this.tsbModificarCita,
            this.tsbCopiarCita,
            this.toolStripSeparator5,
            this.tsbCopiarPortapapelesCita,
            this.tsbPegarPortapapelesCita,
            this.toolStripSeparator7,
            this.tsbProgramarCitas,
            this.toolStripSeparator1,
            this.tsbCambiarEstado,
            this.tsbCambiarSala,
            this.toolStripSeparator2,
            this.tsbBorrarCita});
            this.tsbMenuCitas.Name = "tsbMenuCitas";
            this.tsbMenuCitas.Size = new System.Drawing.Size(186, 22);
            this.tsbMenuCitas.Text = "Citas";
            // 
            // tsbAtenderCita
            // 
            this.tsbAtenderCita.Name = "tsbAtenderCita";
            this.tsbAtenderCita.Size = new System.Drawing.Size(222, 22);
            this.tsbAtenderCita.Text = "Atender cita";
            // 
            // tsbAñadirNotas
            // 
            this.tsbAñadirNotas.Name = "tsbAñadirNotas";
            this.tsbAñadirNotas.Size = new System.Drawing.Size(222, 22);
            this.tsbAñadirNotas.Text = "Editar Notas";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbNuevaCita
            // 
            this.tsbNuevaCita.Name = "tsbNuevaCita";
            this.tsbNuevaCita.Size = new System.Drawing.Size(222, 22);
            this.tsbNuevaCita.Text = "Nueva cita";
            // 
            // tsbVerCita
            // 
            this.tsbVerCita.Name = "tsbVerCita";
            this.tsbVerCita.Size = new System.Drawing.Size(222, 22);
            this.tsbVerCita.Text = "Ver cita";
            // 
            // tsbModificarCita
            // 
            this.tsbModificarCita.Name = "tsbModificarCita";
            this.tsbModificarCita.Size = new System.Drawing.Size(222, 22);
            this.tsbModificarCita.Text = "Modificar cita";
            // 
            // tsbCopiarCita
            // 
            this.tsbCopiarCita.Name = "tsbCopiarCita";
            this.tsbCopiarCita.Size = new System.Drawing.Size(222, 22);
            this.tsbCopiarCita.Text = "Copiar cita";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbCopiarPortapapelesCita
            // 
            this.tsbCopiarPortapapelesCita.Name = "tsbCopiarPortapapelesCita";
            this.tsbCopiarPortapapelesCita.Size = new System.Drawing.Size(222, 22);
            this.tsbCopiarPortapapelesCita.Text = "Copiar al portapapeles";
            // 
            // tsbPegarPortapapelesCita
            // 
            this.tsbPegarPortapapelesCita.Name = "tsbPegarPortapapelesCita";
            this.tsbPegarPortapapelesCita.Size = new System.Drawing.Size(222, 22);
            this.tsbPegarPortapapelesCita.Text = "Pegar desde el portapapeles";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbProgramarCitas
            // 
            this.tsbProgramarCitas.Name = "tsbProgramarCitas";
            this.tsbProgramarCitas.Size = new System.Drawing.Size(222, 22);
            this.tsbProgramarCitas.Text = "Programar citas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbCambiarEstado
            // 
            this.tsbCambiarEstado.Name = "tsbCambiarEstado";
            this.tsbCambiarEstado.Size = new System.Drawing.Size(222, 22);
            this.tsbCambiarEstado.Text = "Cambiar estado";
            // 
            // tsbCambiarSala
            // 
            this.tsbCambiarSala.Name = "tsbCambiarSala";
            this.tsbCambiarSala.Size = new System.Drawing.Size(222, 22);
            this.tsbCambiarSala.Text = "Mover a";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbBorrarCita
            // 
            this.tsbBorrarCita.Name = "tsbBorrarCita";
            this.tsbBorrarCita.Size = new System.Drawing.Size(222, 22);
            this.tsbBorrarCita.Text = "Borrar Cita";
            // 
            // tsbMenuEventos
            // 
            this.tsbMenuEventos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevoEvento,
            this.tsbVerEvento,
            this.tsbModificarEvento,
            this.toolStripSeparator6,
            this.tsbCopiarPortapapelesEvento,
            this.tsbPegarPortapapelesEvento,
            this.toolStripSeparator4,
            this.tsbBorrarEvento});
            this.tsbMenuEventos.Name = "tsbMenuEventos";
            this.tsbMenuEventos.Size = new System.Drawing.Size(186, 22);
            this.tsbMenuEventos.Text = "Eventos/Tareas";
            // 
            // tsbNuevoEvento
            // 
            this.tsbNuevoEvento.Name = "tsbNuevoEvento";
            this.tsbNuevoEvento.Size = new System.Drawing.Size(222, 22);
            this.tsbNuevoEvento.Text = "Nuevo evento";
            // 
            // tsbVerEvento
            // 
            this.tsbVerEvento.Name = "tsbVerEvento";
            this.tsbVerEvento.Size = new System.Drawing.Size(222, 22);
            this.tsbVerEvento.Text = "Ver evento";
            // 
            // tsbModificarEvento
            // 
            this.tsbModificarEvento.Name = "tsbModificarEvento";
            this.tsbModificarEvento.Size = new System.Drawing.Size(222, 22);
            this.tsbModificarEvento.Text = "Modificar evento";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbCopiarPortapapelesEvento
            // 
            this.tsbCopiarPortapapelesEvento.Name = "tsbCopiarPortapapelesEvento";
            this.tsbCopiarPortapapelesEvento.Size = new System.Drawing.Size(222, 22);
            this.tsbCopiarPortapapelesEvento.Text = "Copiar al portapapeles";
            // 
            // tsbPegarPortapapelesEvento
            // 
            this.tsbPegarPortapapelesEvento.Name = "tsbPegarPortapapelesEvento";
            this.tsbPegarPortapapelesEvento.Size = new System.Drawing.Size(222, 22);
            this.tsbPegarPortapapelesEvento.Text = "Pegar desde el portapapeles";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbBorrarEvento
            // 
            this.tsbBorrarEvento.Name = "tsbBorrarEvento";
            this.tsbBorrarEvento.Size = new System.Drawing.Size(222, 22);
            this.tsbBorrarEvento.Text = "Borrar evento";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(183, 6);
            // 
            // tsbMenuVerPaciente
            // 
            this.tsbMenuVerPaciente.Name = "tsbMenuVerPaciente";
            this.tsbMenuVerPaciente.Size = new System.Drawing.Size(186, 22);
            this.tsbMenuVerPaciente.Text = "Ver ficha de Paciente";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(183, 6);
            // 
            // tsbMenuGenerarRecibo
            // 
            this.tsbMenuGenerarRecibo.Name = "tsbMenuGenerarRecibo";
            this.tsbMenuGenerarRecibo.Size = new System.Drawing.Size(186, 22);
            this.tsbMenuGenerarRecibo.Text = "Generar recibo";
            this.tsbMenuGenerarRecibo.Visible = false;
            // 
            // labNotas
            // 
            this.labNotas.AutoSize = true;
            this.labNotas.BackColor = System.Drawing.Color.LightYellow;
            this.labNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labNotas.Location = new System.Drawing.Point(0, 0);
            this.labNotas.Name = "labNotas";
            this.labNotas.Size = new System.Drawing.Size(100, 23);
            this.labNotas.TabIndex = 0;
            this.labNotas.Visible = false;
            // 
            // DayView
            // 
            this.ContextMenuStrip = this.cmenuOpciones;
            this.StartHour = 9;
            this.WorkingHourEnd = 22;
            this.WorkingHourStart = 9;
            this.WorkingMinuteEnd = 0;
            this.WorkingMinuteStart = 0;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DayView_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayView_MouseDown);
            this.NewAppointment += new Calendar.NewAppointmentEventHandler(this.Handler_NewAppointment);
            this.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(this.Handler_ResolveAppointments);
            this.cmenuOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Drawing.Point GetLocationAppointmentAt(int x, int y)
        {
            System.Drawing.Point res = new System.Drawing.Point(x,y);
            foreach (Calendar.DayView.AppointmentView view in appointmentViews.Values)
                if (view.Rectangle.Contains(x, y))
                    res = view.Rectangle.Location;

            return res;
        }

        private void cmenuOpciones_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.tsbMenuCitas.Enabled = (this.SelectedAppointment==null) || (SelectedAppointment.Tag is lib.vo.Cita);
                this.tsbMenuVerPaciente.Enabled = this.tsbMenuCitas.Enabled;

                this.tsbMenuEventos.Enabled = (this.SelectedAppointment==null) || !(SelectedAppointment.Tag is lib.vo.Cita);
                this.tsbMenuGenerarRecibo.Enabled = this.tsbMenuCitas.Enabled && (this.SelectedAppointment!=null) && !((lib.vo.Cita)SelectedAppointment.Tag).Facturada;

                this.tsbCopiarPortapapelesCita.Enabled = (this.SelectedAppointment != null);
                this.tsbPegarPortapapelesCita.Enabled = (this.SelectedAppointment == null) && (_portapapelesCita != null);

                this.tsbCopiarPortapapelesEvento.Enabled = (this.SelectedAppointment != null);
                this.tsbPegarPortapapelesEvento.Enabled = (this.SelectedAppointment == null) && (_portapapelesEvento != null);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private Calendar.Appointment tmpAp = null;
        private void DayView_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                Calendar.Appointment ap = this.GetAppointmentAt(e.X, e.Y);
                if ((ap != null) && (ap != tmpAp))
                {
                    tmpAp = ap;

                    if (ap.Tag is lib.vo.Cita)
                    {
                        lib.vo.Cita cita = AppointmentToCita(ap);
                        //if (!string.IsNullOrEmpty(cita.Notas))
                        if ((!string.IsNullOrEmpty(cita.Paciente.NotasAgenda)) || ((!string.IsNullOrEmpty(cita.Notas))))
                        {
                            if (!string.IsNullOrEmpty(cita.Paciente.NotasAgenda))
                                labNotas.Text = "Notas: " + Environment.NewLine + cita.Paciente.NotasAgenda;
                            else
                                labNotas.Text = "Notas: " + Environment.NewLine + cita.Notas;
                            System.Drawing.Point locationApp = GetLocationAppointmentAt(e.X, e.Y);
                            labNotas.Location = new System.Drawing.Point(locationApp.X, locationApp.Y - labNotas.Height - 4);
                            labNotas.Visible = true;

                            this.Invalidate();
                            this.Refresh();
                            labNotas.Invalidate();
                            labNotas.Refresh();
                        }
                    }
                    else if (ap.Tag is lib.vo.Evento)
                    {
                        lib.vo.Evento evento = AppointmentToEvento(ap);

                        labNotas.Text = "Recordatorio: " + Environment.NewLine + evento.ToString();
                        System.Drawing.Point locationApp = GetLocationAppointmentAt(e.X, e.Y);
                        labNotas.Location = new System.Drawing.Point(locationApp.X, locationApp.Y - labNotas.Height - 4);
                        labNotas.Visible = true;

                        this.Invalidate();
                        this.Refresh();
                        labNotas.Invalidate();
                        labNotas.Refresh();
                    }
                }
                else
                {
                    labNotas.Visible = false;
                    tmpAp = null;
                }
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        private void DayView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        //void dgConsulta_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    try
        //    {
        //        System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
        //        System.Windows.Forms.DataGridView.HitTestInfo hitTest = dgv.HitTest(e.X, e.Y);
        //        if ((hitTest.RowIndex != -1) && (hitTest.ColumnIndex != -1))
        //            dgv.CurrentCell = dgv[hitTest.ColumnIndex, hitTest.RowIndex];
        //    }
        //    catch (Exception ex)
        //    {
        //        template._common.messages.ShowError(ex);
        //    }
        //}


    }
}
