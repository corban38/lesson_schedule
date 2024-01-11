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
    class TLesson_Topic_
    {
        private static bool ExistLessonTopic(string topic_name)
        {
            bool result_ = false;
            string qry_ = "SELECT id FROM lesson_topics WHERE topic = '" + 
                topic_name +"' ";
            string ID_ = SConnect_DB_.GetLastID_(qry_);
            try
            {
                if (Convert.ToInt32(ID_) > 0) { result_ = true; }
            }
            catch { result_ = false; }

            return result_;
        }
        public static void List_(DataGridView dg_)
        {
            string qry_ = "SELECT *" +
                " FROM lesson_topics";

            DataTable tbl_list = new DataTable("list");
            DataSet ds_ = new DataSet();
            ds_.Tables.Add(tbl_list);
            SConnect_DB_.Build_List_(qry_, ds_);

            dg_.DataSource = ds_.Tables["list"];
            dg_.Columns["id"].Visible = false;
            dg_.Columns["topic"].HeaderText = "Название темы урока";

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
        public static void Update_(string topic_, string id_)
        {
            if (ExistLessonTopic(topic_))
            { return; }
                string qryUpdate_ = "UPDATE lesson_topics SET topic='" + topic_ + "' WHERE id=" + id_;
            SConnect_DB_.Query_Execute_(qryUpdate_);
        }

        public static void Insert_(string topic_)
        {
            if (!ExistLessonTopic(topic_))
            {
                string qryInsert_ = "INSERT INTO lesson_topics (topic) VALUES ('" + topic_ + "')";
                SConnect_DB_.Query_Execute_(qryInsert_);
            }
                
        }
        public static void FillComboBox_(ComboBox cb_lesson_topic, int select_id = 0)
        {

            string qry_ = "SELECT id, " +
                " topic AS item " +
                " FROM lesson_topics";
            SConnect_DB_.Build_ComboBox_(qry_, cb_lesson_topic, select_id);
            

        }
    }
}
