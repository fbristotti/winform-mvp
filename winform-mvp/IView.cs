using System;

namespace winform_mvp
{
    public interface IView : IDisposable
    {
        event EventHandler Closed;
        object DataSource { get; set; }
        void Show();
        void Close();
        object ShowDialog();
        void StartApplication();
    }
}