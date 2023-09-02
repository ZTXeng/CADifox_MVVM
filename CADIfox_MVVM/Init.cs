using CADIfox_MVVM.Command;
using System.Windows.Controls.Ribbon;

namespace CADIfox_MVVM
{
    /// <summary>
    /// 自动加载和初始化类，如果不需要自动加载和初始化，可以删除本文件或将本文件代码全部注释
    /// </summary>
    public class Init : AutoLoad
    {
        public override void Initialize()
        {
            var r = new ButtonAddtion();
            r.AddButton();
            Env.Print("loading...");
            // 如果需要将程序的目录加入信任路径，将下行代码取消注释
            // AppendSupportPath(CurrentDirectory.FullName);
        }

        public override void Terminate()
        {
            // 这里不能调用输出函数，因为这个函数执行的时候，已经没有editor对象了。
            // 所以如果不是想要在cad关闭的时候清理某些东西，这里不用写任何的代码。

        }
    }
}