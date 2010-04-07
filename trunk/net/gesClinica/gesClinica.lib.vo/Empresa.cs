using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Empresa
    {
        public Empresa()
        {
            _id = common.constantes.vacio.ID;
            _razonSocial = string.Empty;

            _facturaCliente = string.Empty;
            _facturaConcepto = string.Empty;
            _facturaFormato = tFORMATOFACTURA.GENERICO;
            _facturaIva = 0;

            _direccion = string.Empty;
            _cif = string.Empty;
            _otrosDatos = string.Empty;
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _razonSocial;

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        private string _facturaConcepto;

        public string FacturaConcepto
        {
            get { return _facturaConcepto; }
            set { _facturaConcepto = value; }
        }

        private tFORMATOFACTURA _facturaFormato;

        public tFORMATOFACTURA FacturaFormato
        {
            get { return _facturaFormato; }
            set { _facturaFormato = value; }
        }
        private string _facturaCliente;

        public string FacturaCliente
        {
            get { return _facturaCliente; }
            set { _facturaCliente = value; }
        }
        private int _facturaIva;

        public int FacturaIva
        {
            get { return _facturaIva; }
            set { _facturaIva = value; }
        }

        private string _cif;

        public string CIF
        {
            get { return _cif; }
            set { _cif = value; }
        }
        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private string _otrosDatos;

        public string OtrosDatos
        {
            get { return _otrosDatos; }
            set { _otrosDatos = value; }
        }
        public static tFORMATOFACTURA FormatoFromName(string name)
        {
            return (tFORMATOFACTURA)System.Enum.Parse(typeof(tFORMATOFACTURA), name);
        }
        public static string NameFromFormato(tFORMATOFACTURA tipo)
        {
            return System.Enum.GetName(typeof(tFORMATOFACTURA), tipo);
        }
        public override string ToString()
        {
            return this.RazonSocial;
        }


        private bool _contabilizarFactura = true;

        public bool ContabilizarFactura
        {
            get { return _contabilizarFactura; }
            set { _contabilizarFactura = value; }
        }

    }
}
