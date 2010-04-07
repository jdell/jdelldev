using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Documento : IOldGesClinica<vo.Documento>
    {
        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private TipoDocumento _tipoDocumento;

        public TipoDocumento TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private Byte[] _content;

        public Byte[] Content
        {
            get { return _content; }
            set { _content = value; }
        }

        #region Miembros de IOldGesClinica<Documento>

        public gesClinica.lib.vo.Documento ToNewGesClinica()
        {
            vo.Documento res = new gesClinica.lib.vo.Documento();

            res.Descripcion = this.Descripcion;
            res.Fecha = this.Fecha;
            res.TipoDocumento = this.TipoDocumento.ToNewGesClinica();
            res.Titulo = this.Descripcion;

            if (this.Content != null)
            {
                System.IO.FileStream file = new System.IO.FileStream(System.IO.Path.GetTempFileName().Replace(".tmp", ".doc"), System.IO.FileMode.Create);
                int offset = 78;
                file.Write(this.Content, offset, this.Content.Length - offset);
                file.Close();

                System.IO.FileInfo fInfo = new System.IO.FileInfo(file.Name);
                //System.IO.FileStream fs = fInfo.OpenRead();
                
                //System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                //byte[] rb = new byte[fs.Length - offset];
                //br.Read(rb, offset, (int)fs.Length - offset); 
                //br.Close();
                //fs.Close();
                //res.Content = rb;

                //Byte[] rb = new byte[fs.Length];
                //fs.Read(rb, 0, Convert.ToInt32(fs.Length));
                //res.Content = rb;
                //fs.Close();

                res.Info = fInfo;
                res.Content = this.Content;
            }


            return res;
        }

        #endregion
    }
}
