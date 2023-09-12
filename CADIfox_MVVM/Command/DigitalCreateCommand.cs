using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class DigitalCreateCommand
    {
        public static void Create()
        {
            using var tr = new DBTrans();
            var entities = new List<Entity>();

            var moveMatrix = Matrix3d.Displacement(new Vector3d(-1, 1, 0));

            var s1 = new Solid(new Point3d(16, 0, 0), new Point3d(84, 0, 0), new Point3d(6, 10, 0), new Point3d(94, 10, 0));

            var lineMirror = Matrix3d.Mirroring(new Line3d(s1.GetPointAt(2), s1.GetPointAt(3)));
            var s2 = s1.GetTransformedCopy(lineMirror);

            var p1 = s1.GetPointAt(2).TransformBy(moveMatrix);
            var p2 = s1.GetPointAt(3).TransformBy(moveMatrix);

            var rotat = Matrix3d.Rotation(Math.PI / 2, Vector3d.ZAxis, p1);
            var rotat2 = Matrix3d.Rotation(-Math.PI / 2, Vector3d.ZAxis, p2);
            Solid s3 = s1.GetTransformedCopy(rotat) as Solid;
            Solid s4 = s2.GetTransformedCopy(rotat) as Solid;
            Solid s5 = s1.GetTransformedCopy(rotat2) as Solid;
            Solid s6 = s2.GetTransformedCopy(rotat2) as Solid;
            //var rotat3 = Matrix3d.Rotation(Math.PI / 2, Vector3d.ZAxis, s3.GetPointAt(3).TransformBy(moveMatrix));
            //Solid s7 = s3.GetTransformedCopy(rotat3) as Solid;
            //Solid s8 = s4.GetTransformedCopy(rotat3) as Solid;
            //var rotat4 = Matrix3d.Rotation(Math.PI / 2, Vector3d.ZAxis, s7.GetPointAt(3).TransformBy(moveMatrix));
            //Solid s9 = s7.GetTransformedCopy(rotat4) as Solid;
            //Solid s10 = s8.GetTransformedCopy(rotat4) as Solid;
            //var rotat5 = Matrix3d.Rotation(Math.PI / 2, Vector3d.ZAxis, s9.GetPointAt(2).TransformBy(moveMatrix));
            //Solid s13 = s9.GetTransformedCopy(rotat5) as Solid;
            //Solid s14 = s10.GetTransformedCopy(rotat5) as Solid;
            //var rotat6 = Matrix3d.Rotation(-Math.PI / 2, Vector3d.ZAxis, s7.GetPointAt(2).TransformBy(moveMatrix));
            //Solid s11 = s7.GetTransformedCopy(rotat6) as Solid;
            //Solid s12 = s8.GetTransformedCopy(rotat6) as Solid;


            tr.CurrentSpace.AddEntity(s1);
            tr.CurrentSpace.AddEntity(s2);
            tr.CurrentSpace.AddEntity(s3);
            tr.CurrentSpace.AddEntity(s4);
            tr.CurrentSpace.AddEntity(s5);
            tr.CurrentSpace.AddEntity(s6);
            //tr.CurrentSpace.AddEntity(s7);
            //tr.CurrentSpace.AddEntity(s8);
            //tr.CurrentSpace.AddEntity(s9);
            //tr.CurrentSpace.AddEntity(s10);
            //tr.CurrentSpace.AddEntity(s11);
            //tr.CurrentSpace.AddEntity(s12);
            //tr.CurrentSpace.AddEntity(s13);
            //tr.CurrentSpace.AddEntity(s14);
        }
    }
}
