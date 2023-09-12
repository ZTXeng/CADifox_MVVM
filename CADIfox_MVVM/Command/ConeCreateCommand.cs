using Autodesk.AutoCAD.DatabaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class ConeCreateCommand
    {
        public static void Create()
        {
            using var tr = new DBTrans();
            var circle1 = new Circle(Point3d.Origin,Vector3d.ZAxis,40);
            var circle2 = new Circle(new Point3d(0,0,40),Vector3d.ZAxis,2);

            var soild3d = new Solid3d();
            soild3d.CreateLoftedSolid(new Entity[] { circle1, circle2 }, new Entity[] { } , null, new LoftOptions());
            tr.CurrentSpace.AddEntity(soild3d);
        }
    }
}
