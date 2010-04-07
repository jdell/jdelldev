using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.reservation
{
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateChanged(object sender, EventArgs e)
        {
            try
            {
               this.DateChanged();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        public void DateChanged()
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                
                this.agenda.Focus();

                this.labFecha.Text = this.monthCalendar.Date.ToLongDateString();

                //model.bl.cita.doGetAll lnCita = new ambis1.model.bl.cita.doGetAll(new ambis1.model.vo.filtro.FiltroCita(null, null, this.monthCalendar.Date));
                //this.agenda.DataSourceCitas = lnCita.execute();

                model.bl.reservation.doGetAll doGetAll = new ambis1.model.bl.reservation.doGetAll(this.monthCalendar.Date);
                this.agenda.DataSourceReservations = doGetAll.execute();

                this.agenda.Fecha = this.monthCalendar.Date;
                this.agenda.Load();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true;
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            try
            {            
                this.monthCalendar.Date = DateTime.Now;

                //********************* Holidays *********************
                model.bl.holiday.doGetAll lnHoliday = new ambis1.model.bl.holiday.doGetAll();
                List<model.vo.Holiday> listHoliday = lnHoliday.execute();
                foreach (model.vo.Holiday holiday in listHoliday)
                    this.monthCalendar.Festivos.Add(holiday.Date, model.vo.Holiday.DrawColor);


                // ********************* Cage *********************
                ambis1.model.bl.cage.doGetAll lnCage = new ambis1.model.bl.cage.doGetAll();
                this.agenda.DataSourceColumns = lnCage.execute();

                this.DateChanged();
                this.monthCalendar.Date = DateTime.Now;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void monthCalendar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ambis1.model.bl.holiday.doSetUnset doSetUnset = new ambis1.model.bl.holiday.doSetUnset(new ambis1.model.vo.Holiday(monthCalendar.Date));
                doSetUnset.execute();
                if (!this.monthCalendar.Festivos.ContainsKey(this.monthCalendar.Date))
                    this.monthCalendar.Festivos.Add(this.monthCalendar.Date, model.vo.Holiday.DrawColor);
                else
                    this.monthCalendar.Festivos.Remove(this.monthCalendar.Date);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void agenda_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }



    }
}
