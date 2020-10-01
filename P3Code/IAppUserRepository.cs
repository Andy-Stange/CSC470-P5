using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Code
{
    public interface IAppUserRepository
    {
        bool Login(string UserName, string Password);
        List<AppUser> GetAll();
        void SetAuthenticated(string UserName, bool isAuthenticated);
        AppUser GetbyUserName(string UserName);

    }
}
