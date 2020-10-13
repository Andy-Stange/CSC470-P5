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

        public FormSelect()
        {
            InitializeComponent();
        }
        readonly FakeProjectRepository pro = new FakeProjectRepository();
        private void SelectProject_Load(object sender, EventArgs e)
        {
            List<Project> calledlist = pro.GetAll();
            foreach (Project item in calledlist)
                ProjectListBox.Items.Add(item.Name);

        }

        private void ProjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
