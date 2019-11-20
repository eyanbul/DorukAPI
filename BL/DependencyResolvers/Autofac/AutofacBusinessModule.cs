using Autofac;
using BL.Abstract;
using BL.Concrete;

namespace BL.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReportManager>().As<IReportService>();
        }
    }
}
