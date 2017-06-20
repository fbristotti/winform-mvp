using System;

namespace winform_mvp
{
    public interface IView : IDisposable
    {
        event EventHandler Closed;
        object DataSource { get; set; }
        void ShowView();
        void Close();
        void ShowViewDialog();
        void StartApplication();
    }
}