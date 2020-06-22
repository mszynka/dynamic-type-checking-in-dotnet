using System;
using DynamicTypeChecking.Types;
using NUnit.Framework;

namespace DynamicTypeChecking.Tests
{
    public class HandlerFindingInterfaceTests
    {
        private static IAction GetAction()
        {
            return (IAction)Activator.CreateInstance(typeof(SampleAction));
        }

        private static Type GetHandler<TAction>(TAction action)
            where TAction : IAction
        {
            return HandlerProvider.GetHandler<IActionHandler<TAction>>();
        }

        [Test]
        public void It_cannot_find_action_handler()
        {
            var action = GetAction();
            var handlerType = GetHandler(action);
            Assert.IsNull(handlerType);
        }
    }
}