using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace hrtest
{
    public partial class UC_data_interview : UserControl
    {
        public event EventHandler deleteclick;

        protected void ondeleteclick(EventArgs e)
        {
            deleteclick?.Invoke(this, e);
        }

        public UC_data_interview()
        {
            InitializeComponent();
        }

        private void btn_profile_birthday_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                tb_profile_birthday.Text = calander.Calandervalue;
            }
        }

        private void btn_profile_interviewdate_Click(object sender, EventArgs e)
        {
            data.frm_data_calander calander = new data.frm_data_calander();

            if (calander.ShowDialog() == DialogResult.OK)
            {
                tb_profile_interviewdate.Text = calander.Calandervalue;
            }
        }

        private void btn_project_create_Click(object sender, EventArgs e)
        {
            if (tlp_project_list.RowCount > 1)
            {
                tlp_project_list.RowCount = tlp_project_list.RowCount + 1;
            }
            UC_data_project uC_Data_Project = new UC_data_project();
            tlp_project_list.Controls.Add(uC_Data_Project, 1, 0);
            uC_Data_Project.deleteclick += UC_Data_Project_deleteclick;
        }

        private void UC_Data_Project_deleteclick(object sender, EventArgs e)
        {
            UC_data_project uC_Data_Project = sender as UC_data_project;
            tlp_project_list.Controls.Remove(uC_Data_Project);
            tlp_project_list.RowCount -= 1;
        }

        private void btn_profile_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要刪除資料", "警告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ondeleteclick(e);
            }
        }

        private void btn_profile_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "upload...",
                Filter = @"All image files|*.jpg;",
                Multiselect = false,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_profile_profileimg.ImageLocation = ofd.FileName;
            }
        }

        private void btn_profile_OK_Click(object sender, EventArgs e)
        {
            string id;
            lb_project_lastpdatetimetm.Text = DateTime.Now.ToString();
            try
            {
                SqlConnection con = new SqlConnection(SqlLink.linkmethod());
                con.Open();
                SqlTransaction sqltr;
                sqltr = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand(SqlInsert.ProfileInsertmethod(), con);
                cmd.Transaction = sqltr;
                try
                {
                    cmd.Parameters.Add("@Jobname", SqlDbType.NChar).Value = tb_profile_jobname.Text;
                    cmd.Parameters.Add("@InterviewDate", SqlDbType.DateTime).Value = tb_profile_interviewdate.Text;
                    cmd.Parameters.Add("@Name", SqlDbType.NChar).Value = tb_profile_name.Text;
                    cmd.Parameters.Add("@sex", SqlDbType.NChar).Value = cb_profile_sex.Text;
                    cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = DBNull.Value; //tb_profile_birthday.Text;
                    cmd.Parameters.Add("@Marriage", SqlDbType.NChar).Value = cb_profile_marriage.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NChar).Value = tb_profile_email.Text;
                    cmd.Parameters.Add("@Mobile", SqlDbType.Int).Value = DBNull.Value;//tb_profile_mobile.Text;
                    cmd.Parameters.Add("@Address", SqlDbType.NChar).Value = tb_profile_address.Text;
                    cmd.Parameters.Add("@Contector", SqlDbType.NChar).Value = tb_profile_contactor.Text;
                    cmd.Parameters.Add("@ContectorRelationship", SqlDbType.NChar).Value = tb_profile_contactorrelation.Text;
                    cmd.Parameters.Add("@ContectorMobile", SqlDbType.Int).Value = DBNull.Value;//tb_profile_contactormobile.Text;
                    cmd.Parameters.Add("@StillStudy", SqlDbType.NChar).Value = tb_profile_stillstudy.Text;
                    cmd.Parameters.Add("@FriendInCompany", SqlDbType.NChar).Value = tb_profile_friendincompany.Text;
                    cmd.Parameters.Add("@FriednRelationship", SqlDbType.NChar).Value = tb_profile_friendrelationship.Text;
                    cmd.Parameters.Add("@FriendName", SqlDbType.NChar).Value = tb_profile_friendname.Text;
                    cmd.Parameters.Add("@CareInwork", SqlDbType.NChar).Value = tb_profile_careinwork.Text;
                    cmd.Parameters.Add("@WishSalary", SqlDbType.Int).Value = DBNull.Value;//tb_profile_wishslalry.Text;
                    cmd.Parameters.Add("@RegistDate", SqlDbType.DateTime).Value = DBNull.Value;//tb_profile_registdate.Text;
                    cmd.Parameters.Add("@Advanage", SqlDbType.NChar).Value = tb_profile_advantage.Text;
                    cmd.Parameters.Add("@Disadvantage", SqlDbType.NChar).Value = tb_profile_disadvantage.Text;
                    cmd.Parameters.Add("@FirstInIs", SqlDbType.NChar).Value = tb_profile_firstinis.Text;
                    cmd.Parameters.Add("@FutureHope", SqlDbType.NChar).Value = tb_profile_futurehope.Text;
                    cmd.Parameters.Add("@MindManager", SqlDbType.NChar).Value = tb_profile_mindmanager.Text;
                    cmd.Parameters.Add("@PromiseFromIs", SqlDbType.NChar).Value = tb_profile_PromiseFromIs.Text;
                    cmd.Parameters.Add("@ShowYourSelf", SqlDbType.VarChar).Value = tb_profile_ShowYourSelf.Text;
                    cmd.Parameters.Add("@Armydate", SqlDbType.NChar).Value = tb_profile_armyitem.Text;
                    cmd.Parameters.Add("@NonArmyReason", SqlDbType.NChar).Value = tb_profile_NonArmyReason.Text;
                    cmd.Parameters.Add("@Img", SqlDbType.NChar).Value = DBNull.Value; //pb_profile_profileimg.Location;
                    cmd.Parameters.Add("@LastUpdatetime", SqlDbType.Date).Value = DateTime.Now;
                    id = cmd.ExecuteScalar().ToString();
                    //education add
                    cmd.CommandText = SqlInsert.EducationInsertmethod();
                    try
                    {
                        foreach (DataGridViewRow dr in dgv_profile_graduate.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@SchoolName", SqlDbType.NChar).Value = dr.Cells["SchoolName"].ToString();
                            cmd.Parameters.Add("@Department", SqlDbType.NChar).Value = dr.Cells["Department"].ToString();
                            cmd.Parameters.Add("@DateStart", SqlDbType.NChar).Value = dr.Cells["DateStart"].ToString();
                            cmd.Parameters.Add("@DateEnd", SqlDbType.NChar).Value = dr.Cells["DateEnd"].ToString();
                            cmd.Parameters.Add("@Graduate", SqlDbType.NChar).Value = dr.Cells["Graduate"].ToString();
                            cmd.Parameters.Add("@Note", SqlDbType.NChar).Value = dr.Cells["Note"].ToString();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    //express add
                    cmd.CommandText = SqlInsert.ExpressInsertmethod();
                    try
                    {
                        foreach (DataGridViewRow dr in dgv_profile_express.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@CompanyName", SqlDbType.NChar).Value = dr.Cells["CompanyName"].ToString();
                            cmd.Parameters.Add("@Title", SqlDbType.NChar).Value = dr.Cells["Title"].ToString();
                            cmd.Parameters.Add("@DateStart", SqlDbType.NChar).Value = dr.Cells["DateStart"].ToString();
                            cmd.Parameters.Add("@DateEnd", SqlDbType.NChar).Value = dr.Cells["DateEnd"].ToString();
                            cmd.Parameters.Add("@SatartSalary", SqlDbType.Int).Value = dr.Cells["SatartSalary"].ToString();
                            cmd.Parameters.Add("@EndSalary", SqlDbType.Int).Value = dr.Cells["EndSalary"].ToString();
                            cmd.Parameters.Add("@LeaveReason", SqlDbType.NChar).Value = dr.Cells["LeaveReason"].ToString();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    //language add
                    cmd.CommandText = SqlInsert.ExpressInsertmethod();
                    try
                    {
                        foreach (DataGridViewRow dr in dgv_profile_languageskill.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@Language", SqlDbType.NChar).Value = dr.Cells["Language"].ToString();
                            cmd.Parameters.Add("@Listen", SqlDbType.NChar).Value = dr.Cells["Listen"].ToString();
                            cmd.Parameters.Add("@Speak", SqlDbType.NChar).Value = dr.Cells["Speak"].ToString();
                            cmd.Parameters.Add("@Read", SqlDbType.NChar).Value = dr.Cells["Read"].ToString();
                            cmd.Parameters.Add("@Write", SqlDbType.NChar).Value = dr.Cells["Write"].ToString();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    sqltr.Commit();
                }
                catch (Exception ex)
                {
                    sqltr.Rollback();
                    throw ex;
                }
                finally
                {
                    sqltr.Dispose();
                    cmd.Cancel();
                    con.Close();
                    con.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UC_data_interview_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlLink.linkmethod());
            SqlCommand cmd = new SqlCommand(SqlSelect.UserDataInterviewEducationmethod(), con);
            SqlCommand cmd1 = new SqlCommand(SqlSelect.UserDataInterviewExperiencemethod(), con);
            SqlCommand cmd2 = new SqlCommand(SqlSelect.UserDataInterviewLanguagemethod(), con);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            SqlDataAdapter adapt1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter adapt2 = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            adapt.Fill(ds);
            adapt1.Fill(ds1);
            adapt2.Fill(ds2);
            con.Close();
            dgv_profile_express.DataSource = ds1.Tables[0];
            dgv_profile_graduate.DataSource = ds.Tables[0];
            dgv_profile_languageskill.DataSource = ds2.Tables[0];
        }
    }
}
