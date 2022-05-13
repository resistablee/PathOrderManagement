using Autofac;
using PathOrderManagement.DataAccess.Repositories.Abstract;
using PathOrderManagement.DataAccess.Repositories.Concrete;
using Module = Autofac.Module;

namespace PathOrderManagement.Container.Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>))
                .As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
