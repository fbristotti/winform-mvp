using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_mvp
{
    public interface IPresenter : IDisposable
    {
        void Show();
        void StartApplication();
        IView View { get; }
        void Initialize(object[] args);
    }
}
