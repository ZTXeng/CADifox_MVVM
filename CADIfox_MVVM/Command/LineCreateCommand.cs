using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class LineCreateCommand
    {
        public static void CreateLine()
        {
            using DBTrans tr = new DBTrans();
            var line = new Line(new Point3d(0, 0, 0), new Point3d(1, 1, 0));
            tr.CurrentSpace.AddEntity(line);
        }
    }
}
