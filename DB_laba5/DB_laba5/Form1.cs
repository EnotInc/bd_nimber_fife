using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_laba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mosovLabaOneDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.mosovLabaOneDataSet.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mosovLabaOneDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.mosovLabaOneDataSet.Авторы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mosovLabaOneDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.mosovLabaOneDataSet.Авторы);
        }

        private void SureNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = $"Select Код_Автора from Авторы where Фамилия = '{SureNameBox.Text}' and Имя = '{NameBox.Text}' and Отчество = '{MiddleNameBox.Text}'";
            int authorCode = Convert.ToInt32(cmd.ExecuteScalar());

            SqlCommand cmd2 = cnn.CreateCommand();
            cmd2.CommandText = @"Select count(Код_книги) from Книги where Код_Автора = " + authorCode;
            string booksAmount = Convert.ToString(cmd2.ExecuteScalar());
            AmountBox.Text = booksAmount;

            cnn.Close();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = $"Select Код_Автора from Авторы where Фамилия = '{SureNameBox.Text}' and Имя = '{NameBox.Text}' and Отчество = '{MiddleNameBox.Text}'";
            int authorCode = Convert.ToInt32(cmd.ExecuteScalar());

            SqlCommand cmd2 = cnn.CreateCommand();
            cmd2.CommandText = @"Select count(Код_книги) from Книги where Код_Автора = " + authorCode;
            string booksAmount = Convert.ToString(cmd2.ExecuteScalar());
            AmountBox.Text = booksAmount;

            cnn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        { 
            if ( !(string.IsNullOrEmpty(maskedTextBox1.Text)) && NameBox.Text != "" && SureNameBox.Text != "" && MiddleNameBox.Text != "" && OccupationBox.Text != "" && NationalityBox.Text !="" && AuthorCodeBox.Text != "")
            {
                string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"Insert into Авторы (Фамилия, Имя, Отчество, Дата_рожения, Национальность, Род_деятельности) values ('{SureNameBox.Text}', '{NameBox.Text}', '{MiddleNameBox.Text}', '{NationalityBox.Text}', '{OccupationBox.Text}') ";
                cmd.ExecuteNonQuery();

                SqlCommand newIfno = cnn.CreateCommand();
                newIfno.CommandText = $"select top 1 * from Авторы order by Код_Автора desc";
                MessageBox.Show("Новый автора был добавлен", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cnn.Close();
            }
            else
            {
                MessageBox.Show("Для добавления в таблицу необходимо заполнить все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            if ( !(string.IsNullOrEmpty(maskedTextBox1.Text)) && NameBox.Text != "" && SureNameBox.Text != "" && MiddleNameBox.Text != "" && OccupationBox.Text != "" && NationalityBox.Text !="" && AuthorCodeBox.Text != "")
            {
                string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand IsExist = cnn.CreateCommand();
                IsExist.CommandText = $"Select count(Код_автора) from Авторы where Код_Автора = {AuthorCodeBox.Text}";
                int IsAutorExist = (int)IsExist.ExecuteScalar();

                if (IsAutorExist > 0)
                {
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = $"update Авторы set Фамилия = '{SureNameBox.Text}', Имя = '{NameBox.Text}', Отчество = '{MiddleNameBox.Text}', Национальность = '{NationalityBox.Text}', Род_деятельности = '{OccupationBox.Text}' where Код_автора = {AuthorCodeBox.Text}";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно изменены", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                cnn.Close();
            }
            else
            {
                MessageBox.Show("Для добавления в таблицу необходимо заполнить все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void OpenBooksForm_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Hide();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int athorcode = Convert.ToInt32(AuthorCodeBox.Text); 

            string connectionString = @"Server=DESKTOP-O7CQNSI; Database=MosovLabaOne; Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand IsExist = cnn.CreateCommand();
            IsExist.CommandText = $"Select count(Код_автора) from Авторы where Код_Автора = {athorcode}";
            int IsAutorExist = (int)IsExist.ExecuteScalar();

            if (IsAutorExist > 0)
            {
                MessageBox.Show($"Кол-во авторов: {IsAutorExist}\nКодАвтора: {athorcode}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = $"delete from Авторы where Код_Автора = {athorcode}";
                cmd.ExecuteScalar();
            }
            else
            {
                MessageBox.Show("Неверно введено значение поля Кода автора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            cnn.Close();
        }

        private void AuthorCodeBox_TextChanged(object sender, EventArgs e)
        {
            if (AuthorCodeBox.Text == "")
            {
                MessageBox.Show("Код автора не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Поле дожно быть иметь значения в формате ДД.ММ.ГГГГ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

