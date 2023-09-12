using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.GraphicsInterface;
using IFoxCAD.Cad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class AlongCreateCommand
    {
        public static void Create()
        {
            using var tr = new DBTrans();
            if (tr.Editor == null) return;

            var selected = tr.Editor.GetEntity("请选择一条线");
            var curve = tr.GetObject<Curve>(selected.ObjectId);
            if (curve == null) return;
            var vector = curve.GetFirstDerivative(curve.StartPoint);

            Plane plane = new(curve.StartPoint, vector);

            Polyline polyline = new();
            polyline.SetDatabaseDefaults();
            polyline.AddVertexAt(0, new Point2d(0, 0), 0, 0, 0);
            polyline.AddVertexAt(1, new Point2d(10, 0), 0, 0, 0);
            polyline.AddVertexAt(2, new Point2d(10, 10), 0, 0, 0);
            polyline.AddVertexAt(3, new Point2d(0, 10), 0, 0, 0);
            polyline.AddVertexAt(4, new Point2d(0, 0), 0, 0, 0);
            polyline.Closed = true;
            polyline.Color = Color.FromColorIndex(ColorMethod.ByColor, 6);
            var matrix = Matrix3d.PlaneToWorld(plane);
            var p1 =  polyline.GetTransformedCopy(matrix);
            Plane plane2 = new(curve.EndPoint, vector);
            var p2 = polyline.GetTransformedCopy(Matrix3d.PlaneToWorld(plane2));

            var entitys = new Entity[] { p1, p2 };
            var soild3d = new Solid3d();

            soild3d.CreateLoftedSolid(entitys, new Entity[] { curve }, null, new LoftOptions());

            tr.CurrentSpace.AddEntity(soild3d);
        }
    }
}
