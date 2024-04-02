using System.Collections;

namespace Procedures
{
    public static class SqlProcedure
    {
        private static Hashtable p = new Hashtable();
        public static Hashtable Procedures
        {
            get { return p; }
        }
        static SqlProcedure()
        {
            #region Load Databases 
            p["LoadDatabases"] = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb');";
            #endregion
        }
    }
}
