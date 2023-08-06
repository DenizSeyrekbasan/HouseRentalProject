using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        //Projeyi override ettigimizde calisacak yapi
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HouseManager>().As<IHouseService>().SingleInstance();
            builder.RegisterType<EfHouseDal>().As<IHouseDal>().SingleInstance();
            //IHouseService istenirse HouseManager'i register et 
            //RegisterType yapisi Builder.Services yapisina karsilik geliyor
            //IHouseService istenildiginde HouseManager instance'i ver

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

            //36-43 arasi, HouseManager'a baglanilan yer
        }
    }
}
