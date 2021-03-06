﻿using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;

namespace UBH.Boilerplate
{
    public class UBH.BoilerplateApplicationModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(UBH.BoilerplateCoreModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
