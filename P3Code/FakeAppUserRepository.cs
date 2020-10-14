using System.Collections.Generic;

namespace P4Code
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
                    isAuthenticated = true
                });

                AppUsers.Add("MichaelMoore", new AppUser
                {
                    UserName = "bdog42",
                    Password = "Player42",
                    FirstName = "Michael",
                    LastName = "Moore",
                    EmailAddress = "michael.moore@trojans.dsu.edu",
                    isAuthenticated = true
                });

                AppUsers.Add("KyleGosh", new AppUser
                {
                    UserName = "Kyle17",
                    Password = "password",
                    FirstName = "Kyle",
                    LastName = "Gosh",
                    EmailAddress = "kyle.gosh@trojans.dsu.com",
                    isAuthenticated = true
                });

                AppUsers.Add("JohnnyCash", new AppUser
                {
                    UserName = "JCash100",
                    Password = "Password1!",
                    FirstName = "Johnny",
                    LastName = "Cash",
                    EmailAddress = "Cashster24x7@gmail.com",
                    isAuthenticated = true
                });

                AppUsers.Add("QuickUser", new AppUser
                {
                    UserName = "fj",
                    Password = "fj",
                    FirstName = "Johnny",
                    LastName = "Cash",
                    EmailAddress = "Cashster24x7@gmail.com",
                    isAuthenticated = true
                });
                //Add a couple mor
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
                if (NewUser.Password == Password)
                {
                    return true;
                } 
                else if (NewUser.Password != Password)
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
            AppUser temp = new AppUser();
            foreach (KeyValuePair<string, AppUser> user in AppUsers)
            {
                temp = user.Value;
                if (temp.UserName == UserName)
                {
                    NewUser = user.Value;
                }
            }
            return NewUser;
        }

    }
}
