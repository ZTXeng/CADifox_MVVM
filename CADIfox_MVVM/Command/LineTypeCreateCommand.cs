using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public class LineTypeCreateCommand
    {
        public static void CreateLinType()
        {
            using var tr = new DBTrans();
            tr.LinetypeTable.Add("hah", "虚线", 0.95, new double[] { 0.5, -0.25, 0, -0.25 });
        }
    }
}
