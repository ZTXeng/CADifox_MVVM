using Autofac;
using CommunityToolkit.Mvvm.ComponentModel;
using MediatR;
using MediatR.Extensions.Autofac.DependencyInjection;
using MediatR.Extensions.Autofac.DependencyInjection.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visibility = System.Windows.Visibility;

namespace CADIfox_MVVM.ViewModel
{
    public abstract class ViewModelBase<TModel> : ObservableRecipient
    {
        public TModel Model { get; set; }

        //public IMediator _mediator;

        private Visibility _visibility;

        public Visibility Visibility {
            get => _visibility;
            set=> SetProperty( ref _visibility,value );
        }

        public ViewModelBase()
        {
            //var builder = new ContainerBuilder();

            //var configBuilder = MediatRConfigurationBuilder.Create(typeof(ShowExcelViewModel).Assembly);
            //configBuilder.WithAllOpenGenericHandlerTypesRegistered();

            //builder.RegisterMediatR(configBuilder.Build());
            //builder.RegisterAssemblyModules(typeof(ShowExcelViewModel).Assembly);

            //var container = builder.Build();

            //_mediator = container.Resolve<IMediator>();
        }

        public void HideWindow()
        {
            Visibility = Visibility.Collapsed;
        }
        public void ShowWindow()
        {
            Visibility = Visibility.Visible;
        }
    }
}
