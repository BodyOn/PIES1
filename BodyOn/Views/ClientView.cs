using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodyOn.Models;
using BodyOn.Controller;

namespace BodyOn.Views
{
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getAll();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "123";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "123";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getByQuery(textBox1.Text);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = "123";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
