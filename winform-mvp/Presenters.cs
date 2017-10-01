using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace winform_mvp
{
    public class Presenters
    {
        public static TPresenter Show<TPresenter>(object obj = null) where TPresenter : IPresenter
        {
            var presenter = Activator.CreateInstance<TPresenter>();
            presenter.Initialize(obj);
            WireEvents(presenter);
            presenter.ShowView();
            return presenter;
        }

        public static void Run<TPresenter>(object args = null) where TPresenter : IPresenter
        {
            var presenter = Show<TPresenter>(args);
            Application.Run(new PresenterApplicationContext(presenter));
        }

        public class PresenterApplicationContext : ApplicationContext
        {
            private readonly IPresenter _presenter;

            public PresenterApplicationContext(IPresenter presenter)
            {
                _presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
                Application.ApplicationExit += OnApplicationExit;
                _presenter.Closed += OnPresenterClosed;
            }

            private void OnPresenterClosed(object sender, EventArgs e)
            {
                ExitThread();
            }

            private void OnApplicationExit(object sender, EventArgs e)
            {
                _presenter.Dispose();
            }
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