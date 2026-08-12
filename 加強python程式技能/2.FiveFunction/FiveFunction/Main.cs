using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeSample1_5Function
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("按任一鍵離開!", "身分證字號不可為空白");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                //宣告:字串變數 ; 並給予內容: MSSQL連線字串
                string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";                    
                //string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                using (SqlConnection sql_Conn = new SqlConnection())   //作了二件事: 使用using ; 宣告以及產生物件
                {
                    sql_Conn.ConnectionString = sql_ConnectionString;                        
                    sql_Conn.Open();   //真正去連線資料庫
                    string strSQL = "select * from AddressBookTbl_1 where chID = '" + txtID.Text.Trim() + "' ";                        
                    using (SqlDataAdapter da = new SqlDataAdapter(strSQL, sql_Conn))   //作了二件事: 使用using ; 宣告以及產生物件
                    {                            
                        DataTable dt = new DataTable();     //宣告以及產生物件                            
                        da.Fill(dt);        //真正去執行da 的 SQL指令
                        if (dt.Rows.Count > 0)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("按任一鍵離開!","此身分證字號已經存在");
                            return;
                        }
                        dt.Rows.Add();
                        dt.Rows[0]["chID"] = txtID.Text.ToString().Trim();
                        dt.Rows[0]["chName"] = txtName.Text.ToString().Trim();
                        dt.Rows[0]["chBirthday"] = txtBirthday.Text.ToString().Trim();
                        dt.Rows[0]["chSex"] = cboSex.Text.ToString().Trim().Substring(0, 1);
                        dt.Rows[0]["chTel"] = txtTel.Text.ToString().Trim();
                        dt.Rows[0]["chAddress"] = txtAddress.Text.ToString().Trim();
                        SqlCommandBuilder builderTemp = new SqlCommandBuilder(da);
                        da.Update(dt);     //更新資料庫
                        txtID.Enabled = false;
                        txtID.ForeColor = System.Drawing.Color.Red;
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("按任一鍵離開!", "新增成功");
                    } //SqlDataAdapter using End
                }     //SqlConnection using End 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("查詢時身分證字號不可為空白" + "\r\n\r\n" + "按任一鍵離開!", "Waring!");
                return;
            }

            string abc = "HHHHHH";
            //abc = "HHHHHH";

            int xyz = 88;
            //xyz = 66;

                string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST; user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                //string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    sql_Conn.ConnectionString = sql_ConnectionString;
                    sql_Conn.Open();
                   
                    string strSQL = "select Top 1 * from AddressBookTbl_1 where chID >= '" + txtID.Text.Trim() + "' ";
                    using (SqlDataAdapter da = new SqlDataAdapter(strSQL, sql_Conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("查無此身分證字號資料" + "\r\n\r\n" + "按任一鍵離開!" , "敬請確認");
                            return;
                        }

                        txtID.Text = dt.Rows[0]["chID"].ToString().Trim();
                        txtName.Text = dt.Rows[0]["chName"].ToString().Trim();
                        txtBirthday.Text = dt.Rows[0]["chBirthday"].ToString().Trim();
                        if (dt.Rows[0]["chSex"].ToString().Trim() == "0")
                            cboSex.SelectedIndex = 0;
                        else if (dt.Rows[0]["chSex"].ToString().Trim() == "1")
                            cboSex.SelectedIndex = 1;
                        else if (dt.Rows[0]["chSex"].ToString().Trim() == "2")
                            cboSex.SelectedIndex = 2;
                        else
                        {
                            cboSex.Text = dt.Rows[0]["chSex"].ToString().Trim();
                        }
                        
                        txtTel.Text = dt.Rows[0]["chTel"].ToString().Trim();
                        txtAddress.Text = dt.Rows[0]["chAddress"].ToString().Trim();

                        txtID.Enabled = false;
                        
                        //txtID.ForeColor = System.Drawing.Color.Red;
                        //txtID.ForeColor = Color.Red;

                    }   //using SqlDataAdapter End
                }       //SqlConnection using End

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtBirthday.Text = "";
            cboSex.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";

            txtID.Enabled = true;
            txtID.ForeColor = System.Drawing.Color.White;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text.ToUpper();
        }



        private void btnModify_Click(object sender, EventArgs e)
        {
            //3.修改功能
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("按任一鍵離開!", "身分證字號不可為空白");
                return;
            }
            if (txtID.Enabled == true)
            {
                MessageBox.Show("按任一鍵離開!", "請先查詢成功後, 才可進行修改存檔作業");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                //string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    sql_Conn.ConnectionString = sql_ConnectionString;
                    sql_Conn.Open();
                   
                    string strSQL = "select * from AddressBookTbl_1 where chID = '" + txtID.Text.Trim() + "' ";
                    using (SqlDataAdapter da = new SqlDataAdapter(strSQL, sql_Conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("按任一鍵離開!", "查無此身分證字號資料");
                            return;
                        }
                        else
                        {
                            dt.Rows[0]["chID"] = txtID.Text.ToString().Trim();
                            dt.Rows[0]["chName"] = txtName.Text.ToString().Trim();
                            dt.Rows[0]["chBirthday"] = txtBirthday.Text.ToString().Trim();
                            dt.Rows[0]["chSex"] = cboSex.Text.ToString().Trim().Substring(0, 1);
                            dt.Rows[0]["chTel"] = txtTel.Text.ToString().Trim();
                            dt.Rows[0]["chAddress"] = txtAddress.Text.ToString().Trim();
                            
                            SqlCommandBuilder builder = new SqlCommandBuilder(da);
                            da.Update(dt);
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("按任一鍵離開!", "修改成功");
                        }


                    }   //using SqlDataAdapter End
                }       //SqlConnection using End
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 4.刪除功能
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("按任一鍵離開!", "身分證字號不可為空白");
                return;
            }
            if (txtID.Enabled == true)
            {
                MessageBox.Show("按任一鍵離開!", "請先查詢成功後, 才可進行刪除作業");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                //string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    sql_Conn.ConnectionString = sql_ConnectionString;
                    sql_Conn.Open();

                    string strSQL = "select * from AddressBookTbl_1 where chID = '" + txtID.Text.Trim() + "' ";
                    using (SqlDataAdapter da = new SqlDataAdapter(strSQL, sql_Conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("按任一鍵離開!", "查無此身分證字號資料");
                            return;
                        }
                        else
                        {
                            txtID.Text = dt.Rows[0]["chID"].ToString().Trim();
                            txtName.Text = dt.Rows[0]["chName"].ToString().Trim();
                            txtBirthday.Text = dt.Rows[0]["chBirthday"].ToString().Trim();
                            cboSex.Text = dt.Rows[0]["chSex"].ToString().Trim();
                            txtTel.Text = dt.Rows[0]["chTel"].ToString().Trim();
                            txtAddress.Text = dt.Rows[0]["chAddress"].ToString().Trim();

                            DialogResult myResult = MessageBox.Show("確定要刪除此筆資料?", "敬請再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (myResult == DialogResult.Yes)
                            {
                                dt.Rows[0].Delete();
                                SqlCommandBuilder builderTemp = new SqlCommandBuilder(da);
                                da.Update(dt);     //更新資料庫

                                this.Cursor = Cursors.Default;
                                MessageBox.Show("按任一鍵離開!", "刪除成功");
                                btnClear_Click(null, null);
                            }
                            else
                            {
                                this.Cursor = Cursors.Default;
                            }
                        }

                    }   //using SqlDataAdapter End
                }       //SqlConnection using End
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModify2_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("按任一鍵離開!", "身分證字號不可為空白");
                return;
            }
            if (txtID.Enabled == true)
            {
                MessageBox.Show("按任一鍵離開!", "請先查詢成功後, 才可進行修改存檔作業");
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                //string sql_ConnectionString = @"data source=localhost\SQLEXPRESS;initial catalog=DB_TEST;user id=Exc;password=Excpwd;MultipleActiveResultSets=true";
                using (SqlConnection sql_Conn = new SqlConnection())
                {
                    sql_Conn.ConnectionString = sql_ConnectionString;
                    sql_Conn.Open();

                    string strSQL = "select * from AddressBookTbl_1 where chID = '" + txtID.Text.Trim() + "' ";
                    using (SqlDataAdapter da = new SqlDataAdapter(strSQL, sql_Conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("按任一鍵離開!", "查無此身分證字號資料");
                            return;
                        }
                        else
                        {
                            //dt.Rows[0]["chID"] = txtID.Text.ToString().Trim();
                            //dt.Rows[0]["chName"] = txtName.Text.ToString().Trim();
                            //dt.Rows[0]["chBirthday"] = txtBirthday.Text.ToString().Trim();
                            //dt.Rows[0]["chSex"] = cboSex.Text.ToString().Trim();
                            //dt.Rows[0]["chTel"] = txtTel.Text.ToString().Trim();
                            //dt.Rows[0]["chAddress"] = txtAddress.Text.ToString().Trim();

                            //SqlCommandBuilder builder = new SqlCommandBuilder(da);
                            //da.Update(dt);

                            SqlCommand cmdUpdateData = new SqlCommand(@"update AddressBookTbl_1 set chName = @chName,chBirthday=@chBirthday,chSex=@chSex,chTel=@chTel,chAddress=@chAddress  
                                                                                where chID='" + txtID.Text.Trim() + "'", sql_Conn);
                            cmdUpdateData.Parameters.Add("@chName", SqlDbType.Char, 20).Value = txtName.Text.Trim();
                            cmdUpdateData.Parameters.Add("@chBirthday", SqlDbType.Char, 7).Value = txtBirthday.Text.Trim();
                            cmdUpdateData.Parameters.Add("@chSex", SqlDbType.Char, 1).Value = cboSex.Text.ToString().Trim().Substring(0, 1);
                            cmdUpdateData.Parameters.Add("@chTel", SqlDbType.Char, 20).Value = txtTel.Text.Trim();
                            cmdUpdateData.Parameters.Add("@chAddress", SqlDbType.Char, 100).Value = txtAddress.Text.Trim();
                            cmdUpdateData.ExecuteNonQuery();

                            this.Cursor = Cursors.Default;
                            MessageBox.Show("按任一鍵離開!", "修改成功");
                        }


                    }   //using SqlDataAdapter End
                }       //SqlConnection using End
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }




            //            MessageBox.Show("存檔成功!");
        }

        private void txtBirthday_TextChanged(object sender, EventArgs e)
        {

        }



        private void Main_Activated(object sender, EventArgs e)
        {
            cboSex.Items.Add("0.女");
            cboSex.Items.Add("1.男");
            cboSex.Items.Add("2.中性");
            cboSex.Items.Add("3.變性女");
            cboSex.Items.Add("4.變性男");
        }
    }
}
