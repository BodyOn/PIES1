using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodyOn.Models;
using BodyOn.Service;
using BodyOn.Views;
using Npgsql;

namespace BodyOn.Controller
{
    public class ClientController
    {
        ConnectionService conn = new ConnectionService();

        //read
        public DataTable getAll() {
            return conn.executeSql(@"select * from clientes");
        }

        public DataTable getByQuery(string query) {
            return conn.executeSql(@"select * from clientes where nome like '%" + query + "%'");
        }

        //create

        //update

        //delete

        //search
        

    }
}
