using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.frm._importacion.ctrl
{
    class ctrlImportacion:template.frm.BaseCtrl
    {
        private frmImportacion _vista = null;
        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmImportacion)frm;

                loadRazonSocial(ref _vista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void loadRazonSocial(ref frmImportacion frm)
        {
            try
            {
                _vista = (frmImportacion)frm;

                lib.bl.empresa.doGetAll lnEmpresa = new asr.lib.bl.empresa.doGetAll();
                _vista.cmbRazonSocial.DataSource = lnEmpresa.execute();
                _vista.cmbRazonSocial.DisplayMember = "RazonSocial";
                _vista.cmbRazonSocial.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eraseALL(ref repsol.forms.template.BaseForm frm, bool primeraParte)
        {
            try
            {
                _vista = (frmImportacion)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                lib.bl._importacion.doEraseALL lnImportacion = new asr.lib.bl._importacion.doEraseALL(primeraParte);
                lnImportacion.Processing += new asr.lib.bl._template.actionBL.ProcessingHandler(lnImportacionParte_Processing);
                bool res = lnImportacion.execute();
                if (res)
                    loadRazonSocial(ref _vista);

                template._common.messages.ShowWarning("Operación completada", _vista.Text);
            }
            catch (Exception ex)
            {
                _vista.labInfo.Text = "Operación cancelada";
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        public void eraseALLTerceros(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmImportacion)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                lib.bl._importacion.doEraseALLTerceros lnImportacion = new asr.lib.bl._importacion.doEraseALLTerceros();
                lnImportacion.Processing += new asr.lib.bl._template.actionBL.ProcessingHandler(lnImportacionParte_Processing);
                bool res = lnImportacion.execute();

                template._common.messages.ShowWarning("Operación completada", _vista.Text);
            }
            catch (Exception ex)
            {
                _vista.labInfo.Text = "Operación cancelada";
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        public void importarParte1(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmImportacion)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                lib.bl._importacion.doImportarParte1 lnImportacionParte = new asr.lib.bl._importacion.doImportarParte1();
                lnImportacionParte.Processing += new asr.lib.bl._template.actionBL.ProcessingHandler(lnImportacionParte_Processing);
                bool res = lnImportacionParte.execute();
                if (res)
                    loadRazonSocial(ref _vista);
                template._common.messages.ShowWarning("Operación completada", _vista.Text);
            }
            catch (Exception ex)
            {
                _vista.labInfo.Text += "Operación cancelada";
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        public void importarParte2(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmImportacion)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                lib.bl._importacion.doImportarParte2 lnImportacionParte = new asr.lib.bl._importacion.doImportarParte2((lib.vo.Empresa)_vista.cmbRazonSocial.SelectedItem);
                lnImportacionParte.Processing += new asr.lib.bl._template.actionBL.ProcessingHandler(lnImportacionParte_Processing);
                bool res = lnImportacionParte.execute();
                if (res)
                    loadRazonSocial(ref _vista);
                template._common.messages.ShowWarning("Operación completada", _vista.Text);
            }
            catch (Exception ex)
            {
                _vista.labInfo.Text += "Operación cancelada";
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
        
        public void importarParte3(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmImportacion)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                lib.bl._importacion.doImportarParte3 lnImportacionParte = new asr.lib.bl._importacion.doImportarParte3();
                lnImportacionParte.Processing += new asr.lib.bl._template.actionBL.ProcessingHandler(lnImportacionParte_Processing);
                bool res = lnImportacionParte.execute();
                template._common.messages.ShowWarning("Operación completada", _vista.Text);
            }
            catch (Exception ex)
            {
                _vista.labInfo.Text += "Operación cancelada";
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        void lnImportacionParte_Processing(asr.lib.bl._events.ProgressEventArgs e)
        {
            try
            {
                _vista.labInfo.Text = string.Format("{0} [{1}/{2}]", e.InfoProcess, e.CurrentProcess, e.TotalProcess);
                _vista.pBar.Minimum = 0;
                _vista.pBar.Maximum = e.TotalProcess;
                _vista.pBar.Value = e.CurrentProcess;
                System.Windows.Forms.Application.DoEvents();
                _vista.Invalidate();
                _vista.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
