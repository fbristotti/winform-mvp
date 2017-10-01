using System;

namespace winform_mvp
{
    public abstract class AbstractPresenter<TModel, TView> : IPresenter where TView : class, IView

    {
        private TModel _model;

        protected AbstractPresenter(TView view)
        {
            View = view ?? throw new ArgumentNullException(nameof(view));
            View.Closed += (sender, args) => Dispose();
        }

        public TView View { get; }

        protected TModel Model
        {
            get => _model;
            set
            {
                _model = value;
                View.DataSource = _model;
            }
        }

        public bool Disposed { get; private set; }

        public void ShowView()
        {
            View.ShowView();
        }

        public void ShowViewDialog()
        {
            View.ShowViewDialog();
        }

        IView IPresenter.View => View;

        public abstract void Initialize(object arg);

        public event EventHandler Closed;

        public void Dispose()
        {
            Dispose(true);
            
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !Disposed)
            {
                View.Close();
                Closed?.Invoke(this, EventArgs.Empty);
                Disposed = true;
            }
        }
    }
}