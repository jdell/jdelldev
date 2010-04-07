using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.anexo.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Anexo objVO = null;
                if (newRecord)
                {
                    objVO = new Anexo();
                }
                else
                {
                    objVO = (Anexo)_vista.InnerVO;
                }

                Cita cita = (Cita)((gesClinica.app.pc.frm.cita.frmEditDatosClinicos)_vista.Owner).InnerVO;
                objVO.Cita = cita;

                System.IO.FileInfo fInfo = new System.IO.FileInfo(_vista.txtRuta.Text);
                System.IO.FileStream fs = fInfo.OpenRead();
                Byte[] rb = new byte[fs.Length];
                fs.Read(rb, 0, Convert.ToInt32(fs.Length));
                objVO.Content = rb;
                fs.Close();

                objVO.Info = fInfo;
                if (!String.IsNullOrEmpty(_vista.txtTitulo.Text))
                    objVO.Titulo = _vista.txtTitulo.Text;
                else
                    objVO.Titulo = fInfo.Name;

                objVO.Descripcion = _vista.txtDescripcion.Text;

                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEdit)frm;
                Anexo objVO = (Anexo)obj;

                _vista.InnerVO = objVO;

                _vista.txtTitulo.Text = objVO.Titulo;
                if (objVO.Info != null)
                    _vista.txtRuta.Text = objVO.Info.FullName;
                _vista.txtDescripcion.Text = objVO.Descripcion;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEdit)frm;
                Anexo objVO = (Anexo)getObject(ref frm, newRecord);

                Cita cita = (Cita)((gesClinica.app.pc.frm.cita.frmEditDatosClinicos)_vista.Owner).InnerVO;
                cita.Anexo.Sort();
                int index = cita.Anexo.IndexOf(objVO);
                if (index > -1)
                    cita.Anexo[index] = objVO;
                else
                    cita.Anexo.Add(objVO);

                ((gesClinica.app.pc.frm.cita.frmEditDatosClinicos)_vista.Owner).InnerVO = cita;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void verAnexo(frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                gesClinica.lib.vo.Anexo objVO = null;
                if (_vista.IsNewRecord)
                {
                    objVO = new Anexo();
                    if (!string.IsNullOrEmpty(_vista.txtRuta.Text))
                    {
                        System.IO.FileInfo fInfo = new System.IO.FileInfo(_vista.txtRuta.Text);
                        System.IO.FileStream fs = fInfo.OpenRead();
                        Byte[] rb = new byte[fs.Length];
                        fs.Read(rb, 0, Convert.ToInt32(fs.Length));
                        objVO.Content = rb;
                        fs.Close();

                        objVO.Info = fInfo;
                    }
                }
                else
                {
                    objVO = (lib.vo.Anexo)_vista.InnerVO;
                }

                if ((objVO.Info != null) && (objVO.Content != null))
                {
                    System.IO.FileStream file = new System.IO.FileStream(System.IO.Path.GetTempFileName().Replace(".tmp", "") + objVO.Info.Extension, System.IO.FileMode.Create);
                    file.Write(objVO.Content, 0, objVO.Content.Length);
                    file.Close();
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc = System.Diagnostics.Process.Start(file.Name);
                    proc.Close();
                }

            }
            catch (Exception ex)
            {   
                throw ex;
            }
        }


        public void guardarAnexo(frmEdit frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                gesClinica.lib.vo.Anexo objVO = null;
                if (_vista.IsNewRecord)
                {
                    objVO = new Anexo();
                    if (!string.IsNullOrEmpty(_vista.txtRuta.Text))
                    {
                        System.IO.FileInfo fInfo = new System.IO.FileInfo(_vista.txtRuta.Text);
                        System.IO.FileStream fs = fInfo.OpenRead();
                        Byte[] rb = new byte[fs.Length];
                        fs.Read(rb, 0, Convert.ToInt32(fs.Length));
                        objVO.Content = rb;
                        fs.Close();

                        objVO.Info = fInfo;
                    }
                }
                else
                {
                    objVO = (lib.vo.Anexo)_vista.InnerVO;
                }

                if ((objVO.Info != null) && (objVO.Content != null))
                {
                    System.Windows.Forms.SaveFileDialog fSave = new System.Windows.Forms.SaveFileDialog();
                    fSave.RestoreDirectory = true;
                    fSave.FileName = objVO.Info.Name;
                    fSave.Filter = string.Format("Archivos {0}|{0}", objVO.Info.Extension);
                    if (fSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        System.IO.FileStream file = new System.IO.FileStream(string.Format("{0}.{1}", fSave.FileName, objVO.Info.Extension), System.IO.FileMode.Create);
                        file.Write(objVO.Content, 0, objVO.Content.Length);
                        file.Close();
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc = System.Diagnostics.Process.Start(file.Name);
                        proc.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
