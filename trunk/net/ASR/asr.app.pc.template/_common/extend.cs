using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template._common
{
    public static class extend
    {
        public static void SelectOnEnter(ref repsol.forms.controls.TextBoxColor textBox)
        {
            try
            {
                textBox.Enter+= new EventHandler(SelectOnEnterHandler);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        private static void SelectOnEnterHandler(object sender, EventArgs e)
        {
            try
            {
                ((System.Windows.Forms.TextBox)sender).SelectAll();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        public static void Translate(repsol.forms.template.BaseForm frm)
        {
            try
            {
                Translate((Object)frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        public static void Translate(repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                Translate((Object)frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        public static void Translate(repsol.forms.template.edicion.EditForm frm)
        {
            try
            {
                Translate((Object)frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        public static void Translate(System.Windows.Forms.Control frm)
        {
            try
            {
                Translate((Object)frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private static string Translate(string msg)
        {
            return string.IsNullOrEmpty(msg)?msg: msg
                    .Replace("uevo", "ew")
                    .Replace("modificar", "update")
                    .Replace("egistro", "ecord")
                    .Replace("modificar", "update")
                    .Replace("Aceptar", "OK")
                    .Replace("Guardar", "Save")
                    .Replace("Salir", "Exit")
                    .Replace("salir", "exit")
                    .Replace("Cancelar", "Cancel")
                    .Replace("Borrar", "Delete")
                    .Replace("borrar", "delete")
                    .Replace("Consultar", "View")
                    .Replace("consultar", "view")
                    .Replace("Ver", "View")
                    .Replace("ver", "view")
                    .Replace("Filtrar", "Filter")
                    .Replace("filtrar", "filter")
                    .Replace("uplicar", "uplicate")
                    .Replace("Imprimir", "Print")
                    .Replace("imprimir", "print")
                    .Replace("Mostrar", "View")
                    .Replace("mostrar", "view")
                    .Replace("Informe", "Report")
                    .Replace("informe", "report")
                    .Replace("pciones", "ptions")
                    .Replace("Modificación", "Update")
                    .Replace("Consulta", "View")
                    .Replace("Viewy", "Very");
        }
        private static void Translate(Object ctrl)
        {
            try
            {
                Type type = ctrl.GetType();
                if (type.FullName == typeof(System.Windows.Forms.DateTimePicker).FullName) return;

                System.Reflection.PropertyInfo propertyText = type.GetProperty("Text");
                if ((propertyText != null) && (propertyText.GetValue(ctrl, null) != null))
                    propertyText.SetValue(ctrl, Translate(propertyText.GetValue(ctrl, null).ToString()), null);

                System.Reflection.PropertyInfo propertyToolTip = type.GetProperty("ToolTipText");
                if ((propertyToolTip != null) && (propertyToolTip.GetValue(ctrl, null)!=null))
                    propertyToolTip.SetValue(ctrl, Translate(propertyToolTip.GetValue(ctrl, null).ToString()), null);
                
                System.Reflection.PropertyInfo propertyControls = type.GetProperty("Controls");
                if ((propertyControls != null) && (propertyControls.GetValue(ctrl, null) != null))
                {
                    //System.Windows.Forms.Control.ControlCollection array = (System.Windows.Forms.Control.ControlCollection)propertyControls.GetValue(ctrl, null);
                    System.Collections.ICollection array = (System.Collections.ICollection)propertyControls.GetValue(ctrl, null);
                    foreach (Object c in array)
                        Translate(c);
                }

                System.Reflection.PropertyInfo propertyItems = type.GetProperty("Items");
                if ((propertyItems != null) && (propertyItems.GetValue(ctrl, null) != null))
                {/*
                    if (propertyItems.GetValue(ctrl, null).GetType().FullName != typeof(System.Windows.Forms.ComboBox.ObjectCollection).FullName)
                    {*/
                        System.Collections.ICollection array = (System.Collections.ICollection)propertyItems.GetValue(ctrl, null);
                        foreach (Object c in array)
                            Translate(c);
                    //}
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
