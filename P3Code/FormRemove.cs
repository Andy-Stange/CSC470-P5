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
        public FormRemove()
        {
            InitializeComponent();
        }

        private void FormRemove_Load(object sender, EventArgs e)
        {
            var removeSelect = new FormSelect();
            removeSelect.TopMost = true;
            removeSelect.Show();
            
        }

        private void RemoveCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
