using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace schedule_v2.database_
{
    static class SConnect_DB_
    {
        public enum DB_Tables_
        {
            lesson_schedule,
            lessons,
            lesson_topics,
            students,
            payments
        }
        public enum DB_Mode_
        {
            insert_,
            update_,
            delete_
        }
        public static DB_Tables_ current_table_;
        public static DB_Mode_ current_mode_;
        public static DataRow current_row_;
        public static string db_connection_string_;

        public static void SetForeColor_(DataRow row,string color_name)
        {
            if (current_table_ != DB_Tables_.lesson_schedule) { return ; }
            string qry = "SELECT id FROM colors WHERE color_name = '"+color_name+"' ";
            string id_color = GetFieldByNameLastID(qry, "id");
            if (id_color == null) {
                Query_Execute_("INSERT INTO colors (color_name) VALUES('"+color_name+"') ");
                id_color = GetLastID_("SELECT id FROM colors WHERE color_name ='" + color_name + "' ");
            }
            Query_Execute_("UPDATE lesson_schedule SET  color = " + id_color+" WHERE id = "+row["sch_id"].ToString());
        }
        public static Color GetForeColor_(int idx_color = 0)
        {
            
            Color f_color = Color.Black; 
            string qry_ = "SELECT color_name" +
                " FROM colors" +
                " WHERE id = "+idx_color.ToString();
            using (OleDbConnection con_ = new OleDbConnection(db_connection_string_))
            {
                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand cmd_ = new OleDbCommand(qry_, con_);
                try
                {
                    con_.Open();
                    OleDbDataReader myDataReader = cmd_.ExecuteReader();
                    if (myDataReader.HasRows) // если есть строки
                    {
                        // Читаем первую (в нашем случае - и единственную) строку ответа базы данных с помощью метода Read() объекта OleDbDataReader
                        myDataReader.Read(); //считывает следующую строку в полученном наборе
                        try
                        {
                            f_color = Color.FromName(Convert.ToString(myDataReader["color_name"]));
                        }
                        catch
                        {
                            f_color = Color.Yellow;
                        }
                        
                        
                    }
                    myDataReader.Close();
                }
                catch
                {
                    // обработка исключения
                }
            }
            return f_color;
        } 
        public static int Query_Execute_(string qry_)
        {
            int rec_affected = 0;
            using (OleDbConnection con_ = new OleDbConnection(db_connection_string_))
            {
                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand cmd_ = new OleDbCommand(qry_, con_);
                try
                {
                    con_.Open();
                    // выполняем запрос к MS Access
                    rec_affected = cmd_.ExecuteNonQuery();
                }
                catch
                {
                    // обработка исключения
                }
            }

            return rec_affected;// возвращает количество измененных строк
        }

        public static void Build_ComboBox_(string qry_, ComboBox cb_, int select_id = 0)
        {
            using (OleDbConnection con_ = new OleDbConnection(db_connection_string_))
            {
                OleDbDataAdapter da_ = new OleDbDataAdapter(qry_, con_);
                DataSet ds_ = new DataSet("items_list");
                con_.Open();
                da_.Fill(ds_, "items_list");
                cb_.ValueMember = "id";
                cb_.DisplayMember = "item";
                cb_.DataSource = ds_.Tables["items_list"];
                if (select_id > 0) { cb_.SelectedValue = select_id; }
                
            }
                
        }

        public async static Task BuildList_Async(string qry_, DataSet ds_)
        {
            await Task.Run(() => Build_List_(qry_, ds_));
        }
        public static void Build_List_(string qry_, DataSet ds_)
        {
            using (OleDbConnection con_ = new OleDbConnection(db_connection_string_)) 
            {
                OleDbDataAdapter da_ = new OleDbDataAdapter(qry_, con_);
                con_.Open();
                da_.Fill(ds_, "list");                
                
            }
        }

        public static void FillTable_BuildList_(string qry_, DataTable tbl_)
        {
            DataTable table_ = tbl_;
            using (OleDbConnection con_ = new OleDbConnection(db_connection_string_))
            {
                OleDbCommand myCommand = con_.CreateCommand();
                myCommand.CommandText = qry_;
                con_.Open();
                OleDbDataReader myDataReader = myCommand.ExecuteReader();
                if (myDataReader.HasRows) // если есть строки
                {
                    while (myDataReader.Read())
                    {
                        DataRow row_ = table_.NewRow();
                        foreach(DataColumn c in table_.Columns)
                        {
                            row_[c.ColumnName] = myDataReader[c.ColumnName];
                        }
                        table_.Rows.Add(row_);
                    }                       
                    
                }
                myDataReader.Close();

            }

            
        }
        public static string GetLastID_(string qry_)
        {            
            OleDbConnection myConnection = new OleDbConnection(db_connection_string_);
            // создаем объект OleDbCommand
            OleDbCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = qry_;
            myConnection.Open();
            object last_id = myCommand.ExecuteScalar();
            myConnection.Close();
            return Convert.ToString(last_id); ;
        }

        public static string GetFieldByNameLastID(string query_, string field_)
        {
            string result_ = null;
            OleDbConnection myConnection = new OleDbConnection(db_connection_string_);
            // создаем объект OleDbCommand
            OleDbCommand myCommand = myConnection.CreateCommand();
            myCommand.CommandText = query_;
            myConnection.Open();
            OleDbDataReader myDataReader = myCommand.ExecuteReader();
            if (myDataReader.HasRows) // если есть строки
            {
                // Читаем первую (в нашем случае - и единственную) строку ответа базы данных с помощью метода Read() объекта OleDbDataReader
                myDataReader.Read(); //считывает следующую строку в полученном наборе
                result_ = Convert.ToString(myDataReader[field_]);
            }
            myDataReader.Close();
            myConnection.Close();
            return result_;
        }

    }
}
