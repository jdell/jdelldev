using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._importacion
{
    public class doImportarParte1 : gesClinica.lib.bl._template.generalActionBL
    {
        new public bool execute()
        {
            return (bool)base.execute();
        }
        protected override object accion()
        {
            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando tipos de documentos...", 1, 1));
            dao._importacion.tipodocumento.fachada fachadaOldTipoDocumento = new gesClinica.lib.dao._importacion.tipodocumento.fachada();
            fachadaOldTipoDocumento.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldTipoDocumento.doImport(fachadaOldTipoDocumento.doGetAll());

            //this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando documentos...", 1, 1));
            //dao._importacion.documento.fachada fachadaOldDocumento = new gesClinica.lib.dao._importacion.documento.fachada();
            //fachadaOldDocumento.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            //fachadaOldDocumento.doImport(fachadaOldDocumento.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando componentes...", 1, 1));
            dao._importacion.componente.fachada fachadaOldComponente = new gesClinica.lib.dao._importacion.componente.fachada();
            fachadaOldComponente.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldComponente.doImport(fachadaOldComponente.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando indicaciones...", 1, 1));
            dao._importacion.indicacion.fachada fachadaOldIndicacion = new gesClinica.lib.dao._importacion.indicacion.fachada();
            fachadaOldIndicacion.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldIndicacion.doImport(fachadaOldIndicacion.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando laboratorios...", 1, 1));
            dao._importacion.laboratorio.fachada fachadaOldLaboratorio = new gesClinica.lib.dao._importacion.laboratorio.fachada();
            fachadaOldLaboratorio.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldLaboratorio.doImport(fachadaOldLaboratorio.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando clubs...", 1, 1));
            dao._importacion.club.fachada fachadaOldClub = new gesClinica.lib.dao._importacion.club.fachada();
            fachadaOldClub.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldClub.doImport(fachadaOldClub.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando subcuentas...", 1, 1));
            dao._importacion.subcuenta.fachada fachadaOldSubCuenta = new gesClinica.lib.dao._importacion.subcuenta.fachada();
            fachadaOldSubCuenta.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldSubCuenta.doImport(fachadaOldSubCuenta.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando pacientes...", 1, 1));
            dao._importacion.paciente.fachada fachadaOldPaciente = new gesClinica.lib.dao._importacion.paciente.fachada();
            fachadaOldPaciente.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldPaciente.doImport(fachadaOldPaciente.doGetAll(), new vo.SubCuenta(_common.cache.SUBCUENTAS.SubCuentaPaciente));

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando ginecologia...", 1, 1));
            dao._importacion.ginecologia.fachada fachadaOldGinecologia = new gesClinica.lib.dao._importacion.ginecologia.fachada();
            fachadaOldGinecologia.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldGinecologia.doImport(fachadaOldGinecologia.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando terapeutas...", 1, 1));
            dao._importacion.terapeuta.fachada fachadaOldTerapeuta = new gesClinica.lib.dao._importacion.terapeuta.fachada();
            fachadaOldTerapeuta.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldTerapeuta.doImport(fachadaOldTerapeuta.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando actividades...", 1, 1));
            dao._importacion.actividad.fachada fachadaOldActividad = new gesClinica.lib.dao._importacion.actividad.fachada();
            fachadaOldActividad.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldActividad.doImport(fachadaOldActividad.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando productos...", 1, 1));
            dao._importacion.producto.fachada fachadaOldProducto = new gesClinica.lib.dao._importacion.producto.fachada();
            fachadaOldProducto.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldProducto.doImport(fachadaOldProducto.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando productos. detalle...", 1, 1));
            dao._importacion.relprocom.fachada fachadaOldRelProCom = new gesClinica.lib.dao._importacion.relprocom.fachada();
            fachadaOldRelProCom.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldRelProCom.doImport(fachadaOldRelProCom.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando visitas...", 1, 1));
            dao._importacion.visita.fachada fachadaOldVisita = new gesClinica.lib.dao._importacion.visita.fachada();
            fachadaOldVisita.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldVisita.doImport(fachadaOldVisita.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando recetas...", 1, 1));
            dao._importacion.receta.fachada fachadaOldReceta = new gesClinica.lib.dao._importacion.receta.fachada();
            fachadaOldReceta.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldReceta.doImport(fachadaOldReceta.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando tipos de caja...", 1, 1));
            dao._importacion.tipocaja.fachada fachadaOldTipoCaja = new gesClinica.lib.dao._importacion.tipocaja.fachada();
            fachadaOldTipoCaja.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldTipoCaja.doImport(fachadaOldTipoCaja.doGetAll());

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando caja...", 1, 1));
            dao._importacion.caja.fachada fachadaOldCaja = new gesClinica.lib.dao._importacion.caja.fachada();
            fachadaOldCaja.Processing += new gesClinica.lib.dao._importacion.facade.ProcessingHandler(fachada_Processing);
            fachadaOldCaja.doImport(fachadaOldCaja.doGetAll());

            // Creamos las facturas
            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Preparando facturas...", 1, 1));
            dao.operacion.fachada fachadaOperacion = new gesClinica.lib.dao.operacion.fachada();
            List<vo.Operacion> listOperacion = fachadaOperacion.doGetAll(gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE);
            if (listOperacion != null)
            {
                int c = 0;
                int t = listOperacion.Count;
                bl.factura.doGenerate doGenerate = null;
                gesClinica.lib.dao.factura.fachada fachadaFactura = new gesClinica.lib.dao.factura.fachada();
                foreach (vo.Operacion operacion in listOperacion)
                {
                    if (operacion.Facturado)
                    {
                        this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Creando facturas...", c, t));
                        doGenerate = new gesClinica.lib.bl.factura.doGenerate(operacion, operacion.Fecha);
                        doGenerate.SystemAction = true;
                        vo.Factura factura = doGenerate.execute();
                        int numero = factura.Numero;
                        int.TryParse(string.IsNullOrEmpty(operacion.FacturaAntigua) ? "0" : operacion.FacturaAntigua, out numero);
                        factura.Numero = numero;
                        factura.Contabilizada = true;
                        fachadaFactura.doAdd(factura);
                    }

                    c++;
                }
            }
            // ********************

            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs("Operacion completada", 1, 1));

            return true;
        }

        void fachada_Processing(gesClinica.lib.dao._events.ProgressEventArgs e)
        {
            this.OnProcessing(new gesClinica.lib.bl._events.ProgressEventArgs(e.InfoProcess, e.CurrentProcess, e.TotalProcess));
        }
    }
}
