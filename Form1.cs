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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    enum RowState2
    {
        Existed2,
        New2,
        Modified2,
        ModifiedNew2,
        Deleted2
    }

    enum RowState3
    {
        Existed3,
        New3,
        Modified3,
        ModifiedNew3,
        Deleted3
    }

    enum RowState4
    {
        Existed4,
        New4,
        Modified4,
        ModifiedNew4,
        Deleted4
    }

    enum RowState5
    {
        Existed5,
        New5,
        Modified5,
        ModifiedNew5,
        Deleted5
    }

    enum RowState6
    {
        Existed6,
        New6,
        Modified6,
        ModifiedNew6,
        Deleted6
    }

    enum RowState7
    {
        Existed7,
        New7,
        Modified7,
        ModifiedNew7,
        Deleted7
    }

    enum RowState8
    {
        Existed8,
        New8,
        Modified8,
        ModifiedNew8,
        Deleted8
    }

    enum RowState9
    {
        Existed9,
        New9,
        Modified9,
        ModifiedNew9,
        Deleted9
    }


    public partial class Form1 : Form
    {
        DataBase database = new DataBase();

        int selectedRow;

        int selectedRow2;

        int selectedRow3;

        int selectedRow4;

        int selectedRow5;

        int selectedRow6;

        int selectedRow7;

        int selectedRow8;

        int selectedRow9;

        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("name", "Название товара");
            dataGridView1.Columns.Add("unit_price", "Цена");
            dataGridView1.Columns.Add("packaging", "Упаковка");
            dataGridView1.Columns.Add("batch_delivery", "Поставка партии");
            dataGridView1.Columns.Add("note", "Заметки");
            dataGridView1.Columns.Add("producerid", "Поставщик");
            dataGridView1.Columns.Add("productid", "id");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void CreateColumns2()
        {
            dataGridView2.Columns.Add("quantity", "Количество товара");
            dataGridView2.Columns.Add("unit_price", "Цена");
            dataGridView2.Columns.Add("packaging", "Упаковка");
            dataGridView2.Columns.Add("productstid", "idst");
            dataGridView2.Columns.Add("productid", "id");
            dataGridView2.Columns.Add("name", "Название товара");
            dataGridView2.Columns.Add("IsNew2", String.Empty);
        }
        private void CreateColumns3()
        {
            dataGridView3.Columns.Add("name", "Название товара");
            dataGridView3.Columns.Add("unit_price", "Цена");
            dataGridView3.Columns.Add("packaging", "Упаковка");
            dataGridView3.Columns.Add("ord_productid", "Id заказанного товара");
            dataGridView3.Columns.Add("productid", "id товара");
            dataGridView3.Columns.Add("numb_contrid", "ID договора на продажу");
            dataGridView3.Columns.Add("quantity", "Количество");
            dataGridView3.Columns.Add("IsNew3", String.Empty);
        }

        private void CreateColumns4()
        {
            dataGridView4.Columns.Add("name", "Название");
            dataGridView4.Columns.Add("fio", "ФИО");
            dataGridView4.Columns.Add("adress", "Адрес");
            dataGridView4.Columns.Add("phone_numb", "Номер телефона");
            dataGridView4.Columns.Add("bank_requisites", "Банк. рекв.");
            dataGridView4.Columns.Add("directorid", "ID директора");
            dataGridView4.Columns.Add("IsNew4", String.Empty);
        }

        private void CreateColumns5()
        {
            dataGridView5.Columns.Add("producerid", "ID поставщика");
            dataGridView5.Columns.Add("name", "Название");
            dataGridView5.Columns.Add("adress", "Адрес");
            dataGridView5.Columns.Add("bank_requisites", "Банк. рекв.");
            dataGridView5.Columns.Add("IsNew5", String.Empty);
        }

        private void CreateColumns6()
        {
            dataGridView6.Columns.Add("fio_buyer", "ФИО");
            dataGridView6.Columns.Add("buyerid", "ID покупателя");
            dataGridView6.Columns.Add("IsNew6", String.Empty);
        }

        private void CreateColumns7()
        {
            dataGridView7.Columns.Add("order_number", "Номер заказа");
            dataGridView7.Columns.Add("product_name", "Название товара");
            dataGridView7.Columns.Add("price", "Цена");
            dataGridView7.Columns.Add("terms_delivery", "Условия доставки");
            dataGridView7.Columns.Add("contract_numb", "Номер договора");
            dataGridView7.Columns.Add("sum", "Сумма");
            dataGridView7.Columns.Add("bank_requisites", "Банк. рекв.");
            dataGridView7.Columns.Add("contract_numberid", "ID договора на покупку");
            dataGridView7.Columns.Add("producerid", "ID поставщика");
            dataGridView7.Columns.Add("directorid", "ID директора");
            dataGridView7.Columns.Add("date_contr", "Дата заключения");
            dataGridView7.Columns.Add("IsNew7", String.Empty);
        }

        private void CreateColumns8()
        {
            dataGridView8.Columns.Add("numb_contrid", "ID договора на продажу");
            dataGridView8.Columns.Add("buyerid", "ID покупателя");
            dataGridView8.Columns.Add("req_bank", "Банк. рекв.");
            dataGridView8.Columns.Add("directorid", "ID директора");
            dataGridView8.Columns.Add("conclusion_date", "Дата заключения");
            dataGridView8.Columns.Add("IsNew8", String.Empty);
        }

        private void CreateColumns9()
        {
            dataGridView9.Columns.Add("number", "Номер счета");
            dataGridView9.Columns.Add("sum", "Суммаа");
            dataGridView9.Columns.Add("vat", "НДС");
            dataGridView9.Columns.Add("payment_mark", "Отметка об оплате");
            dataGridView9.Columns.Add("accountid", "ID счета");
            dataGridView9.Columns.Add("contract_numberid", "ID договора на покупку");
            dataGridView9.Columns.Add("numb_contrid", "ID договора на продажу");
            dataGridView9.Columns.Add("datasale", "Дата");
            dataGridView9.Columns.Add("IsNew9", String.Empty);
        }

        private void ClearFields()
        {
            id_textBox4.Text = "";
            batch_textBox6.Text = "";
            price_textBox5.Text = "";
            prod_textBox1.Text = "";
            note_textBox7.Text = "";
            pack_textBox3.Text = "";
            name_textBox2.Text = "";
        }

        private void ClearFields2()
        {
            quan_textBox1.Text = "";
            price2_textBox2.Text = "";
            packi_textBox3.Text = "";
            idst_textBox4.Text = "";
            idt_textBox5.Text = "";
            namest_textBox6.Text = "";
        }

        private void ClearFields3()
        {
            name3_textBox1.Text = "";
            price3_textBox2.Text = "";
            pack3_textBox3.Text = "";
            ord3_textBox4.Text = "";
            idto_textBox5.Text = "";
            numbid_textBox6.Text = "";
            quan3_textBox7.Text = "";
        }

        private void ClearFields4()
        {
            namedir_textBox1.Text = "";
            fio_textBox2.Text = "";
            ad_textBox3.Text = "";
            tel_textBox4.Text = "";
            bank_textBox5.Text = "";
            iddir_textBox6.Text = "";
        }

        private void ClearFields5()
        {
            idpost_textBox1.Text = "";
            name5_textBox2.Text = "";
            adress_textBox3.Text = "";
            bank5_textBox4.Text = "";
        }

        private void ClearFields6()
        {
            fio6_textBox1.Text = "";
            idbuyer_textBox2.Text = "";
        }

        private void ClearFields7()
        {
            numb7_textBox1.Text = "";
            name7_textBox2.Text = "";
            price7_textBox3.Text = "";
            terms_textBox4.Text = "";
            numbdog_textBox5.Text = "";
            sum_textBox6.Text = "";
            bank7_textBox7.Text = "";
            iddog_textBox8.Text = "";
            postid_textBox9.Text = "";
            dirid_textBox10.Text = "";
            data_textBox11.Text = "";
        }

        private void ClearFields8()
        {
            idprodaza_textBox1.Text = "";
            pokupid_textBox2.Text = "";
            bank8_textBox3.Text = "";
            dirid8_textBox4.Text = "";
            date8_textBox5.Text = "";
        }

        private void ClearFields9()
        {
            number9_textBox1.Text = "";
            summ9_textBox2.Text = "";
            vat_textBox3.Text = "";
            payment_textBox4.Text = "";
            accountid_textBox5.Text = "";
            iddogpok_textBox6.Text = "";
            iddogprod_textBox7.Text = "";
            date9_textBox8.Text = "";
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetInt32(5), record.GetInt32(6), RowState.ModifiedNew);
        }

        private void ReadSingleRow2(DataGridView dgw2, IDataRecord record2)
        {
            dgw2.Rows.Add(record2.GetInt32(0), record2.GetInt32(1), record2.GetString(2), record2.GetInt32(3), record2.GetInt32(4), record2.GetString(5), RowState2.ModifiedNew2);
        }

        private void ReadSingleRow3(DataGridView dgw3, IDataRecord record3)
        {
            dgw3.Rows.Add(record3.GetString(0), record3.GetInt32(1), record3.GetString(2), record3.GetInt32(3), record3.GetInt32(4), record3.GetInt32(5), record3.GetInt32(6), RowState3.ModifiedNew3);
        }

        private void ReadSingleRow4(DataGridView dgw4, IDataRecord record4)
        {
            dgw4.Rows.Add(record4.GetString(0), record4.GetString(1), record4.GetString(2), record4.GetString(3), record4.GetString(4), record4.GetInt32(5), RowState4.ModifiedNew4);
        }

        private void ReadSingleRow5(DataGridView dgw5, IDataRecord record5)
        {
            dgw5.Rows.Add(record5.GetInt32(0), record5.GetString(1), record5.GetString(2), record5.GetString(3), RowState5.ModifiedNew5);
        }

        private void ReadSingleRow6(DataGridView dgw6, IDataRecord record6)
        {
            dgw6.Rows.Add(record6.GetString(0), record6.GetInt32(1), RowState6.ModifiedNew6);
        }

        private void ReadSingleRow7(DataGridView dgw7, IDataRecord record7)
        {
            dgw7.Rows.Add(record7.GetInt32(0), record7.GetString(1), record7.GetInt32(2), record7.GetString(3), record7.GetInt32(4), record7.GetInt32(5), record7.GetString(6), record7.GetInt32(7), record7.GetInt32(8), record7.GetInt32(9), record7.GetString(10), RowState7.ModifiedNew7);
        }

        private void ReadSingleRow8(DataGridView dgw8, IDataRecord record8)
        {
            dgw8.Rows.Add(record8.GetInt32(0), record8.GetInt32(1), record8.GetString(2), record8.GetInt32(3), record8.GetString(4), RowState8.ModifiedNew8);
        }

        private void ReadSingleRow9(DataGridView dgw9, IDataRecord record9)
        {
            dgw9.Rows.Add(record9.GetInt32(0), record9.GetInt32(1), record9.GetInt32(2), record9.GetString(3), record9.GetInt32(4), record9.GetInt32(5), record9.GetInt32(6), record9.GetString(7), RowState9.ModifiedNew9);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from product";

            NpgsqlCommand command = new NpgsqlCommand(queryString, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void RefreshDataGrid2(DataGridView dgw2)
        {
            dgw2.Rows.Clear();

            string queryString2 = $"select * from product_stock";

            NpgsqlCommand command2 = new NpgsqlCommand(queryString2, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                ReadSingleRow2(dgw2, reader2);
            }
            reader2.Close();
        }

        private void RefreshDataGrid3(DataGridView dgw3)
        {
            dgw3.Rows.Clear();

            string queryString3 = $"select * from ordered_product";

            NpgsqlCommand command3 = new NpgsqlCommand(queryString3, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                ReadSingleRow3(dgw3, reader3);
            }
            reader3.Close();
        }

        private void RefreshDataGrid4(DataGridView dgw4)
        {
            dgw4.Rows.Clear();

            string queryString4 = $"select * from director";

            NpgsqlCommand command4 = new NpgsqlCommand(queryString4, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader4 = command4.ExecuteReader();

            while (reader4.Read())
            {
                ReadSingleRow4(dgw4, reader4);
            }
            reader4.Close();
        }

        private void RefreshDataGrid5(DataGridView dgw5)
        {
            dgw5.Rows.Clear();

            string queryString5 = $"select * from producer";

            NpgsqlCommand command5 = new NpgsqlCommand(queryString5, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader5 = command5.ExecuteReader();

            while (reader5.Read())
            {
                ReadSingleRow5(dgw5, reader5);
            }
            reader5.Close();
        }

        private void RefreshDataGrid6(DataGridView dgw6)
        {
            dgw6.Rows.Clear();

            string queryString6 = $"select * from buyer";

            NpgsqlCommand command6 = new NpgsqlCommand(queryString6, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {
                ReadSingleRow6(dgw6, reader6);
            }
            reader6.Close();
        }

        private void RefreshDataGrid7(DataGridView dgw7)
        {
            dgw7.Rows.Clear();

            string queryString7 = $"select * from purchase_agreement";

            NpgsqlCommand command7 = new NpgsqlCommand(queryString7, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader7 = command7.ExecuteReader();

            while (reader7.Read())
            {
                ReadSingleRow7(dgw7, reader7);
            }
            reader7.Close();
        }

        private void RefreshDataGrid8(DataGridView dgw8)
        {
            dgw8.Rows.Clear();

            string queryString8 = $"select * from sale_contract";

            NpgsqlCommand command8 = new NpgsqlCommand(queryString8, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader8 = command8.ExecuteReader();

            while (reader8.Read())
            {
                ReadSingleRow8(dgw8, reader8);
            }
            reader8.Close();
        }

        private void RefreshDataGrid9(DataGridView dgw9)
        {
            dgw9.Rows.Clear();

            string queryString9 = $"select * from account";

            NpgsqlCommand command9 = new NpgsqlCommand(queryString9, database.getConnection());

            database.openConnection();

            NpgsqlDataReader reader9 = command9.ExecuteReader();

            while (reader9.Read())
            {
                ReadSingleRow9(dgw9, reader9);
            }
            reader9.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            CreateColumns2();
            CreateColumns3();
            CreateColumns4();
            CreateColumns5();
            CreateColumns6();
            CreateColumns7();
            CreateColumns8();
            CreateColumns9();
            RefreshDataGrid(dataGridView1);
            RefreshDataGrid2(dataGridView2);
            RefreshDataGrid3(dataGridView3);
            RefreshDataGrid4(dataGridView4);
            RefreshDataGrid5(dataGridView5);
            RefreshDataGrid6(dataGridView6);
            RefreshDataGrid7(dataGridView7);
            RefreshDataGrid8(dataGridView8);
            RefreshDataGrid9(dataGridView9);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                name_textBox2.Text = row.Cells[0].Value.ToString();
                price_textBox5.Text = row.Cells[1].Value.ToString();
                pack_textBox3.Text = row.Cells[2].Value.ToString();
                batch_textBox6.Text = row.Cells[3].Value.ToString();
                note_textBox7.Text = row.Cells[4].Value.ToString();
                prod_textBox1.Text = row.Cells[5].Value.ToString();
                id_textBox4.Text = row.Cells[6].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_form addfrm = new Add_form();
            addfrm.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from product where concat (name, unit_price, packaging, batch_delivery, note, producerid, productid) like '%" + textBox_search.Text + "%'";

            NpgsqlCommand com = new NpgsqlCommand(searchString, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void Search2(DataGridView dgw2)
        {
            dgw2.Rows.Clear();

            string searchString2 = $"select * from product_stock where concat (quantity, unit_price, packaging, productstid, productid, name) like '%" + search2_textBox1.Text + "%'";

            NpgsqlCommand com2 = new NpgsqlCommand(searchString2, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read2 = com2.ExecuteReader();

            while (read2.Read())
            {
                ReadSingleRow2(dgw2, read2);
            }

            read2.Close();
        }

        private void Search3(DataGridView dgw3)
        {
            dgw3.Rows.Clear();

            string searchString3 = $"select * from ordered_product where concat (name, unit_price, packaging, ord_productid, productid, numb_contrid, quantity) like '%" + search3_textBox1.Text + "%'";

            NpgsqlCommand com3 = new NpgsqlCommand(searchString3, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read3 = com3.ExecuteReader();

            while (read3.Read())
            {
                ReadSingleRow3(dgw3, read3);
            }

            read3.Close();
        }

        private void Search4(DataGridView dgw4)
        {
            dgw4.Rows.Clear();

            string searchString4 = $"select * from director where concat (name, fio, adress, phone_numb, bank_requisites, directorid) like '%" + search4_textBox1.Text + "%'";

            NpgsqlCommand com4 = new NpgsqlCommand(searchString4, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read4 = com4.ExecuteReader();

            while (read4.Read())
            {
                ReadSingleRow4(dgw4, read4);
            }

            read4.Close();
        }

        private void Search5(DataGridView dgw5)
        {
            dgw5.Rows.Clear();

            string searchString5 = $"select * from producer where concat (producerid, name, adress, bank_requisites) like '%" + search5_textBox1.Text + "%'";

            NpgsqlCommand com5 = new NpgsqlCommand(searchString5, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read5 = com5.ExecuteReader();

            while (read5.Read())
            {
                ReadSingleRow5(dgw5, read5);
            }

            read5.Close();
        }

        private void Search6(DataGridView dgw6)
        {
            dgw6.Rows.Clear();

            string searchString6 = $"select * from buyer where concat (fio_buyer, buyerid) like '%" + search6_textBox1.Text + "%'";

            NpgsqlCommand com6 = new NpgsqlCommand(searchString6, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read6 = com6.ExecuteReader();

            while (read6.Read())
            {
                ReadSingleRow6(dgw6, read6);
            }

            read6.Close();
        }

        private void Search7(DataGridView dgw7)
        {
            dgw7.Rows.Clear();

            string searchString7 = $"select * from purchase_agreement where concat (order_number, product_name, price, terms_delivery, contract_numb, sum, bank_requisites, contract_numberid, producerid, directorid, date_contr) like '%" + search7_textBox1.Text + "%'";

            NpgsqlCommand com7 = new NpgsqlCommand(searchString7, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read7 = com7.ExecuteReader();

            while (read7.Read())
            {
                ReadSingleRow7(dgw7, read7);
            }

            read7.Close();
        }

        private void Search8(DataGridView dgw8)
        {
            dgw8.Rows.Clear();

            string searchString8 = $"select * from sale_contract where concat (numb_contrid, buyerid, req_bank, directorid, conclusion_date) like '%" + search8_textBox1.Text + "%'";

            NpgsqlCommand com8 = new NpgsqlCommand(searchString8, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read8 = com8.ExecuteReader();

            while (read8.Read())
            {
                ReadSingleRow8(dgw8, read8);
            }

            read8.Close();
        }

        private void Search9(DataGridView dgw9)
        {
            dgw9.Rows.Clear();

            string searchString9 = $"select * from account where concat (number, sum, vat, payment_mark, accountid, contract_numberid, numb_contrid, datasale) like '%" + search9_textBox1.Text + "%'";

            NpgsqlCommand com9 = new NpgsqlCommand(searchString9, database.getConnection());

            database.openConnection();

            NpgsqlDataReader read9 = com9.ExecuteReader();

            while (read9.Read())
            {
                ReadSingleRow9(dgw9, read9);
            }

            read9.Close();
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void deleteRow2()
        {
            int index2 = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index2].Visible = false;

            if (dataGridView2.Rows[index2].Cells[3].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index2].Cells[6].Value = RowState2.Deleted2;
                return;
            }

            dataGridView2.Rows[index2].Cells[6].Value = RowState2.Deleted2;
        }

        private void deleteRow3()
        {
            int index3 = dataGridView3.CurrentCell.RowIndex;

            dataGridView3.Rows[index3].Visible = false;

            if (dataGridView3.Rows[index3].Cells[3].Value.ToString() == string.Empty)
            {
                dataGridView3.Rows[index3].Cells[7].Value = RowState3.Deleted3;
                return;
            }

            dataGridView3.Rows[index3].Cells[7].Value = RowState3.Deleted3;
        }

        private void deleteRow4()
        {
            int index4 = dataGridView4.CurrentCell.RowIndex;

            dataGridView4.Rows[index4].Visible = false;

            if (dataGridView4.Rows[index4].Cells[5].Value.ToString() == string.Empty)
            {
                dataGridView4.Rows[index4].Cells[6].Value = RowState4.Deleted4;
                return;
            }

            dataGridView4.Rows[index4].Cells[6].Value = RowState4.Deleted4;
        }

        private void deleteRow5()
        {
            int index5 = dataGridView5.CurrentCell.RowIndex;

            dataGridView5.Rows[index5].Visible = false;

            if (dataGridView5.Rows[index5].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView5.Rows[index5].Cells[4].Value = RowState5.Deleted5;
                return;
            }

            dataGridView5.Rows[index5].Cells[4].Value = RowState5.Deleted5;
        }

        private void deleteRow6()
        {
            int index6 = dataGridView6.CurrentCell.RowIndex;

            dataGridView6.Rows[index6].Visible = false;

            if (dataGridView6.Rows[index6].Cells[1].Value.ToString() == string.Empty)
            {
                dataGridView6.Rows[index6].Cells[2].Value = RowState6.Deleted6;
                return;
            }

            dataGridView6.Rows[index6].Cells[2].Value = RowState6.Deleted6;
        }

        private void deleteRow7()
        {
            int index7 = dataGridView7.CurrentCell.RowIndex;

            dataGridView7.Rows[index7].Visible = false;

            if (dataGridView7.Rows[index7].Cells[2].Value.ToString() == string.Empty)
            {
                dataGridView7.Rows[index7].Cells[11].Value = RowState7.Deleted7;
                return;
            }

            dataGridView7.Rows[index7].Cells[11].Value = RowState7.Deleted7;
        }

        private void deleteRow8()
        {
            int index8 = dataGridView8.CurrentCell.RowIndex;

            dataGridView8.Rows[index8].Visible = false;

            if (dataGridView8.Rows[index8].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView8.Rows[index8].Cells[5].Value = RowState8.Deleted8;
                return;
            }

            dataGridView8.Rows[index8].Cells[5].Value = RowState8.Deleted8;
        }

        private void deleteRow9()
        {
            int index9 = dataGridView9.CurrentCell.RowIndex;

            dataGridView9.Rows[index9].Visible = false;

            if (dataGridView9.Rows[index9].Cells[4].Value.ToString() == string.Empty)
            {
                dataGridView9.Rows[index9].Cells[8].Value = RowState9.Deleted9;
                return;
            }

            dataGridView9.Rows[index9].Cells[8].Value = RowState9.Deleted9;
        }
        private new void Update()
        {
            database.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[6].Value);
                    var deleteQuery = $"delete from product where productid = {id}";

                    var command = new NpgsqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                } 

                if(rowState == RowState.Modified)
                {
                    var name = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var pack = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var batch = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var note = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var prod = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var id = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update product set name = '{name}', unit_price = '{price}', packaging = '{pack}', batch_delivery = '{batch}', note = '{note}', producerid = '{prod}', productid = '{id}' where productid = '{id}'";

                    var command = new NpgsqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update2()
        {
            database.openConnection();

            for (int index2 = 0; index2 < dataGridView2.Rows.Count; index2++)
            {
                var rowState2 = (RowState2)dataGridView2.Rows[index2].Cells[6].Value;

                if (rowState2 == RowState2.Existed2)
                    continue;

                if (rowState2 == RowState2.Deleted2)
                {
                    var idst = Convert.ToInt32(dataGridView2.Rows[index2].Cells[3].Value);
                    var deleteQuery2 = $"delete from product_stock where productstid = {idst}";

                    var command2 = new NpgsqlCommand(deleteQuery2, database.getConnection());
                    command2.ExecuteNonQuery();
                }

                if (rowState2 == RowState2.Modified2)
                {
                    var quan2 = dataGridView2.Rows[index2].Cells[0].Value.ToString();
                    var price2 = dataGridView2.Rows[index2].Cells[1].Value.ToString();
                    var packi = dataGridView2.Rows[index2].Cells[2].Value.ToString();
                    var idst = dataGridView2.Rows[index2].Cells[3].Value.ToString();
                    var idt = dataGridView2.Rows[index2].Cells[4].Value.ToString();
                    var namest = dataGridView2.Rows[index2].Cells[5].Value.ToString();


                    var changeQuery2 = $"update product_stock set quantity = '{quan2}', unit_price = '{price2}', packaging = '{packi}', productstid = '{idst}', productid = '{idt}', name = '{namest}' where productstid = '{idst}'";

                    var command2 = new NpgsqlCommand(changeQuery2, database.getConnection());
                    command2.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update3()
        {
            database.openConnection();

            for (int index3 = 0; index3 < dataGridView3.Rows.Count; index3++)
            {
                var rowState3 = (RowState3)dataGridView3.Rows[index3].Cells[7].Value;

                if (rowState3 == RowState3.Existed3)
                    continue;

                if (rowState3 == RowState3.Deleted3)
                {
                    var idord = Convert.ToInt32(dataGridView3.Rows[index3].Cells[3].Value);
                    var deleteQuery3 = $"delete from ordered_product where ord_productid = {idord}";

                    var command3 = new NpgsqlCommand(deleteQuery3, database.getConnection());
                    command3.ExecuteNonQuery();
                }

                if (rowState3 == RowState3.Modified3)
                {
                    var name3 = dataGridView3.Rows[index3].Cells[0].Value.ToString();
                    var price3 = dataGridView3.Rows[index3].Cells[1].Value.ToString();
                    var pack3 = dataGridView3.Rows[index3].Cells[2].Value.ToString();
                    var idord = dataGridView3.Rows[index3].Cells[3].Value.ToString();
                    var idto = dataGridView3.Rows[index3].Cells[4].Value.ToString();
                    var numbid = dataGridView3.Rows[index3].Cells[5].Value.ToString();
                    var quan3 = dataGridView3.Rows[index3].Cells[6].Value.ToString();

                    var changeQuery3 = $"update ordered_product set name = '{name3}', unit_price = '{price3}', packaging = '{pack3}', ord_productid = '{idord}', productid = '{idto}', numb_contrid = '{numbid}', quantity = '{quan3}' where ord_productid = '{idord}'";

                    var command3 = new NpgsqlCommand(changeQuery3, database.getConnection());
                    command3.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update4()
        {
            database.openConnection();

            for (int index4 = 0; index4 < dataGridView4.Rows.Count; index4++)
            {
                var rowState4 = (RowState4)dataGridView4.Rows[index4].Cells[6].Value;

                if (rowState4 == RowState4.Existed4)
                    continue;

                if (rowState4 == RowState4.Deleted4)
                {
                    var dirid = (dataGridView4.Rows[index4].Cells[5].Value);
                    var deleteQuery4 = $"delete from director where directorid = {dirid}";

                    var command4 = new NpgsqlCommand(deleteQuery4, database.getConnection());
                    command4.ExecuteNonQuery();
                }

                if (rowState4 == RowState4.Modified4)
                {
                    var name4 = dataGridView4.Rows[index4].Cells[0].Value.ToString();
                    var fio = dataGridView4.Rows[index4].Cells[1].Value.ToString();
                    var adress = dataGridView4.Rows[index4].Cells[2].Value.ToString();
                    var phone = dataGridView4.Rows[index4].Cells[3].Value.ToString();
                    var bank = dataGridView4.Rows[index4].Cells[4].Value.ToString();
                    var dirid = dataGridView4.Rows[index4].Cells[5].Value.ToString();

                    var changeQuery4 = $"update director set name = '{name4}', fio = '{fio}', adress = '{adress}', phone_numb = '{phone}', bank_requisites = '{bank}', directorid = '{dirid}' where directorid = '{dirid}'";

                    var command4 = new NpgsqlCommand(changeQuery4, database.getConnection());
                    command4.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update5()
        {
            database.openConnection();

            for (int index5 = 0; index5 < dataGridView5.Rows.Count; index5++)
            {
                var rowState5 = (RowState5)dataGridView5.Rows[index5].Cells[4].Value;

                if (rowState5 == RowState5.Existed5)
                    continue;

                if (rowState5 == RowState5.Deleted5)
                {
                    var prodid = (dataGridView5.Rows[index5].Cells[0].Value);
                    var deleteQuery5 = $"delete from producer where producerid = {prodid}";

                    var command5 = new NpgsqlCommand(deleteQuery5, database.getConnection());
                    command5.ExecuteNonQuery();
                }

                if (rowState5 == RowState5.Modified5)
                {
                    var prodid = dataGridView5.Rows[index5].Cells[0].Value.ToString();
                    var name5 = dataGridView5.Rows[index5].Cells[1].Value.ToString();
                    var adress5 = dataGridView5.Rows[index5].Cells[2].Value.ToString();
                    var bank5 = dataGridView5.Rows[index5].Cells[3].Value.ToString();

                    var changeQuery5 = $"update producer set producerid = '{prodid}', name = '{name5}', adress = '{adress5}', bank_requisites = '{bank5}' where producerid = '{prodid}'";

                    var command5 = new NpgsqlCommand(changeQuery5, database.getConnection());
                    command5.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update6()
        {
            database.openConnection();

            for (int index6 = 0; index6 < dataGridView6.Rows.Count; index6++)
            {
                var rowState6 = (RowState6)dataGridView6.Rows[index6].Cells[2].Value;

                if (rowState6 == RowState6.Existed6)
                    continue;

                if (rowState6 == RowState6.Deleted6)
                {
                    var buyerid = (dataGridView6.Rows[index6].Cells[1].Value);
                    var deleteQuery6 = $"delete from buyer where buyerid = {buyerid}";

                    var command6 = new NpgsqlCommand(deleteQuery6, database.getConnection());
                    command6.ExecuteNonQuery();
                }

                if (rowState6 == RowState6.Modified6)
                {
                    var fio6 = dataGridView6.Rows[index6].Cells[0].Value.ToString();
                    var buyerid = dataGridView6.Rows[index6].Cells[1].Value.ToString();

                    var changeQuery6 = $"update buyer set fio_buyer = '{fio6}', buyerid = '{buyerid}' where buyerid = '{buyerid}'";

                    var command6 = new NpgsqlCommand(changeQuery6, database.getConnection());
                    command6.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update7()
        {
            database.openConnection();

            for (int index7 = 0; index7 < dataGridView7.Rows.Count; index7++)
            {
                var rowState7 = (RowState7)dataGridView7.Rows[index7].Cells[11].Value;

                if (rowState7 == RowState7.Existed7)
                    continue;

                if (rowState7 == RowState7.Deleted7)
                {
                    var contrid = Convert.ToInt32(dataGridView7.Rows[index7].Cells[7].Value);
                    var deleteQuery7 = $"delete from purchase_agreement where contract_numberid = {contrid}";

                    var command7 = new NpgsqlCommand(deleteQuery7, database.getConnection());
                    command7.ExecuteNonQuery();
                }

                if (rowState7 == RowState7.Modified7)
                {
                    var numbz = dataGridView7.Rows[index7].Cells[0].Value.ToString();
                    var name7 = dataGridView7.Rows[index7].Cells[1].Value.ToString();
                    var price7 = dataGridView7.Rows[index7].Cells[2].Value.ToString();
                    var terms = dataGridView7.Rows[index7].Cells[3].Value.ToString();
                    var numbdog = dataGridView7.Rows[index7].Cells[4].Value.ToString();
                    var sum = dataGridView7.Rows[index7].Cells[5].Value.ToString();
                    var bank7 = dataGridView7.Rows[index7].Cells[6].Value.ToString();
                    var iddog = dataGridView7.Rows[index7].Cells[7].Value.ToString();
                    var postid = dataGridView7.Rows[index7].Cells[8].Value.ToString();
                    var dirid = dataGridView7.Rows[index7].Cells[9].Value.ToString();
                    var data = dataGridView7.Rows[index7].Cells[10].Value.ToString();

                    var changeQuery7 = $"update purchase_agreement set order_number = '{numbz}', product_name = '{name7}', price = '{price7}', terms_delivery = '{terms}', contract_numb = '{numbdog}', sum = '{sum}', bank_requisites = '{bank7}', contract_numberid = '{iddog}', producerid = '{postid}', directorid = '{dirid}', date_contr = '{data}' where contract_numberid = '{iddog}'";

                    var command7 = new NpgsqlCommand(changeQuery7, database.getConnection());
                    command7.ExecuteNonQuery();

                }
            }
            database.closeConnection();
        }

        private void Update8()
        {
            database.openConnection();

            for (int index8 = 0; index8 < dataGridView8.Rows.Count; index8++)
            {
                var rowState8 = (RowState8)dataGridView8.Rows[index8].Cells[5].Value;

                if (rowState8 == RowState8.Existed8)
                    continue;

                if (rowState8 == RowState8.Deleted8)
                {
                    var numbid = (dataGridView8.Rows[index8].Cells[0].Value);
                    var deleteQuery8 = $"delete from sale_contract where numb_contrid = {numbid}";

                    var command8 = new NpgsqlCommand(deleteQuery8, database.getConnection());
                    command8.ExecuteNonQuery();
                }

                if (rowState8 == RowState8.Modified8)
                {
                    var numb8 = dataGridView8.Rows[index8].Cells[0].Value.ToString();
                    var buyerid8 = dataGridView8.Rows[index8].Cells[1].Value.ToString();
                    var bank8 = dataGridView8.Rows[index8].Cells[2].Value.ToString();
                    var directorid = dataGridView8.Rows[index8].Cells[3].Value.ToString();
                    var date8 = dataGridView8.Rows[index8].Cells[4].Value.ToString();

                    var changeQuery8 = $"update sale_contract set numb_contrid = '{numb8}', buyerid = '{buyerid8}', req_bank = '{bank8}', directorid = '{directorid}', conclusion_date = '{date8}' where numb_contrid = '{numb8}'";

                    var command8 = new NpgsqlCommand(changeQuery8, database.getConnection());
                    command8.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void Update9()
        {
            database.openConnection();

            for (int index9 = 0; index9 < dataGridView9.Rows.Count; index9++)
            {
                var rowState9 = (RowState9)dataGridView9.Rows[index9].Cells[8].Value;

                if (rowState9 == RowState9.Existed9)
                    continue;

                if (rowState9 == RowState9.Deleted9)
                {
                    var accountid = (dataGridView9.Rows[index9].Cells[4].Value);
                    var deleteQuery9 = $"delete from account where accountid = {accountid}";

                    var command9 = new NpgsqlCommand(deleteQuery9, database.getConnection());
                    command9.ExecuteNonQuery();
                }

                if (rowState9 == RowState9.Modified9)
                {
                    var number = dataGridView9.Rows[index9].Cells[0].Value.ToString();
                    var sum9 = dataGridView9.Rows[index9].Cells[1].Value.ToString();
                    var vat = dataGridView9.Rows[index9].Cells[2].Value.ToString();
                    var payment = dataGridView9.Rows[index9].Cells[3].Value.ToString();
                    var accountid9 = dataGridView9.Rows[index9].Cells[4].Value.ToString();
                    var contractid = dataGridView9.Rows[index9].Cells[5].Value.ToString();
                    var numbid = dataGridView9.Rows[index9].Cells[6].Value.ToString();
                    var datasale = dataGridView9.Rows[index9].Cells[7].Value.ToString();

                    var changeQuery9 = $"update account set number = '{number}', sum = '{sum9}', vat = '{vat}', payment_mark = '{payment}', accountid = '{accountid9}', contract_numberid = '{contractid}', numb_contrid = '{numbid}', datasale = '{datasale}' where accountid = '{accountid9}'";

                    var command9 = new NpgsqlCommand(changeQuery9, database.getConnection());
                    command9.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update();
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var name = name_textBox2.Text;
            int price;
            var pack = pack_textBox3.Text;
            int batch;
            var note = note_textBox7.Text;
            int prod;
            int id;
            int.TryParse(batch_textBox6.Text, out batch);
            int.TryParse(prod_textBox1.Text, out prod);
            int.TryParse(id_textBox4.Text, out id);

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].ToString() != string.Empty)
            {
                if (int.TryParse(price_textBox5.Text, out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(name, price, pack, batch, note, prod, id);
                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void Change2()
        {
            var selectedRowIndex2 = dataGridView2.CurrentCell.RowIndex;

            var quan2 = quan_textBox1.Text;
            int price2;
            var pack3 = pack3_textBox3.Text;
            int idst;
            int idt;
            var namest = namest_textBox6.Text;
            int.TryParse(idst_textBox4.Text, out idst);
            int.TryParse(idt_textBox5.Text, out idt);

            if (dataGridView2.Rows[selectedRowIndex2].Cells[1].ToString() != string.Empty)
            {
                if (int.TryParse(price2_textBox2.Text, out price2))
                {
                    dataGridView2.Rows[selectedRowIndex2].SetValues(quan2, price2, pack3, idst, idt, namest);
                    dataGridView2.Rows[selectedRowIndex2].Cells[6].Value = RowState2.Modified2;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void Change3()
        {
            var selectedRowIndex3 = dataGridView3.CurrentCell.RowIndex;

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
            int.TryParse(quan_textBox1.Text, out quan3);

            if (dataGridView3.Rows[selectedRowIndex3].Cells[1].ToString() != string.Empty)
            {
                if (int.TryParse(price3_textBox2.Text, out price3))
                {
                    dataGridView3.Rows[selectedRowIndex3].SetValues(name3, price3, pack3, idord, idto, numbid, quan3);
                    dataGridView3.Rows[selectedRowIndex3].Cells[7].Value = RowState3.Modified3;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!");
                }
            }
        }

        private void Change4()
        {
            var selectedRowIndex4 = dataGridView4.CurrentCell.RowIndex;

            var name4 = namedir_textBox1.Text;
            var fio = fio_textBox2.Text;
            var adress = ad_textBox3.Text;
            var phone = tel_textBox4.Text;
            var bank = bank_textBox5.Text;
            int dirid;

            if (dataGridView4.Rows[selectedRowIndex4].Cells[5].ToString() != string.Empty)
            {
                if (int.TryParse(iddir_textBox6.Text, out dirid))
                {
                    dataGridView4.Rows[selectedRowIndex4].SetValues(name4, fio, adress, phone, bank, dirid);
                    dataGridView4.Rows[selectedRowIndex4].Cells[6].Value = RowState4.Modified4;
                }
                else
                {
                    MessageBox.Show("ID должен иметь числовой формат");
                }
            }
        }

        private void Change5()
        {
            var selectedRowIndex5 = dataGridView5.CurrentCell.RowIndex;

            int prodid;
            var name5 = name5_textBox2.Text;
            var adress5 = adress_textBox3.Text;
            var bank5 = bank5_textBox4.Text;

            if (dataGridView5.Rows[selectedRowIndex5].Cells[0].ToString() != string.Empty)
            {
                if (int.TryParse(idpost_textBox1.Text, out prodid))
                {
                    dataGridView5.Rows[selectedRowIndex5].SetValues(prodid, name5, adress5, bank5);
                    dataGridView5.Rows[selectedRowIndex5].Cells[4].Value = RowState5.Modified5;
                }
                else
                {
                    MessageBox.Show("ID должен иметь числовой формат");
                }
            }
        }

        private void Change6()
        {
            var selectedRowIndex6 = dataGridView6.CurrentCell.RowIndex;

            var fio6 = fio6_textBox1.Text;
            int buyerid;

            if (dataGridView6.Rows[selectedRowIndex6].Cells[1].ToString() != string.Empty)
            {
                if (int.TryParse(idbuyer_textBox2.Text, out buyerid))
                {
                    dataGridView6.Rows[selectedRowIndex6].SetValues(fio6, buyerid);
                    dataGridView6.Rows[selectedRowIndex6].Cells[2].Value = RowState6.Modified6;
                }
                else
                {
                    MessageBox.Show("ID должен иметь числовой формат");
                }
            }
        }

        private void Change7()
        {
            var selectedRowIndex7 = dataGridView7.CurrentCell.RowIndex;

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

            if (dataGridView7.Rows[selectedRowIndex7].Cells[2].ToString() != string.Empty)
            {
                if (int.TryParse(price7_textBox3.Text, out price7))
                {
                    dataGridView7.Rows[selectedRowIndex7].SetValues(numbz, name7, price7, terms, numbdog, sum, bank7, iddog, postid, dirid, data);
                    dataGridView7.Rows[selectedRowIndex7].Cells[11].Value = RowState7.Modified7;
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат");
                }
            }
        }

        private void Change8()
        {
            var selectedRowIndex8 = dataGridView8.CurrentCell.RowIndex;

            int numb8;
            int buyerid8;
            var bank8 = bank8_textBox3.Text;
            int directorid;
            var date8 = date8_textBox5.Text;
            int.TryParse(pokupid_textBox2.Text, out buyerid8);
            int.TryParse(dirid8_textBox4.Text, out directorid);

            if (dataGridView8.Rows[selectedRowIndex8].Cells[0].ToString() != string.Empty)
            {
                if (int.TryParse(idprodaza_textBox1.Text, out numb8))
                {
                    dataGridView8.Rows[selectedRowIndex8].SetValues(numb8, buyerid8, bank8, directorid, date8);
                    dataGridView8.Rows[selectedRowIndex8].Cells[5].Value = RowState8.Modified8;
                }
                else
                {
                    MessageBox.Show("ID должен иметь числовой формат!");
                }
            }
        }

        private void Change9()
        {
            var selectedRowIndex9 = dataGridView9.CurrentCell.RowIndex;

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

            if (dataGridView9.Rows[selectedRowIndex9].Cells[4].ToString() != string.Empty)
            {
                if (int.TryParse(accountid_textBox5.Text, out accountid9))
                {
                    dataGridView9.Rows[selectedRowIndex9].SetValues(number, sum, vat, payment, accountid9, contractid, numbid, datasale);
                    dataGridView9.Rows[selectedRowIndex9].Cells[8].Value = RowState9.Modified9;
                }
                else
                {
                    MessageBox.Show("ID должен иметь числовой формат!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow2 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row2 = dataGridView2.Rows[selectedRow2];

                quan_textBox1.Text = row2.Cells[0].Value.ToString();
                price2_textBox2.Text = row2.Cells[1].Value.ToString();
                packi_textBox3.Text = row2.Cells[2].Value.ToString();
                idst_textBox4.Text = row2.Cells[3].Value.ToString();
                idt_textBox5.Text = row2.Cells[4].Value.ToString();
                namest_textBox6.Text = row2.Cells[5].Value.ToString();

            }
        }



        private void button11_Click(object sender, EventArgs e)
        {
            deleteRow2();
            ClearFields2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2(dataGridView2);
            ClearFields2();
        }

        private void search2_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search2(dataGridView2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Update2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            add_form2 addfrm2 = new add_form2();
            addfrm2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Change2();
            ClearFields2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClearFields2();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow3 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row3 = dataGridView3.Rows[selectedRow3];

                name3_textBox1.Text = row3.Cells[0].Value.ToString();
                price3_textBox2.Text = row3.Cells[1].Value.ToString();
                pack3_textBox3.Text = row3.Cells[2].Value.ToString();
                ord3_textBox4.Text = row3.Cells[3].Value.ToString();
                idto_textBox5.Text = row3.Cells[4].Value.ToString();
                numbid_textBox6.Text = row3.Cells[5].Value.ToString();
                quan3_textBox7.Text = row3.Cells[6].Value.ToString();

            }
        }

        private void del_button1_Click(object sender, EventArgs e)
        {
            deleteRow3();
            ClearFields3();
        }

        private void up_button1_Click(object sender, EventArgs e)
        {
            Change3();
            ClearFields3();
        }

        private void save_button1_Click(object sender, EventArgs e)
        {
            Update3();
        }

        private void del_button2_Click(object sender, EventArgs e)
        {
            ClearFields3();
        }

        private void ref_button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid3(dataGridView3);
            ClearFields3();
        }

        private void search3_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search3(dataGridView3);
        }

        private void name3_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow4 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row4 = dataGridView4.Rows[selectedRow4];

                namedir_textBox1.Text = row4.Cells[0].Value.ToString();
                fio_textBox2.Text = row4.Cells[1].Value.ToString();
                ad_textBox3.Text = row4.Cells[2].Value.ToString();
                tel_textBox4.Text = row4.Cells[3].Value.ToString();
                bank_textBox5.Text = row4.Cells[4].Value.ToString();
                iddir_textBox6.Text = row4.Cells[5].Value.ToString();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClearFields4();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RefreshDataGrid4(dataGridView4);
            ClearFields4();
        }

        private void search4_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search4(dataGridView4);
        }

        private void del4_button2_Click(object sender, EventArgs e)
        {
            deleteRow4();
            ClearFields4();
        }

        private void upd4_button3_Click(object sender, EventArgs e)
        {
            Change4();
            ClearFields4();
        }

        private void save4_button4_Click(object sender, EventArgs e)
        {
            Update4();
        }

        private void new_button1_Click(object sender, EventArgs e)
        {
            add_form3 addfrm3 = new add_form3();
            addfrm3.Show();
        }

        private void new4_button1_Click(object sender, EventArgs e)
        {
            add_form4 addfrm4 = new add_form4();
            addfrm4.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow5 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row5 = dataGridView5.Rows[selectedRow5];

                idpost_textBox1.Text = row5.Cells[0].Value.ToString();
                name5_textBox2.Text = row5.Cells[1].Value.ToString();
                adress_textBox3.Text = row5.Cells[2].Value.ToString();
                bank5_textBox4.Text = row5.Cells[3].Value.ToString();
            }
        }

        private void search5_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search5(dataGridView5);
        }

        private void del_button5_Click(object sender, EventArgs e)
        {
            ClearFields5();
        }

        private void upd_button5_Click(object sender, EventArgs e)
        {
            RefreshDataGrid5(dataGridView5);
            ClearFields5();
        }

        private void del5_button2_Click(object sender, EventArgs e)
        {
            deleteRow5();
            ClearFields5();
        }

        private void upd5_button3_Click(object sender, EventArgs e)
        {
            Change5();
            ClearFields5();
        }

        private void save5_button4_Click(object sender, EventArgs e)
        {
            Update5();
        }

        private void new5_button1_Click(object sender, EventArgs e)
        {
            add_form5 addfrm5 = new add_form5();
            addfrm5.Show();
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow6 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row6 = dataGridView6.Rows[selectedRow6];

                fio6_textBox1.Text = row6.Cells[0].Value.ToString();
                idbuyer_textBox2.Text = row6.Cells[1].Value.ToString();
            }
        }

        private void delete5_button2_Click(object sender, EventArgs e)
        {
            deleteRow6();
            ClearFields6();
        }

        private void upd6_button3_Click(object sender, EventArgs e)
        {
            Change6();
            ClearFields6();
        }

        private void save6_button4_Click(object sender, EventArgs e)
        {
            Update6();
        }

        private void del6_button1_Click(object sender, EventArgs e)
        {
            ClearFields6();
        }

        private void upd6_button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid6(dataGridView6);
            ClearFields6();
        }

        private void new6_button1_Click(object sender, EventArgs e)
        {
            add_form6 addfrm6 = new add_form6();
            addfrm6.Show();
        }

        private void search6_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search6(dataGridView6);
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow7 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row7 = dataGridView7.Rows[selectedRow7];

                numb7_textBox1.Text = row7.Cells[0].Value.ToString();
                name7_textBox2.Text = row7.Cells[1].Value.ToString();
                price7_textBox3.Text = row7.Cells[2].Value.ToString();
                terms_textBox4.Text = row7.Cells[3].Value.ToString();
                numbdog_textBox5.Text = row7.Cells[4].Value.ToString();
                sum_textBox6.Text = row7.Cells[5].Value.ToString();
                bank7_textBox7.Text = row7.Cells[6].Value.ToString();
                iddog_textBox8.Text = row7.Cells[7].Value.ToString();
                postid_textBox9.Text = row7.Cells[8].Value.ToString();
                dirid_textBox10.Text = row7.Cells[9].Value.ToString();
                data_textBox11.Text = row7.Cells[10].Value.ToString();
            }
        }

        private void del7_button1_Click(object sender, EventArgs e)
        {
            ClearFields7();
        }

        private void upd7_button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid7(dataGridView7);
            ClearFields7();
        }

        private void search7_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search7(dataGridView7);
        }

        private void del7_button2_Click(object sender, EventArgs e)
        {
            deleteRow7();
            ClearFields7();
        }

        private void upd7_button3_Click(object sender, EventArgs e)
        {
            Change7();
            ClearFields7();
        }

        private void save7_button4_Click(object sender, EventArgs e)
        {
            Update7();
        }

        private void new7_button1_Click(object sender, EventArgs e)
        {
            add_form7 addfrm7 = new add_form7();
            addfrm7.Show();
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow8 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row8 = dataGridView8.Rows[selectedRow8];

                idprodaza_textBox1.Text = row8.Cells[0].Value.ToString();
                pokupid_textBox2.Text = row8.Cells[1].Value.ToString();
                bank8_textBox3.Text = row8.Cells[2].Value.ToString();
                dirid8_textBox4.Text = row8.Cells[3].Value.ToString();
                date8_textBox5.Text = row8.Cells[4].Value.ToString();

            }
        }

        private void del8_button1_Click(object sender, EventArgs e)
        {
            ClearFields8();
        }

        private void upd8_button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid8(dataGridView8);
            ClearFields8();
        }

        private void search8_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search8(dataGridView8);
        }

        private void delete8_button2_Click(object sender, EventArgs e)
        {
            deleteRow8();
            ClearFields8();
        }

        private void upd8_button3_Click(object sender, EventArgs e)
        {
            Change8();
            ClearFields8();
        }

        private void save8_button4_Click(object sender, EventArgs e)
        {
            Update8();
        }

        private void new8_button1_Click(object sender, EventArgs e)
        {
            add_form8 addfrm8 = new add_form8();
            addfrm8.Show();
        }

        private void search9_textBox1_TextChanged(object sender, EventArgs e)
        {
            Search9(dataGridView9);
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow9 = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row9 = dataGridView9.Rows[selectedRow9];

                number9_textBox1.Text = row9.Cells[0].Value.ToString();
                summ9_textBox2.Text = row9.Cells[1].Value.ToString();
                vat_textBox3.Text = row9.Cells[2].Value.ToString();
                payment_textBox4.Text = row9.Cells[3].Value.ToString();
                accountid_textBox5.Text = row9.Cells[4].Value.ToString();
                iddogpok_textBox6.Text = row9.Cells[5].Value.ToString();
                iddogprod_textBox7.Text = row9.Cells[6].Value.ToString();
                date9_textBox8.Text = row9.Cells[7].Value.ToString();

            }
        }

        private void del9_button1_Click(object sender, EventArgs e)
        {
            ClearFields9();
        }

        private void upd9_button2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid9(dataGridView9);
            ClearFields9();
        }

        private void del9_button2_Click(object sender, EventArgs e)
        {
            deleteRow9();
            ClearFields9();
        }

        private void upd9_button3_Click(object sender, EventArgs e)
        {
            Change9();
            ClearFields9();
        }

        private void save9_button4_Click(object sender, EventArgs e)
        {
            Update9();
        }

        private void new9_button1_Click(object sender, EventArgs e)
        {
            add_form9 addfrm9 = new add_form9();
            addfrm9.Show();
        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}