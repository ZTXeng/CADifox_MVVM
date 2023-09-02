using Autodesk.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CADIfox_MVVM.CommandHandler
{
    public class RibbonCommandHandler : ICommand
    {
        public event EventHandler CanExecuteChanged;

        bool ICommand.CanExecute(object parameter)
        {
            return true;
        }

        void ICommand.Execute(object parameter)
        {
            var ribBtn = (RibbonButton)parameter;
            if (ribBtn != null)
            {
                Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
                      .SendStringToExecute((string)ribBtn.CommandParameter, true, false, false);
            }
        }
    }
}
