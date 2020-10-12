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
        private static List<Project> projects;


        public const string NO_ERROR = "No Error";
        public const string MODIFIED_PROJECT_ID_ERROR = "Can not modify the project ID";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project Name Already Exists";
        public const string NO_PROJECT_FOUND_ERROR = "No Project Found!";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project Name is Empty or Blank!";

        public FakeProjectRepository()
        {
            if(projects == null)
            {
                Project project = new Project();
                project.ID = 1;
                project.Name = "Random Project";
                projects.Add(project);

                project.ID = 2;
                project.Name = "Better Project";
                projects.Add(project);

                project.ID = 111;
                project.Name = "P5";
                projects.Add(project);
            }
        }


        string Add(Project project, int ID)
        {
            string Name = null;


            return Name;
        }

        string Remove(int ProjectID)
        {
            string ProjName = null;
            foreach(Project proj in projects)
            {
                if(ProjectID == proj.ID)
                {
                    ProjName = proj.Name;
                    projects.Remove(proj);
                }
            }
            return ProjName;
        }

        string Modify(int ProjectID, Project project)
        {
            string Name = null;
            project.ID = ProjectID;
            Name = project.Name;
            return Name;
        }

        List<Project> GetAll()
        {
            return projects;
        }

        bool IsDuplicateName(string projectName)
        {
            foreach(Project proj in projects)
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
