using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class ViewControlCommand
    {
        public static void AutoZoom()
        {
            Env.Editor.ZoomExtents();
        }
    }
}
