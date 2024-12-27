using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_laba5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PageNameLable_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mosovLabaOneDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.mosovLabaOneDataSet.Книги);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }
        
        private void OpenAuthorsForm_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand IsExist = cnn.CreateCommand();
            IsExist.CommandText = $"select count(Код_Автора) from Книги where Код_автора = {AuthorCodeBox.Text}";
            int CountEsists = Convert.ToInt32(IsExist.ExecuteScalar());

            if (CountEsists > 0 && Convert.ToInt32(YearOfBublishBox.Text) > 2000)
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"Insert into Книги (Код_Автора, Название, Год_издания, Колво_стр, Издательство) values ('{AuthorCodeBox.Text}', '{NameBox.Text}', '{YearOfBublishBox.Text}', '{PagesAmountBox.Text}', '{PublisherBox.Text}')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Новая книга была добавлена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Некоторые значени были введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnn.Close();
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand IsExist = cnn.CreateCommand();
            IsExist.CommandText = $"select count(Код_книги) from Книги where Код_книги = {BookCodeBox.Text}";
            int CountEsistsBooks = Convert.ToInt32(IsExist.ExecuteScalar());

            SqlCommand IsExistNew = cnn.CreateCommand();
            IsExist.CommandText = $"select count(Код_Автора) from Книги where Код_Автора = {AuthorCodeBox.Text}";
            int CountEsistsAuthors= Convert.ToInt32(IsExist.ExecuteScalar());

            if (CountEsistsBooks > 0 && CountEsistsAuthors > 0 && Convert.ToInt32(YearOfBublishBox.Text) > 2000)
            {
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"Update Книги set Код_Автора = '{AuthorCodeBox.Text}', Название = '{NameBox.Text}', Год_издания = '{YearOfBublishBox.Text}', Колво_стр = {PagesAmountBox.Text}, Издательство = '{PublisherBox.Text}' where Код_книги = {BookCodeBox.Text}";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные успешно изменены", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Некоторые значения были введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnn.Close();
        }

        private void PagesAmountBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNull();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public void UpdateNull()
        {
            string Fields = "";

            if (AuthorCodeBox.Text == "")
                Fields += "Код Автора, ";
            if (BookCodeBox.Text == "")
                Fields += "Код Буквы, ";
            if (NameBox.Text == "")
                Fields += "Название, ";
            if (YearOfBublishBox.Text == "")
                Fields += "Год Издания, ";
            if (PublisherBox.Text == "")
                Fields += "Издательство";

            EmptyFieldsBox.Text = Fields.Trim(new char[] {',', ' '});
        }

        private void PublisherBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            UpdateNull();
        }

        private void YearOfBublishBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNull();
        }

        private void BookCodeBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNull();
        }

        private void AuthorCodeBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNull();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            UpdateNull();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int bookcode = Convert.ToInt32(BookCodeBox.Text); 

            string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand IsExist = cnn.CreateCommand();
            IsExist.CommandText = $"Select count(Код_книги) from Книги where Код_книги = {bookcode}";
            int IsBookExist = (int)IsExist.ExecuteScalar();

            //MessageBox.Show($"{bookcode} {IsBookExist}");
            if (IsBookExist > 0)
            {
                MessageBox.Show($"Кол-во книг: {IsBookExist}\nКодАвтора: {bookcode}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"delete from Книги where Код_книги = {bookcode}";
                cmd.ExecuteScalar();
            }
            else
            {
                MessageBox.Show("Неверно введено значение поля Кода автора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            cnn.Close();
        }
    }
}
