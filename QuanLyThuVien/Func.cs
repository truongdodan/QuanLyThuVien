using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace QuanLyThuVien
{
    class Func
    {
        public string conStr = ConfigurationManager.ConnectionStrings["thuvien"].ConnectionString;
        public SqlConnection sqlCon = new SqlConnection();
        public ErrorProvider er = new ErrorProvider();

        public void connectDB()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                sqlCon.ConnectionString = conStr;
                sqlCon.Open();
            }
            catch
            {
                MessageBox.Show("Mở kết nối đến cơ sở dữ liệu thất bại!", "Thông báo");
                return;
            }

        }

        public DataTable getTable(string tableName)
        {
            using (SqlCommand cmd = sqlCon.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM " + tableName;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

        }

        public void getRecord(string query, DataGridView dgv)
        {
            using (SqlCommand cmd = sqlCon.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;

                }
            }
        }
        public void updateDGVNumber(Label lb, DataGridView dgv)
        {
            int num = dgv.Rows.Count - 1;
            int num2 = dgv.DisplayedRowCount(false);
            int num3 = dgv.RowCount;

            lb.Text = num.ToString();
        }

        public bool queryExecuter(string query) {
            try
            {
                using (SqlCommand cmd = sqlCon.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        //MessageBox.Show(successMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show(failedMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public bool isNull(TextBox tb)
        {
            if (String.IsNullOrEmpty(tb.Text))
            {
                er.SetError(tb, "Không được để trống vùng này!");
                return true;
            }
            else
            {
                er.Clear();
                return false;
            }
        }

        public bool isNumber(TextBox tb)
        {
            if(!int.TryParse(tb.Text, out int n))
            {
                er.SetError(tb, "Đây phải là một số!");
                return false;
                
            }
            else
            {
                er.Clear();
                return true;
            }
        }

        public bool isRecordExist(int recordID, string tablename, string column)
        {
            using (SqlCommand cmd = sqlCon.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT COUNT({column}) FROM {tablename} WHERE {column} = @recordid";

                cmd.Parameters.AddWithValue("@recordID", recordID);

                int re = (int)cmd.ExecuteScalar();

                if (re != 0) { return true; }
                else return false;
            }
        }

        public void updateDGV(DataGridView dgv, string tablename)
        {
            using (SqlCommand cmd = sqlCon.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM {tablename}";

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;

                }
            }
        }
        public bool isItExistInThisRecord(int it, string itsColumn, string tablename, string column, int thisRecord)
        {
            using (SqlCommand cmd = sqlCon.CreateCommand())
            {
                cmd.CommandType= CommandType.Text;
                cmd.CommandText = $"SELECT COUNT({itsColumn}) FROM {tablename} WHERE {column} = {thisRecord} AND {itsColumn} = {it}";

                int re = (int)cmd.ExecuteScalar();

                if (re != 0) { return true; }
                else return false;
            }
        }

        public string getTenNV(int manv)
        {
            string hoten = "";
            using (SqlCommand cmd = sqlCon.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT COUNT(iMaNV) FROM NhanVien WHERE iMaNV = {manv}";

                int ck = cmd.ExecuteNonQuery();

                if (ck != 0)
                {
                    cmd.CommandText = $"SELECT sHoTen FROM NhanVien WHERE iMaNV = {manv}";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hoten = (string)reader.GetValue(0);
                        }
                    }
                    return hoten;
                }
                else
                {
                    return hoten;
                }
            }
        }
    }
}
