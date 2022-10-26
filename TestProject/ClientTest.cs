using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Numerics;

namespace TestProject
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void GetAllClientTest()
        {
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getAll();

            Assert.IsNotNull(source, "nao foi possivel encontrar clientes");

        }

        [TestMethod]
        public void GetClientByNameTest()
        {
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getByQuery();

            Assert.IsNotNull(source, "nao foi possivel encontrar o cliente");
        }

        [TestMethod]
        public void AddClientTest()
        {
            ClientModel client = new ClientModel(int id,
                           "josue",
                           "rua 123",
                           "888",
                           "email",
                           "cpf",
                           100.0,
                           1.7,
                           "manha",
                           1,
                           "2022-03-03",
                           false);
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.add(client);

            Assert.IsNotNull(source, "nao foi possivel adicionar o cliente");

        }

        [TestMethod]
        public void UpdateClientTest()
        {
            ClientModel client = new ClientModel(int id,
                           "josue",
                           "rua 123",
                           "888",
                           "email",
                           "cpf",
                           100.0,
                           1.7,
                           "manha",
                           1,
                           "2022-03-03",
                           false);
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.update(client);

            Assert.IsNotNull(source, "nao foi possivel atualizar o cliente");
        }

        [TestMethod]
        public void DeleteClientTest()
        {
            ind id = 2;
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.delete(id);

            Assert.IsNotNull(source, "nao foi possivel deletar o cliente");
        }

        [TestMethod]
        public void RenderFormTest()
        {
            ClientView view = new ClientView();
            view.Show();
            Assert(view.isAcessible, "a view nao pode ser acessada");
        }

        [TestMethod]
        public void UpdateTableTest()
        {
            ClientView view = new ClientView();
            view.Show();
            view.dataGridView1.DataSource = null;
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getAll();
            view.DataGridView1.DataSource = source; 
            Assert.IsNotNull(source, "dados nao foram pegos com sucesso");
            Assert.IsTrue(view.DataGridView1.ColumnCount > 0, "a tabela nao pode ser atualizada");
        }

        [TestMethod]
        public void RetrieveIdOnClickTest()
        {
            ClientView view = new ClientView();
            view.Show();
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getAll();
            view.DataGridView1.DataSource = source;
            view.DataGridView1.Select(Row[1]);
            Assert.IsNotNull(source, "dados nao foram pegos com sucesso");
            Assert.IsTrue(view.DataGridView1.SelectedRow = 1, "o id nao pode ser recuperado");
        }

        [TestMethod]
        public void ChangeTablePageTest()
        {
            ClientView view = new ClientView();
            view.Show();
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getAll();
            view.DataGridView1.DataSource = source;
            view.tabPage2.click();
            Assert.IsNotNull(source, "dados nao foram pegos com sucesso");
            Assert.IsTrue(view.tabPage2.selected()), "a tabela nao pode ser mudada");
        }

        [TestMethod]
        public void ClickOnTablePageTest()
        {
            ClientView view = new ClientView();
            view.Show();
            ClientController controller = new ClientController();
            DataTable source = new DataTable();
            source = controller.getAll();
            view.DataGridView1.DataSource = source;
            view.tabPage2.click();
            Assert.IsNotNull(source, "dados nao foram pegos com sucesso");
            Assert.IsTrue(view.tabPage2.selected()), "a tabela nao pode ser clicada");
        }
    }
}
