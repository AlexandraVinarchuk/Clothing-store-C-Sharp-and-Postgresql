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
    public partial class add_form3 : Form
    {

        DataBase dataBase = new DataBase();

        public add_form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_form3_Load(object sender, EventArgs e)
        {


        }

        private void soh23_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name3 = name3_textBox1.Text;
            int price3;
            var pack3 = pack3_textBox3.Text;
            int idord;
            int idto;
            int numbid;
            int quan3;
            int.TryParse(ord3_textBox4.Text, out idord);
            int.TryParse(idto_textBox5.Text, out idto);
            int.TryParse(numbid_textBox6.Text, out numbid);
            int.TryParse(quan3_textBox7.Text, out quan3);

            if (int.TryParse(price3_textBox2.Text, out price3))
            {
                var addQuery3 = $"insert into ordered_product (name, unit_price, packaging, ord_productid, productid, numb_contrid, quantity) values ('{name3}', '{price3}', '{pack3}', '{idord}', '{idto}', '{numbid}', '{quan3}')";

                var command3 = new NpgsqlCommand(addQuery3, dataBase.getConnection());
                command3.ExecuteNonQuery();

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
