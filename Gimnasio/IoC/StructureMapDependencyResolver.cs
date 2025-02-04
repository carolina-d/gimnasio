﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Gimnasio.IoC
{
    public class StructureMapDependencyResolver
    {
        private readonly IContainer _container;

        public StructureMapDependencyResolver(IContainer container)
        {
            _container = container;
        }

        

        public object GetService(Type serviceType)
        {
            if (serviceType.IsAbstract || serviceType.IsInterface)
            {
                return _container.TryGetInstance(serviceType);
            }
            else
            {
                return _container.GetInstance(serviceType);
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAllInstances<object>().Where(p => p.GetType() == serviceType);
        }
    }
}
