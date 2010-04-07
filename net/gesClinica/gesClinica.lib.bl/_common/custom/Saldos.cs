using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.custom
{
    internal class Saldos
    {

        public Saldos()
        {
            ClearData();
        }
        public void ClearData()
        {
            //this.Acreedores = 0;
            this.AnticipoAZETA = 0;
            this.AnticipoCeliaGodon = 0;
            this.BancoPastor = 0;
            this.CaixaGalicia = 0;
            this.Caja = 0;
            //this.Tesoreria = 0;
        }
        public void SetData(List<vo.Apunte> apuntes)
        {
            ClearData();
            if (apuntes != null)
            {
                foreach (vo.Apunte apunte in apuntes)
                {
                    //CaixaGalicia
                    if (apunte.SubCuenta.Codigo.StartsWith("57000"))
                        this.Caja += apunte.Saldo;
                    //BancoPastor
                    else if (apunte.SubCuenta.Codigo.StartsWith("57203"))
                        this.BancoPastor += apunte.Saldo;
                    //CaixaGalicia
                    else if (apunte.SubCuenta.Codigo.StartsWith("57202"))
                        this.CaixaGalicia += apunte.Saldo;
                    //AnticipoCeliaGodon
                    else if (apunte.SubCuenta.Codigo.StartsWith("41110"))
                        this.AnticipoCeliaGodon += apunte.Saldo;
                    //AnticipoAZETA
                    else if (apunte.SubCuenta.Codigo.StartsWith("41050"))
                        this.AnticipoAZETA += apunte.Saldo;
                    //Resto
                    else if (apunte.SubCuenta.Codigo.StartsWith("41"))
                        this.Resto += apunte.Saldo;                                  
                }
            }
        }

        private double _caja;

        public double Caja
        {
            get { return _caja; }
            set { _caja = value; }
        }
        private double _bancoPastor;

        public double BancoPastor
        {
            get { return _bancoPastor; }
            set { _bancoPastor = value; }
        }
        private double _caixaGalicia;

        public double CaixaGalicia
        {
            get { return _caixaGalicia; }
            set { _caixaGalicia = value; }
        }

        private double _anticipoCeliaGodon;

        public double AnticipoCeliaGodon
        {
            get { return _anticipoCeliaGodon; }
            set { _anticipoCeliaGodon = value; }
        }
        private double _anticipoAZETA;

        public double AnticipoAZETA
        {
            get { return _anticipoAZETA; }
            set { _anticipoAZETA = value; }
        }

        private double _resto;

        public double Resto
        {
            get { return _resto; }
            set { _resto = value; }
        }

        public double Tesoreria
        {
            get
            {
                return 
                    this.Caja 
                  + this.CaixaGalicia 
                  + this.BancoPastor;
            }
        }
        public double Acreedores
        {
            get
            {
                return
                    this.AnticipoAZETA
                  + this.AnticipoCeliaGodon
                  + this.Resto;     
            }
        }
    }
}
