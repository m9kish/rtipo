using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rtipo.Entities;
using Microsoft.EntityFrameworkCore;

namespace rtipo.Entities
{
    public class Organisation
    {
        public int Id { get; set; }
        public OrganisationType OrganisationType { get; set; }
        public Locality Locality { get; set; }
        public string Full_title { get; set; }
        public long INN { get; set; }
        public string Registration_address { get; set; }
        public bool IsIndividual { get; set; }
        public long KPP { get; set; }

        [InverseProperty("OrganisationOrderId")]
        public ICollection<MunicipalContract> Order { get; set; }

        [InverseProperty("OrganisationExecutorId")]
        public ICollection<MunicipalContract> Executor { get; set; }

        public DataTable FillTable()
        {
            DataTable table = new();
            table = new DB().DataTable("SELECT Organisations.Id, Full_title, INN, KPP, Registration_address, IsIndividual, " +
                "OrganisationTypes.Title, Localities.Title FROM `Organisations` " +
                "INNER JOIN `OrganisationTypes` ON OrganisationTypes.Id = Organisations.OrganisationTypeId " +
                "INNER JOIN `Localities` ON Localities.Id = Organisations.LocalityId");

            return table;
        }
    }
}
