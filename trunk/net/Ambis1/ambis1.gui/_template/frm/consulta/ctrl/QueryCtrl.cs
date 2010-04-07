using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.frm.consulta.ctrl
{
    public abstract class QueryCtrl:repsol.forms.template.consulta.ctrl.QueryFormCtrl
    {
        [Obsolete("Migración a 2005/2008.",true)]
        protected override System.Data.DataView ArrayVOToDataView(object[] aObject)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        protected abstract System.Data.DataView ListVOToDataView(Object listObj);
        
        #region "SelectedRow" 
            protected object _objVO = null;
            protected string _columnNameToRemember = "Id" ;
            protected string _propertyNameToRemember = "ID" ;
            public void saveSelectedRow(repsol.forms.template.consulta.QueryForm frm) 
            {
                _objVO = this.getRegistroSeleccionado(ref frm) ;
            }
            public void loadSelectedRow(repsol.forms.template.consulta.QueryForm frm) 
            {
                if (_objVO !=null) 
                {
                    foreach ( System.Windows.Forms.DataGridViewRow dr in frm.dgConsulta.Rows)
                    {
                        if (dr.Cells[_columnNameToRemember].Value.ToString() == _objVO.GetType().GetProperty(_propertyNameToRemember).GetValue(_objVO, null).ToString()) 
                        {
                            frm.dgConsulta.CurrentCell = dr.Cells[frm.dgConsulta.CurrentCell.ColumnIndex] ;
                            break;
                        }
                    }
            }
            }
        #endregion 
    }
}
