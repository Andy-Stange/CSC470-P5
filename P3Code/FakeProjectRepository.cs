using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4Code
{
    class FakeProjectRepository : IProjectRepository
    {
        private static List<Project> projects = new System.Collections.Generic.List<Project>();


        public const string NO_ERROR = "No Error";
        public const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project ID";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project Name Already Exists";
        public const string NO_PROJECT_FOUND_ERROR = "No Project Found!";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project Name is Empty or Blank!";

        public FakeProjectRepository()
        {
            if (projects == null)
            {
                projects.Add(new Project
                {
                    Name = "Cool Project",
                    ID = 2
                });
                projects.Add(new Project
                {
                    Name = "Cool Project",
                    ID = 2
                });
                projects.Add(new Project
                {
                    Name = "P5",
                    ID = 3
                });


            }
        }


        public void Add(string name, int ID)
        {
            projects.Add(new Project
            {
                Name = name,
                ID = ID
            });
        }

        public string Remove(int ProjectID)
        {
            string ProjName = null;
            foreach (Project proj in projects)
            {
                if (ProjectID == proj.ID)
                {
                    ProjName = proj.Name;
                    projects.Remove(proj);
                }
            }
            return ProjName;
        }

        public string Modify(int ProjectID, Project project)
        {
            string Name = null;
            project.ID = ProjectID;
            Name = project.Name;
            return Name;
        }

        public List<Project> GetAll()
        {
            return projects;
        }

        public bool isDublicate(string projectName)
        {
            foreach (Project proj in projects)
            {
                if (projectName == proj.Name)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
