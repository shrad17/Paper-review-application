using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAM2017.Models;
using SAM2017.Presenters;

namespace SAM2017
{
    public partial class submissions : System.Web.UI.Page
    {
        SubmissionPresenter _submissionPresenter = new SubmissionPresenter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                PopulateSubmissions();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Title", typeof(int)),
                            new DataColumn("Name", typeof(string)),
                            new DataColumn("Country",typeof(string)),
                            new DataColumn("someVal", typeof(bool)),
                });
                dt.Rows.Add(1, "John Hammond", "United States", true);
                dt.Rows.Add(2, "Mudassar Khan", "India", true);
                dt.Rows.Add(3, "Suzanne Mathews", "France", false);
                dt.Rows.Add(4, "Robert Schidner", "Russia", true);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }




            //List<Submission> submissionsList = _submissionPresenter.GetSubmissions();
            List<String> stringList = new List<String>();
            stringList.Add("hi");
            stringList.Add("there");
            stringList.Add("buddy");
            int i = 3;

            DataTable dataTable = new DataTable("StringList");
            dataTable.Columns.Add("String", typeof(string));
            dataTable.Columns.Add("Button", typeof(Button));


            foreach (string s in stringList)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["String"] = s;
                dataRow["Button"] = new Button();
                dataTable.Rows.Add(dataRow);
            }
        }

        private void PopulateSubmissions()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3]{new DataColumn("Title", typeof(string)),
            new DataColumn("Submitter", typeof(string)),
            new DataColumn("Submission", typeof(Submission))
            });
        }

        protected void GridView1_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            Debug.WriteLine(e.CommandArgument);
        }

        protected void AssignPCMButton_OnCommand(object sender, CommandEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void button2_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void SubmissionsGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void ReviewButton_OnCommand(object sender, CommandEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void RateButton_OnCommand(object sender, CommandEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void GenerateReportButton_OnCommand(object sender, CommandEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void PreferredCheckBox_OnCheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}