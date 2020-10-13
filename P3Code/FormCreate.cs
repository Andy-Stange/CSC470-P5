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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }
        readonly FakeProjectRepository pro = new FakeProjectRepository();
        private void FormCreate_Load(object sender, EventArgs e)
        {

        }

        private void CreateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateAdd_Click(object sender, EventArgs e)
        {
            List<Project> calledlist = pro.GetAll();

            int value = 0;
            if (CreateTextbox.Text.Length == 0)
            {
                MessageBox.Show("Project Name empty or blank");
            }

            if (pro.isDublicate(CreateTextbox.Text) == true)
            {
                MessageBox.Show("Project Name is a duplicate");
                value = 1;

            }
            else
            {
                value = 0;
            }
            if (value == 0)
            {
                int max = 0;
                int newid = 0;
                foreach (Project item in calledlist)
                {

                    if (item.ID > max)
                        max = item.ID;
                }
                newid = max + 1;
                Project newpro = new Project { Name = CreateTextbox.Text };
                pro.Add(newpro, newid);
                this.Close();
            }

        }
    }
}
