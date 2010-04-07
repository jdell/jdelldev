using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita._sintoma.ctrl
{
    public class ctrlEditASintoma: template.frm.edicion.ctrl.EditCtrl
    {
        frmEditASintoma _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmEditASintoma)frm;

                _vista.tvSintomas.Nodes.Clear();

                lib.bl.tiposintoma.doGetAll lnTipoSintoma = new gesClinica.lib.bl.tiposintoma.doGetAll();
                List<lib.vo.TipoSintoma> listTipoSintoma = lnTipoSintoma.execute();
                listTipoSintoma.Sort(sortTipoSintoma);
                foreach (lib.vo.TipoSintoma tipoSintoma in listTipoSintoma)
                {
                    System.Windows.Forms.TreeNode parentNode = new System.Windows.Forms.TreeNode();
                    parentNode.Tag = tipoSintoma;
                    parentNode.Text = tipoSintoma.ToString();

                    lib.bl.sintoma.doGetAll lnSintomas = new gesClinica.lib.bl.sintoma.doGetAll(tipoSintoma);
                    List<lib.vo.Sintoma> listSintoma = lnSintomas.execute();
                    listSintoma.Sort(sortSintoma);
                    foreach (lib.vo.Sintoma sintoma in listSintoma)
                    {
                        System.Windows.Forms.TreeNode node = new System.Windows.Forms.TreeNode();
                        node.Tag = sintoma;
                        node.Text = sintoma.ToString();

                        parentNode.Nodes.Add(node);
                    }
                    _vista.tvSintomas.Nodes.Add(parentNode);
                }
            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }

        public void updateSintomas(ref frmEditASintoma frm)
        {
            try
            {
                _vista = (frmEditASintoma)frm;

                string temp = string.Empty;
                
                //if (string.IsNullOrEmpty(text) && (_v)) //= ctrl.getText(this.tvSintomas.Nodes);
                temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\r\n\r\n}\r\n\r\n" + "}";

                int pos = 10;
                if (!string.IsNullOrEmpty(this._vista.txtAcudePor.Text))
                {
                    temp = temp.Substring(0, temp.Length - pos);
                    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab} Acude por:\\ulnone\\b0\\par\r\n}\r\n" + "}";

                    temp = temp.Substring(0, temp.Length - 1);
                    temp += this._vista.txtAcudePor.Text + " \\par\\par}";

                    pos = 1;
                }

                string tmp = getText(_vista.tvSintomas.Nodes);
                if (!string.IsNullOrEmpty(tmp))
                {
                    temp = temp.Substring(0, temp.Length - pos);
                    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab} Síntomas:\\ulnone\\b0\\par\\par\r\n}\r\n" + "}";

                    temp = temp.Substring(0, temp.Length - 1);
                    temp += tmp + "}";
                }
                //if (!string.IsNullOrEmpty(this._vista.txtAcudePor.Text))
                //    text += @" \par {\b{\pntext\f1\'B7\tab} Acude por: \ulnone\b0\par} \par " + _vista.txtAcudePor.Text;

                //if (!string.IsNullOrEmpty(tmp))
                //    text += @" \par {\b Síntomas:} \par " + tmp;

                //_vista.txtSintomas.Text = !string.IsNullOrEmpty(this.txtAcudePor.Text) ? string.Format("Acude por: {0}{1}{0}", Environment.NewLine, this.txtAcudePor.Text) : this.txtAcudePor.Text;
                //_vista.txtSintomas.Text += !string.IsNullOrEmpty(text) ? string.Format("Síntomas : {0}{1}", Environment.NewLine, text) : text;

                //text += "}";

                _vista.txtSintomas.TextRTF = temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string getText(System.Windows.Forms.TreeNodeCollection nodes)
        {
            StringBuilder res = new StringBuilder();
            foreach (System.Windows.Forms.TreeNode tnode in nodes)
            {
                if (tnode.Checked)
                    res.AppendLine("\\b{\\pntext\\f1\\'B7\\tab} - " + tnode.Text + " \\b0.- \\par\\par");
                string tmp = getText(tnode.Nodes);
                if (!string.IsNullOrEmpty(tmp)) res.AppendLine(tmp);
            }
            return res.ToString();
        }
        private int sortTipoSintoma(lib.vo.TipoSintoma one, lib.vo.TipoSintoma other)
        {
            return one.Descripcion.CompareTo(other.Descripcion);
        }
        private int sortSintoma(lib.vo.Sintoma one, lib.vo.Sintoma other)
        {
            return one.Descripcion.CompareTo(other.Descripcion);
        }
    }
}
