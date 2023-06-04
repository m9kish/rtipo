using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Entities
{
    internal class Inspection
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


    }
}
