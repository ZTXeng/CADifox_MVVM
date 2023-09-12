using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class LayerCreateCommand
    {
        public static void CreateLayer()
        {
            using DBTrans tr = new DBTrans();
            tr.LayerTable.Add("1");
        }
    }
}
