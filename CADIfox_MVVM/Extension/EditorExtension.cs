using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.Extension
{
    public static class EditorExtension
    {
        public static List<Entity> SelectEntities(this Autodesk.AutoCAD.EditorInput.Editor editor,DBTrans dB)
        {
            var tr = dB;
            var entities = new List<Entity>();

            var selected = editor.GetSelection();
            var objetIds = new List<ObjectId>();

            if (selected.Status == PromptStatus.OK)
            {
                objetIds.AddRange(selected.Value.GetObjectIds());
            }

            foreach (ObjectId id in objetIds)
            {
                var entity = tr.GetObject<Entity>(id);
                entities.Add(entity);
            }

            return entities;
        }
    }
}
