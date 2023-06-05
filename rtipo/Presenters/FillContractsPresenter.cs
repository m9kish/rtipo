using rtipo.Entities;
using rtipo.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtipo.Presenters
{
    internal class FillContractsPresenter
    {
        IWorkWithMainForm fillContractsView;

        public FillContractsPresenter(IWorkWithMainForm view)
        {
            fillContractsView = view;
        }

        public DataTable FillTable()
        {
            MunicipalContract fillContracts = new MunicipalContract();

            return fillContracts.FillTable();
        }
    }
}
