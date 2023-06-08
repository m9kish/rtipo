using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Entities
{
    public class MunicipalContract
    {
        public int Id { get; set; }
        public Organisation OrganisationOrderId { get; set; }
        public Organisation OrganisationExecutorId { get; set; }
        public DateTime Agreenent_date { get; set; }
        public DateTime Validaity_date { get; set; }
        public int Contract_number { get; set; }

        public DataTable FillTable()
        {
            DataTable table = new();
            table = new DB().DataTable("SELECT MunicipalContracts.Id, a.Full_title, b.Full_title, Agreenent_date, Validaity_date, Contract_number " +
                "FROM `MunicipalContracts` " +
                "INNER JOIN Organisations a ON a.Id = MunicipalContracts.OrganisationOrderIdId " +
                "INNER JOIN Organisations b ON b.Id = MunicipalContracts.OrganisationExecutorIdId");

            return table;
        }
    }
    
}
