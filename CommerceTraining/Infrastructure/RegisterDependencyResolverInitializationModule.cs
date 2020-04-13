using System;
using System.Linq;
using System.Web.Mvc;
using CommerceTraining.Infrastructure.SiteDependencyResolver;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace CommerceTraining.Infrastructure
{
    [InitializableModule]
    public class RegisterDependencyResolverInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}