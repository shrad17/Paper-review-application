using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAM2017.Models;

namespace SAM2017.Presenters
{
    public class SubmissionPresenter
    {
        readonly DatabaseEntities _databaseEntities = new DatabaseEntities();
        AccountPresenter _accountPresenter = new AccountPresenter();

        public List<Submission> GetSubmissions()
        {
            //TODO replace with user check to see which submissions should be visible

            //User curUser = _accountPresenter.GetUser(HttpContext.Current.Session["Username"].ToString());
            return _databaseEntities.Submissions.ToList();
        }
    }
}