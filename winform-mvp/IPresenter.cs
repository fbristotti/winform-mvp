using System;

namespace winform_mvp
{
    public interface IPresenter : IDisposable
    {
        IView View { get; }
        void ShowView();
        void ShowViewDialog();
        void Initialize(object obj);
        event EventHandler Closed;
    }
}