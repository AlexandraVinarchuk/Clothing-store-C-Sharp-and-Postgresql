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
    public partial class Add_form : Form
    {
        DataBase dataBase = new DataBase();

        public Add_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = name_textBox2.Text;
            int price;
            var pack = pack_textBox3.Text;
            var batch = batch_textBox6.Text;
            var note = note_textBox7.Text;
            int prod;
            int id;
            int.TryParse(prod_textBox1.Text, out prod);
            int.TryParse(id_textBox4.Text, out id);

            if (int.TryParse(price_textBox5.Text, out price))
            {
                var addQuery = $"insert into product (name, unit_price, packaging, batch_delivery, note, producerid, productid) values ('{name}', '{price}', '{pack}', '{batch}', '{note}', '{prod}', '{id}')";

                var command = new NpgsqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }

        private void Add_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
