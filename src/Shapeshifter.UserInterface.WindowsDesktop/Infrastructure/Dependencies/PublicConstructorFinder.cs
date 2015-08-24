﻿using Autofac.Core.Activators.Reflection;
using System;
using System.Linq;
using System.Reflection;

namespace Shapeshifter.UserInterface.WindowsDesktop.Infrastructure.Dependencies
{
    class PublicConstructorFinder : IConstructorFinder
    {
        public ConstructorInfo[] FindConstructors(Type targetType)
        {
            return targetType.GetConstructors()
                .Where(x => x.IsPublic)
                .OrderByDescending(x => x.GetParameters().Count())
                .ToArray();
        }
    }
}