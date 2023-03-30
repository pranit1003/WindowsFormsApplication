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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace WindowsFormsApplication
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.dat", FileMode.Create, FileAccess.Write);
                // step 2
                Student stu = new Student();
                stu.StuName = txtStudentForm.Text;
                stu.StuRollNo = Convert.ToInt32(txtStudentRollNo.Text);
                stu.StuPercentage = Convert.ToInt32(txtStudentPer.Text);
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("Employee record added to file");
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
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.dat", FileMode.Open, FileAccess.Read);
                // step 2
                Student stu = new Student();
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                stu = (Student)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtStudentForm.Text = stu.StuName;
                txtStudentRollNo.Text = stu.StuRollNo.ToString();
                txtStudentPer.Text = stu.StuPercentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentXML.xml", FileMode.Create, FileAccess.Write);
                // step 2
                Student stu = new Student();
                stu.StuName = txtStudentForm.Text;
                stu.StuRollNo = Convert.ToInt32(txtStudentRollNo.Text);
                stu.StuPercentage = Convert.ToInt32(txtStudentPer.Text);
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("Employee XML Write Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentXML.xml", FileMode.Open, FileAccess.Read);
                // step 2
                Student stu = new Student();
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                stu = (Student)xml.Deserialize(fs);
                fs.Close();

                txtStudentForm.Text = stu.StuName;
                txtStudentRollNo.Text = stu.StuRollNo.ToString();
                txtStudentPer.Text = stu.StuPercentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.soap", FileMode.Create, FileAccess.Write);
                // step 2
                Student stu = new Student();
                stu.StuName = txtStudentForm.Text;
                stu.StuRollNo = Convert.ToInt32(txtStudentRollNo.Text);
                stu.StuPercentage = Convert.ToInt32(txtStudentPer.Text);
                // step 3
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("Employee SOAP record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Student.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Student stu = new Student();
                // step 3
                SoapFormatter soap = new SoapFormatter();
                stu = (Student)soap.Deserialize(fs);
                fs.Close();

                txtStudentForm.Text = stu.StuName;
                txtStudentRollNo.Text = stu.StuRollNo.ToString();
                txtStudentPer.Text = stu.StuPercentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentJSON.json", FileMode.Create, FileAccess.Write);
                // step 2
                Student stu = new Student();
                stu.StuName = txtStudentForm.Text;
                stu.StuRollNo = Convert.ToInt32(txtStudentRollNo.Text);
                stu.StuPercentage = Convert.ToInt32(txtStudentPer.Text);
                // step 3
                JsonSerializer.Serialize<Student>(fs, stu);
                fs.Close();
                MessageBox.Show("Employee JSON record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\StudentJSON.json", FileMode.Open, FileAccess.Read);
                // step 2
                Student stu = new Student();
                // step 3

                stu = JsonSerializer.Deserialize<Student>(fs);
                fs.Close();

                txtStudentForm.Text = stu.StuName;
                txtStudentRollNo.Text = stu.StuRollNo.ToString();
                txtStudentPer.Text = stu.StuPercentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtStudentForm.Clear();
            txtStudentRollNo.Clear();
            txtStudentPer.Clear();
        }

        private void txtStudentForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
