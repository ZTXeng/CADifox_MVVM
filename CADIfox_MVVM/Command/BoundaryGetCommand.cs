using CADIfox_MVVM.Extension;
using IFoxCAD.Cad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace CADIfox_MVVM.Command
{
    public static class BoundaryGetCommand
    {
        public static void GetTraceBoundary()
        {
            using var tr = new DBTrans();
            if (tr.Editor == null) return;
            var selected = tr.Editor.GetPoint("请选择一个点");
            var dbs = tr.Editor.TraceBoundary(selected.Value, true);

            var entities = new List<Entity>();
            foreach (Entity item in dbs)
            {
                entities.Add(item);
            }
            tr.CurrentSpace.AddEntity(entities);
        }

        public static void GetOutBoundary()
        {
            double minx = 0;
            double miny = 0;
            var polyline = new Polyline();

            using (var tr = new DBTrans())
            {
                if (tr.Editor == null) return;
                var enities = tr.Editor.SelectEntities(tr);

                var curves = enities.FindAll(x => x is Curve).Select(x => x as Curve).ToList();

                minx = curves.Min(x => x.Bounds.Value.MinPoint.X) - 1000;
                var maxx = curves.Max(x => x.Bounds.Value.MaxPoint.X) + 1000;
                miny = curves.Min(x => x.Bounds.Value.MinPoint.Y) - 1000;
                var maxy = curves.Max(x => x.Bounds.Value.MaxPoint.Y) + 1000;
                polyline.SetDatabaseDefaults();
                polyline.AddVertexAt(0, new Point2d(minx, miny), 0, 0, 0);
                polyline.AddVertexAt(1, new Point2d(maxx, miny), 0, 0, 0);
                polyline.AddVertexAt(2, new Point2d(maxx, maxy), 0, 0, 0);
                polyline.AddVertexAt(3, new Point2d(minx, maxy), 0, 0, 0);
                polyline.Closed = true;
                //tr.Database.AddDBObject(polyline);
                polyline.Color = Color.FromColorIndex(ColorMethod.ByColor, 6);
                tr.CurrentSpace.AddEntity(polyline);

            }
            using (var tr = new DBTrans())
            {
                var dbs = tr.Editor.TraceBoundary(new Point3d(minx + 100, miny + 100, 0), true);

                var entities = new List<Entity>();
                foreach (Entity item in dbs)
                {
                    if (item.Bounds.Value.MinPoint.X != minx)
                    {
                        entities.Add(item);
                        item.Color = Color.FromColorIndex(ColorMethod.ByColor, 6);
                    }
                }
                if (entities != null&& entities.Count != 0)
                {
                    tr.CurrentSpace.AddEntity(entities);
                }
            }
        }
    }
}
