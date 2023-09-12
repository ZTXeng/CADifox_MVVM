using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Command
{
    public static class DeleteCommand
    {
        public static void De()
        {
            using DBTrans tr = new();
            var res = Env.Editor.GetEntity("\npick ent:");
            if (res.Status == PromptStatus.OK)
            {
                res.ObjectId.Erase();//删除图元
            }
        }
    }
}
