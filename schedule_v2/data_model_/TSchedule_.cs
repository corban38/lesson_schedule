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
    static class TSchedule_
    {
        public static string schedule_date_ = null;
        public static string schedule_less_id_ = null;
        public static string schedule_less_tpc_id_ = null;
        public static string schedule_stdnt_id_ = null;
        public static string schedule_descr__ = null;
        public static string schedule_id_ = null;
        static int Day_Of_Week(string date_)
        {            
            DateTime _date_ = Convert.ToDateTime(date_);

            return ((int)_date_.DayOfWeek) == 0 ? 7 : (int)_date_.DayOfWeek;
        }

        static int EmptyLessons_(string date_) //есть ли такая дата в расписании с пустыми уроками, если есть то вернуть id
        {
            int sch_id = 0;
            string qryEmpty_Lesson = "SELECT *" +
                "FROM  lesson_schedule " +
                " WHERE (FORMAT(lesson_date,'DD.MM.YYYY') = '" + date_ + "') AND (ISNULL(lesson_id) OR  lesson_id=0)";
            try
            {
                sch_id = Convert.ToInt32(SConnect_DB_.GetLastID_(qryEmpty_Lesson));
            }
            
            catch
            {

            }
            return sch_id;
        }
        async public static Task List_Async (DataGridViewEx_ dg)
        {
            await Task.Run(() => List_(dg));
        }
        public async static void List_(DataGridViewEx_ dgrid)

        {
            DataGridViewEx_ dg_ = dgrid;
            dg_.Columns.Clear();
            string qry_ = "SELECT " +
                " lesson_schedule.id AS sch_id, " +
                " lesson_schedule.lesson_id AS less_id, " +
                " lesson_schedule.student_id AS stdnt_id, " +
                " lesson_schedule.lesson_topic_id AS less_tpc_id," +
                " IIF(ISNULL(attending_lessons.attended),false,attending_lessons.attended) AS is_attended, " +
                " IIF(ISNULL(lesson_schedule.payed),false,lesson_schedule.payed) AS is_payed, " +
                " FORMAT(lesson_schedule.lesson_date, 'DD.MM.YYYY') AS date_, " +
                " days_of_week.day_of_week AS day_week, " +
                " (IIF(ISNULL(lessons.start_time),'',(FORMAT(lessons.start_time,'hh:mm')+' - ')))+ " +
                " (IIF(ISNULL(lessons.end_time),'',FORMAT(lessons.end_time,'hh:mm'))) AS less_time, " +
                " IIF(ISNULL(lesson_topics.topic),' < тема не указана > ',lesson_topics.topic) AS less_topic, " +
                " (students.first_name+' '+IIF(ISNULL(students.last_name), '', students.last_name)) AS student_full_name, " +
                
                " IIF(IIF(ISNULL(attending_lessons.attended),false,attending_lessons.attended),'Да','Нет') AS less_attended," +
                " IIF(IIF(ISNULL(lesson_schedule.payed),false,lesson_schedule.payed),'Да','Нет') AS less_payed," +
                " attending_lessons.description AS less_description, " +
                " lesson_schedule.color AS color " +
                " FROM ((((lesson_schedule LEFT OUTER JOIN students ON lesson_schedule.student_id = students.id) " +
                " LEFT OUTER JOIN days_of_week ON lesson_schedule.day_of_week_id = days_of_week.id)" +
                " LEFT OUTER JOIN lesson_topics ON lesson_schedule.lesson_topic_id = lesson_topics.id)" +
                " LEFT OUTER JOIN lessons ON lesson_schedule.lesson_id = lessons.id)" +
                " LEFT OUTER JOIN attending_lessons ON attending_lessons.lesson_schedule_id = lesson_schedule.id" +
                " WHERE (lesson_schedule.lesson_date >= DATEVALUE('" + SDate_.date_start.ToShortDateString()+"')) " +
                " AND (lesson_schedule.lesson_date <= DATEVALUE('" + SDate_.date_end.ToShortDateString() + "')) " +
                " ORDER BY lesson_schedule.lesson_date, lessons.start_time;";
            DataTable tbl_list = new DataTable("list");
            // Define one column.
            DataColumn col_sch_id = new DataColumn("sch_id", typeof(int));
            tbl_list.Columns.Add(col_sch_id);
            DataColumn col_less_id = new DataColumn("less_id", typeof(int));
            tbl_list.Columns.Add(col_less_id);
            DataColumn col_stdnt_id = new DataColumn("stdnt_id", typeof(int));
            tbl_list.Columns.Add(col_stdnt_id);
            DataColumn col_less_tpc_id = new DataColumn("less_tpc_id", typeof(int));
            tbl_list.Columns.Add(col_less_tpc_id);
            DataColumn col_is_attended = new DataColumn("is_attended", typeof(bool));
            tbl_list.Columns.Add(col_is_attended);
            DataColumn col_is_payed = new DataColumn("is_payed", typeof(bool));
            tbl_list.Columns.Add(col_is_payed);
            DataColumn colDate = new DataColumn("date_", typeof(DateTime));
            tbl_list.Columns.Add(colDate);
            DataColumn colDayWeek = new DataColumn("day_week", typeof(String));
            tbl_list.Columns.Add(colDayWeek);
            DataColumn colLessTime = new DataColumn("less_time", typeof(String));
            tbl_list.Columns.Add(colLessTime);
            DataColumn col_less_topic = new DataColumn("less_topic", typeof(String));
            tbl_list.Columns.Add(col_less_topic);
            DataColumn col_student_full_name = new DataColumn("student_full_name", typeof(String));
            tbl_list.Columns.Add(col_student_full_name);
            DataColumn col_less_attended = new DataColumn("less_attended", typeof(String));
            tbl_list.Columns.Add(col_less_attended);
            DataColumn col_less_payed = new DataColumn("less_payed", typeof(String));
            tbl_list.Columns.Add(col_less_payed);
            DataColumn col_less_description = new DataColumn("less_description", typeof(String));
            tbl_list.Columns.Add(col_less_description);
            DataColumn col_color = new DataColumn("color", typeof(int));
            tbl_list.Columns.Add(col_color);
            // Set the col_sch_id column as the primary key.
            tbl_list.PrimaryKey = new DataColumn[] { col_sch_id };

        //    SConnect_DB_.FillTable_BuildList_(qry_, tbl_list);
            DataSet ds_ = new DataSet();
            ds_.Tables.Add(tbl_list);



            await SConnect_DB_.BuildList_Async(qry_, ds_);
            
            

            dg_.DataSource = ds_.Tables["list"];
            //dg_.DataSource = tbl_list;
            dg_.Columns["sch_id"].Visible = false;
          
            dg_.Columns["less_id"].Visible = false;
          
            dg_.Columns["stdnt_id"].Visible = false;
         
            dg_.Columns["less_tpc_id"].Visible = false;
         
            dg_.Columns["is_attended"].Visible = false;
         
            dg_.Columns["is_payed"].Visible = false;
            dg_.Columns["color"].Visible = false;

            dg_.Columns["student_full_name"].HeaderText = "Ученик";
            dg_.Columns["date_"].HeaderText = "Дата";
            dg_.Columns["date_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["date_"].Width = 90;
            dg_.Columns["date_"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["date_"].Tag = 101;
            // формат для столбца отображения даты 
            dg_.Columns["date_"].DefaultCellStyle.Format = "d";
            dg_.Columns["date_"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_.Columns["day_week"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["day_week"].Width = 100;
            dg_.Columns["day_week"].HeaderText = "День недели";
            
            dg_.Columns["day_week"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["day_week"].Tag = 101;

            dg_.Columns["less_time"].HeaderText = "Время";
            dg_.Columns["less_time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["less_time"].Width = 100;
            dg_.Columns["less_time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["less_time"].Tag = 101;
            dg_.Columns["less_topic"].HeaderText = "Тема урока";
            dg_.Columns["less_topic"].Tag = 101;
            
            dg_.Columns["less_attended"].HeaderText = "Проведён";
            dg_.Columns["less_attended"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["less_attended"].Width = 75;
            dg_.Columns["less_attended"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["less_payed"].HeaderText = "Оплачен";
            dg_.Columns["less_payed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["less_payed"].Width = 75;
            dg_.Columns["less_payed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_.Columns["less_description"].HeaderText = "Комментарии";
            //dg_.Tag = "schedule";

            int col_idx = dg_.Columns["date_"].Index;
            dg_.Sort(dg_.Columns[col_idx], System.ComponentModel.ListSortDirection.Descending);


            if (dg_.RowCount > 0)
            {
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

        public static void ListForStudent_(DataGridView dg_)
        {
            string qry_ = "SELECT " +
                " lesson_schedule.id AS sch_id, " +
                " lesson_schedule.lesson_id AS less_id, " +
                " lesson_schedule.student_id AS stdnt_id, " +
                " lesson_schedule.lesson_topic_id AS less_tpc_id," +
                " IIF(ISNULL(attending_lessons.attended),false,attending_lessons.attended) AS is_attended, " +
                " IIF(ISNULL(lesson_schedule.payed),false,lesson_schedule.payed) AS is_payed, " +
                " FORMAT(lesson_schedule.lesson_date, 'DD.MM.YYYY') AS date_, " +
                " days_of_week.day_of_week AS day_week, " +
                " (IIF(ISNULL(lessons.start_time),'',(FORMAT(lessons.start_time,'hh:mm')+' - ')))+ " +
                " (IIF(ISNULL(lessons.end_time),'',FORMAT(lessons.end_time,'hh:mm'))) AS less_time, " +
                " IIF(ISNULL(lesson_topics.topic),' < тема не указана > ',lesson_topics.topic) AS less_topic, " +
             //   " (students.first_name+' '+IIF(ISNULL(students.last_name), '', students.last_name)) AS student_full_name, " +

                " IIF(IIF(ISNULL(attending_lessons.attended),false,attending_lessons.attended),'Да','Нет') AS less_attended," +
                " IIF(IIF(ISNULL(lesson_schedule.payed),false,lesson_schedule.payed),'Да','Нет') AS less_payed," +
                " attending_lessons.description AS less_description, " +
                " lesson_schedule.color AS color " +
                " FROM ((((lesson_schedule LEFT OUTER JOIN students ON lesson_schedule.student_id = students.id) " +
                " LEFT OUTER JOIN days_of_week ON lesson_schedule.day_of_week_id = days_of_week.id)" +
                " LEFT OUTER JOIN lesson_topics ON lesson_schedule.lesson_topic_id = lesson_topics.id)" +
                " LEFT OUTER JOIN lessons ON lesson_schedule.lesson_id = lessons.id)" +
                " LEFT OUTER JOIN attending_lessons ON attending_lessons.lesson_schedule_id = lesson_schedule.id " +
                " WHERE lesson_schedule.student_id = " + SConnect_DB_.current_row_["id"].ToString()+
                " ORDER BY lesson_schedule.lesson_date, lessons.start_time;";

            DataTable tbl_list = new DataTable("list");
            // Define one column.
            DataColumn col_sch_id = new DataColumn("sch_id", typeof(int));
            tbl_list.Columns.Add(col_sch_id);
            DataColumn col_less_id = new DataColumn("less_id", typeof(int));
            tbl_list.Columns.Add(col_less_id);
            DataColumn col_stdnt_id = new DataColumn("stdnt_id", typeof(int));
            tbl_list.Columns.Add(col_stdnt_id);
            DataColumn col_less_tpc_id = new DataColumn("less_tpc_id", typeof(int));
            tbl_list.Columns.Add(col_less_tpc_id);
            DataColumn col_is_attended = new DataColumn("is_attended", typeof(bool));
            tbl_list.Columns.Add(col_is_attended);
            DataColumn col_is_payed = new DataColumn("is_payed", typeof(bool));
            tbl_list.Columns.Add(col_is_payed);
            DataColumn colDate = new DataColumn("date_", typeof(DateTime));
            tbl_list.Columns.Add(colDate);
            DataColumn colDayWeek = new DataColumn("day_week", typeof(String));
            tbl_list.Columns.Add(colDayWeek);
            DataColumn colLessTime = new DataColumn("less_time", typeof(String));
            tbl_list.Columns.Add(colLessTime);
            DataColumn col_less_topic = new DataColumn("less_topic", typeof(String));
            tbl_list.Columns.Add(col_less_topic);
            DataColumn col_less_attended = new DataColumn("less_attended", typeof(String));
            tbl_list.Columns.Add(col_less_attended);
            DataColumn col_less_payed = new DataColumn("less_payed", typeof(String));
            tbl_list.Columns.Add(col_less_payed);
            DataColumn col_less_description = new DataColumn("less_description", typeof(String));
            tbl_list.Columns.Add(col_less_description);
            DataColumn col_color = new DataColumn("color", typeof(int));
            tbl_list.Columns.Add(col_color);
            // Set the OrderId column as the primary key.
            tbl_list.PrimaryKey = new DataColumn[] { col_sch_id };

            DataSet ds_ = new DataSet();
            ds_.Tables.Add(tbl_list);
                
            SConnect_DB_.Build_List_(qry_, ds_);

            dg_.Columns.Clear();
            dg_.DataSource = ds_.Tables["list"];
            dg_.Columns["sch_id"].Visible = false;         
            dg_.Columns["less_id"].Visible = false;         
            dg_.Columns["stdnt_id"].Visible = false;         
            dg_.Columns["less_tpc_id"].Visible = false;         
            dg_.Columns["is_attended"].Visible = false;         
            dg_.Columns["is_payed"].Visible = false;
            dg_.Columns["color"].Visible = false;

            dg_.Columns["date_"].HeaderText = "Дата";
            dg_.Columns["date_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["date_"].Width = 90;
            dg_.Columns["date_"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["date_"].Tag = 101;
            // формат для столбца отображения даты 
            dg_.Columns["date_"].DefaultCellStyle.Format = "d";
            dg_.Columns["date_"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_.Columns["day_week"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["day_week"].Width = 100;
            dg_.Columns["day_week"].HeaderText = "День недели";

            dg_.Columns["day_week"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dg_.Columns["day_week"].Tag = 101;

            dg_.Columns["less_time"].HeaderText = "Время";
            dg_.Columns["less_time"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["less_time"].Width = 100;
            dg_.Columns["less_time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["less_time"].Tag = 101;
            dg_.Columns["less_topic"].HeaderText = "Тема урока";
            dg_.Columns["less_topic"].Tag = 101;

            dg_.Columns["less_attended"].HeaderText = "Проведён";
            dg_.Columns["less_attended"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["less_attended"].Width = 75;
            dg_.Columns["less_attended"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["less_payed"].HeaderText = "Оплачен";
            dg_.Columns["less_payed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dg_.Columns["less_payed"].Width = 75;
            dg_.Columns["less_payed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dg_.Columns["less_description"].HeaderText = "Комментарии";
            

            int col_idx = dg_.Columns["date_"].Index;
            dg_.Sort(dg_.Columns[col_idx], System.ComponentModel.ListSortDirection.Descending);


            if (dg_.RowCount > 0)
            {
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

        public static void Lesson_Update_(DataRow update_row_)
        {
            string day_ = Convert.ToString(Day_Of_Week(update_row_["date_"].ToString())) ;
            string qryUpdate = "UPDATE lesson_schedule SET " +
                " lesson_date = ':lesson_date:'," +
                " day_of_week_id = "+day_+"," +
                " lesson_id = :lesson_id:, " +
                " lesson_topic_id = :topic_id:, " +
                " student_id = :student_id:," +
                " lesson_schedule.payed = "+ update_row_["is_payed"].ToString() +
                
                " WHERE id = "+ update_row_["sch_id"].ToString();

            qryUpdate = qryUpdate.Replace(":lesson_date:", update_row_["date_"].ToString());
            
            qryUpdate = qryUpdate.Replace(":topic_id:", update_row_["less_tpc_id"].ToString());
            qryUpdate = qryUpdate.Replace(":lesson_id:", update_row_["less_id"].ToString());
            qryUpdate = qryUpdate.Replace(":student_id:", update_row_["stdnt_id"].ToString());
            qryUpdate = qryUpdate.Replace(":sch_id:", update_row_["sch_id"].ToString());

            SConnect_DB_.Query_Execute_(qryUpdate);
        }

        public static int Lesson_Insert_(DataRow row_insert_)
        {
            int schedule_id = EmptyLessons_(Convert.ToString(row_insert_["date_"]));

            if (schedule_id> 0)
            {
                row_insert_["sch_id"] = schedule_id;
                Lesson_Update_(row_insert_);
            }
            else
            {
                string day_ = Convert.ToString(Day_Of_Week(Convert.ToString(row_insert_["date_"]))); // получим порядковый номер дня недели
                // текст запроса к БД на вставку урока в расписание
                string qryInsert_ = "INSERT INTO lesson_schedule " +
               " (lesson_date, day_of_week_id, " +
               " lesson_topic_id, lesson_id, student_id," +
               " payed)" +
               " VALUES (':date:', :day_of_week_id:, :topic_id:,:lesson_id:,:student_id:," +
               " "+ row_insert_["is_payed"].ToString()+")";
                qryInsert_ = qryInsert_.Replace(":date:", Convert.ToString(row_insert_["date_"]));
                qryInsert_ = qryInsert_.Replace(":day_of_week_id:", day_);
                qryInsert_ = qryInsert_.Replace(":topic_id:", Convert.ToString(row_insert_["less_tpc_id"]));
                qryInsert_ = qryInsert_.Replace(":lesson_id:", Convert.ToString(row_insert_["less_id"]));
                qryInsert_ = qryInsert_.Replace(":student_id:", Convert.ToString(row_insert_["stdnt_id"]));
                SConnect_DB_.Query_Execute_(qryInsert_);
                                
                schedule_id = Convert.ToInt32(SConnect_DB_.GetLastID_("SELECT MAX(id) AS last_id FROM lesson_schedule;"));
                
            }
            return schedule_id;
        }

        public static void Lesson_Delete(DataRow row_delete_)
        {
            string qry_ = "DELETE * FROM lesson_schedule WHERE id = "+row_delete_["sch_id"];
            SConnect_DB_.Query_Execute_(qry_);
        }
    }
}
