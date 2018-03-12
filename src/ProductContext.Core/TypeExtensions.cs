﻿using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace ProductContext.Framework
{
    public static class TypeExtensions
    {
        private static readonly ConcurrentDictionary<Type, string> shortenedTypeNames = new ConcurrentDictionary<Type, string>();
        private static readonly string coreAssemblyName = typeof(object).GetTypeInfo().Assembly.GetName().Name;

        public static string TypeQualifiedName(this Type type)
        {
            if (shortenedTypeNames.TryGetValue(type, out string shortened))
            {
                return shortened;
            }

            string assemblyName = type.GetTypeInfo().Assembly.GetName().Name;
            shortened = assemblyName.Equals(coreAssemblyName)
                ? type.GetTypeInfo().FullName
                : $"{type.GetTypeInfo().FullName}, {assemblyName}";
            shortenedTypeNames.TryAdd(type, shortened);
            return shortened;
        }
    }
}
