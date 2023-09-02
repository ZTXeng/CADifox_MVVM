using CADIfox_MVVM.ExcelControl;
using CADIfox_MVVM.Model;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using DataTable = System.Data.DataTable;

namespace CADIfox_MVVM.ViewModel
{
    public class ShowExcelViewModel : ViewModelBase<ShowExcelModel>
    {
        public IRelayCommand FileSelect { get; set; }
        public ShowExcelViewModel(Document doc)
        {
            Model = new ShowExcelModel();

            FileSelect = new RelayCommand(OnFileSelect);
        }

        public ShowExcelViewModel()
        {
            Model = new ShowExcelModel();

            FileSelect = new RelayCommand(OnFileSelect);
        }

        private void OnFileSelect()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Model.FilePath = dialog.FileName;

                Model.DataTables = ExcelToData.ReadExcelDataTbales(Model.FilePath, true);
                Model.CurrentDataTable = Model.DataTables.First();
            }
        }
    }
}
