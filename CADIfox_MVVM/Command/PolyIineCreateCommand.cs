using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class PolyIineCreateCommand
    {
        public static void Create()
        {
            using DBTrans tr = new();
            Polyline pl = new();
            pl.SetDatabaseDefaults();
            pl.AddVertexAt(0, new Point2d(0, 0), 0, 0, 0);
            pl.AddVertexAt(1, new Point2d(10, 10), 0, 0, 0);
            pl.AddVertexAt(2, new Point2d(20, 20), 0, 0, 0);
            pl.AddVertexAt(3, new Point2d(30, 30), 0, 0, 0);
            pl.AddVertexAt(4, new Point2d(40, 40), 0, 0, 0);
            pl.Closed = true;
            pl.Color = Color.FromColorIndex(ColorMethod.ByColor, 6);
            tr.CurrentSpace.AddEntity(pl);
        }
    }
}
