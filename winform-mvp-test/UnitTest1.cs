using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using winform_mvp;

namespace winform_mvp_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var presenter = Presenters.Show<MyPresenter>();

            presenter.View.FireRefreshData();
        }
    }

    public class MyPresenter : AbstractPresenter<MyModel, MyView>
    {

        public void OnRefreshData()
        {
            
        }
    }

    public class MyModel
    {
        
    }

    public interface IMyView : IView
    {
    }

    public class MyView : IMyView
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public event EventHandler Closed;
        public object DataContext { get; set; }
        public void Show()
        {
            throw new NotImplementedException();
        }

        public event EventHandler RefreshData;

        public void FireRefreshData()
        {
            RefreshData?.Invoke(this, EventArgs.Empty);
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
