using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using schedule_v2.database_;

namespace schedule_v2.data_model_
{
    static class TStudent_
    {
        public static void FillComboBox_(ComboBox cb_, int select_id = 0)
        {
            string qry_ = "SELECT " +
               " id," +
               " (first_name+' '+last_name) AS item " +
               " FROM students " +
               " WHERE is_active; ";
            SConnect_DB_.Build_ComboBox_(qry_, cb_, select_id);
        }

        public static int Insert_(string fname_, string lname_, string descr_, bool is_active_)
        {
            string qry_ = "INSERT INTO students " +
                " (first_name, last_name, description, is_active) " +
                " VALUES ('" + fname_ + "', " +
                " '" + lname_ + "', " +
                " '" + descr_ + "', " +
                " :is_active:" +
                ")";
            if (is_active_)
            {
                qry_ = qry_.Replace(":is_active:", "true");
            }
            else
            {
                qry_ = qry_.Replace(":is_active:", "false");
            }
            SConnect_DB_.Query_Execute_(qry_);
            string id_s = SConnect_DB_.GetLastID_("SELECT MAX(id) AS last_id  FROM students");
            
            if (Int32.TryParse(id_s, out int id_)) {
                return id_; 
            }
            else { return 0; }

        }

        public static void Update_(int id_, string fname_, string lname_, string descr_, bool is_active_)
        {
            string qryUpdate = "UPDATE students SET " +
               " first_name ='" + fname_ + "', " +
               " last_name = '" + lname_ + "', " +
               " description = '" + descr_ + "'," +
               "  is_active = :is_active:" +
               " WHERE id = " + id_.ToString() + ";";
            if (is_active_)
            {
                qryUpdate = qryUpdate.Replace(":is_active:", "true");
            }
            else
            {
                qryUpdate = qryUpdate.Replace(":is_active:", "false");
            }
            SConnect_DB_.Query_Execute_(qryUpdate);
        }

        public static void List_(DataGridView dg_)
        {
            string qry_ = "SELECT " +
                " id," +
                " first_name," +
                " last_name," +
                " (first_name+' '+last_name) AS full_name," +
                " description," +
                " is_active " +
                " FROM students " +
                " WHERE is_active; ";

            DataTable tbl_list = new DataTable("list");
            DataSet ds_ = new DataSet();
            ds_.Tables.Add(tbl_list);
            SConnect_DB_.Build_List_(qry_, ds_);

            dg_.Columns.Clear();
            dg_.DataSource = ds_.Tables["list"];
            dg_.Columns["id"].Visible = false;
            dg_.Columns["id"].ValueType = typeof(int);
            dg_.Columns["first_name"].Visible = false;
            dg_.Columns["first_name"].ValueType = typeof(string);
            dg_.Columns["last_name"].Visible = false;
            dg_.Columns["last_name"].ValueType = typeof(string);
            dg_.Columns["full_name"].HeaderText = "Ученик";
            dg_.Columns["full_name"].ValueType = typeof(string);
            dg_.Columns["description"].HeaderText = "Комментарии";
            dg_.Columns["description"].ValueType = typeof(string);
            dg_.Columns["is_active"].Visible = false;
            dg_.Columns["is_active"].ValueType = typeof(bool);
            dg_.Rows[0].Selected = true;
            foreach (DataGridViewCell cell_ in dg_.Rows[0].Cells)
            {
                if (cell_.Visible)
                {
                    dg_.CurrentCell = cell_;
                    break;
                }
            }


        }
    }
}
