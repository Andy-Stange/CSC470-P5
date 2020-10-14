using P3Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4Code
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        private string selectedProjectDelete;
        private int selectedProjectIDDelete;
        private string selectedProject;



        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formlog = new FormLogin();
            formlog.ShowDialog();
            FormSelect sel = new FormSelect();
            sel.ShowDialog();

        }

        private void selectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect();
            select.ShowDialog();

            if(select.isSelected == true)
            {
                selectedProject = select.selectedName;
                setText();
            }

        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newCreate = new FormCreate();
            newCreate.Show();
        }

        private void modifyProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newModify = new FormModify();
            newModify.Show();
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newSelect = new FormSelect();
            newSelect.Show();
            if(newSelect.isSelected == true)
            {
                selectedProjectDelete = newSelect.selectedName;
                selectedProjectIDDelete = newSelect.ID;
            }
            if(selectedProjectDelete != selectedProject)
            {
                var newRemove = new FormRemove();
                newRemove.projectText = selectedProjectDelete;

            }
        }

        private void createProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var newCreate = new FormCreate();
            newCreate.Show();
        }
        private void countByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listByAssigneeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void countByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listByArtifactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void countByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trendByDateRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PreferencesBox_Click(object sender, EventArgs e)
        {

        }

        private void setText()
        {
            this.Text = "Main - " + selectedProject;
        }


    }
}
