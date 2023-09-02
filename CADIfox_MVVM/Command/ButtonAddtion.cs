using Autodesk.Windows;
using CADIfox_MVVM.CommandHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.Windows;
using RibbonButton = Autodesk.Windows.RibbonButton;
using Application = Autodesk.AutoCAD.ApplicationServices.Application;
using RibbonTab = Autodesk.Windows.RibbonTab;

namespace CADIfox_MVVM.Command
{
    public class ButtonAddtion
    {
        [CommandMethod("AddButton")]
        public void AddButton()
        {
            var edito = Application.DocumentManager.MdiActiveDocument.Editor;

            var ribbonControl = ComponentManager.Ribbon;
            ComponentManager.ItemInitialized += ComponentManager_ItemInitialized;
        }
        private void ComponentManager_ItemInitialized(object sender, RibbonItemEventArgs e)
        {

            var ribbonControl = ComponentManager.Ribbon;
            if (ribbonControl != null)
            {
                var tab = AddTab(ribbonControl, "上清", "id1", true);
                var panel = AddPanel(tab, "上清");
                var path = Path.GetDirectoryName(typeof(ButtonAddtion).Assembly.Location);
                var photoPath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(path))), "Pic", "奶茶.png");
                var button = CreateRibbonButton(panel, "工具", "AddButton ", photoPath);
                ComponentManager.ItemInitialized -= ComponentManager_ItemInitialized;
            }
        }

        public RibbonTab AddTab(RibbonControl ribbonCtrl, string title, string id, bool isActive)
        {
            var tab = new RibbonTab();
            tab.Title = title;
            tab.Id = id;
            ribbonCtrl.Tabs.Add(tab);
            tab.IsVisible = isActive;
            return tab;
        }

        public RibbonPanelSource AddPanel(RibbonTab tab, string title)
        {
            var panelSource = new RibbonPanelSource();
            panelSource.Title = title;
            var panel = new RibbonPanel();
            panel.Source = panelSource;
            tab.Panels.Add(panel);
            return panelSource;
        }

        public RibbonButton CreateRibbonButton(RibbonPanelSource ribbonPanel, string naem, string cmd, string photoPath)
        {
            var button = new RibbonButton();
            button.Text = naem;
            button.ShowText = true;
            var bitmap = new Bitmap(photoPath);
            var bitSource = Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            button.Image = bitSource;
            button.LargeImage = bitSource;
            button.Size = RibbonItemSize.Large;
            button.Orientation = System.Windows.Controls.Orientation.Horizontal;
            button.CommandHandler = new RibbonCommandHandler();
            button.CommandParameter = cmd;
            ribbonPanel.Items.Add(button);
            return button;

        }
    }
}
