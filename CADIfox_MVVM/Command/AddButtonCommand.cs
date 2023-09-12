using Autodesk.AutoCAD.ApplicationServices;
using CADIfox_MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application = Autodesk.AutoCAD.ApplicationServices.Application;

namespace CADIfox_MVVM.Command
{
    public class AddButtonCommand
    {
        [CommandMethod("AddButton")]
        public void AddButton()
        {
            var view = new ShowExcelView();
            view.ShowDialog();
        }

        [CommandMethod("Learn")]
        public void Learn()
        {
            var view = new LearnToolkitView();
            Application.ShowModalWindow(view);

            //view.ShowDialog();
        }
    }
}
