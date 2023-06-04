using System;
using System.Collections.Generic;
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

    }
}
