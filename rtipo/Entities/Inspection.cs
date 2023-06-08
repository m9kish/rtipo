using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace rtipo.Entities
{
    public class Inspection
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Animal Animal { get; set; }
        public MunicipalContract MunicipalContracts { get; set; }
        public Organisation Organisation { get; set; }
        public string Features { get; set; }
        public string Condition_animal { get; set; }
        public string Temperature { get; set; }
        public string Skin_covers { get; set; }
        public string Condition_wool { get; set; }
        public string Damage { get; set; }
        public string Emergency_assistance { get; set; }
        public string Diagnosis { get; set; }
        public string Manipulations_performed { get;set; }
        public string Treatment_prescribed { get; set; }
        public DateTime Inspection_date { get; set; }

        public DataTable FillTable(int Id)
        {
            DataTable table = new();
            table = new DB().DataTable("SELECT ins.Id, us.First_name, con.Contract_number, org.Full_title, " +
                "ins.Features, ins.Condition_animal, ins.Temperature, ins.Skin_covers, ins.Condition_wool, ins.Damage, " +
                "ins.Emergency_assistance, ins.Diagnosis, ins.Manipulations_performed, ins.Treatment_prescribed, ins.Inspection_date " +
                "FROM Inspections ins " +
                "INNER JOIN Animals an ON an.Id = ins.AnimalId " +
                "INNER JOIN Users us ON us.Id = ins.UserId " +
                "INNER JOIN MunicipalContracts con ON con.Id = ins.MunicipalContractsId " +
                "INNER JOIN Organisations org ON org.Id = ins.OrganisationId " +
                $"WHERE ins.AnimalId = {Id}");

            return table;
        }

    }
}
