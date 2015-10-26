using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAcadSchedule.Menu
{
    public partial class AddSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadSubjects();
            }

        }

        protected void LoadSubjectTypes()
        {
            ddlSubjectTypes.Items.Add(new ListItem("Wybierz typ zajęć", ""));
            ddlSubjectTypes.AppendDataBoundItems = true;
            String strConnString = ConfigurationManager.ConnectionStrings["ScheduleDB"].ConnectionString;
            String strQuery = "SELECT SubjectTypeId FROM Subjects WHERE Name = @Name";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Name", ddlSubjects.SelectedItem.Value);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;

            try
            {
                con.Open();
                ddlSubjectTypes.DataSource = cmd.ExecuteReader();
                ddlSubjectTypes.DataValueField = "SubjectTypeId";
                ddlSubjectTypes.DataBind();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void LoadSubjects()
        {
            ddlSubjects.Items.Add(new ListItem("Wybierz przedmiot", ""));
            ddlSubjects.AppendDataBoundItems = true;
            String strConnString = ConfigurationManager.ConnectionStrings["ScheduleDB"].ConnectionString;
            String strQuery = "SELECT Name FROM Subjects";
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strQuery;
            cmd.Connection = con;

            try
            {
                con.Open();
                ddlSubjects.DataSource = cmd.ExecuteReader();
                ddlSubjects.DataValueField = "Name";
                ddlSubjects.DataBind();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubjectTypes();
        }
    }
}