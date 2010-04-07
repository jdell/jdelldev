using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.ginecologia.dao
{	
	internal class ginecologiaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from gine e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Ginecologia res = null;
				if (reader!=null)
				{
                    res = new Ginecologia();

                    if (!Convert.IsDBNull(reader["Abortos"])) res.Abortos = Convert.ToInt32(reader["Abortos"]);
                    if (!Convert.IsDBNull(reader["Anticonceptivos"])) res.Anticonceptivos = Convert.ToString(reader["Anticonceptivos"]);
                    if (!Convert.IsDBNull(reader["Cesareas"])) res.Cesareas = Convert.ToInt32(reader["Cesareas"]);
                    if (!Convert.IsDBNull(reader["Dismen"])) res.Dismenorrea = Convert.ToString(reader["Dismen"]);
                    if (!Convert.IsDBNull(reader["Dispr"])) res.Dispareunemia = Convert.ToString(reader["Dispr"]);
                    if (!Convert.IsDBNull(reader["Gestaciones"])) res.Gestaciones = Convert.ToInt32(reader["Gestaciones"]);
                    if (!Convert.IsDBNull(reader["Hormonas"])) res.Hormonas = Convert.ToString(reader["Hormonas"]);
                    if (!Convert.IsDBNull(reader["IdGine"])) res.ID = Convert.ToString(reader["IdGine"]);
                    if (!Convert.IsDBNull(reader["Menarquia"])) res.Menarquia = Convert.ToInt32(reader["Menarquia"]);
                    if (!Convert.IsDBNull(reader["Menopausia"])) res.Menopausia = Convert.ToInt32(reader["Menopausia"]);
                    if (!Convert.IsDBNull(reader["MolestiasPelv"])) res.MolestiasPelvicas = Convert.ToString(reader["MolestiasPelv"]);
                    if (!Convert.IsDBNull(reader["Observaciones"])) res.Observaciones = Convert.ToString(reader["Observaciones"]);
                    if (!Convert.IsDBNull(reader["IdPaciente"]))
                    {
                        res.Paciente = new Paciente();
                        res.Paciente.Codigo= Convert.ToString(reader["IdPaciente"]);
                    }
                    if (!Convert.IsDBNull(reader["Partos"])) res.Partos = Convert.ToInt32(reader["Partos"]);
                    if (!Convert.IsDBNull(reader["ReglaDur"])) res.ReglaDuracion = Convert.ToInt32(reader["ReglaDur"]);
                    if (!Convert.IsDBNull(reader["ReglaFre"])) res.ReglaFrecuencia = Convert.ToInt32(reader["ReglaFre"]);
                    if (!Convert.IsDBNull(reader["Premest"])) res.SindromePremenstrual = Convert.ToString(reader["Premest"]);
                    if (!Convert.IsDBNull(reader["Vivos"])) res.Vivos = Convert.ToInt32(reader["Vivos"]);
				}
				return res;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public override object doGetAll(DbCommand command)
        {
            try
            {
                string query = getQuery();
                command.CommandText = query;

                DbDataReader reader = command.ExecuteReader();
                List<Ginecologia> res = (List<Ginecologia>)this.dataReaderToList(reader);
                reader.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override object doGet(DbCommand command, object obj)
        {
            try
            {
                throw new Exception("No implementado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override bool doCheckIfExists(DbCommand command, object obj)
        {
            try
            {
                throw new Exception("No implementado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override object doAdd(DbCommand command, object obj)
        {
            try
            {
                throw new Exception("No implementado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override object doUpdate(DbCommand command, object obj)
        {
            try
            {
                throw new Exception("No implementado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override object doDelete(DbCommand command, object obj)
        {
            try
            {
                throw new Exception("No implementado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        protected override object dataReaderToList(DbDataReader reader)
        {
            try
            {
                System.Collections.Generic.List<Ginecologia> res = new System.Collections.Generic.List<Ginecologia>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Ginecologia)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }
    }
}
