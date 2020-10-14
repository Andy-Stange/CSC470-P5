using P4Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3Code
{
    public partial class FormSelect : Form
    {
        public FakeProjectRepository repoToEdit = new FakeProjectRepository();

        public Project SelectedProject;
        public List<Project> projects = new List<Project>();
        public bool isSelected = false;
        public string selectedName { get; set; }
        public int ID { get; set; }   



        public FormSelect()
        {
            InitializeComponent();
        }
        readonly FakeProjectRepository pro = new FakeProjectRepository();
        private void SelectProject_Load(object sender, EventArgs e)
        {
            projects = repoToEdit.GetAll();
            foreach (Project project in projects)
                ProjectListBox.Items.Add(project.Name);
            ProjectListBox.SelectedIndex = 0;
        }

        private void ProjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectProj_btn_Click(object sender, EventArgs e)
        {
            SelectedProject = projects[ProjectListBox.SelectedIndex];
            selectedName = SelectedProject.Name;
            ID = SelectedProject.ID;
            isSelected = true;
            this.Close();
        }
    }
}
