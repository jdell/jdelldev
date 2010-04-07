using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.controls
{
    class Agenda:System.Windows.Forms.DataGridView
    {

        private List<lib.vo.Cita> _dataSourceCitas = null;
        private System.Windows.Forms.ContextMenuStrip cmenuOpciones;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuCitas;
        private System.Windows.Forms.ToolStripMenuItem tsbAtenderCita;
        private System.Windows.Forms.ToolStripMenuItem tsbAñadirNotas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsbNuevaCita;
        private System.Windows.Forms.ToolStripMenuItem tsbVerCita;
        private System.Windows.Forms.ToolStripMenuItem tsbModificarCita;
        private System.Windows.Forms.ToolStripMenuItem tsbCopiarCita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsbCopiarPortapapelesCita;
        private System.Windows.Forms.ToolStripMenuItem tsbPegarPortapapelesCita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsbProgramarCitas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsbCambiarEstadoCita;
        private System.Windows.Forms.ToolStripMenuItem tsbCambiarSala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsbBorrarCita;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuEventos;
        private System.Windows.Forms.ToolStripMenuItem tsbNuevoEvento;
        private System.Windows.Forms.ToolStripMenuItem tsbVerEvento;
        private System.Windows.Forms.ToolStripMenuItem tsbModificarEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsbCopiarPortapapelesEvento;
        private System.Windows.Forms.ToolStripMenuItem tsbPegarPortapapelesEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsbBorrarEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuVerPaciente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsbCambiarEstadoEvento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.Label labNotas;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuGenerarRecibo;

        public Agenda():base()
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
            List<lib.vo.EstadoCita> listEstadoCita = lnEstadoCita.execute();
            foreach (lib.vo.EstadoCita estado in listEstadoCita)
            {
                System.Windows.Forms.ToolStripMenuItem item = new System.Windows.Forms.ToolStripMenuItem(estado.ToString(), repsol.util.image.CreateImage(estado.DrawColor));
                item.Tag = estado;
                item.Click += new EventHandler(itemEstadoCita_Click);
                this.tsbCambiarEstadoCita.DropDownItems.Add(item);
                if (estado.GeneraRecibo)
                    this.cmenuOpciones.Items.Add(item);
            }

            lib.bl.estadoevento.doGetAll lnEstadoEvento = new asr.lib.bl.estadoevento.doGetAll();
            List<lib.vo.EstadoEvento> listEstadoEvento = lnEstadoEvento.execute();
            foreach (lib.vo.EstadoEvento estado in listEstadoEvento)
            {
                System.Windows.Forms.ToolStripMenuItem item = new System.Windows.Forms.ToolStripMenuItem(estado.ToString(), repsol.util.image.CreateImage(estado.DrawColor));
                item.Tag = estado;
                item.Click += new EventHandler(itemEstadoEvento_Click);
                this.tsbCambiarEstadoEvento.DropDownItems.Add(item);
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

        }

        #region Propiedades

        private DateTime _fecha;
        public DateTime Fecha
        {
            get
            {
                return this._fecha;
            }
            set
            {
                this._fecha = value;
            }
        }

        public List<lib.vo.Cita> DataSourceCitas
        {
            get
            {
                return _dataSourceCitas;
            }
            set
            {
                _dataSourceCitas = value;
            }
        }
        private List<lib.vo.Evento> _dataSourceEventos = null;
        public List<lib.vo.Evento> DataSourceEventos
        {
            get
            {
                return _dataSourceEventos;
            }
            set
            {
                _dataSourceEventos = value;
            }
        }
        public lib.vo.Cita CitaSeleccionada
        {
            get
            {
                lib.vo.Cita res = null;

                if ((this.CurrentCell.Tag!=null) && (this.CurrentCell.Tag is lib.vo.Cita))
                    res = (lib.vo.Cita)this.CurrentCell.Tag;

                return res;
            }
        }
        public lib.vo.Evento EventoSeleccionado
        {
            get
            {
                lib.vo.Evento res = null;

                if ((this.CurrentCell.Tag != null) && (this.CurrentCell.Tag is lib.vo.Evento))
                    res = (lib.vo.Evento)this.CurrentCell.Tag;

                return res;
            }
        }

        private int _salto = 10;
        public int Salto
        {
            get
            {
                return _salto;
            }
            set
            {
                _salto = value;
            }
        }

        private int _inicioHora = 9;
        public int InicioHora
        {
            get
            {
                return _inicioHora;
            }
            set
            {
                _inicioHora = value;
            }
        }

        private int _inicioMinuto = 0;
        public int InicioMinuto
        {
            get
            {
                return _inicioMinuto;
            }
            set
            {
                _inicioMinuto = value;
            }
        }

        private int _finHora = 18;
        public int FinHora
        {
            get
            {
                return _finHora;
            }
            set
            {
                _finHora = value;
            }
        }

        private int _finMinuto = 0;
        public int FinMinuto
        {
            get
            {
                return _finMinuto;
            }
            set
            {
                _finMinuto = value;
            }
        }
        
        private List<lib.vo.Sala> _dataSourceColumns = null;
        public List<lib.vo.Sala> DataSourceColumns
        {
            get
            {
                return _dataSourceColumns;
            }
            set
            {
                _dataSourceColumns = value;
            }
        }

        #endregion

        #region Eventos

        #region Citas

        void tsbAtenderCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEditDatosClinicos vVen = new asr.app.pc.frm.cita.frmEditDatosClinicos((lib.vo.Cita)this.CitaSeleccionada);
                vVen.ShowDialog();

                this.RefreshData_II();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbVerCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit((lib.vo.Cita)this.CitaSeleccionada, true);
                vVen.ShowDialog();
                this.RefreshData_II();
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
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit((lib.vo.Cita)this.CitaSeleccionada);
                vVen.ShowDialog();
                
                this.RefreshData_II();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    
        void tsbBorrarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(asr.app.pc._common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if (borrarCita((lib.vo.Cita)this.CitaSeleccionada))
                        RefreshData_II();
                    else
                        template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                }
                this.RefreshData_II();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        void tsbModificarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit((lib.vo.Cita)this.CitaSeleccionada, false);
                vVen.ShowDialog();
                
                this.RefreshData_II();
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
                if (this.isCeldaValida())
                {
                    DateTime fecha = this.getFechaSeleccionada();
                    lib.vo.Sala sala = this.getSalaSeleccionada();

                    asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit(fecha, sala);
                    vVen.ShowDialog();

                    this.RefreshData_II();
                }
                else
                    template._common.messages.ShowWarning("Debe seleccionar una celda válida","Agenda");
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbMenuVerPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.paciente.frmEdit vVen = new asr.app.pc.frm.paciente.frmEdit(getFullPaciente(this.CitaSeleccionada), false);
                vVen.ShowDialog();
                
                this.RefreshData_II();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbMenuGenerarRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //asr.app.pc.frm.operacion.frmEdit vVen = new asr.app.pc.frm.operacion.frmEdit(AppointmentToCita(this.SelectedAppointment));
                //vVen.ShowDialog();

                lib.bl.operacion.doGenerate lnOperacionGenerate = new asr.lib.bl.operacion.doGenerate(this.CitaSeleccionada);
                lib.bl.operacion.doAdd lnOperacionAdd = new asr.lib.bl.operacion.doAdd(lnOperacionGenerate.execute());
                lnOperacionAdd.execute();
                //template._common.messages.ShowInfo("Recibo generado", "Recibos");
                
                this.RefreshData_II();
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
                if (this.isCeldaValida())
                {
                    DateTime fecha = this.getFechaSeleccionada();

                    asr.app.pc.frm.cita.frmEditProgramada vVen = new asr.app.pc.frm.cita.frmEditProgramada(fecha, (lib.vo.Sala)this.Tag);
                    vVen.ShowDialog();

                    this.RefreshData_II();
                }

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
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.cita.frmEditNotas vVen = new asr.app.pc.frm.cita.frmEditNotas((lib.vo.Cita)this.CitaSeleccionada);
                vVen.ShowDialog();
                
                this.RefreshData_II();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        #endregion

        #region Eventos 
        
        void tsbBorrarEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.EventoSeleccionado == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(asr.app.pc._common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if (borrarEvento((lib.vo.Evento)this.EventoSeleccionado))
                        RefreshData_II();
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
                if (this.EventoSeleccionado == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit((lib.vo.Evento)this.EventoSeleccionado, false);
                vVen.ShowDialog();
                
                this.RefreshData_II();
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
                if (this.EventoSeleccionado == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit((lib.vo.Evento)this.EventoSeleccionado, true);
                vVen.ShowDialog();
                
                this.RefreshData_II();
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
                if (this.isCeldaValida())
                {
                    DateTime fecha = this.getFechaSeleccionada();
                    lib.vo.Sala sala = this.getSalaSeleccionada();

                    asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit(fecha, sala);
                    vVen.ShowDialog();

                    this.RefreshData_II();
                }
                else
                    template._common.messages.ShowWarning("Debe seleccionar una celda válida", "Agenda");
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        #endregion

        #endregion

        #region Metodos

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
        private DateTime getFechaSeleccionada()
        {
            try
            {
                DateTime res = (DateTime)this.CurrentRow.Cells["horaIzq"].Tag;
                res = new DateTime(this.Fecha.Year, this.Fecha.Month, this.Fecha.Day, res.Hour, res.Minute,res.Second);

                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private lib.vo.Sala getSalaSeleccionada()
        {
            try
            {
                return (lib.vo.Sala)this.Columns[this.CurrentCell.ColumnIndex].Tag;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool isCeldaValida()
        {
            try
            {
                bool res = this.CurrentCell!=null && this.Columns[this.CurrentCell.ColumnIndex].Tag!=null;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        
        #region Portapapeles

        bool portapapelesIsCita()
        {
            return _portapapelesObject.GetType().FullName == typeof(lib.vo.Cita).FullName;
        }
        bool portapapelesIsEvento()
        {
            return _portapapelesObject.GetType().FullName == typeof(lib.vo.Evento).FullName;
        }

        //private static lib.vo.Cita _portapapelesCita = null;
        private static object _portapapelesObject = null;
        private void setPortapapeles(lib.vo.Cita cita)
        {
            _portapapelesObject = cita;
        }
        private lib.vo.Cita getPortapapelesCita(bool clear)
        {
            lib.vo.Cita res = (lib.vo.Cita)_portapapelesObject;
            if (clear)
                _portapapelesObject = null;
            return res;
        }

        void tsbPegarPortapapelesCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isCeldaValida())
                {
                    if (getPortapapelesCita(false) == null)
                    {
                        template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.CLIPBOARD_EMPTY, this.Text);
                        return;
                    }

                    lib.vo.Cita objVO = getPortapapelesCita(false);
                    objVO.Sala = (lib.vo.Sala)this.Columns[this.CurrentCell.ColumnIndex].Tag;
                    objVO.Fecha = this.getFechaSeleccionada();

                    asr.app.pc.frm.cita.frmEdit vVen = new asr.app.pc.frm.cita.frmEdit(objVO);
                    if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        getPortapapelesCita(false);

                    this.RefreshData_II();
                }
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
                if (this.isCeldaValida())
                {
                    if (this.CitaSeleccionada == null)
                    {
                        template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                        return;
                    }

                    setPortapapeles((lib.vo.Cita)this.CitaSeleccionada);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


        private static lib.vo.Evento _portapapelesEvento = null;
        private void setPortapapeles(lib.vo.Evento evento)
        {
            _portapapelesObject = evento;
        }
        private lib.vo.Evento getPortapapelesEvento(bool clear)
        {
            lib.vo.Evento res = (lib.vo.Evento)_portapapelesObject;
            if (clear)
                _portapapelesObject = null;
            return res;
        }

        void tsbPegarPortapapelesEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isCeldaValida())
                {
                    if (getPortapapelesEvento(false) == null)
                    {
                        template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.CLIPBOARD_EMPTY, this.Text);
                        return;
                    }

                    lib.vo.Evento objVO = getPortapapelesEvento(false);
                    objVO.Fecha = this.getFechaSeleccionada();
                    objVO.Sala = (lib.vo.Sala)this.Columns[this.CurrentCell.ColumnIndex].Tag;

                    asr.app.pc.frm.evento.frmEdit vVen = new asr.app.pc.frm.evento.frmEdit(objVO);
                    if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        getPortapapelesEvento(false);

                    this.RefreshData_II();
                }
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
                if (this.isCeldaValida())
                {
                    if (this.EventoSeleccionado == null)
                    {
                        template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                        return;
                    }

                    setPortapapeles((lib.vo.Evento)this.EventoSeleccionado);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #endregion
        void itemEstadoEvento_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.EventoSeleccionado == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Desea cambiar el estado de la evento?", "Agenda", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                //{
                System.Windows.Forms.ToolStripMenuItem item = (System.Windows.Forms.ToolStripMenuItem)sender;
                lib.vo.EstadoEvento estado = (lib.vo.EstadoEvento)item.Tag;
                lib.vo.Evento evento = this.EventoSeleccionado;
                if ((evento.EstadoEvento.ID != estado.ID))
                {
                    //if ((!lib.bl._common.cache.EMPLEADO.Gerente) && (evento.Facturada))
                    //    throw new lib.bl._exceptions.validatingException("La evento ya ha sido facturada y no puede ser modificada. Borre la operación asociada y vuelva a intentarlo.");

                    evento.EstadoEvento = estado;

                    lib.bl.evento.doUpdate lnEvento = new asr.lib.bl.evento.doUpdate(evento);
                    lnEvento.execute();

                    this.RefreshData_II();
                }
                //}

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        void itemEstadoCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Desea cambiar el estado de la cita?", "Agenda", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                //{
                System.Windows.Forms.ToolStripMenuItem item = (System.Windows.Forms.ToolStripMenuItem)sender;
                lib.vo.EstadoCita estado = (lib.vo.EstadoCita)item.Tag;
                lib.vo.Cita cita = this.CitaSeleccionada;
                if ((cita.EstadoCita.ID != estado.ID))
                {
                    //if ((!lib.bl._common.cache.EMPLEADO.Gerente) && (cita.Facturada))
                    //    throw new lib.bl._exceptions.validatingException("La cita ya ha sido facturada y no puede ser modificada. Borre la operación asociada y vuelva a intentarlo.");

                    cita.EstadoCita = estado;

                    lib.bl.cita.doUpdate lnCita = new asr.lib.bl.cita.doUpdate(cita);
                    lnCita.execute();

                    //if ((cita.EstadoCita.GeneraRecibo) && (!cita.Facturada)) tsbMenuGenerarRecibo_Click(this.tsbMenuGenerarRecibo, e);

                    this.RefreshData_II();
                }
                //}

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        void itemSala_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada == null)
                {
                    template._common.messages.ShowWarning(asr.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Desea cambiar el estado de la cita?", "Agenda", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                //{
                System.Windows.Forms.ToolStripMenuItem item = (System.Windows.Forms.ToolStripMenuItem)sender;
                lib.vo.Sala sala = (lib.vo.Sala)item.Tag;
                lib.vo.Cita cita = this.CitaSeleccionada;
                if (cita.Sala.ID != sala.ID)
                {
                    cita.Sala = sala;

                    lib.bl.cita.doUpdate lnCita = new asr.lib.bl.cita.doUpdate(cita);
                    lnCita.execute();

                    this.RefreshData_II();
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
                //this.Appointments.Clear();
                //if (fecha != null)
                //{
                //    if (sala != null)
                //    {
                //        asr.lib.bl.evento.doGetAllPorFechaYSala lnEvento = new asr.lib.bl.evento.doGetAllPorFechaYSala(fecha, sala);
                //        List<lib.vo.Evento> listEvento = lnEvento.execute();
                //        foreach (lib.vo.Evento evento in listEvento)
                //            this.Appointments.Add(this.EventoToAppointment(evento));

                //        asr.lib.bl.cita.doGetAllPorFechaYSala lnCita = new asr.lib.bl.cita.doGetAllPorFechaYSala(fecha, sala);
                //        List<lib.vo.Cita> listCita = lnCita.execute();
                //        foreach (lib.vo.Cita cita in listCita)
                //            if (cita.Presencial) this.Appointments.Add(this.CitaToAppointment(cita));
                //    }
                //}

                //this.Invalidate();
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
                //this.Appointments.Clear();
                //if ((fecha != null) && (paciente != null))
                //{
                //    asr.lib.bl.cita.doGetAllPorFechaYPaciente lnCita = new asr.lib.bl.cita.doGetAllPorFechaYPaciente(fecha, paciente);
                //    List<lib.vo.Cita> listCita = lnCita.execute();
                //    foreach (lib.vo.Cita cita in listCita)
                //        if (cita.Presencial) this.Appointments.Add(this.CitaToAppointment(cita));
                //}

                //this.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void Init()
        {
            try
            {
                this.AllowUserToAddRows = false;
                this.AllowUserToDeleteRows = false;
                this.Font = pc._common.cache.FontAgenda;
                //System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
                //dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                //dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
                //dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
                //dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
                //dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
                //dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                //this.DefaultCellStyle = dataGridViewCellStyle1;
                this.ReadOnly = true;
                this.RowHeadersVisible = false;
                this.AllowUserToResizeColumns = false;
                this.AllowUserToResizeRows = false;
                this.MultiSelect = false;
                this.BackgroundColor = System.Drawing.Color.White;

                this.Salto = lib.bl._common.cache.WorkingScheduleStep;
                          
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void Load()
        {
            try
            {
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                this.Init();

                this.Columns.Clear();
                this.Rows.Clear();

                DateTime inicioFecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, this.InicioHora, this.InicioMinuto, 0);
                DateTime finFecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, this.FinHora, this.FinMinuto, 0);

                System.Windows.Forms.DataGridViewTextBoxColumn c;
                c = new System.Windows.Forms.DataGridViewTextBoxColumn();
                c.HeaderText = "Hora";
                c.Name = "horaIzq";
                c.Tag = null;
                c.CellTemplate.Style.BackColor = System.Drawing.Color.SkyBlue;
                c.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
                //c.Frozen = true;
                c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                this.Columns.Add(c);

                if (this.DataSourceColumns != null)
                {
                    foreach (lib.vo.Sala sala in this.DataSourceColumns)
                    {
                        if (sala.Activo)
                        {
                            c = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            c.HeaderText = sala.Descripcion;
                            c.Name = "Sala" + sala.ID.ToString();
                            c.Tag = sala;
                            //c.CellTemplate.Style.BackColor = sala.DrawColor;
                            c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                            
                            this.Columns.Add(c);
                        }
                    }
                }
                c = new System.Windows.Forms.DataGridViewTextBoxColumn();
                c.HeaderText = "Hora";
                c.Name = "horaDcha";
                c.Tag = null;
                c.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
                c.CellTemplate.Style.BackColor = System.Drawing.Color.SkyBlue;
                c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                this.Columns.Add(c);

                for (DateTime fechaTmp = inicioFecha; fechaTmp < finFecha; fechaTmp = fechaTmp.AddMinutes(Salto))
                {
                    int index = this.Rows.Add();
                    System.Windows.Forms.DataGridViewRow r = this.Rows[index];


                    foreach (System.Windows.Forms.DataGridViewCell cl in r.Cells)
                        cl.Value = string.Empty;

                    r.Cells["horaIzq"].Value = fechaTmp.ToString("HH:mm");
                    r.Cells["horaIzq"].Tag = fechaTmp;
                    r.Cells["horaDcha"].Value = fechaTmp.ToString("HH:mm");
                    r.Cells["horaDcha"].Tag = fechaTmp;
                }

                if (this.DataSourceCitas != null)
                {
                    foreach (lib.vo.Cita cita in this.DataSourceCitas)
                        setCitaIntoGrid(cita);
                }
                if (this.DataSourceEventos != null)
                {
                    foreach (lib.vo.Evento evento in this.DataSourceEventos)
                        setEventoIntoGrid(evento);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true;
            }
        }

        private void setCitaIntoGrid(lib.vo.Cita cita)
        {
            try
            {
                int column = int.MinValue;
                foreach (System.Windows.Forms.DataGridViewColumn c in this.Columns)
                {
                    if ((c.Tag != null) && (cita.Sala!=null) && (((lib.vo.Sala)c.Tag).ID == cita.Sala.ID))
                    {
                        column = c.Index;
                        break;
                    }
                }
                if (column != int.MinValue)
                {
                    int minutos = cita.Fecha.Hour * 60 + cita.Fecha.Minute;
                    minutos -= this.InicioHora * 60 + this.InicioMinuto;
                    int row = minutos / this.Salto;

                    if ((row > -1) && (row <= (this.FinHora * 60 + this.FinMinuto - this.InicioHora * 60 - this.InicioMinuto) / this.Salto))
                    {
                        int celdas = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(cita.Duracion) / Convert.ToDouble(this.Salto)));
                        if (celdas > 0)
                        {
                            if (celdas == 1)
                            {
                                this[column, row].Value = cita.Customer.ToString();
                                this[column, row].Style.BackColor = cita.DrawColor;//cita.Sala.DrawColor;
                                this[column, row].Tag = cita;
                            }
                            else
                            {
                                //TODO: Agenda - Hay que darle formato a las celdas
                                this[column, row].Value = cita.Paciente.ToString();
                                this[column, row].Style.ForeColor = cita.EstadoCita.DrawColor;
                                this[column, row].Tag = cita;

                                if (row + 1 < this.Rows.Count)
                                {
                                    row += 1;
                                    this[column, row].Value = cita.Customer.ToString();
                                    this[column, row].Style.BackColor = cita.DrawColor;//cita.Sala.DrawColor;
                                    this[column, row].Tag = cita;
                                }

                                for (int i = 2; i < celdas; i++)
                                {
                                    if (row + 1 < this.Rows.Count)
                                    {
                                        row += 1;
                                        this[column, row].Value = string.Empty;// i.ToString();
                                        this[column, row].Style.BackColor = cita.DrawColor; //cita.Sala.DrawColor;
                                        this[column, row].Tag = cita;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void setEventoIntoGrid(lib.vo.Evento evento)
        {
            try
            {
                int column = int.MinValue;
                foreach (System.Windows.Forms.DataGridViewColumn c in this.Columns)
                {
                    if ((c.Tag != null) && (((lib.vo.Sala)c.Tag).ID == evento.Sala.ID))
                    {
                        column = c.Index;
                        break;
                    }
                }
                if (column != int.MinValue)
                {
                    int minutos = evento.Fecha.Hour * 60 + evento.Fecha.Minute;
                    minutos -= this.InicioHora * 60 + this.InicioMinuto;
                    int row = minutos / this.Salto;

                    if ((row > -1) && (row <= (this.FinHora * 60 + this.FinMinuto - this.InicioHora * 60 - this.InicioMinuto) / this.Salto))
                    {
                        int celdas = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(evento.Duracion) / Convert.ToDouble(this.Salto)));
                        if (celdas > 0)
                        {
                            if (celdas == 1)
                            {
                                this[column, row].Value = "Evento: " + evento.Descripcion.ToString();
                                this[column, row].Style.BackColor = evento.EstadoEvento.DrawColor;
                                this[column, row].Tag = evento;
                            }
                            else
                            {
                                this[column, row].Value = "Evento: " + evento.Descripcion.ToString();
                                this[column, row].Style.BackColor = evento.EstadoEvento.DrawColor;
                                this[column, row].Tag = evento;

                                for (int i = 1; i < celdas; i++)
                                {
                                    if (row + 1 < this.Rows.Count)
                                    {
                                        row += 1;
                                        this[column, row].Value = string.Empty;// i.ToString();
                                        this[column, row].Style.BackColor = evento.EstadoEvento.DrawColor;
                                        this[column, row].Tag = evento;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
            this.tsbCambiarEstadoCita = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsbCambiarEstadoEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBorrarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMenuVerPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMenuGenerarRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.labNotas = new System.Windows.Forms.Label();
            this.cmenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            this.tsbCambiarEstadoCita,
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
            // tsbCambiarEstadoCita
            // 
            this.tsbCambiarEstadoCita.Name = "tsbCambiarEstadoCita";
            this.tsbCambiarEstadoCita.Size = new System.Drawing.Size(222, 22);
            this.tsbCambiarEstadoCita.Text = "Cambiar estado";
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
            this.tsbCambiarEstadoEvento,
            this.toolStripSeparator10,
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
            // tsbCambiarEstadoEvento
            // 
            this.tsbCambiarEstadoEvento.Name = "tsbCambiarEstadoEvento";
            this.tsbCambiarEstadoEvento.Size = new System.Drawing.Size(222, 22);
            this.tsbCambiarEstadoEvento.Text = "Cambiar estado";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(219, 6);
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
            // Agenda
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.BackgroundColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cmenuOpciones;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Agenda_MouseDown);
            this.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Agenda_CellDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Agenda_MouseMove);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Agenda_KeyDown);
            this.cmenuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void Agenda_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                System.Windows.Forms.DataGridView.HitTestInfo htest = this.HitTest(e.X, e.Y);
                if (htest.ColumnIndex!=-1 && htest.RowIndex!=-1)
                    this.CurrentCell = this[htest.ColumnIndex, htest.RowIndex];
            }
            catch (Exception ex)
            {
                //throw ex;
                template._common.messages.ShowError(ex);
            }
        }

        private void Agenda_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.CitaSeleccionada != null)
                    this.tsbModificarCita_Click(null, null);
                else if (this.EventoSeleccionado != null)
                    this.tsbModificarEvento_Click(null, null);
                else if (this.CitaSeleccionada == null)
                    this.tsbNuevaCita_Click(null, null);

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        public void RefreshData_II()
        {
            try
            {
                lib.bl.cita.doGetAll lnCita = new asr.lib.bl.cita.doGetAll(new asr.lib.vo.filtro.FiltroCita(null, null, this.Fecha));
                this.DataSourceCitas = lnCita.execute();

                lib.bl.evento.doGetAllPorFecha lnEvento = new asr.lib.bl.evento.doGetAllPorFecha(new lib.common.tipos.ParDateTime(this.Fecha));
                this.DataSourceEventos = lnEvento.execute();

                this.Load();
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        private void cmenuOpciones_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.tsbMenuCitas.Enabled = this.isCeldaValida() && (((this.CitaSeleccionada == null) && (this.EventoSeleccionado==null)) || (this.CitaSeleccionada!=null));
                this.tsbMenuVerPaciente.Enabled = this.tsbMenuCitas.Enabled;

                this.tsbMenuEventos.Enabled = this.isCeldaValida() && (((this.CitaSeleccionada == null) && (this.EventoSeleccionado == null)) || (this.EventoSeleccionado != null));
                this.tsbMenuGenerarRecibo.Enabled = this.tsbMenuCitas.Enabled && (this.CitaSeleccionada!=null) && !this.CitaSeleccionada.Facturada;

                this.tsbCopiarPortapapelesCita.Enabled = (this.CitaSeleccionada != null);
                this.tsbPegarPortapapelesCita.Enabled = this.isCeldaValida() && (this.CitaSeleccionada == null) && (this.EventoSeleccionado == null) ;//&& (_portapapelesCita != null);

                this.tsbCopiarPortapapelesEvento.Enabled = (this.EventoSeleccionado != null);
                this.tsbPegarPortapapelesEvento.Enabled = this.isCeldaValida() && (this.CitaSeleccionada == null) && (this.EventoSeleccionado == null) ;//&& (_portapapelesEvento != null);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private System.Windows.Forms.DataGridViewCell tmpAp = null;
        private void Agenda_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                //System.Windows.Forms.DataGridView.HitTestInfo hti = this.HitTest(e.X, e.Y);
                
                //bool res = this.CurrentCell != null && this.Columns[this.CurrentCell.ColumnIndex].Tag != null;

                //System.Windows.Forms.DataGridViewCell cell = this[hti.ColumnIndex, hti.RowIndex];

                //if ((cell != null) && (cell != tmpAp))
                //{
                //    tmpAp = cell;

                //    if (cell.Tag is lib.vo.Cita)
                //    {
                //        lib.vo.Cita cita = (lib.vo.Cita)cell.Tag;
                //        //if (!string.IsNullOrEmpty(cita.Notas))
                //        if (!string.IsNullOrEmpty(cita.Paciente.NotasAgenda))
                //        {
                //            labNotas.Text = "Notas: " + Environment.NewLine + cita.Paciente.NotasAgenda;
                //            System.Drawing.Point locationApp = e.Location;
                //            labNotas.Location = new System.Drawing.Point(locationApp.X, locationApp.Y - labNotas.Height - 4);
                //            labNotas.Visible = true;

                //            this.Invalidate();
                //            this.Refresh();
                //            labNotas.Invalidate();
                //            labNotas.Refresh();
                //        }
                //    }
                //    else if (cell.Tag is lib.vo.Evento)
                //    {
                //        lib.vo.Evento evento = (lib.vo.Evento)cell.Tag;

                //        labNotas.Text = "Recordatorio: " + Environment.NewLine + evento.ToString();
                //        System.Drawing.Point locationApp = e.Location;
                //        labNotas.Location = new System.Drawing.Point(locationApp.X, locationApp.Y - labNotas.Height - 4);
                //        labNotas.Visible = true;

                //        this.Invalidate();
                //        this.Refresh();
                //        labNotas.Invalidate();
                //        labNotas.Refresh();
                //    }
                //}
                //else
                //{
                //    labNotas.Visible = false;
                //    tmpAp = null;
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Agenda_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.Control == true && e.KeyCode == System.Windows.Forms.Keys.C) 
                {
                    if (isCeldaValida())
                    {
                        if (this.CitaSeleccionada != null)
                            this.tsbCopiarPortapapelesCita_Click(null, null);
                        else if (this.EventoSeleccionado != null)
                            this.tsbCopiarPortapapelesEvento_Click(null, null);
                    }
                }
                else if (e.Control && e.KeyCode == System.Windows.Forms.Keys.V)
                {
                    if (isCeldaValida())
                    {
                        if ((this.CitaSeleccionada == null) && (this.EventoSeleccionado == null) && (_portapapelesObject!=null))
                        {
                            if (this.portapapelesIsCita())
                                this.tsbPegarPortapapelesCita_Click(null, null);
                            else if (portapapelesIsEvento())
                                this.tsbPegarPortapapelesEvento_Click(null, null);
                        }
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
