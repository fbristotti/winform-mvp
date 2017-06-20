using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace winform_mvp
{
    public class Presenters
    {
        public static TPresenter Show<TPresenter, T>(T args) where TPresenter : IPresenter<T>
        {
            var presenter = Activator.CreateInstance<TPresenter>();
            presenter.Initialize(args);
            WireEvents(presenter);
            return presenter;
        }

        public static TPresenter Show<TPresenter>(params object[] args) where TPresenter : IPresenter
        {
            var presenter = Activator.CreateInstance<TPresenter>();
            presenter.Initialize(args);
            WireEvents(presenter);

            return presenter;
        }

        public static TPresenter StartApplication<TPresenter>(object[] args = null) where TPresenter : IPresenter
        {
            var presenter = Activator.CreateInstance<TPresenter>();
            presenter.Initialize(args);
            WireEvents(presenter);
            presenter.StartApplication();
            return presenter;
        }

        private static void WireEvents(IPresenter presenter)
        {
            var viewType = presenter.View.GetType();
            var presenterType = presenter.GetType();
            var methodsAndEvents =
                    from method in GetParameterlessActionMethods(presenterType)
                    let matchingEvent = viewType.GetEvent(method.Name.Substring(2))
                    where matchingEvent != null
                    where matchingEvent.EventHandlerType == typeof(EventHandler)
                    select new { method, matchingEvent };

            foreach (var methodAndEvent in methodsAndEvents)
            {
                var action = (Action)Delegate.CreateDelegate(typeof(Action),
                                                              presenter, methodAndEvent.method);

                var handler = (EventHandler)((sender, args) => action());
                methodAndEvent.matchingEvent.AddEventHandler(presenter.View, handler);
            }
        }

        private static IEnumerable<MethodInfo> GetActionMethods(Type type)
        {
            return from method in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
                   where method.Name.StartsWith("On")
                   select method;
        }

        private static IEnumerable<MethodInfo> GetParameterlessActionMethods(Type type)
        {
            return from method in GetActionMethods(type)
                   where method.GetParameters().Length == 0
                   select method;
        }
    }
}