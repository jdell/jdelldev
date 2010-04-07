using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.frm.consulta
{
    public class QueryForm:repsol.forms.template.consulta.QueryForm
    {
        private System.Windows.Forms.Label labError;
    
        public QueryForm():base()
        {
            InitializeComponent();

            this.RememberUserPreferences = true;
            this.tbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;

            this.btImprimir.Visible = true;
            this.chkVerFiltro.Visible = false;
            this.btFiltrar.Enabled = false;
            this.ShowIcon = false;
            this.dgConsulta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(dgConsulta_MouseDoubleClick);
        }
        public QueryForm(bool soloconsulta):base(soloconsulta)
        {
            InitializeComponent();
            
            this.RememberUserPreferences = true;
            this.tbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;

            this.btImprimir.Visible = false;
            this.chkVerFiltro.Visible = false;
            this.btFiltrar.Enabled = false;
            this.ShowIcon = false;
            this.dgConsulta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(dgConsulta_MouseDoubleClick);
        }

        void dgConsulta_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Windows.Forms.DataGridView.HitTestInfo hit = this.dgConsulta.HitTest(e.X, e.Y);
            if ((hit.ColumnIndex != -1) && (hit.RowIndex != -1))
            {
                if (!this.Modal)
                {
                    if (this.OnlyView)
                        this.btConsulta_record();
                    else
                        this.btModificar_record();
                }
                else
                    this.btSeleccionar_record();
            }
        }

        public System.Windows.Forms.ToolStripButton menuFiltrar
        {
            get
            {
                return this.btFiltrar;
            }
        }
        protected override void btFiltrar_record()
        {
            this.chkVerFiltro.Checked = !this.chkVerFiltro.Checked;
        }
        protected override void btImprimir_record()
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                repsol.forms.DynamicReportViewer vVen = new repsol.forms.DynamicReportViewer(this.dgConsulta);
                vVen.Text = this.Text;
                vVen.ShowSelectionColumns = false;
                vVen.RdlCompanyName = "Affinity Staffing";
                vVen.RdlCompanyUrlLogo = "file://" + System.IO.Path.GetFullPath(@"_template/_images/logo.png");
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
        protected override void btImprimirWithSelColumns_record()
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                repsol.forms.DynamicReportViewer vVen = new repsol.forms.DynamicReportViewer(this.dgConsulta);
                vVen.Text = this.Text;
                vVen.ShowSelectionColumns = true;
                vVen.RdlCompanyName = "Affinity Staffing";
                vVen.RdlCompanyUrlLogo = "file://" + System.IO.Path.GetFullPath(@"_template/_images/logo.png");
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }
        #region 20080707: Control error consulta

        public void setError(string msgError)
        {
            this.labError.Visible = !string.IsNullOrEmpty(msgError);
            this.labError.Text = msgError;
        }

        #endregion

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.labError = new System.Windows.Forms.Label();
            this.panDetail.SuspendLayout();
            this.panInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panDetail
            // 
            this.panDetail.Controls.Add(this.labError);
            this.panDetail.Controls.SetChildIndex(this.labError, 0);
            // 
            // panInfo
            // 
            this.panInfo.Location = new System.Drawing.Point(0, 127);
            // 
            // labNRegistros
            // 
            this.labNRegistros.Text = "0 Registros";
            // 
            // labError
            // 
            this.labError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(0, 359);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(792, 62);
            this.labError.TabIndex = 2;
            this.labError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueryForm
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryForm_FormClosing);
            this.Controls.SetChildIndex(this.panHead, 0);
            this.Controls.SetChildIndex(this.panInfo, 0);
            this.Controls.SetChildIndex(this.panDetail, 0);
            this.panDetail.ResumeLayout(false);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.RememberUserPreferences) 
                    loadUserPreferences();

                if (this.Modal)
                {
                    this.btNuevo.Visible = true;
                    this.btModificar.Visible = true;
                    this.btConsulta.Visible = true;

                    this.NuevoToolStripMenuItem.Visible = true;
                    this.ModificarToolStripMenuItem.Visible = true;
                    this.VerToolStripMenuItem.Visible = true;

                    this.DuplicarToolStripMenuItem.Visible = false;
                    this.ToolStripMenuItemSeparador.Visible = false;
                    this.BorrarToolStripMenuItem.Visible = false;
                    this.toolSeparadorBorrar.Visible = false;

                    this.dgConsulta.ContextMenuStrip = this.contextMenu2;
                }

                this.dgConsulta.MouseDown += new System.Windows.Forms.MouseEventHandler(dgConsulta_MouseDown);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        void dgConsulta_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
                System.Windows.Forms.DataGridView.HitTestInfo hitTest = dgv.HitTest(e.X, e.Y);
                if ((hitTest.RowIndex != -1) && (hitTest.ColumnIndex != -1))
                    dgv.CurrentCell = dgv[hitTest.ColumnIndex, hitTest.RowIndex];
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #region "UserPreferences"

        private bool _rememberUserPreferences;

        public new bool RememberUserPreferences
        {
          get { return _rememberUserPreferences; }
          set { _rememberUserPreferences = value; }
        }

        private static System.Collections.Generic.Dictionary<string, repsol.util.setting.userpreferences> _settings;
        private static string _USERPREFERENCES_FULL_PATH = System.IO.Path.GetFullPath(string.Format("{0}{1}{2}", System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), System.IO.Path.DirectorySeparatorChar.ToString(), String.Format("{0}{1}.dat", System.Windows.Forms.Application.ProductName, "UserPreferences")));

        public static new string USERPREFERENCES_FULL_PATH
        {
            get { return QueryForm._USERPREFERENCES_FULL_PATH; }
            set { QueryForm._USERPREFERENCES_FULL_PATH = value; }
        }

        private string GetFullPathUserPreferencesDat()
        {
            return USERPREFERENCES_FULL_PATH;
        }

        private void saveUserPreferences()
        {
            System.IO.FileStream fs = null;
            try
            {
                repsol.util.setting.userpreferences currentPreference = getUserPreferences();
                if (currentPreference != null)
                {
                    if (_settings == null) _settings = new Dictionary<string, repsol.util.setting.userpreferences>();
                    if (_settings.ContainsKey(this.GetType().FullName))
                        _settings[this.GetType().FullName] = currentPreference;
                    else
                        _settings.Add(this.GetType().FullName, currentPreference);

                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    string fileDatPath = GetFullPathUserPreferencesDat();
                    fs = new System.IO.FileStream(fileDatPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);

                    formatter.Serialize(fs, _settings);
                }
            }
            catch (Exception ex)
            {
                _common.messages.ShowError(ex);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void loadUserPreferences()
        {
            System.IO.FileStream fs = null;
            try
            {
                if (_settings != null)
                {
                    string fileDatPath = GetFullPathUserPreferencesDat();
                    if (System.IO.File.Exists(fileDatPath) && (System.IO.File.ReadAllBytes(fileDatPath).Length > 0))
                    {
                        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        fs = new System.IO.FileStream(fileDatPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);

                        _settings = ( Dictionary<string, repsol.util.setting.userpreferences>)formatter.Deserialize(fs);
                    }
                    if ((_settings!=null) && (_settings.ContainsKey(this.GetType().FullName)))
                        setUserPreferences(_settings[this.GetType().FullName]);
                }
            }
            catch (Exception ex)
            {
                _common.messages.ShowError(ex);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        #endregion

        private void QueryForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            try
            {
                if ((this.RememberUserPreferences) && (!this.IsDocked))
                    saveUserPreferences();
            }
            catch (Exception ex)
            {
                _common.messages.ShowError(ex);
            }
        }

        
    }
}
