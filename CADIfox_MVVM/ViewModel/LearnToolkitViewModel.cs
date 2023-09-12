using Autodesk.AutoCAD.EditorInput;
using CADIfox_MVVM.Command;
using CADIfox_MVVM.Model;
using CommunityToolkit.Mvvm.Input;
using IFoxCAD.Cad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CADIfox_MVVM.ViewModel
{
    public class LearnToolkitViewModel:ViewModelBase<LearnToolkitModel>
    {
        [DllImport("user32.dll", EntryPoint = "SetFocus")]
        public static extern int SetFocus(IntPtr hWnd);

        public IRelayCommand DrawLine { get; set; }
        public IRelayCommand CreateLayer { get; set; }
        public IRelayCommand CreateLineType { get; set; }
        public IRelayCommand CreateBlock { get; set; }
        public IRelayCommand CreateCircle { get; set; }
        public IRelayCommand DeleteEntity { get; set; }
        public IRelayCommand CreateArc { get; set; }
        public IRelayCommand CreatePolyLine { get; set; }
        public IRelayCommand CreateCube { get; set; }
        public IRelayCommand CreateStar { get; set; }
        public IRelayCommand CreateStarSoild { get; set; }
        public IRelayCommand AutoZoom { get; set; }
        public IRelayCommand CreateNurbs { get; set; }
        public IRelayCommand CreateCone { get; set; }
        public IRelayCommand<Window> CreatAlong { get; set; }
        public IRelayCommand<Window> GetTraceBoundary { get; set; }
        public IRelayCommand<Window> GetOutBoundary { get; set; }
        public IRelayCommand<Window> CreateDigital { get; set; }

        


        public LearnToolkitViewModel()
        {
            Model = new LearnToolkitModel();

            DrawLine = new RelayCommand(OnDrawLine);
            CreateLayer = new RelayCommand(OnCreateLayer);
            CreateLineType = new RelayCommand(OnCreateLineType);
            CreateBlock = new RelayCommand(OnCreateBlock);
            CreateCircle = new RelayCommand(OnCreateCircle);
            DeleteEntity = new RelayCommand(OnDeleteEntity);
            CreateArc = new RelayCommand(OnCreateArc);
            CreatePolyLine = new RelayCommand(OnCreatePolyLine);
            CreateCube=  new RelayCommand(OnCreateCube);
            CreateStar = new RelayCommand(OnCreateStar);
            CreateStarSoild = new RelayCommand(OnCreateStarSoild);
            AutoZoom = new RelayCommand(OnAutoZoom);
            CreateNurbs = new RelayCommand(OnCreateNurbs);
            CreateCone = new RelayCommand(OnCreateCone);
            CreatAlong = new RelayCommand<Window>(OnCreatAlong);
            GetTraceBoundary = new RelayCommand<Window>(OnGetTraceBoundary);
            GetOutBoundary = new RelayCommand<Window>(OnGetOutBoundary);
            CreateDigital= new RelayCommand<Window>(OnCreateDigital);
        }

        private void OnCreateDigital(Window? view)
        {
            using (var edUserInt = Env.Editor.StartUserInteraction(view))
            {
                DigitalCreateCommand.Create();
                edUserInt.End();
                view.Focus();
            }
        }

        private void OnGetOutBoundary(Window view)
        {
            using (var edUserInt = Env.Editor.StartUserInteraction(view))
            {
                BoundaryGetCommand.GetOutBoundary();
                edUserInt.End();
                view.Focus();
            }
        }

        private void OnGetTraceBoundary(Window view)
        {
            using (var edUserInt = Env.Editor.StartUserInteraction(view))
            {
                BoundaryGetCommand.GetTraceBoundary();
                edUserInt.End();
                view.Focus();
            }
        }

        private void OnCreateCone()
        {
            ConeCreateCommand.Create();
            MessageBox.Show("成功");
        }

        private void OnCreateNurbs()
        {
            NurbsCreateCommand.Create();
            MessageBox.Show("成功");
        }

        private void OnCreatAlong(Window view)
        {
            using (var edUserInt = Env.Editor.StartUserInteraction(view))
            {
                AlongCreateCommand.Create();
                edUserInt.End();
                view.Focus();
            }
        }

        private void OnAutoZoom()
        {
            ViewControlCommand.AutoZoom();
        }

        private void OnCreateStarSoild()
        {
            StarCreateCommand.CreatSoild();
            MessageBox.Show("成功");
        }

        private void OnCreateStar()
        {
            StarCreateCommand.Create();
            MessageBox.Show("成功");
        }

        private void OnCreateCube()
        {
            BoxCrateCommand.Create();
            MessageBox.Show("成功");
        }

        private void OnCreatePolyLine()
        {
            PolyIineCreateCommand.Create();
            MessageBox.Show("成功");
        }

        private void OnCreateArc()
        {
            ArcCreateCommand.Create();
            MessageBox.Show("成功");
        }

        private void OnDeleteEntity()
        {
            DeleteCommand.De();
            MessageBox.Show("成功");
        }

        private void OnCreateCircle()
        {
            CircleCreateCommand.Create();
            MessageBox.Show("成功");
        }

        private void OnCreateBlock()
        {
            BlockTableCreateCommand.CreateBlock();
            MessageBox.Show("成功");
        }

        private void OnCreateLineType()
        {
            LineTypeCreateCommand.CreateLinType();
            MessageBox.Show("成功");
        }

        private void OnCreateLayer()
        {
            LayerCreateCommand.CreateLayer();
            MessageBox.Show("成功");
        }

        private void OnDrawLine()
        {
            LineCreateCommand.CreateLine();
            MessageBox.Show("成功");
        }
    }
}
