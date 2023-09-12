using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public class BlockTableCreateCommand
    {
        public static void CreateBlock()
        {
            using DBTrans tr = new DBTrans();
            var line = new Line(new Point3d(1, 1, 0), new Point3d(2, 0, 0));

            tr.BlockTable.Add("dd", btr => btr.AddEntity(line));
        }
    }
}
