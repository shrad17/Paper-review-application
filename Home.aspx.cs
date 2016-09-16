using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAM2017.Presenters;

namespace SAM2017
{
    public partial class Home : System.Web.UI.Page
    {
        AccountPresenter _accountPresenter = new AccountPresenter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!_accountPresenter.IsLoggedIn())
            {
                //TODO redirect them to Home
            }
        }

        protected void RegisterButton_OnClick(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;
            _accountPresenter.RegisterUser(username, password);
            //TODO Display notification to user
        }
    }
}