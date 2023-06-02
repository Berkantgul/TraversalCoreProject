using Autofac;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProject.Business.Abstract;
using TraversalCoreProject.Business.Concrete;
using TraversalCoreProject.Core.Utilities.Interceptions;
using TraversalCoreProject.DataAccess.Abstract;
using TraversalCoreProject.DataAccess.Concrete.EntityFramework;
using TraversalCoreProject.DataAccess.Repository;

namespace TraversalCoreProject.Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DestinationManager>().As<IDestinationService>();
            builder.RegisterType<EfDestinationDal>().As<IDestinationDal>();

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<FirstAboutManager>().As<IFirstAboutService>();
            builder.RegisterType<EfFirstAboutDal>().As<IFirstAboutDal>();
            
            builder.RegisterType<FirstFeatureManager>().As<IFirstFeatureService>();
            builder.RegisterType<EfFirstFeatureDal>().As<IFirstFeatureDal>();
            
            builder.RegisterType<GuideManager>().As<IGuideService>();
            builder.RegisterType<EfGuideDal>().As<IGuideDal>();
            
            builder.RegisterType<NewsletterManager>().As<INewsletterService>();
            builder.RegisterType<EfNewsletterDal>().As<INewsletterDal>();
            
            builder.RegisterType<SecondAboutManager>().As<ISecondAboutService>();
            builder.RegisterType<EfSecondAboutDal>().As<ISecondAboutDal>();
            
            builder.RegisterType<SecondFeatureManager>().As<ISecondFeatureService>();
            builder.RegisterType<EfSecondFeatureDal>().As<ISecondFeatureDal>();
            
            builder.RegisterType<SubAboutManager>().As<ISubAboutService>();
            builder.RegisterType<EfSubAboutDal>().As<ISubAboutDal>();
            
            builder.RegisterType<TestimaniolManager>().As<ITestimaniolService>();
            builder.RegisterType<EfTestimaniolDal>().As<ITestimaniolDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableClassInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
