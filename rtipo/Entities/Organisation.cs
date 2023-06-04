using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Entities
{
    internal class Organisation
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
    }
}
