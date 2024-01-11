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
    class TLesson_
    {
        private static bool ExistLesson(string s_time, string e_time)
        {
            bool result_ = false;
            string qry_ = "SELECT id FROM lessons WHERE (FORMAT(start_time,'hh:mm') = '" + s_time+
                "') AND (FORMAT(end_time,'hh:mm') = '" + e_time+
                "') ";
            string ID_ = SConnect_DB_.GetLastID_(qry_);
            try
            {
                if (Convert.ToInt32(ID_) > 0) { result_ = true; }
            }
            catch { result_ = false; }
            
            return result_;
        }
        public static void Insert_(string s_time, string e_time)
        {
            if (!ExistLesson(s_time, e_time))
            {
                string qryInsert_ = "INSERT INTO lessons (start_time, end_time) " +
                " VALUES ('" + s_time + "', '" + e_time + "')";
                SConnect_DB_.Query_Execute_(qryInsert_);
            }
            
        }
        public static void Update_(string s_time, string e_time, string id_)
        {
            if (ExistLesson(s_time, e_time)) { //SConnect_DB_.Query_Execute_("DELETE * FROM lessons WHERE id = " + id_);
                return;
            }
            string qryUpdate_ = "UPDATE lessons SET start_time='" + s_time + "', " +
                " end_time='" + e_time + "' " +
                " WHERE id=" + id_;
            SConnect_DB_.Query_Execute_(qryUpdate_);
        }
        public static void List_(DataGridView dg_)
        {
            DataGridView Grid_ = dg_; // копирует ссылку на сетку из формы
            string qry_ = "SELECT id, " +
                " FORMAT(start_time, 'hh:mm') AS s_time, " +
                " FORMAT(end_time, 'hh:mm') AS e_time" +
                " FROM lessons ORDER BY start_time";
            DataTable tbl_list = new DataTable("list");
            DataSet ds_ = new DataSet();
            ds_.Tables.Add(tbl_list);
            SConnect_DB_.Build_List_(qry_, ds_);

            
            Grid_.DataSource = ds_.Tables["list"];
            Grid_.Columns["id"].Visible = false;
            Grid_.Columns["s_time"].HeaderText = "Начало урока";
            Grid_.Columns["e_time"].HeaderText = "Конец урока";
            
            Grid_.Rows[0].Selected = true;
            Grid_.CurrentCell = Grid_[1, 0];
        }

        public static void FillComboBox_(ComboBox cb_lesson, int select_id = 0)
        {
            string qry_ = "SELECT id, " +
                " FORMAT(start_time, 'hh:mm')+' - '+ " +
                " FORMAT(end_time, 'hh:mm') AS item" +
                " FROM lessons ORDER BY start_time";
            SConnect_DB_.Build_ComboBox_(qry_, cb_lesson, select_id);

        }


    }
}
