using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rtipo.Views;
using rtipo.Entities;
using System.Data;

namespace rtipo.Presenters
{
    internal class FillAnimalsPresenter
    {
        IWorkWithMainForm fillAnimalsView;

        public FillAnimalsPresenter(IWorkWithMainForm view)
        {
            fillAnimalsView = view;
        }

        public DataTable FillTable()
        {
            Animal fillAnimals = new Animal();

            return fillAnimals.FillTable();
        }
    }
}
