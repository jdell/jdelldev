using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.extpaciente.dao
{	
	internal class extpacienteDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from extpaciente e"
            + " left join paciente p on e.id_paciente = p.id_paciente";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				ExtPaciente res = null;
				if (reader!=null)
				{
                    res = new ExtPaciente();
                    res.Abortos = Convert.ToInt32(reader["abortos_extpaciente"]);
                    res.Anticonceptivos= Convert.ToString(reader["anticonceptivos_extpaciente"]);
                    res.Cesareas = Convert.ToInt32(reader["cesareas_extpaciente"]);
                    res.Dismenorrea = Convert.ToString(reader["dismenorrea_extpaciente"]);
                    res.Dispareunemia = Convert.ToString(reader["dispareunemia_extpaciente"]);
                    res.Gestaciones = Convert.ToInt32(reader["gestaciones_extpaciente"]);
                    res.Hormonas = Convert.ToString(reader["hormonas_extpaciente"]);

                    res.ID= Convert.ToInt32(reader["id_extpaciente"]);

                    res.Menarquia = Convert.ToInt32(reader["menarquia_extpaciente"]);
                    res.Menopausia = Convert.ToInt32(reader["menopausia_extpaciente"]);
                    res.MolestiasPelvicas = Convert.ToString(reader["molestiaspelvicas_extpaciente"]);
                    res.Observaciones = Convert.ToString(reader["observaciones_extpaciente"]);

                    res.Paciente = new Paciente();
                    res.Paciente.ID = Convert.ToInt32(reader["id_paciente"]);
                    res.Paciente.Apellido1 = Convert.ToString(reader["apellido1_paciente"]);
                    res.Paciente.Apellido2 = Convert.ToString(reader["apellido2_paciente"]);
                    res.Paciente.Nombre = Convert.ToString(reader["nombre_paciente"]);

                    res.Partos = Convert.ToInt32(reader["partos_extpaciente"]);
                    res.ReglaDuracion = Convert.ToInt32(reader["regladuracion_extpaciente"]);
                    res.ReglaFrecuencia = Convert.ToInt32(reader["reglafrecuencia_extpaciente"]);
                    res.SindromePremenstrual= Convert.ToString(reader["sindromepremenstrual_extpaciente"]);
                    res.Vivos= Convert.ToInt32(reader["vivos_extpaciente"]);
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
                List<ExtPaciente> res = (List<ExtPaciente>)this.dataReaderToList(reader);
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
                ExtPaciente objVO = (ExtPaciente)obj;

                string where = " id_extpaciente = " + this.PARAMETERPREFIX + "id_extpaciente";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_extpaciente", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                ExtPaciente res = null;
                if (reader.Read())
                    res = (ExtPaciente)this.dataReaderToObject(reader);
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
        public object doGetByPaciente(DbCommand command, Paciente paciente)
        {
            try
            {
                string where = " e.id_paciente = " + this.PARAMETERPREFIX + "id_paciente";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", paciente.ID, command));

                DbDataReader reader = command.ExecuteReader();
                ExtPaciente res = null;
                if (reader.Read())
                    res = (ExtPaciente)this.dataReaderToObject(reader);
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

        public override bool doCheckIfExists(DbCommand command, object obj)
        {
            try
            {
                ExtPaciente objVO = (ExtPaciente)obj;
                string where = " id_extpaciente = " + this.PARAMETERPREFIX + "id_extpaciente";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_extpaciente", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                bool res = reader.Read();
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

        public override object doAdd(DbCommand command, object obj)
        {
            try
            {
                ExtPaciente objVO = (ExtPaciente)obj;
                string query = "insert into extpaciente "
                    + " (abortos_extpaciente, anticonceptivos_extpaciente, cesareas_extpaciente, dismenorrea_extpaciente, dispareunemia_extpaciente, gestaciones_extpaciente, hormonas_extpaciente, menarquia_extpaciente, menopausia_extpaciente, molestiaspelvicas_extpaciente, observaciones_extpaciente, id_paciente, partos_extpaciente, regladuracion_extpaciente, reglafrecuencia_extpaciente, sindromepremenstrual_extpaciente, vivos_extpaciente)"
                    + " values "
                    + string.Format("({0}abortos_extpaciente, {0}anticonceptivos_extpaciente, {0}cesareas_extpaciente, {0}dismenorrea_extpaciente, {0}dispareunemia_extpaciente, {0}gestaciones_extpaciente, {0}hormonas_extpaciente, {0}menarquia_extpaciente, {0}menopausia_extpaciente, {0}molestiaspelvicas_extpaciente, {0}observaciones_extpaciente, {0}id_paciente, {0}partos_extpaciente, {0}regladuracion_extpaciente, {0}reglafrecuencia_extpaciente, {0}sindromepremenstrual_extpaciente, {0}vivos_extpaciente)",this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "abortos_extpaciente", objVO.Abortos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "anticonceptivos_extpaciente", objVO.Anticonceptivos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "cesareas_extpaciente", objVO.Cesareas, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "dismenorrea_extpaciente", objVO.Dismenorrea, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "dispareunemia_extpaciente", objVO.Dispareunemia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "gestaciones_extpaciente", objVO.Gestaciones, command));
                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "hormonas_extpaciente", objVO.Hormonas, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "menarquia_extpaciente", objVO.Menarquia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "menopausia_extpaciente", objVO.Menopausia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "molestiaspelvicas_extpaciente", objVO.MolestiasPelvicas, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_extpaciente", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "partos_extpaciente", objVO.Partos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "regladuracion_extpaciente", objVO.ReglaDuracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "reglafrecuencia_extpaciente", objVO.ReglaFrecuencia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "sindromepremenstrual_extpaciente", objVO.SindromePremenstrual, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "vivos_extpaciente", objVO.Vivos, command));

                command.ExecuteNonQuery();
                //long res = Convert.ToInt32(command.Parameters["" + this.PARAMETERPREFIX + "id"].Value);
                //return res;
                return this.GetGeneratedIdentifier(command);
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
                ExtPaciente objVO = (ExtPaciente)obj;
                string query = "update extpaciente "
                    + "  set "
                    + "  abortos_extpaciente = " + this.PARAMETERPREFIX + "abortos_extpaciente"
                    + " ,anticonceptivos_extpaciente = " + this.PARAMETERPREFIX + "anticonceptivos_extpaciente"
                    + " ,cesareas_extpaciente = " + this.PARAMETERPREFIX + "cesareas_extpaciente"
                    + " ,dismenorrea_extpaciente = " + this.PARAMETERPREFIX + "dismenorrea_extpaciente"
                    + " ,dispareunemia_extpaciente = " + this.PARAMETERPREFIX + "dispareunemia_extpaciente"
                    + " ,gestaciones_extpaciente = " + this.PARAMETERPREFIX + "gestaciones_extpaciente"
                    + " ,hormonas_extpaciente = " + this.PARAMETERPREFIX + "hormonas_extpaciente"
                    + " ,menarquia_extpaciente = " + this.PARAMETERPREFIX + "menarquia_extpaciente"
                    + " ,menopausia_extpaciente = " + this.PARAMETERPREFIX + "menopausia_extpaciente"
                    + " ,molestiaspelvicas_extpaciente = " + this.PARAMETERPREFIX + "molestiaspelvicas_extpaciente"
                    + " ,observaciones_extpaciente = " + this.PARAMETERPREFIX + "observaciones_extpaciente"
                    + " ,id_paciente = " + this.PARAMETERPREFIX + "id_paciente"
                    + " ,partos_extpaciente = " + this.PARAMETERPREFIX + "partos_extpaciente"
                    + " ,regladuracion_extpaciente = " + this.PARAMETERPREFIX + "regladuracion_extpaciente"
                    + " ,reglafrecuencia_extpaciente = " + this.PARAMETERPREFIX + "reglafrecuencia_extpaciente"
                    + " ,sindromepremenstrual_extpaciente = " + this.PARAMETERPREFIX + "sindromepremenstrual_extpaciente"
                    + " ,vivos_extpaciente = " + this.PARAMETERPREFIX + "vivos_extpaciente"
                    + " where"
                    + " id_extpaciente = " + this.PARAMETERPREFIX + "id_extpaciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "abortos_extpaciente", objVO.Abortos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "anticonceptivos_extpaciente", objVO.Anticonceptivos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "cesareas_extpaciente", objVO.Cesareas, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "dismenorrea_extpaciente", objVO.Dismenorrea, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "dispareunemia_extpaciente", objVO.Dispareunemia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "gestaciones_extpaciente", objVO.Gestaciones, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_extpaciente", objVO.ID, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "hormonas_extpaciente", objVO.Hormonas, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "menarquia_extpaciente", objVO.Menarquia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "menopausia_extpaciente", objVO.Menopausia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "molestiaspelvicas_extpaciente", objVO.MolestiasPelvicas, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_extpaciente", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "partos_extpaciente", objVO.Partos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "regladuracion_extpaciente", objVO.ReglaDuracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "reglafrecuencia_extpaciente", objVO.ReglaFrecuencia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "sindromepremenstrual_extpaciente", objVO.SindromePremenstrual, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "vivos_extpaciente", objVO.Vivos, command));

                command.ExecuteNonQuery();
                return objVO;
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
                ExtPaciente objVO = (ExtPaciente)obj;
                string query = "delete from extpaciente "
                    + " where"
                    + " id_extpaciente = " + this.PARAMETERPREFIX + "id_extpaciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_extpaciente", objVO.ID, command));

                command.ExecuteNonQuery();
                return objVO;
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
                System.Collections.Generic.List<ExtPaciente> res = new System.Collections.Generic.List<ExtPaciente>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((ExtPaciente)dataReaderToObject(reader));
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
