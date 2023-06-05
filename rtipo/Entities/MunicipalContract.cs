using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Entities
{
    internal class MunicipalContract
    {
        public int Id { get; set; }
        public Organisation OrganisationOrderId { get; set; }
        public Organisation OrganisationExecutorId { get; set; }
        public DateTime Agreenent_date { get; set; }
        public DateTime Validaity_date { get; set; }
        public int Contract_number { get; set; }

        public DataTable FillTable()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `MunicipalContracts`", db.getConnection());
            // Выдает ошибку MySqlConnector.MySqlException: "Not unique table/alias: 'Organisations'"  хз как пофиксить пока что
            /*MySqlCommand command = new MySqlCommand("SELECT MunicipalContracts.Id, Agreenent_date, Validaity_date, Contract_number, " +
                "Organisations.Full_title, Organisations.Full_title FROM `MunicipalContracts` " +
                "INNER JOIN `Organisations` ON Organisations.Id = MunicipalContracts.OrganisationOrderIdId " +
                "INNER JOIN `Organisations` ON Organisations.Id = MunicipalContracts.OrganisationExecutorIdId", db.getConnection());*/

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
    
}
