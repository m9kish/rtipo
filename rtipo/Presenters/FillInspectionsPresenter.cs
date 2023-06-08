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
    internal class FillInspectionsPresenter
    {
        IWorkWithMainForm inspectionsView;

        public FillInspectionsPresenter(IWorkWithMainForm view)
        {
            inspectionsView = view;
        }

        public DataTable FillTable(int Id)
        {
            Inspection inspections = new Inspection();
            
            Animal animal = new Animal();
            animal.Id = Id;

            return inspections.FillTable(animal.Id);
        }
    }
}
