using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CADIfox_MVVM.Command
{
    public static class StarCreateCommand
    {
        public static void Create()
        {
            var pts = GetStarPoints(new Point3d(0, 0, 0), 5);

            Polyline acPoly = new Polyline();

            for (int i = 0; i < pts.Count; i++)
            {
                acPoly.AddVertexAt(i, pts[i], 0.0, 0.0, 0.0);
            }

            acPoly.Closed = true;


            using var tr = new DBTrans();
            tr.CurrentSpace.AddEntity(acPoly);

           
        }

        public static void CreatSoild()
        {
            var pts = GetStarPoints(new Point3d(0, 0, 0), 5);

            Polyline acPoly = new Polyline();

            for (int i = 0; i < pts.Count; i++)
            {
                acPoly.AddVertexAt(i, pts[i], 0.0, 0.0, 0.0);
            }

            acPoly.Closed = true;
            var soild = new Solid3d();
            var swpOption = new SweepOptions();

            soild.CreateExtrudedSolid(acPoly, new Vector3d(0, 0, 1), swpOption);
            using var tr = new DBTrans();
            tr.CurrentSpace.AddEntity(soild);
        }

        public static Point2dCollection GetStarPoints(Point3d center, double radius)
        {
            Point2dCollection points = new Point2dCollection();

            double angle = Math.PI / 2;
            double angle2 = -Math.PI / 2+3* Math.PI * 2 / 5;
            double increment = Math.PI*2 / 5;

            for (int i = 0; i < 5; i++)
            {
                double x = center.X + radius * Math.Cos(angle);
                double y = center.Y + radius * Math.Sin(angle);

                double x1 = center.X + radius *0.381* Math.Cos(angle2);
                double y1 = center.Y + radius * 0.381 * Math.Sin(angle2);
                points.Add(new Point2d(x, y));
                points.Add(new Point2d(x1, y1));

                angle += increment;
                angle2 += increment;
            }

            return points;
        }
    }
}
