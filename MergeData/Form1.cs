using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MergeData
{
    public partial class Form1 : Form
    {
        DAL mdal, sdal;
        List<string> mcol, scol;
        DataTable sData;
        string mDataBase, mTable;
        string accountext, roleext;
        List<GameID> GameIDs = new List<GameID>();
        List<Character> Characters = new List<Character>();
        string gameaccounttable = "account";
        string gamecharactertable = "character";
        string gameresource = "resource";

        public Form1()
        {            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ddlMTable.Text))
            {
                MessageBox.Show("请选择主库表");
                return;
            }
            if (string.IsNullOrWhiteSpace(ddlSTable.Text))
            {
                MessageBox.Show("请选择从库表");
                return;
            }

            if(GameIDs.Count == 0 && ddlMTable.Text.ToLower() == gamecharactertable)
            {
                MessageBox.Show("请先合并" + gameaccounttable +"表，再合并" + ddlMTable.Text);
                return;
            }

            if(Characters.Count == 0 && ddlMTable.Text.ToLower() == gameresource)
            {
                MessageBox.Show("请先合并" + gamecharactertable + "表，再合并" + ddlMTable.Text);
                return;
            }

            mcol = mdal.GetTableColumns(ddlMDataBase.Text, ddlMTable.Text);
            scol = sdal.GetTableColumns(ddlSDataBase.Text, ddlSTable.Text);
            sData = sdal.GetDataByTableName(ddlSDataBase.Text, ddlSTable.Text);
            mDataBase = ddlMDataBase.Text.ToLower();
            mTable = ddlMTable.Text.ToLower();
            accountext = txtAccountext.Text;
            roleext = txtRoleext.Text;

            Thread th = new Thread(Merge);
            th.Start();
        }

        private void ddlMDataBase_DropDown(object sender, EventArgs e)
        {
            mdal = new DAL(txtMIP.Text, txtMAccount.Text, txtMPwd.Text);
            if (InitDataBase(mdal, ddlMDataBase))
            {
                ddlMDataBase.SelectedIndexChanged += ddlMDataBase_SelectedIndexChanged;
                ddlMDataBase.SelectedIndex = 0;
            }
        }

        private void ddlSDataBase_DropDown(object sender, EventArgs e)
        {
            sdal = new DAL(txtSIP.Text, txtSAccount.Text, txtSPwd.Text);
            if (InitDataBase(sdal, ddlSDataBase))
            {
                ddlSDataBase.SelectedIndexChanged += ddlSDataBase_SelectedIndexChanged;
                ddlSDataBase.SelectedIndex = 0;
            }
        }

        private bool InitDataBase(DAL dal, ComboBox ddl)
        {
            try
            {
                var data = dal.GetDataBases();
                ddl.DataSource = data;
                ddl.DisplayMember = "name";
                ddl.ValueMember = "database_id";
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void ddlMDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitTable(mdal, ddlMTable, ddlMDataBase.Text);
        }

        private void ddlSDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitTable(sdal, ddlSTable, ddlSDataBase.Text);
        }

        private void InitTable(DAL dal, ComboBox ddl, string database)
        {
            var data = dal.GetTables(database);
            ddl.DataSource = data;
            ddl.DisplayMember = "name";
            ddl.ValueMember = "id";
        }

        private void Merge()
        {
            this.Invoke(new Action(() => { button1.Enabled = false; }));
            
            string accountname = "name";
            bool hasaccountcol = false;
            string accountname2 = "act_name";
            bool hasaccountcol2 = false;
            string rolename = "cha_name";
            bool hasrolecol = false;
            int maxID = 0;                       

            if (mcol.Count() == scol.Count() && mcol.Count(t => !scol.Contains(t)) == 0)
            {
                //如果是account,则获取最大值
                if(mTable.ToLower() == gameaccounttable)
                {
                    maxID = mdal.MaxID(mDataBase);
                }

                string sql = "USE "+ mDataBase + " INSERT INTO " + mTable + "(";
                foreach (var col in mcol)
                {
                    sql += col + ",";
                }
                sql = sql.TrimEnd(',') + ")";

                hasaccountcol = scol.Exists(e => e.ToLower() == accountname);
                hasaccountcol2 = scol.Exists(e => e.ToLower() == accountname2);
                hasrolecol = scol.Exists(e => e.ToLower() == rolename);
                int count = 0;
                int actid = 0;
                Character character = null;

                foreach (DataRow row in sData.Rows)
                {
                    string valuesql = "VALUES(";
                    foreach (var cols in scol)
                    {
                        var value = row[cols];
                        if (cols.ToLower() == "act_id")
                        {
                            actid = 0;
                            if (mTable.ToLower() == gameaccounttable)
                            {
                                var item = new GameID();
                                item.OldID = Convert.ToInt32(value);
                                value = ++maxID;
                                item.NewID = Convert.ToInt32(value);
                                GameIDs.Add(item);
                            }
                            else if (mTable.ToLower() == gamecharactertable)
                            {
                                value = GameIDs.First(w => w.OldID == Convert.ToInt32(value)).NewID;
                            }
                            actid = Convert.ToInt32(value);
                        }

                        if(cols.ToLower() == "cha_id" && mTable.Equals(gameresource, StringComparison.InvariantCultureIgnoreCase))
                        {
                            character = Characters.FirstOrDefault(w => w.OldID == Convert.ToInt32(value));
                            if (character == null)
                                break;
                            value = character.NewID;
                        }

                        if (mTable.ToLower() == gamecharactertable && cols.ToLower() == "guild_id")
                            value = 0;

                        DataColumn col = sData.Columns[cols];
                        if (col.ColumnName.ToLower() == accountname && hasaccountcol && mdal.CheckedColumnValue(mDataBase, mTable, accountname, value.ToString()))
                            value += accountext;
                        else if (col.ColumnName.ToLower() == accountname2 && hasaccountcol2 && mdal.CheckedColumnValue(mDataBase, mTable, accountname2, value.ToString()))
                            value += accountext;
                        else if (col.ColumnName.ToLower() == rolename && hasrolecol && mdal.CheckedColumnValue(mDataBase, mTable, rolename, value.ToString()))
                            value += roleext;

                        if (value == DBNull.Value)
                            valuesql += " NULL,";
                        else if (col.DataType.Name == "DateTime")
                            valuesql += "N'" + value + "',";
                        else if (col.DataType.BaseType.Name == "ValueType")
                            valuesql += value + ",";
                        else
                            valuesql += "N'" + value + "',";
                    }
                    if (valuesql == "VALUES(") continue;
                    valuesql = valuesql.TrimEnd(',') + ")";
                    mdal.InsertData(sql + valuesql);
                    if (mTable.ToLower() == gamecharactertable)
                    {
                        var oldcharid = Convert.ToInt32(row["cha_id"]);
                        var newcharid = mdal.MaxChaID(mDataBase);
                        mdal.UpdateCharIDs(mDataBase, actid, oldcharid, newcharid);

                        var item = new Character();
                        item.OldID = oldcharid;
                        item.NewID = newcharid;
                        item.Kitbag = string.IsNullOrWhiteSpace(row["kitbag"].ToString()) ? 0 : Convert.ToInt32(row["kitbag"]);
                        item.Bank = string.IsNullOrWhiteSpace(row["bank"].ToString()) ? 0 : Convert.ToInt32(row["bank"]);
                        item.KitBag_tmp = string.IsNullOrWhiteSpace(row["kitbag_tmp"].ToString()) ? 0 : Convert.ToInt32(row["kitbag_tmp"]);
                        Characters.Add(item);
                    }
                    if(mTable.Equals(gameresource, StringComparison.InvariantCultureIgnoreCase))
                    {
                        var oldid = Convert.ToInt32(row["id"]);
                        var newid = mdal.MaxResourceID(mDataBase);
                        string colname = "";
                        if (oldid == character.Kitbag)
                            colname = "kitbag";
                        else if(oldid == character.Bank)
                            colname = "bank";
                        else if (oldid == character.KitBag_tmp)
                            colname = "kitbag_tmp";
                        mdal.UpdateCharacter(mDataBase, colname, newid.ToString(), character.NewID.ToString());
                    }
                    count++;
                    this.Invoke(new Action(() =>{ label13.Text = "成功合并" + count + "条数据"; }));
                }
                if (mTable.ToLower() == gamecharactertable)
                    GameIDs.Clear();
                if (mTable.Equals(gameresource, StringComparison.InvariantCultureIgnoreCase))
                    Characters.Clear();
                this.Invoke(new Action(() => { button1.Enabled = true; }));
            }
            else
            {
                MessageBox.Show("选择的表结构不一致");
                this.Invoke(new Action(() => { button1.Enabled = true; }));
            }
        }
    }

    public class GameID
    {
        public int OldID { get; set; }
        public int NewID { get; set; }
    }

    public class Character
    {
        public int OldID { get; set; }
        public int NewID { get; set; }
        public int Kitbag { get; set; }
        public int Bank { get; set; }
        public int KitBag_tmp { get; set; }
    }
}
