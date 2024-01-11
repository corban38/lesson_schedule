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
    class TPayment_
    {
        public static void Update_(DataRow update_row_)
        {
            string qry_ = "UPDATE payments SET " +
                " payment_date = '" + update_row_["date_"].ToString() + "', " +
                " amount = '" + update_row_["amount_"].ToString() + "', " +
                " description = '" + update_row_["description_"].ToString() + "', " +
                " student_id = " + update_row_["stdnt_id"].ToString() +
                " WHERE id = " + update_row_["id_"].ToString();
            SConnect_DB_.Query_Execute_(qry_);
        }

        public static void Insert_(DataRow insert_row_)
        {
            string qry_ = "INSERT INTO payments " +
                " (payment_date, amount, description, student_id) " +
                " VALUES ('" + insert_row_["date_"].ToString() + "', " +
                " '" + insert_row_["amount_"].ToString() + "', " +
                " '" + insert_row_["description_"].ToString() + "', " +
                insert_row_["stdnt_id"].ToString() + ")";
            SConnect_DB_.Query_Execute_(qry_);
        }
        public static void List_(DataGridView dg_)
        {           
            string qry_ = "SELECT " +
                " payments.id AS id_," +
                " payments.payment_date AS date_," +
                " payments.amount AS amount_," +
                " (students.first_name+' '+students.last_name) AS full_name, " +
                " payments.description AS description_, " +
                " payments.student_id AS stdnt_id" +

                " FROM payments LEFT JOIN students ON payments.student_id = students.id";
         
            if (SConnect_DB_.current_table_ == SConnect_DB_.DB_Tables_.students)
            {
                qry_ += " WHERE payments.student_id = " + SConnect_DB_.current_row_["id"].ToString();
            } 
                
            
           DataTable tbl_list = new DataTable("list");
            DataSet ds_ = new DataSet();
            ds_.Tables.Add(tbl_list);
            SConnect_DB_.Build_List_(qry_, ds_);

            dg_.DataSource = ds_.Tables["list"];
            dg_.Columns["id_"].Visible = false;
            dg_.Columns["id_"].ValueType = typeof(int);
            dg_.Columns["stdnt_id"].Visible = false;
            dg_.Columns["stdnt_id"].ValueType = typeof(int);
            dg_.Columns["date_"].HeaderText = "Дата";
            dg_.Columns["date_"].ValueType = typeof(DateTime);
            dg_.Columns["date_"].DefaultCellStyle.Alignment =
                                       DataGridViewContentAlignment.MiddleCenter;
            dg_.Columns["date_"].Width = 90;
            dg_.Columns["amount_"].HeaderText = "Сумма";
            dg_.Columns["amount_"].ValueType = typeof(decimal);
            dg_.Columns["amount_"].DefaultCellStyle.Format = "c";
            // выравнивание в ячейках
            dg_.Columns["amount_"].DefaultCellStyle.Alignment =
                                        DataGridViewContentAlignment.MiddleRight;
            dg_.Columns["amount_"].Width = 90;
            dg_.Columns["full_name"].HeaderText = "Ученик";
            dg_.Columns["description_"].HeaderText = "Комментарии";
            

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
    }
}
