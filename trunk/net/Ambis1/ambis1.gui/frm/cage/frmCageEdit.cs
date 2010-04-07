using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ambis1.gui.pc.frm.cage
{
    public partial class frmCageEdit : Form
    {
        model.vo.Cage _innerVO = null;

        public frmCageEdit()
        {
            InitializeComponent();
        }
        public frmCageEdit(model.vo.Cage innerVO)
        {
            InitializeComponent();

            this._innerVO = innerVO;
        }

        private void frmCageEdit_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            try
            {
                saveData();
                MessageBox.Show(_common.constants.messages.RECORD_SAVED);
                this.Close();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void loadData()
        {
            if (_innerVO != null)
            {
                this.txtDescription.Text = _innerVO.Description;
            }
        }
        private void saveData()
        {
            model.vo.Cage tmpVO = new ambis1.model.vo.Cage();
            tmpVO.Description = txtDescription.Text;

            if (_innerVO != null)
            {
                tmpVO.ID = _innerVO.ID;

                model.bl.cage.doUpdate doAction = new ambis1.model.bl.cage.doUpdate(tmpVO);
                doAction.execute();
            }
            else
            {
                model.bl.cage.doAdd doAction = new ambis1.model.bl.cage.doAdd(tmpVO);
                doAction.execute();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
