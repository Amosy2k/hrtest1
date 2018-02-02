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
                    cmd.Parameters.Add("@LastUpdatetime", SqlDbType.DateTime).Value = DateTime.Now;
                    id = cmd.ExecuteScalar().ToString();
                    //education add
                    cmd.CommandText = SqlInsert.EducationInsertmethod();
                    try
                    {
                        for (int i = 0; i <= dgv_profile_graduate.RowCount - 1; i++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@SchoolName", SqlDbType.NChar).Value = dgv_profile_graduate.Rows[i].Cells["SchoolName"].Value.ToString();// ?? string.Empty;
                            cmd.Parameters.Add("@Department", SqlDbType.NChar).Value = dgv_profile_graduate.Rows[i].Cells["Department"].Value ?? string.Empty;
                            cmd.Parameters.Add("@DateStart", SqlDbType.NChar).Value = dgv_profile_graduate.Rows[i].Cells["DateStart"].Value ?? string.Empty;
                            cmd.Parameters.Add("@DateEnd", SqlDbType.NChar).Value = dgv_profile_graduate.Rows[i].Cells["DateEnd"].Value ?? string.Empty;
                            cmd.Parameters.Add("@Graduate", SqlDbType.NChar).Value = dgv_profile_graduate.Rows[i].Cells["Graduate"].Value ?? string.Empty;
                            cmd.Parameters.Add("@Note", SqlDbType.NChar).Value = dgv_profile_graduate.Rows[i].Cells["Note"].Value ?? string.Empty;
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
                            cmd.Parameters.Add("@CompanyName", SqlDbType.NChar).Value = dr.Cells["CompanyName"].Value ?? string.Empty;
                            cmd.Parameters.Add("@Title", SqlDbType.NChar).Value = dr.Cells["Title"].Value ?? string.Empty;
                            cmd.Parameters.Add("@DateStart", SqlDbType.NChar).Value = dr.Cells["DateStart"].Value ?? string.Empty;
                            cmd.Parameters.Add("@DateEnd", SqlDbType.NChar).Value = dr.Cells["DateEnd"].Value ?? string.Empty;
                            cmd.Parameters.Add("@SatartSalary", SqlDbType.Int).Value = dr.Cells["SatartSalary"].Value ?? DBNull.Value;
                            cmd.Parameters.Add("@EndSalary", SqlDbType.Int).Value = dr.Cells["EndSalary"].Value ?? DBNull.Value;
                            cmd.Parameters.Add("@LeaveReason", SqlDbType.NChar).Value = dr.Cells["LeaveReason"].Value ?? string.Empty;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    //language add
                    cmd.CommandText = SqlInsert.LanguageInsertmethod();
                    try
                    {
                        foreach (DataGridViewRow dr in dgv_profile_languageskill.Rows)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                            cmd.Parameters.Add("@Language", SqlDbType.NChar).Value = dr.Cells["Language"].Value ?? string.Empty;
                            cmd.Parameters.Add("@Listen", SqlDbType.NChar).Value = dr.Cells["Listen"].Value ?? string.Empty;
                            cmd.Parameters.Add("@Speak", SqlDbType.NChar).Value = dr.Cells["Speak"].Value ?? string.Empty;
                            cmd.Parameters.Add("@Read", SqlDbType.NChar).Value = dr.Cells["Read"].Value ?? string.Empty;
                            cmd.Parameters.Add("@Write", SqlDbType.NChar).Value = dr.Cells["Write"].Value ?? string.Empty;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    //skill
                    cmd.CommandText = SqlInsert.SkillInsertmethod();
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@Language", SqlDbType.NChar).Value = Getskill(clb_profile_programlanguage, tb_profile_programlanguage_others.Text);
                        cmd.Parameters.Add("@Developetools", SqlDbType.NChar).Value = Getskill(clb_profile_developetools, tb_profile_developtool_others.Text);
                        cmd.Parameters.Add("@Devops", SqlDbType.NChar).Value = Getskill(clb_profile_devops, tb_profile_devops_others.Text);
                        cmd.Parameters.Add("@Os", SqlDbType.NChar).Value = Getskill(clb_profile_os, tb_profile_os_others.Text);
                        cmd.Parameters.Add("@Bigdata", SqlDbType.NChar).Value = Getskill(clb_profile_bigdata, tb_profile_bigdata_others.Text);
                        cmd.Parameters.Add("@Database", SqlDbType.NChar).Value = Getskill(clb_profile_database, tb_profile_database_others.Text);
                        cmd.Parameters.Add("@Cert", SqlDbType.NChar).Value = Getskill(clb_profile_cert, tb_profile_cert_others.Text);
                        cmd.Parameters.Add("@Framwork", SqlDbType.NChar).Value = tb_profile_framwork.Text;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    sqltr.Commit();
                    MessageBox.Show("新增成功");
                }
                catch (Exception ex)
                {
                    sqltr.Rollback();
                    MessageBox.Show(ex.Message, "新增失敗");
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

        private void btn_profile_graduate_Click(object sender, EventArgs e)
        {
            dgv_profile_graduate.ColumnCount = 7;
            dgv_profile_graduate.Columns[1].Name = "SchoolName";
            dgv_profile_graduate.Columns[2].Name = "Department";
            dgv_profile_graduate.Columns[3].Name = "DateStart";
            dgv_profile_graduate.Columns[4].Name = "DateEnd";
            dgv_profile_graduate.Columns[5].Name = "Graduate";
            dgv_profile_graduate.Columns[6].Name = "Note";
            string[] row = new string[] { };
            dgv_profile_graduate.Rows.Add(row);
        }

        private void btn_profile_express_Click(object sender, EventArgs e)
        {
            dgv_profile_express.ColumnCount = 8;
            dgv_profile_express.Columns[1].Name = "CompanyName";
            dgv_profile_express.Columns[2].Name = "Title";
            dgv_profile_express.Columns[3].Name = "DateStart";
            dgv_profile_express.Columns[4].Name = "DateEnd";
            dgv_profile_express.Columns[5].Name = "SatartSalary";
            dgv_profile_express.Columns[6].Name = "EndSalary";
            dgv_profile_express.Columns[7].Name = "LeaveReason";
            string[] row = new string[] { };
            dgv_profile_express.Rows.Add(row);
        }

        private void btn_profile_languageskill_Click(object sender, EventArgs e)
        {
            dgv_profile_languageskill.ColumnCount = 6;
            dgv_profile_languageskill.Columns[1].Name = "Language";
            dgv_profile_languageskill.Columns[2].Name = "Listen";
            dgv_profile_languageskill.Columns[3].Name = "Speak";
            dgv_profile_languageskill.Columns[4].Name = "Read";
            dgv_profile_languageskill.Columns[5].Name = "Write";
            string[] row1 = new string[] { };
            dgv_profile_languageskill.Rows.Add(row1);
        }

        private string Getskill(CheckedListBox clb, string others)
        {
            string experience = string.Empty;
            for(int i = 0; i < clb.Items.Count; i++)
            {
                if(clb.GetItemChecked(i))
                {
                    experience += clb.Items[i].ToString() + ",";
                }
            }

            experience += others;

            if(experience.EndsWith(","))
            {
                experience = experience.Remove(experience.Length - 1);
            }
            return experience;
        }
    }
}

