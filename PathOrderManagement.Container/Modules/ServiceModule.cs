using Autofac;
using PathOrderManagement.Business.Service.Abstract;
using Module = Autofac.Module;

namespace PathOrderManagement.Container.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            //Business katmanı içerisindeki IService interfacesinden miras alan tüm interfaceleri liftime boyunca scope ediyor.
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .Where(x => typeof(IService).IsAssignableFrom(x))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
