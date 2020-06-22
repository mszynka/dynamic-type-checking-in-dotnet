using System;
using DynamicTypeChecking.Types;
using NUnit.Framework;

namespace DynamicTypeChecking.Tests
{
    public class HandlerFindingDynamicTests
    {
        private static dynamic GetAction()
        {
            return (IAction) Activator.CreateInstance(typeof(SampleAction));
        }

        private static Type GetHandler<TAction>(TAction action)
            where TAction : IAction
        {
            return HandlerProvider.GetHandler<IActionHandler<TAction>>();
        }

        [Test]
        public void It_can_find_action_handler()
        {
            var action = GetAction();
            var handlerType = GetHandler(action);
            Assert.IsNotNull(handlerType);
        }
    }
}