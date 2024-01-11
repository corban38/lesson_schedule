using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using schedule_v2.database_;

namespace schedule_v2.data_model_
{
    static class TAttendLesson_
    {        
        public static void Update_(DataRow update_row_)
        {
            string id_ = SConnect_DB_.GetFieldByNameLastID(
                    "SELECT id FROM attending_lessons WHERE lesson_schedule_id = " + update_row_["sch_id"].ToString(),
                    "id");
            if (Convert.ToInt32(id_ )>0)
            {
                string qryUpdate_ = "UPDATE attending_lessons SET " +
                " lesson_schedule_id = " + update_row_["sch_id"].ToString() + ", " +
                " description = '" + update_row_["less_description"].ToString() + "', " +
                " student_id = " + update_row_["stdnt_id"].ToString() + ", " +
                " attended = " + update_row_["is_attended"].ToString() + " " +
                " WHERE  id = " + id_;

            SConnect_DB_.Query_Execute_(qryUpdate_);
            }
            else
            {
                Insert_(update_row_);
            }
            

        }

        public static void Insert_(DataRow insert_row_)
        {
            string qryInsert_ = "INSERT INTO attending_lessons " +
                "(lesson_schedule_id, student_id, attended, description) " +
                " VALUES (" + insert_row_["sch_id"].ToString() + ", " +
                " " + insert_row_["stdnt_id"].ToString() + //"',:attended:)";
                " ," + insert_row_["is_attended"].ToString()+", " +
                " '" + insert_row_["less_description"].ToString()+
                "')";

            SConnect_DB_.Query_Execute_(qryInsert_);

        }
    }
}
