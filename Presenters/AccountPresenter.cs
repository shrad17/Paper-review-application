using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SAM2017.Models;

namespace SAM2017.Presenters
{
    public class AccountPresenter
    {
        readonly Models.DatabaseEntities _databaseEntities = new DatabaseEntities();

        public User GetUser(string username)
        {
            return _databaseEntities.Users.FirstOrDefault(x => x.Username.Equals(username));
        }

        public void RegisterUser(string username, string password)
        {
            try
            {
                _databaseEntities.RegisterUser(username, password);
                Login(username, password);
            }
            catch (SqlException ex)
            {
                //TODO
                throw new NotImplementedException();
            }
            
        }

        public bool CheckIfUserExists(string username, string password)
        {
            int numOfUsers = _databaseEntities.Users.Count(x => x.Username.Equals(username) && x.Password.Equals(password));
            if (numOfUsers == 1)
            {
                return true;
            } else if (numOfUsers == 0)
            {
                return false;
            }
            else
            {
                throw new Exception("The number of valid users was not 1 or 0, but instead " + numOfUsers);
            }
        }

        public bool Login(string username, string password)
        {
            //Check if user exists
            //if true, set in session context and redirect to LoggedIn

            //if not, return false
            throw new NotImplementedException();
        }

        public void GetNotifications()
        {
            throw new NotImplementedException();
        }

        public bool IsLoggedIn()
        {
            throw new NotImplementedException();
        }
    }
}