using System;
using winform_mvp;

namespace MyApplication.Main
{
    public interface IMainView : IView
    {
        event EventHandler AddDate;
        event EventHandler NameChanged;
        event EventHandler ValueChanged;
        event EventHandler ShowDetails;
    }
}