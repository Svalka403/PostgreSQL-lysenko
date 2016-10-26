using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String ConnectionString;
        NpgsqlConnection npgsqlConnection;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString = String.Format("Server={0};Port={1};User={2};Password={3};Database={4};",
                ServerTB.Text, PortTB.Text, UsernameTB.Text, PasswordTB.Text, DBNameTB.Text);
            npgsqlConnection = new NpgsqlConnection(ConnectionString);
            npgsqlConnection.Open();
            ConnectLabel.Text = String.Format("Подключено к серверу{0}:{1}", ServerTB.Text, PortTB.Text);



        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(QueryTB.Text, npgsqlConnection);
                NpgsqlCommandBuilder cd = new NpgsqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds);
                DataGrid.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            npgsqlConnection.Close();
            ConnectLabel.Text = "Отключено от сервера";
        }

        private void QueryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), DataGrid.Columns[e.ColumnIndex].Name);
        }
    }
}
