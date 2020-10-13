using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4Code 
{ 
    public interface IProjectRepository
    {
        string Add(Project project, int out_id);
        string Remove(int ProjectID);
        string Modify(int ProjectID, Project project);
        List<Project> GetAll();
        bool isDublicate(string projectName);
    }
}
