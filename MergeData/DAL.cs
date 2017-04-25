using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MergeData
{
    public class DAL
    {
        Db db;

        public DAL(string ip, string userid, string pwd)
        {
            db = new Db(ip, userid, pwd);
        }

        public DataTable GetDataBases()
        {
            return db.Context.FromSql("select database_id, name from sys.databases").ToDataTable();
        }

        public DataTable GetTables(string database)
        {
            return db.Context.FromSql("USE "+ database +" SELECT id, name FROM sys.sysobjects WHERE type = 'U'").ToDataTable();
        }

        public DataTable GetDataByTableName(string database, string tableName)
        {
            return db.Context.FromSql("USE "+ database +" SELECT * FROM " + tableName).ToDataTable();
        }

        public List<string> GetTableColumns(string database, string tableName)
        {
            return db.Context.FromSql("USE " + database + " select name from syscolumns where id=object_id('" + tableName +"') AND colstat=0 ").ToList<string>();
        }

        public bool CheckedColumnValue(string database, string tableName, string column, string value)
        {
            var v = string.Format("USE {0} SELECT {1} FROM {2} WHERE {1} = '{3}'", database, column, tableName, value);
            var a = db.Context.FromSql(v).ToDataTable();
            return a.Rows.Count > 0;
        }

        public bool InsertData(string sql)
        {
            return db.Context.FromSql(sql).ExecuteNonQuery() > 0;
        }

        public int MaxID(string database)
        {
            var a = db.Context.FromSql("USE " + database + " SELECT MAX(act_id)AS act_id FROM dbo.account").ToDataTable();
            return Convert.ToInt32(a.Rows[0]["act_id"]);
        }

        public int MaxChaID(string database)
        {
            var a = db.Context.FromSql("USE " + database + " SELECT MAX(cha_id)AS cha_id FROM dbo.character").ToDataTable();
            return Convert.ToInt32(a.Rows[0]["cha_id"]);
        }

        public int MaxResourceID(string database)
        {
            var a = db.Context.FromSql("USE " + database + " SELECT MAX(id)AS id FROM dbo.resource").ToDataTable();
            return Convert.ToInt32(a.Rows[0]["id"]);
        }

        public void UpdateCharIDs(string database, int actid, int oldcharid, int newcharid)
        {
            var a = "USE " + database + " UPDATE dbo.account SET cha_ids = REPLACE(cha_ids, '" + oldcharid + "', '" + newcharid + "') WHERE act_id = " + actid;
            db.Context.FromSql(a).ExecuteNonQuery();
        }

        public void UpdateCharacter(string database, string colname, string colvalue, string chaid)
        {
            var a = "USE " + database + " UPDATE dbo.character SET "+ colname +" = "+ colvalue +" WHERE cha_id = " + chaid;
            db.Context.FromSql(a).ExecuteNonQuery();
        }
    }
}
