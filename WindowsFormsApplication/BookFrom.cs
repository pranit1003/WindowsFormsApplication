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
    public partial class BookFrom : Form
    {
        public BookFrom()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.dat", FileMode.Create, FileAccess.Write);
                // step 2
                Book book = new Book();
                book.BookId = Convert.ToInt32(txtBookId.Text);
                book.BookName = txtBookName.Text;
                book.BookPrice = Convert.ToInt32(txtBookPrice);
                book.BookAuthor = txtBookAuthor.Text;
                book.BookEdition = Convert.ToInt32(txtBookEdition);
                book.BookPublication = Convert.ToInt32(txtBookPublication);
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, book);
                fs.Close();
                MessageBox.Show("Book record added to file");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.dat", FileMode.Open, FileAccess.Read);
                // step 2
                Book book = new Book();
                // step 3
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                book = (Book)binaryFormatter.Deserialize(fs);
                fs.Close();

                txtBookId.Text = book.BookId.ToString();
                txtBookName.Text = book.BookName; 
                txtBookPrice.Text = book.BookPrice.ToString();
                txtBookAuthor.Text = book.BookAuthor;
                txtBookEdition.Text = book.BookEdition.ToString();
                txtBookPublication.Text = book.BookPublication.ToString();
                
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.XML", FileMode.Create, FileAccess.Write);
                // step 2
                Book book = new Book();
                book.BookId = Convert.ToInt32(txtBookId.Text);
                book.BookName = txtBookName.Text;
                book.BookPrice = Convert.ToInt32(txtBookPrice);
                book.BookAuthor = txtBookAuthor.Text;
                book.BookEdition = Convert.ToInt32(txtBookEdition);
                book.BookPublication = Convert.ToInt32(txtBookPublication);
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(fs, book);

                fs.Close();
                MessageBox.Show("Book record XML added to file");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.XML", FileMode.Open, FileAccess.Read);
                // step 2
                Book book = new Book();
                // step 3
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                book = (Book)xml.Deserialize(fs);
                fs.Close();

                txtBookId.Text = book.BookId.ToString();
                txtBookName.Text = book.BookName;
                txtBookPrice.Text = book.BookPrice.ToString();
                txtBookAuthor.Text = book.BookAuthor;
                txtBookEdition.Text = book.BookEdition.ToString();
                txtBookPublication.Text = book.BookPublication.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 1
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.soap", FileMode.Create, FileAccess.Write);
                // step 2
                Book book = new Book();
                book.BookId = Convert.ToInt32(txtBookId.Text);
                book.BookName = txtBookName.Text;
                book.BookPrice = Convert.ToInt32(txtBookPrice);
                book.BookAuthor = txtBookAuthor.Text;
                book.BookEdition = Convert.ToInt32(txtBookEdition);
                book.BookPublication = Convert.ToInt32(txtBookPublication);
                // step 3
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);

                fs.Close();
                MessageBox.Show("Book record XML added to file");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.soap", FileMode.Open, FileAccess.Read);
                // step 2
                Book book = new Book();
                // step 3
                SoapFormatter soap = new SoapFormatter();
                book = (Book)soap.Deserialize(fs);
                fs.Close();

                txtBookId.Text = book.BookId.ToString();
                txtBookName.Text = book.BookName;
                txtBookPrice.Text = book.BookPrice.ToString();
                txtBookAuthor.Text = book.BookAuthor;
                txtBookEdition.Text = book.BookEdition.ToString();
                txtBookPublication.Text = book.BookPublication.ToString();

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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.json", FileMode.Create, FileAccess.Write);
                // step 2
                Book book = new Book();
                book.BookId = Convert.ToInt32(txtBookId.Text);
                book.BookName = txtBookName.Text;
                book.BookPrice = Convert.ToInt32(txtBookPrice);
                book.BookAuthor = txtBookAuthor.Text;
                book.BookEdition = Convert.ToInt32(txtBookEdition);
                book.BookPublication = Convert.ToInt32(txtBookPublication);
                // step 3
                JsonSerializer.Serialize<Book>(fs, book);

                fs.Close();
                MessageBox.Show("Book record JSON added to file");
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
                FileStream fs = new FileStream(@"C:\SkillMineDoc\Book.json", FileMode.Open, FileAccess.Read);
                // step 2
                Book book = new Book();
                // step 3
                book = JsonSerializer.Deserialize<Book>(fs);
                fs.Close();

                txtBookId.Text = book.BookId.ToString();
                txtBookName.Text = book.BookName;
                txtBookPrice.Text = book.BookPrice.ToString();
                txtBookAuthor.Text = book.BookAuthor;
                txtBookEdition.Text = book.BookEdition.ToString();
                txtBookPublication.Text = book.BookPublication.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
