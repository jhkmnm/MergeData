using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeData
{
    public class Db
    {
        public readonly DbSession Context;// = new DbSession("SqliteConn");

        public Db(string ip, string userid, string pwd)
        {
            Context = new DbSession(DatabaseType.SqlServer, string.Format("Data Source ={0};User ID ={1}; Pwd={2};", ip, userid, pwd));
        }

        public Db(string ip, string db, string userid, string pwd)
        {
            Context = new DbSession(DatabaseType.SqlServer, string.Format("Data Source ={0}; Initial Catalog ={3}; User ID ={1}; Pwd={2};", ip, userid, pwd, db));
        }
    }
}
