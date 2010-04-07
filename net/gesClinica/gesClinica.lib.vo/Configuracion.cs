using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Configuracion:IComparable<Configuracion>  
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _clase;
        public string Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }

        private string _clave;
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        private Configuracion _parent;
        public Configuracion Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        private List<Configuracion> _childs;

        public List<Configuracion> Childs
        {
            get { return _childs; }
            set { _childs = value; }
        }

        public Configuracion()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _clase = string.Empty;
            _clave = string.Empty;
            _parent = null;

            _childs = new List<Configuracion>();
        }
        public Configuracion(Empleado empleado)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _clase = typeof(lib.vo.Empleado).FullName;
            _clave = empleado.ID.ToString();
            _parent = null;

            _childs = new List<Configuracion>();
        }
        public Configuracion(Terapia terapia)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _clase = typeof(lib.vo.Terapia).FullName;
            _clave = terapia.ID.ToString();
            _parent = null;

            _childs = new List<Configuracion>();
        }
        public Configuracion(FormaPago formaPago)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _clase = typeof(lib.vo.FormaPago).FullName;
            _clave = formaPago.ID.ToString();
            _parent = null;

            _childs = new List<Configuracion>();
        }
        public Configuracion(EstadoCita estadoCita)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _clase = typeof(lib.vo.EstadoCita).FullName;
            _clave = estadoCita.ID.ToString();
            _parent = null;

            _childs = new List<Configuracion>();
        }
        public Configuracion(Empresa empresa)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _clase = typeof(lib.vo.Empresa).FullName;
            _clave = empresa.ID.ToString();
            _parent = null;

            _childs = new List<Configuracion>();
        }
        public Configuracion(Sala sala)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _clase = typeof(lib.vo.Sala).FullName;
            _clave = sala.ID.ToString();
            _parent = null;

            _childs = new List<Configuracion>();
        }

        public override string ToString()
        {
            return this.Clase;
        }

        public Type GetTypeOfClass()
        {
            return System.Type.GetType(this.Clase);
        }

        public bool IsTerapia()
        {
            return typeof(lib.vo.Terapia).FullName.CompareTo(this.Clase)==0;
        }

        public bool IsEmpleado()
        {
            return typeof(lib.vo.Empleado).FullName.CompareTo(this.Clase) == 0;
        }

        public bool IsFormaPago()
        {
            return typeof(lib.vo.FormaPago).FullName.CompareTo(this.Clase) == 0;
        }

        public bool IsEstadoCita()
        {
            return typeof(lib.vo.EstadoCita).FullName.CompareTo(this.Clase) == 0;
        }
        public bool IsEmpresa()
        {
            return typeof(lib.vo.Empresa).FullName.CompareTo(this.Clase) == 0;
        }

        public bool IsSala()
        {
            return typeof(lib.vo.Sala).FullName.CompareTo(this.Clase) == 0;
        }

        #region Miembros de IComparable<Configuracion>

        public int CompareTo(Configuracion other)
        {
            return this.Clase.CompareTo(other.Clase);
        }

        #endregion
    }
}
