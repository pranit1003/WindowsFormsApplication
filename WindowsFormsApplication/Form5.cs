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
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;


namespace WindowsFormsApplication
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.dat", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Empld = Convert.ToInt32(txtEmpid.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSalary.Text);
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.dat", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtEmpid.Text = emp.Empld.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSalary.Text = emp.EmpSalary.ToString();
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.soap", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Empld = Convert.ToInt32(txtEmpid.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSalary.Text);
                // step 3
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee SOAP added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                SoapFormatter soap = new SoapFormatter();
                emp = (Employee)soap.Deserialize(fs);
                fs.Close();

                txtEmpid.Text = emp.Empld.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSalary.Text = emp.EmpSalary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.xml", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Empld = Convert.ToInt32(txtEmpid.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSalary.Text);
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                xml.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Employee XML Write Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Employee.xml", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Employee));
                emp = (Employee)xml.Deserialize(fs);
                fs.Close();

                txtEmpid.Text = emp.Empld.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSalary.Text = emp.EmpSalary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeJSON.json", FileMode.Create, FileAccess.Write);
                // step 2
                Employee emp = new Employee();
                emp.Empld = Convert.ToInt32(txtEmpid.Text);
                emp.EmpName = txtEmpName.Text;
                emp.EmpSalary = Convert.ToInt32(txtEmpSalary.Text);
                // step 3
                JsonSerializer.Serialize<Employee>(fs, emp);
                fs.Close();
                MessageBox.Show("Employee JSON record added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\EmployeeJSON.json", FileMode.Open, FileAccess.Read);
                // step 2
                Employee emp = new Employee();
                // step 3

                emp = JsonSerializer.Deserialize<Employee>(fs);
                fs.Close();

                txtEmpid.Text = emp.Empld.ToString();
                txtEmpName.Text = emp.EmpName;
                txtEmpSalary.Text = emp.EmpSalary.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
