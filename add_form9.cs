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
    public partial class add_form9 : Form
    {
        DataBase dataBase = new DataBase();
        public add_form9()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_form9_Load(object sender, EventArgs e)
        {

        }

        private void soh29_button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int number;
            int sum;
            int vat;
            var payment = payment_textBox4.Text;
            int accountid9;
            int contractid;
            int numbid;
            var datasale = date9_textBox8.Text;
            int.TryParse(number9_textBox1.Text, out number);
            int.TryParse(summ9_textBox2.Text, out sum);
            int.TryParse(vat_textBox3.Text, out vat);
            int.TryParse(iddogpok_textBox6.Text, out contractid);
            int.TryParse(iddogprod_textBox7.Text, out numbid);

            if (int.TryParse(accountid_textBox5.Text, out accountid9))
            {
                var addQuery9 = $"insert into account (number, sum, vat, payment_mark, accountid, contract_numberid, numb_contrid, datasale) values ('{number}', '{sum}', '{vat}', '{payment}', '{accountid9}', '{contractid}', '{numbid}', '{datasale}')";

                var command9 = new NpgsqlCommand(addQuery9, dataBase.getConnection());
                command9.ExecuteNonQuery();

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
