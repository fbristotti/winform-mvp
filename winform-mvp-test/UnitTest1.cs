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

        public MyPresenter(MyView view) : base(view)
        {
        }

        public override void Initialize(object arg)
        {
            
        }
    }

    public class MyModel
    {
        
    }

    public interface IMyView : IView
    {
    }

    public class MyView : ViewBase
    {
        public event EventHandler RefreshData;

        public void FireRefreshData()
        {
            RefreshData?.Invoke(this, EventArgs.Empty);
        }
    }
}
