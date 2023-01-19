using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            string path = @"C:\SkillMineDoc";
            try
            {
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\SkillMineDoc\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\SkillMineDoc\Test1.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    MessageBox.Show("File has been removed");
                }
                else
                {
                    MessageBox.Show("File not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
               
                fs.Close();
                MessageBox.Show("Data saved to file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\SkillMineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtEmployeId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
