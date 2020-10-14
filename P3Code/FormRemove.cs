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
    public partial class FormRemove : Form
    {
        public string projectText;

        public FormRemove()
        {
            InitializeComponent();
        }

        private void FormRemove_Load(object sender, EventArgs e)
        {
            ProjectRemovalLabel.Text = projectText;
            
        }

        private void RemoveCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveOkay_Click(object sender, EventArgs e)
        {
            string message = "Are you sure that you want to delete this project?";
            string subMessage = "Deleting Project";
            var announcment = MessageBox.Show(message, subMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
