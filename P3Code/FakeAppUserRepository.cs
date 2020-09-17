using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3Code
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if(AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();
                //add fake users for testing
                AppUsers.Add("AndyStange17", new AppUser
                {
                    UserName = "AndyStange17",
                    Password = "AS0717@!",
                    FirstName = "Andrew",
                    LastName = "Stange",
                    EmailAddress = "andrew.stange@trojans.dsu.edu",
                    isAuthenticated = false
                });

                AppUsers.Add("MichaelMoore", new AppUser
                {
                    UserName = "bdog422",
                    Password = "Player42",
                    FirstName = "Michael",
                    LastName = "Moore",
                    EmailAddress = "michael.moore@trojans.dsu.edu",
                    isAuthenticated = false
                });

                AppUsers.Add("KyleGosh", new AppUser
                {
                    UserName = "Gosh017",
                    Password = "12345678",
                    FirstName = "Kyle",
                    LastName = "Gosh",
                    EmailAddress = "kyle.gosh@trojans.dsu.com",
                    isAuthenticated = false
                });
                //Add a couple more
            }
        }

        public bool Login(string UserName, string Password)
        {
            AppUser NewUser = new AppUser();
            NewUser = GetbyUserName(UserName);

            if (NewUser == null)
            {
                return false;
            }
            else
            {
                if(NewUser.Password == Password)
                {
                    return true;
                }else if(NewUser.Password != Password)
                {
                    return false;
                }
            }
            return false;

        }

        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();
            foreach(KeyValuePair<string, AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }
            return users;
        }
        public void SetAuthenticated(string UserName, bool isAuthenticated)
        {
            AppUser NewUser = new AppUser();
            NewUser = GetbyUserName(UserName);
            NewUser.isAuthenticated = isAuthenticated;

        }

        public AppUser GetbyUserName(string UserName)
        {
            AppUser NewUser = new AppUser();
            foreach (KeyValuePair<string, AppUser> user in AppUsers)
            {
                if (user.Key == UserName)
                {
                    NewUser = user.Value;
                }
            }
            return NewUser;
        }
    }
}
