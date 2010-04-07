using System;
using System.Data.Common;
using ambis1.model.dao._template;
using ambis1.model.vo;
using System.Collections.Generic;

namespace ambis1.model.dao.reservation.dao
{	
	internal class reservationDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from reservation c";
            query += " left join cage on cage.id_cage = c.id_cage";
            query += " left join member on member.id_member = c.id_member";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by id_reservation asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Reservation res = null;
				if (reader!=null)
				{
                    res = new Reservation();
                    res.ID = Convert.ToInt32(reader["id_reservation"]);
                    res.Cage = new Cage();
                    res.Cage.ID = Convert.ToInt32(reader["id_cage"]);
                    res.Cage.Description = Convert.ToString(reader["description_cage"]);

                    res.DateAndTime = Convert.ToDateTime(reader["dateandtime_reservation"]);
                    res.Duration = Convert.ToDateTime(reader["duration_reservation"]);

                    res.Member = new Team();
                    res.Member.ID = Convert.ToInt32(reader["id_member"]);
                    res.Member.FirstName = Convert.ToString(reader["firstName_member"]);
                    res.Member.MiddleName = Convert.ToString(reader["middleName_member"]);
                    res.Member.LastName = Convert.ToString(reader["lastName_member"]);
				}

				return res;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public object doGetAll(DbCommand command, DateTime date)
        {
            try
            {
                string where = " c.dateAndTime_reservation >= " + this.PARAMETERPREFIX + "dateFrom_reservation and c.dateAndTime_reservation < " + this.PARAMETERPREFIX + "dateTo_reservation ";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "dateFrom_reservation", date.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "dateTo_reservation", date.Date.AddDays(1), command));


                DbDataReader reader = command.ExecuteReader();
                List<Reservation> res = (List<Reservation>)this.dataReaderToList(reader);
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
        public override object doGetAll(DbCommand command)
        {
            try
            {
                string query = getQuery();
                command.CommandText = query;

                DbDataReader reader = command.ExecuteReader();
                List<Reservation> res = (List<Reservation>)this.dataReaderToList(reader);
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
                Reservation objVO = (Reservation)obj;

                string where = " c.id_reservation = " + this.PARAMETERPREFIX + "id_reservation";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_reservation", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Reservation res = null;
                if (reader.Read())
                    res = (Reservation)this.dataReaderToObject(reader);
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
                Reservation objVO = (Reservation)obj;
                string where = " c.id_reservation = " + this.PARAMETERPREFIX + "id_reservation";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_reservation", objVO.ID, command));

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
                Reservation objVO = (Reservation)obj;
                string query = "insert into reservation "
                    + " (dateAndTime_reservation, duration_reservation, id_member, id_cage)"
                    + " values "
                    + " ({0}dateAndTime_reservation, {0}duration_reservation, {0}id_member, {0}id_cage)";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.INSERT);
            
                command.ExecuteNonQuery();
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
                Reservation objVO = (Reservation)obj;
                string query = "update reservation "
                    + "  set "
                    + "  dateAndTime_reservation = {0}dateAndTime_reservation"
                    + " ,duration_reservation = {0}duration_reservation"
                    + " ,id_member = {0}id_member"
                    + " ,id_cage = {0}id_cage"
                    + " where"
                    + " id_reservation = {0}id_reservation";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.UPDATE);

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
                Reservation objVO = (Reservation)obj;
                string query = "delete from reservation "
                    + " where"
                    + " id_reservation = {0}id_reservation";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.DELETE);
            
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
                System.Collections.Generic.List<Reservation> res = new System.Collections.Generic.List<Reservation>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Reservation)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }

        protected override void doSetParameter(ref DbCommand command, object obj, tDAOAction daoAction)
        {
            try
            {
                Reservation objVO = (Reservation)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cage", objVO.Cage.ID, command)); ;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "dateAndTime_reservation", objVO.DateAndTime, command)); ;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "duration_reservation", objVO.Duration, command)); ;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_member", objVO.Member.ID, command)); ;
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_reservation", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_reservation", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
