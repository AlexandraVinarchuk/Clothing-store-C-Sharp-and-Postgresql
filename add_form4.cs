using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ClothStore2
{
    public partial class add_form4 : Form
    {
        DataBase dataBase = new DataBase();
        public add_form4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save4_button4_Click(object sender, EventArgs e)
        {

        }

        private void upd4_button3_Click(object sender, EventArgs e)
        {

        }

        private void del4_button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search4_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void add_form4_Load(object sender, EventArgs e)
        {

        }

        private void soh24_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name4 = namedir_textBox1.Text;
            var fio = fio_textBox2.Text;
            var adress = ad_textBox3.Text;
            var phone = tel_textBox4.Text;
            var bank = bank_textBox5.Text;
            int dirid;

            if (int.TryParse(iddir_textBox6.Text, out dirid))
            {
                var addQuery4 = $"insert into director (name, fio, adress, phone_numb, bank_requisites, directorid) values ('{name4}', '{fio}', '{adress}', '{phone}', '{bank}', '{dirid}')";

                var command4 = new NpgsqlCommand(addQuery4, dataBase.getConnection());
                command4.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID должен иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }
    }
}
