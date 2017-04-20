using System;

namespace winform_mvp
{
    public abstract class AbstractPresenter<TModel, TView> : IPresenter where TView : class, IView, new()
    {
        private TModel _model;
        private readonly TView _view;

        protected AbstractPresenter()
        {
            _view = new TView();
            _view.Closed += (sender, args) => Dispose();
        }

        public void Show()
        {
            View.Show();
        }

        IView IPresenter.View => _view;
        public TView View => _view;
        public virtual void Initialize(object[] args)
        {
            
        }

        private TModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                _view.DataContext = _model;
            }
        }

        public bool Disposed { get; private set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !Disposed)
            {
                _view.Close();
                Disposed = true;
            }
        }
    }
}