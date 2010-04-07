using System;
using System.Data;
using System.Data.Common;

namespace asr.lib.dao._template
{
	
	public abstract class objectDAO
	{
        protected abstract void doSetParameter(ref DbCommand command, object obj, tDAOAction daoAction);

        public abstract object doGetAll(DbCommand command);
        public abstract object doGet(DbCommand command, object obj);

        public abstract bool doCheckIfExists(DbCommand command, object obj);

        public abstract object doAdd(DbCommand command, object obj);
        public abstract object doUpdate(DbCommand command, object obj);
        public abstract object doDelete(DbCommand command, object obj);

        protected abstract object dataReaderToList(DbDataReader reader);
        protected abstract object dataReaderToObject(DbDataReader reader);

        protected abstract string getQuery(string conditionWhere);
        protected string getQuery()
        {
            return getQuery(string.Empty);
        }

        protected string PARAMETERPREFIX = DataBaseConfigSection.getDataBaseConfig().ParameterPrefix;
        protected string ISNULLFUNCTION = DataBaseConfigSection.getDataBaseConfig().GetIsNull;
        protected string CALLSTOREDPROCEDURE = DataBaseConfigSection.getDataBaseConfig().CallStoredProcedure;

        protected Int64 GetGeneratedIdentifier(DbCommand command)
        {
            string queryString = string.Format("SELECT {0}", DataBaseConfigSection.getDataBaseConfig().GetIdentity);
            
            try
            {
                command.CommandText = queryString;
                Int64 identity = Convert.ToInt64(command.ExecuteScalar());
                return identity;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        protected DbParameter CreateParameter(DbType type, string parameterName, DbCommand command)
        {
            DbParameter res = command.CreateParameter();
            res.DbType = type;
            res.ParameterName = parameterName;
            res.Direction = ParameterDirection.Output;

            return res;
        }
        protected DbParameter CreateParameter(DbType type, string parameterName, object objectValue, DbCommand command)
        {
            DbParameter res = command.CreateParameter();
            res.DbType = type;
            res.ParameterName = parameterName;
            res.Value = objectValue;

            return res;
        }
        protected object DBValueToObject(object dbvalue)
        {
            object res = null;

            if (!Convert.IsDBNull(dbvalue)) res = dbvalue;

            return res;
        }

        #region DataBaseConfigSection

        private class DataBaseConfigSection
        {
            string _callStoredProcedure;
            public string CallStoredProcedure
            {
                get { return _callStoredProcedure; }
                set { _callStoredProcedure = value; }
            }

            protected string _name;
            public string Name
            {
                get
                {
                    return _name;
                }

            }

            string _parameterPrefix;
            public string ParameterPrefix
            {
              get { return _parameterPrefix; }
              set { _parameterPrefix = value; }
            }

            string _getIdentity;
            public string GetIdentity
            {
              get { return _getIdentity; }
              set { _getIdentity = value; }
            }

            string _getIsNull;

            public string GetIsNull
            {
                get { return _getIsNull; }
                set { _getIsNull = value; }
            }

            private DataBaseConfigSection()
            {
                this._name = "dataBaseConfig";
                this._parameterPrefix = "?";
                this._getIdentity = "LAST_INSERT_ID()";
                this._getIsNull = "IFNULL";
                this._callStoredProcedure = "SELECT";
            }

            private static DataBaseConfigSection _instance = null;
            public static DataBaseConfigSection getDataBaseConfig()
            {
                if (_instance == null)
                {
                    _instance = new DataBaseConfigSection();
                    repsol.util.config.sections.section dataBaseConfigSetting = repsol.util.config.sections.section.getSectionSetting(lib.common.variables.configpath.GetFullPath(), _instance.Name);
                    if (dataBaseConfigSetting != null)
                    {
                        _instance.GetIdentity = dataBaseConfigSetting["getIdentity"].Value;
                        _instance.ParameterPrefix = dataBaseConfigSetting["parameterPrefix"].Value;
                        _instance.GetIsNull = dataBaseConfigSetting["getIsNull"].Value;
                        _instance.CallStoredProcedure = dataBaseConfigSetting["callStoredProcedure"].Value;
                    }
                }
                return _instance;
            }

        }

        #endregion
    }
}
