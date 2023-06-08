using Microsoft.VisualBasic.Logging;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace rtipo.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public Locality Locality { get; set; }
        public int Registration_number { get; set; }
        public DateTime Birthday { get; set; }
        public int ChipNumber { get; set; }
        public string Nickname { get; set; }
        public string Sex { get; set; }
        public string Photos { get; set; }
        public string Special_signs { get; set; }
        public Category Category { get; set; }
        public OwnerSign OwnerSigns { get; set; }

        public DataTable FillTable()
        {
            DataTable table = new();
            table = new DB().DataTable("SELECT Animals.Id, Registration_number, Birthday, ChipNumber, Nickname, Sex, Photos, Special_signs, " +
                "OwnerSigns.Title, Categories.Title, Localities.Title FROM `Animals` " +
                "INNER JOIN `OwnerSigns` ON OwnerSigns.Id = Animals.OwnerSignsId " +
                "INNER JOIN `Localities` ON Localities.Id = Animals.LocalityId " +
                "INNER JOIN `Categories` ON Categories.Id = Animals.CategoryId");

            return table;   
        }
    }
}
