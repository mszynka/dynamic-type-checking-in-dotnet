using System;
using System.Linq;
using System.Reflection;

namespace DynamicTypeChecking.Types
{
    public class HandlerProvider
    {
        public static Type GetHandler<THandler>()
        {
            // ReSharper disable once PossibleNullReferenceException
            return Assembly.GetAssembly(typeof(IAction))
                .GetTypes()
                .SingleOrDefault(x => typeof(THandler).IsAssignableFrom(x));
        }
    }
}