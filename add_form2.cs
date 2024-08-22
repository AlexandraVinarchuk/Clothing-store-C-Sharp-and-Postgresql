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
    public partial class add_form2 : Form
    {

        DataBase dataBase = new DataBase();

        public add_form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_form2_Load(object sender, EventArgs e)
        {

        }

        private void soh2_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var quan2 = quan_textBox1.Text;
            int price2;
            var packi = packi_textBox3.Text;
            int idst;
            int idt;
            var namest = namest_textBox6.Text;
            int.TryParse(idst_textBox4.Text, out idst);
            int.TryParse(idt_textBox5.Text, out idt);

            if (int.TryParse(price2_textBox2.Text, out price2))
            {
                var addQuery2 = $"insert into product_stock (quantity, unit_price, packaging, productstid, productid, name) values ('{quan2}', '{price2}', '{packi}', '{idst}', '{idt}', '{namest}')";

                var command2 = new NpgsqlCommand(addQuery2, dataBase.getConnection());
                command2.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
