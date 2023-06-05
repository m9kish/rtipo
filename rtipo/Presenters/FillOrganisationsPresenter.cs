using rtipo.Entities;
using rtipo.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Presenters
{
    internal class FillOrganisationsPresenter
    {
        IWorkWithMainForm fillOrganisationsView;

        public FillOrganisationsPresenter(IWorkWithMainForm view)
        {
            fillOrganisationsView = view;
        }

        public DataTable FillTable()
        {
            Organisation fillOrg = new Organisation();

            return fillOrg.FillTable();
        }
    }
}
