using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.gui.pc.template.controls
{
    class Agenda:System.Windows.Forms.DataGridView
    {

        private List<ambis1.model.vo.Reservation> _dataSourceReservations = null;
        private System.Windows.Forms.ContextMenuStrip cmenuOpciones;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuReservations;
        private System.Windows.Forms.ToolStripMenuItem tsbNuevaReservation;
        private System.Windows.Forms.ToolStripMenuItem tsbModificarReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsbCopiarPortapapelesReservation;
        private System.Windows.Forms.ToolStripMenuItem tsbPegarPortapapelesReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tsbProgramarReservations;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsbCambiarCage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsbBorrarReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsbMenuVerTeam;
        private System.Windows.Forms.Label labNotas;

        public Agenda():base()
        {
            InitializeComponent();

            this.tsbNuevaReservation.Click += new EventHandler(tsbNuevaReservation_Click);
            this.tsbModificarReservation.Click += new EventHandler(tsbModificarReservation_Click);
            this.tsbBorrarReservation.Click += new EventHandler(tsbBorrarReservation_Click);
            this.tsbCopiarPortapapelesReservation.Click += new EventHandler(tsbCopiarPortapapelesReservation_Click);
            this.tsbPegarPortapapelesReservation.Click += new EventHandler(tsbPegarPortapapelesReservation_Click);

            this.tsbMenuVerTeam.Click += new EventHandler(tsbMenuVerTeam_Click);

            //model.bl.cage.doGetAll lnCage = new ambis1.model.bl.cage.doGetAll();
            //List<ambis1.model.vo.Cage> listCage = lnCage.execute();
            //foreach (ambis1.model.vo.Cage cage in listCage)
            //{
            //    System.Windows.Forms.ToolStripMenuItem item = new System.Windows.Forms.ToolStripMenuItem(cage.ToString());
            //    item.Tag = cage;
            //    item.Click += new EventHandler(itemCage_Click);
            //    this.tsbCambiarCage.DropDownItems.Add(item);
            //}
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

                model.bl.holiday.doIsHoliday doIsHoliday = new ambis1.model.bl.holiday.doIsHoliday(new ambis1.model.vo.Holiday(this._fecha));
                _isHoliday = doIsHoliday.execute();
            }
        }

        public List<ambis1.model.vo.Reservation> DataSourceReservations
        {
            get
            {
                return _dataSourceReservations;
            }
            set
            {
                _dataSourceReservations = value;
            }
        }
        public ambis1.model.vo.Reservation ReservationSeleccionada
        {
            get
            {
                ambis1.model.vo.Reservation res = null;

                if ((this.CurrentCell.Tag!=null) && (this.CurrentCell.Tag is ambis1.model.vo.Reservation))
                    res = (ambis1.model.vo.Reservation)this.CurrentCell.Tag;

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
        
        private List<ambis1.model.vo.Cage> _dataSourceColumns = null;
        public List<ambis1.model.vo.Cage> DataSourceColumns
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


        #region Reservations

        void tsbBorrarReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ReservationSeleccionada == null)
                {
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(ambis1.gui.pc._common.constants.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if (borrarReservation((ambis1.model.vo.Reservation)this.ReservationSeleccionada))
                        RefreshData_II();
                    else
                        template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.IMCOMPLETED_OPERATION, this.Text);
                }
                this.RefreshData_II();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        void tsbModificarReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ReservationSeleccionada == null)
                {
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                ambis1.gui.pc.frm.reservation.frmEdit vVen = new ambis1.gui.pc.frm.reservation.frmEdit((ambis1.model.vo.Reservation)this.ReservationSeleccionada);
                vVen.ShowDialog();

                this.RefreshData_II();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbNuevaReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isCeldaValida())
                {
                    DateTime fecha = this.getFechaSeleccionada();
                    ambis1.model.vo.Cage cage = this.getCageSeleccionada();

                    ambis1.gui.pc.frm.reservation.frmEdit vVen = new ambis1.gui.pc.frm.reservation.frmEdit(fecha, cage);
                    vVen.ShowDialog();

                    this.RefreshData_II();
                }
                else
                    template._common.messages.ShowWarning("You must select a valid cell","Calendar");
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void tsbMenuVerTeam_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ReservationSeleccionada == null)
                {
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                model.vo.Member selectedMember = this.ReservationSeleccionada.Member;
                model.bl.membership.doGetByMember doGet = new ambis1.model.bl.membership.doGetByMember(selectedMember);
                model.vo.Membership membership = doGet.execute();
                if (membership != null)
                {
                    frm.membership.frmMemberShipEdit vVen = new ambis1.gui.pc.frm.membership.frmMemberShipEdit(membership);
                    vVen.ShowDialog();
                    
                    this.RefreshData_II();
                }

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #endregion


        #region Metodos

        private ambis1.model.vo.Team getFullTeam(ambis1.model.vo.Reservation reservation)
        {
            try
            {
                model.bl.member.doGet lnTeam = new ambis1.model.bl.member.doGet((model.vo.Member)reservation.Member);
                return (model.vo.Team)lnTeam.execute();
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
        private ambis1.model.vo.Cage getCageSeleccionada()
        {
            try
            {
                return (ambis1.model.vo.Cage)this.Columns[this.CurrentCell.ColumnIndex].Tag;
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

        bool portapapelesIsReservation()
        {
            return _portapapelesObject.GetType().FullName == typeof(ambis1.model.vo.Reservation).FullName;
        }
        
        //private static ambis1.model.vo.Reservation _portapapelesReservation = null;
        private static object _portapapelesObject = null;
        private void setPortapapeles(ambis1.model.vo.Reservation reservation)
        {
            _portapapelesObject = reservation;
        }
        private ambis1.model.vo.Reservation getPortapapelesReservation(bool clear)
        {
            ambis1.model.vo.Reservation res = (ambis1.model.vo.Reservation)_portapapelesObject;
            if (clear)
                _portapapelesObject = null;
            return res;
        }

        void tsbPegarPortapapelesReservation_Click(object sender, EventArgs e)
        {
            try
            {
                //if (this.isCeldaValida())
                //{
                //    if (getPortapapelesReservation(false) == null)
                //    {
                //        template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.CLIPBOARD_EMPTY, this.Text);
                //        return;
                //    }

                //    ambis1.model.vo.Reservation objVO = getPortapapelesReservation(false);
                //    objVO.Cage = (ambis1.model.vo.Cage)this.Columns[this.CurrentCell.ColumnIndex].Tag;
                //    objVO.DateAndTime = this.getFechaSeleccionada();

                //    ambis1.gui.pc.frm.reservation.frmEdit vVen = new ambis1.gui.pc.frm.reservation.frmEdit(objVO);
                //    if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //        getPortapapelesReservation(false);

                //    this.RefreshData_II();
                //}
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        void tsbCopiarPortapapelesReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.isCeldaValida())
                {
                    if (this.ReservationSeleccionada == null)
                    {
                        template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                        return;
                    }

                    setPortapapeles((ambis1.model.vo.Reservation)this.ReservationSeleccionada);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #endregion
        void itemCage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ReservationSeleccionada == null)
                {
                    template._common.messages.ShowWarning(ambis1.gui.pc._common.constants.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Desea cambiar el estado de la reservation?", "Calendar", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                //{
                System.Windows.Forms.ToolStripMenuItem item = (System.Windows.Forms.ToolStripMenuItem)sender;
                ambis1.model.vo.Cage cage = (ambis1.model.vo.Cage)item.Tag;
                ambis1.model.vo.Reservation reservation = this.ReservationSeleccionada;
                if (reservation.Cage.ID != cage.ID)
                {
                    reservation.Cage = cage;

                    model.bl.reservation.doUpdate lnReservation = new ambis1.model.bl.reservation.doUpdate(reservation);
                    lnReservation.execute();

                    this.RefreshData_II();
                }
                //}

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        public void RefreshData(ambis1.model.common.types.ParDateTime fecha, ambis1.model.vo.Cage cage)
        {
            try
            {
                //this.Appointments.Clear();
                //if (fecha != null)
                //{
                //    if (cage != null)
                //    {
                //        ambis1.model.bl.evento.doGetAllPorFechaYCage lnEvento = new ambis1.model.bl.evento.doGetAllPorFechaYCage(fecha, cage);
                //        List<ambis1.model.vo.Evento> listEvento = lnEvento.execute();
                //        foreach (ambis1.model.vo.Evento evento in listEvento)
                //            this.Appointments.Add(this.EventoToAppointment(evento));

                //        ambis1.model.bl.reservation.doGetAllPorFechaYCage lnReservation = new ambis1.model.bl.reservation.doGetAllPorFechaYCage(fecha, cage);
                //        List<ambis1.model.vo.Reservation> listReservation = lnReservation.execute();
                //        foreach (ambis1.model.vo.Reservation reservation in listReservation)
                //            if (reservation.Presencial) this.Appointments.Add(this.ReservationToAppointment(reservation));
                //    }
                //}

                //this.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RefreshData(ambis1.model.common.types.ParDateTime fecha, ambis1.model.vo.Team team)
        {
            try
            {
                //this.Appointments.Clear();
                //if ((fecha != null) && (team != null))
                //{
                //    ambis1.model.bl.reservation.doGetAllPorFechaYTeam lnReservation = new ambis1.model.bl.reservation.doGetAllPorFechaYTeam(fecha, team);
                //    List<ambis1.model.vo.Reservation> listReservation = lnReservation.execute();
                //    foreach (ambis1.model.vo.Reservation reservation in listReservation)
                //        if (reservation.Presencial) this.Appointments.Add(this.ReservationToAppointment(reservation));
                //}

                //this.Invalidate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool borrarReservation(ambis1.model.vo.Reservation objVO)
        {
            try
            {
                model.bl.reservation.doDelete lnReservation = new ambis1.model.bl.reservation.doDelete(objVO);
                lnReservation.execute();

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
                this.RowTemplate.Height = 50;
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
                //this.ReadOnly = true;
                //this.RowHeadersVisible = false;
                //this.AllowUserToResizeColumns = false;
                //this.AllowUserToResizeRows = false;
                //this.MultiSelect = false;
                //this.BackgroundColor = System.Drawing.Color.White;


                this.ReadOnly = true;
                this.RowHeadersVisible = false;
                this.AllowUserToResizeColumns = false;
                this.AllowUserToResizeRows = false;
                this.MultiSelect = false;
                this.BackgroundColor = System.Drawing.Color.White;
                this.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
                this.InicioHora = model.bl._common.cache.WorkingHourStart;
                this.InicioMinuto = model.bl._common.cache.WorkingMinuteStart;
                this.FinHora = model.bl._common.cache.WorkingHourEnd;
                this.FinMinuto = model.bl._common.cache.WorkingMinuteEnd;
                //System.Windows.Forms.MessageBox.Show(this.AutoSizeRowsMode= System.Windows.Forms.DataGridViewAutoSizeRowsMode.);
                this.Salto = model.bl._common.cache.WorkingScheduleStep;
                          
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
                    foreach (ambis1.model.vo.Cage cage in this.DataSourceColumns)
                    {
                        //if (cage.Activo)
                        //{
                            c = new System.Windows.Forms.DataGridViewTextBoxColumn();
                            c.HeaderText = cage.Description;
                            c.Name = "Cage" + cage.ID.ToString();
                            c.Tag = cage;
                            //c.CellTemplate.Style.BackColor = cage.DrawColor;
                            c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                            
                            this.Columns.Add(c);
                        //}
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
                    {
                        cl.Value = string.Empty;
                        if ((this.IsHoliday) && (r.Cells["horaIzq"].ColumnIndex != cl.ColumnIndex) && (r.Cells["horaDcha"].ColumnIndex != cl.ColumnIndex)) 
                            cl.Style.BackColor = model.vo.Holiday.DrawColor;
                    }

                    r.Cells["horaIzq"].Value = fechaTmp.ToString("HH:mm");
                    r.Cells["horaIzq"].Tag = fechaTmp;
                    r.Cells["horaDcha"].Value = fechaTmp.ToString("HH:mm");
                    r.Cells["horaDcha"].Tag = fechaTmp;
                }

                if (this.DataSourceReservations != null)
                {
                    foreach (ambis1.model.vo.Reservation reservation in this.DataSourceReservations)
                        setReservationIntoGrid(reservation);
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

        private void setReservationIntoGrid(ambis1.model.vo.Reservation reservation)
        {
            try
            {
                int column = int.MinValue;
                foreach (System.Windows.Forms.DataGridViewColumn c in this.Columns)
                {
                    if ((c.Tag != null) && (reservation.Cage!=null) && (((ambis1.model.vo.Cage)c.Tag).ID == reservation.Cage.ID))
                    {
                        column = c.Index;
                        break;
                    }
                }
                if (column != int.MinValue)
                {
                    int minutos = reservation.DateAndTime.Hour * 60 + reservation.DateAndTime.Minute;
                    minutos -= this.InicioHora * 60 + this.InicioMinuto;
                    int row = minutos / this.Salto;

                    if ((row > -1) && (row <= (this.FinHora * 60 + this.FinMinuto - this.InicioHora * 60 - this.InicioMinuto) / this.Salto))
                    {
                        int celdas = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(reservation.Duration.Hour*60 + reservation.Duration.Minute) / Convert.ToDouble(this.Salto)));
                        if (celdas > 0)
                        {
                            if (celdas == 1)
                            {
                                this[column, row].Value = reservation.Member.ToString();
                                this[column, row].Style.BackColor = reservation.DrawColor;//reservation.Cage.DrawColor;
                                this[column, row].Tag = reservation;
                            }
                            else
                            {
                                //TODO: Agenda - Hay que darle formato a las celdas
                                this[column, row].Value = reservation.Member.ToString();
                                //this[column, row].Style.ForeColor = reservation.DrawColor; //??
                                this[column, row].Style.BackColor = reservation.DrawColor; //??
                                this[column, row].Tag = reservation;

                                //if (row + 1 < this.Rows.Count)
                                //{
                                //    row += 1;
                                //    this[column, row].Value = reservation.Member.ToString();
                                //    this[column, row].Style.BackColor = reservation.DrawColor;//reservation.Cage.DrawColor;
                                //    this[column, row].Tag = reservation;
                                //}

                                for (int i = 1; i < celdas; i++)
                                {
                                    if (row + 1 < this.Rows.Count)
                                    {
                                        row += 1;
                                        this[column, row].Value = string.Empty;// i.ToString();
                                        this[column, row].Style.BackColor = reservation.DrawColor; //reservation.Cage.DrawColor;
                                        this[column, row].Tag = reservation;
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
            this.tsbMenuReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbNuevaReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbModificarReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopiarPortapapelesReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPegarPortapapelesReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbProgramarReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCambiarCage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBorrarReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMenuVerTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.labNotas = new System.Windows.Forms.Label();
            this.cmenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmenuOpciones
            // 
            this.cmenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMenuReservations,
            this.toolStripSeparator9,
            this.tsbMenuVerTeam});
            this.cmenuOpciones.Name = "cmenuOpciones";
            this.cmenuOpciones.Size = new System.Drawing.Size(164, 54);
            this.cmenuOpciones.Opening += new System.ComponentModel.CancelEventHandler(this.cmenuOpciones_Opening);
            // 
            // tsbMenuReservations
            // 
            this.tsbMenuReservations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevaReservation,
            this.tsbModificarReservation,
            this.toolStripSeparator5,
            this.tsbCopiarPortapapelesReservation,
            this.tsbPegarPortapapelesReservation,
            this.toolStripSeparator7,
            this.tsbProgramarReservations,
            this.toolStripSeparator1,
            this.tsbCambiarCage,
            this.toolStripSeparator2,
            this.tsbBorrarReservation});
            this.tsbMenuReservations.Name = "tsbMenuReservations";
            this.tsbMenuReservations.Size = new System.Drawing.Size(163, 22);
            this.tsbMenuReservations.Text = "Reservations";
            // 
            // tsbNuevaReservation
            // 
            this.tsbNuevaReservation.Name = "tsbNuevaReservation";
            this.tsbNuevaReservation.Size = new System.Drawing.Size(222, 22);
            this.tsbNuevaReservation.Text = "New Reservation";
            // 
            // tsbModificarReservation
            // 
            this.tsbModificarReservation.Name = "tsbModificarReservation";
            this.tsbModificarReservation.Size = new System.Drawing.Size(222, 22);
            this.tsbModificarReservation.Text = "Modify Reservation";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbCopiarPortapapelesReservation
            // 
            this.tsbCopiarPortapapelesReservation.Name = "tsbCopiarPortapapelesReservation";
            this.tsbCopiarPortapapelesReservation.Size = new System.Drawing.Size(222, 22);
            this.tsbCopiarPortapapelesReservation.Text = "Copiar al portapapeles";
            this.tsbCopiarPortapapelesReservation.Visible = false;
            // 
            // tsbPegarPortapapelesReservation
            // 
            this.tsbPegarPortapapelesReservation.Name = "tsbPegarPortapapelesReservation";
            this.tsbPegarPortapapelesReservation.Size = new System.Drawing.Size(222, 22);
            this.tsbPegarPortapapelesReservation.Text = "Pegar desde el portapapeles";
            this.tsbPegarPortapapelesReservation.Visible = false;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(219, 6);
            this.toolStripSeparator7.Visible = false;
            // 
            // tsbProgramarReservations
            // 
            this.tsbProgramarReservations.Name = "tsbProgramarReservations";
            this.tsbProgramarReservations.Size = new System.Drawing.Size(222, 22);
            this.tsbProgramarReservations.Text = "Programar reservations";
            this.tsbProgramarReservations.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // tsbCambiarCage
            // 
            this.tsbCambiarCage.Name = "tsbCambiarCage";
            this.tsbCambiarCage.Size = new System.Drawing.Size(222, 22);
            this.tsbCambiarCage.Text = "Move to";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // tsbBorrarReservation
            // 
            this.tsbBorrarReservation.Name = "tsbBorrarReservation";
            this.tsbBorrarReservation.Size = new System.Drawing.Size(222, 22);
            this.tsbBorrarReservation.Text = "Delete Reservation";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(160, 6);
            // 
            // tsbMenuVerTeam
            // 
            this.tsbMenuVerTeam.Name = "tsbMenuVerTeam";
            this.tsbMenuVerTeam.Size = new System.Drawing.Size(163, 22);
            this.tsbMenuVerTeam.Text = "See Membership";
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
            this.RowTemplate.Height = 44;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Agenda_MouseDown);
            this.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Agenda_CellDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Agenda_MouseMove);
            this.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Agenda_CellClick);
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
                if ((e.ColumnIndex!=-1) && (e.RowIndex!=-1))
                {
                    if (this.ReservationSeleccionada != null)
                        this.tsbModificarReservation_Click(null, null);
                    else if (this.ReservationSeleccionada == null)
                        this.tsbNuevaReservation_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        bool _isHoliday = false;

        public bool IsHoliday
        {
            get { return _isHoliday; }
        }

        public void RefreshData_II()
        {
            try
            {
                //TODO: ??
                //model.bl.reservation.doGetAll lnReservation = new ambis1.model.bl.reservation.doGetAll(new ambis1.model.vo.filtro.FiltroReservation(null, null, this.Fecha));
                //this.DataSourceReservations = lnReservation.execute();

                model.bl.reservation.doGetAll lnReservation = new ambis1.model.bl.reservation.doGetAll(this.Fecha);
                this.DataSourceReservations = lnReservation.execute();

                model.bl.holiday.doIsHoliday doIsHoliday = new ambis1.model.bl.holiday.doIsHoliday(new ambis1.model.vo.Holiday(this.Fecha));
                _isHoliday = doIsHoliday.execute();

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
                this.tsbMenuReservations.Enabled = this.isCeldaValida() && (((this.ReservationSeleccionada == null)) || (this.ReservationSeleccionada!=null));
                this.tsbMenuVerTeam.Enabled = this.tsbMenuReservations.Enabled;

                this.tsbCopiarPortapapelesReservation.Enabled = (this.ReservationSeleccionada != null);
                this.tsbPegarPortapapelesReservation.Enabled = this.isCeldaValida() && (this.ReservationSeleccionada == null);
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

                //    if (cell.Tag is ambis1.model.vo.Reservation)
                //    {
                //        ambis1.model.vo.Reservation reservation = (ambis1.model.vo.Reservation)cell.Tag;
                //        //if (!string.IsNullOrEmpty(reservation.Notas))
                //        if (!string.IsNullOrEmpty(reservation.Team.NotasAgenda))
                //        {
                //            labNotas.Text = "Notas: " + Environment.NewLine + reservation.Team.NotasAgenda;
                //            System.Drawing.Point locationApp = e.Location;
                //            labNotas.Location = new System.Drawing.Point(locationApp.X, locationApp.Y - labNotas.Height - 4);
                //            labNotas.Visible = true;

                //            this.Invalidate();
                //            this.Refresh();
                //            labNotas.Invalidate();
                //            labNotas.Refresh();
                //        }
                //    }
                //    else if (cell.Tag is ambis1.model.vo.Evento)
                //    {
                //        ambis1.model.vo.Evento evento = (ambis1.model.vo.Evento)cell.Tag;

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
                        if (this.ReservationSeleccionada != null)
                            this.tsbCopiarPortapapelesReservation_Click(null, null);
                    }
                }
                else if (e.Control && e.KeyCode == System.Windows.Forms.Keys.V)
                {
                    if (isCeldaValida())
                    {
                        if ((this.ReservationSeleccionada == null) && (_portapapelesObject!=null))
                        {
                            if (this.portapapelesIsReservation())
                                this.tsbPegarPortapapelesReservation_Click(null, null);
                        }
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Agenda_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex != -1) && ((this.Columns[e.ColumnIndex] == this.Columns["horaIzq"]) || ((this.Columns[e.ColumnIndex] == this.Columns["horaDcha"]))))
                    this.Rows[e.RowIndex].Selected = true;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
