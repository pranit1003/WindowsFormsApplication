using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtBasicSalary_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTotalSalary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtBasicSalary.Clear();
            txtDA.Clear();
            txtHRA.Clear();
            txtNumber.Clear();
            txtTotalSalary.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }
    }
}
