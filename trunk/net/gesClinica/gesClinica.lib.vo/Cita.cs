using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Cita
    {

        private Int32 _id;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private Sala _sala;

        public Sala Sala
        {
            get { return _sala; }
            set { _sala = value; }
        }
        private Terapia _terapia;

        public Terapia Terapia
        {
            get { return _terapia; }
            set { _terapia = value; }
        }
        private Paciente _paciente;

        public Paciente Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }
        private Empleado _empleado;

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        private EstadoCita _estadocita;

        public EstadoCita EstadoCita
        {
            get { return _estadocita; }
            set { _estadocita = value; }
        }

        private Int32 _duracion;

        public Int32 Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        public Cita()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _fecha = DateTime.Now;
            _sala = null;
            _terapia = null;
            _paciente = null;
            _empleado = null;
            _estadocita = null;
            _duracion = 0;

            _sintomas = string.Empty;
            _diagnostico = string.Empty;
            _tratamiento = string.Empty;

            _presencial = true;
            _notas = string.Empty;

            _programada = false;
            _facturada = false;

            _anexo = new List<Anexo>();
            _receta = new List<Receta>();
        }

        public Cita(Paciente paciente)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _fecha = DateTime.Now;
            _sala = null;
            _terapia = null;
            _paciente = paciente;
            _empleado = null;
            _estadocita = null;
            _duracion = 0;

            _sintomas = string.Empty;
            _diagnostico = string.Empty;
            _tratamiento = string.Empty;

            _presencial = true;
            _notas = string.Empty;

            _programada = false;
            _facturada = false;

            _anexo = new List<Anexo>();
            _receta = new List<Receta>();
        }

        private bool _presencial;

        public bool Presencial
        {
            get { return _presencial; }
            set { _presencial = value; }
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            if (this.Paciente != null) 
            {
                strB.Append(string.Format("{0}", this.Paciente.ToString()));
                strB.Append(" - ");
            }
            if (this.Terapia != null) strB.Append(string.Format("{0}", this.Terapia.ToString()));

            return strB.ToString();
        }

        private List<Anexo> _anexo;

        public List<Anexo> Anexo
        {
            get { return _anexo; }
            set { _anexo = value; }
        }

        private List<Receta> _receta;

        public List<Receta> Receta
        {
            get { return _receta; }
            set { _receta = value; }
        }

        private string _sintomas;

        public string Sintomas
        {
            get { return _sintomas; }
            set { _sintomas = value; }
        }
        private string _diagnostico;

        public string Diagnostico
        {
            get { return _diagnostico; }
            set { _diagnostico = value; }
        }
        private string _tratamiento;

        public string Tratamiento
        {
            get { return _tratamiento; }
            set { _tratamiento = value; }
        }

        private string _notas;

        public string Notas
        {
            get { return _notas; }
            set { _notas = value; }
        }

        private bool _programada;

        public bool Programada
        {
            get { return _programada; }
            set { _programada = value; }
        }

        private bool _facturada;

        public bool Facturada
        {
            get { return _facturada; }
            set { _facturada = value; }
        }



        public string Resumen
        {
            get
            {
                string res = string.Empty;
                string temp;

                //temp = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Síntomas\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n";
                string info = string.Format("********** {0}. ({1}). {2} **********", this.Fecha.ToString("dd/MM/yyyy"), this.Empleado.ToString(), !this.Presencial ? "Llamada telefónica" : "");
                temp = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\b{\\pntext\\f1\\'B7\\tab}" + info + "\\ulnone\\b0\\par\r\n}\r\n\r\n" + "}";

                if (!string.IsNullOrEmpty(this.Sintomas))
                {
                    temp = temp.Substring(0, temp.Length - 10);
                    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Síntomas\\ulnone\\b0\\par\r\n}\r\n" + "}";

                    temp = temp.Substring(0, temp.Length - 1);
                    temp += this.Sintomas + "}";
                }

                if (!string.IsNullOrEmpty(this.Diagnostico))
                {
                    temp = temp.Substring(0, temp.Length - 10);
                    //temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Diagnóstico\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n" +"}";
                    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Diagnóstico\\ulnone\\b0\\par\r\n}\r\n" + "}";

                    temp = temp.Substring(0, temp.Length - 1);
                    temp += this.Diagnostico + "}";
                }

                if (!string.IsNullOrEmpty(this.Tratamiento))
                {
                    temp = temp.Substring(0, temp.Length - 10);
                    //temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Tratamiento\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n" + "}";
                    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Tratamiento\\ulnone\\b0\\par\r\n}\r\n" + "}";

                    temp = temp.Substring(0, temp.Length - 1);
                    temp += this.Tratamiento + "}";
                }

                if (!string.IsNullOrEmpty(this.Prescrito))
                {
                    temp = temp.Substring(0, temp.Length - 10);
                    //temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Prescrito\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n" + "}";
                    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Prescrito\\ulnone\\b0\\par\r\n}\r\n" + "}";

                    temp = temp.Substring(0, temp.Length - 1);
                    temp += this.Prescrito + "}";
                }
                res = temp;

                return res;
            }
        }

        public string Prescrito
        {
            get
            {
                StringBuilder strB = new StringBuilder();

                if ((Receta != null) && (Receta.Count>0))
                {
                    foreach (Receta receta in this.Receta)
                        strB.AppendLine(receta.Prescrito);
                    return strB.ToString();
                }
                else
                    return string.Empty;

            }
        }

        public Cita GetCopy()
        {
            Cita res = new Cita();

            res.Duracion = this.Duracion;
            res.Empleado = this.Empleado;
            res.Fecha = this.Fecha;
            res.Notas = this.Notas;
            res.Paciente = this.Paciente;
            res.Presencial = this.Presencial;
            res.Sala = this.Sala;
            res.Terapia = this.Terapia;

            return res;
        }

        public System.Drawing.Color DrawColor
        {
            get
            {
                if (
                    (this.Terapia.TipoTerapia.Codigo == gesClinica.lib.vo.tTIPOTERAPIA.LLAMADA_TELEFONICA)
                    ||
                    (this.Terapia.TipoTerapia.Codigo == gesClinica.lib.vo.tTIPOTERAPIA.MC)
                    ||
                    (this.Terapia.TipoTerapia.Codigo == gesClinica.lib.vo.tTIPOTERAPIA.VISITADOR)
                    )
                    return this.Terapia.TipoTerapia.DrawColor;
                else
                    return this.Sala.DrawColor;
            }
        }
    }
}
