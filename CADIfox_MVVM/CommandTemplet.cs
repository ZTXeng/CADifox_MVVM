//namespace CADIfox_MVVM
//{
//    public class Command
//    {
//        [CommandMethod(nameof(HelloWorld))]
//        public void HelloWorld()
//        {
//            using var tr = new DBTrans();
//            Env.Editor.WriteMessage("hello world!");
//            Env.Printl("开始画线：");
//            Line line = new(new(0, 0, 0), new(1, 1, 0));
//            tr.CurrentSpace.AddEntity(line);
//            Env.Print("画线结束");
//            Env.Editor.ZoomWindow(new(-1, -1, 0), new(2, 2, 0));
//        }
//    }
//}