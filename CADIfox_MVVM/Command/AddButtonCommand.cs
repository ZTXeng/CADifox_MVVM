using CADIfox_MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
