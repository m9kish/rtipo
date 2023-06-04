using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Entities
{
    internal class Animal
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
    }
}
