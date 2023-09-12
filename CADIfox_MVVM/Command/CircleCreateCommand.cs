using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class CircleCreateCommand
    {
        public static void Create()
        {
            using var tr = new  DBTrans();
            tr.CurrentSpace.AddEntity(new Circle(new Point3d(2, 2, 0),new Vector3d(0,0,1), 2));
        }
    }
}
