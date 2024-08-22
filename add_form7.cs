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
    public partial class add_form7 : Form
    {
        DataBase dataBase = new DataBase();
        public add_form7()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_form7_Load(object sender, EventArgs e)
        {

        }

        private void soh27_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var numbz = numb7_textBox1.Text;
            var name7 = name7_textBox2.Text;
            int price7;
            var terms = terms_textBox4.Text;
            int numbdog;
            int sum;
            var bank7 = bank7_textBox7.Text;
            int iddog;
            int postid;
            int dirid;
            var data = data_textBox11.Text;
            int.TryParse(numbdog_textBox5.Text, out numbdog);
            int.TryParse(sum_textBox6.Text, out sum);
            int.TryParse(iddog_textBox8.Text, out iddog);
            int.TryParse(postid_textBox9.Text, out postid);
            int.TryParse(dirid_textBox10.Text, out dirid);

            if (int.TryParse(price7_textBox3.Text, out price7))
            {
                var addQuery7 = $"insert into purchase_agreement (order_number, product_name, price, terms_delivery, contract_numb, sum, bank_requisites, contract_numberid, producerid, directorid, date_contr) values ('{numbz}', '{name7}', '{price7}', '{terms}', '{numbdog}', '{sum}', '{bank7}', '{iddog}', '{postid}', '{dirid}', '{data}')";

                var command7 = new NpgsqlCommand(addQuery7, dataBase.getConnection());
                command7.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }
    }
}
