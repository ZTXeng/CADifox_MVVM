using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class NurbsCreateCommand
    {
        public static void Create()
        {
            using var tr = new DBTrans();

            var point1 = new Point3d(0, 0, 0);
            var point2 = new Point3d(20, 20, 0);
            var point3 = new Point3d(40, 0, 0);
            var point4 = new Point3d(60, 0, 0);

            var points = new Point3dCollection() { point1, point2 , point3 , point4 };

            NurbCurve3d nurbCurve = new NurbCurve3d(points);

            var curve=  Curve.CreateFromGeCurve(nurbCurve);

            tr.CurrentSpace.AddEntity(curve);
        }
    }
}
