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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
           
                try
                {
                    FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    txtDepartmentId.Text = br.ReadInt32().ToString();
                    txtDepartmentName.Text = br.ReadString();
                    txtLocation.Text = br.ReadDouble().ToString();
                    br.Close();
                    fs.Close();

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
                    FileStream fs = new FileStream(@"D:\SkillMineDoc\emp.dat", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(Convert.ToInt32(txtDepartmentId.Text));
                    bw.Write(txtDepartmentName.Text);
                    bw.Write(txtLocation.Text);
                    bw.Close();
                    fs.Close();
                    MessageBox.Show("Data saved to file..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"D:\SkillMineDoc");

            try
            {
                if (info.Exists)
                {
                    MessageBox.Show("Directory is already exists");
                }
                else
                {
                    info.Create();
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

            FileInfo fileinfo = new FileInfo(@"D:\SkillMineDoc\Test1.txt");
            try
            {
                if (fileinfo.Exists)
                {
                    MessageBox.Show("File is already exists");
                }
                else
                {
                    fileinfo.Create();
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

            FileInfo fileinfo = new FileInfo(@"D:\SkillMineDoc\Test1.txt");
            try
            {
                if (fileinfo.Exists)
                {
                    fileinfo.Delete();
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
    }
}
