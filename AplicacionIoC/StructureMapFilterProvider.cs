﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace AplicacionIoC
{
    public class StructureMapFilterProvider
    {
        private readonly IContainer container;
        public StructureMapFilterProvider(IContainer container)
        {
            this.container = container;
        }
    }
}
