using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Store.WebUI.App_Start
{
    public class NinjectWebCommon
    {
        private static void RegisterService(IKernel kernel)
        {
            DependencyResolver.SetResolver(new Store.WebUI.Infrastructure.NinjectDependencyResolver(kernel));
        }
    }
}
