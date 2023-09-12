using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class BoxCrateCommand
    {
        public static void Create()
        {
            using var tr = new DBTrans();
            var soild = new Solid3d();
            soild.CreateBox(10,10,10);
            tr.CurrentSpace.AddEntity(soild);
        }
    }
}
