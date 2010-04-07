using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Documento : IComparable<Documento>
    {
        private TipoDocumento _tipoDocumento;

        public TipoDocumento TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Byte[] _content;

        public Byte[] Content
        {
            get { return _content; }
            set { _content = value; }
        }
        private System.IO.FileInfo _info;

        public System.IO.FileInfo Info
        {
            get { return _info; }
            set { _info = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Documento()
        {
            this._content = null;
            this._descripcion = string.Empty;
            this._fecha = DateTime.Now;
            this._id = lib.common.constantes.vacio.ID;
            this._info = null;
            this._titulo = string.Empty;
        }


        #region Miembros de IComparable<Documento>

        public int CompareTo(Documento other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
