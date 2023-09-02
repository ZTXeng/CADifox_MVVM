using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADIfox_MVVM.ViewModel
{
    public abstract class ViewModelBase<TModel> : ObservableRecipient
    {
        public TModel Model { get; set; }

        //public IMediator _mediator;


        public ViewModelBase()
        {
            //var builder = new ContainerBuilder();

            //var configBuilder = MediatRConfigurationBuilder.Create(typeof(ExcelShowViewModel).Assembly);
            //configBuilder.WithAllOpenGenericHandlerTypesRegistered();

            //builder.RegisterMediatR(configBuilder.Build());
            //builder.RegisterAssemblyModules(typeof(ExcelShowViewModel).Assembly);

            //var container = builder.Build();

            //_mediator = container.Resolve<IMediator>();
        }
    }
}
