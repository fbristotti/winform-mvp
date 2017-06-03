using System;

namespace winform_mvp
{
    public abstract class AbstractPresenter<TModel, TView> : IPresenter where TView : class, IView
    {
        private TModel _model;
        private readonly TView _view;

        protected AbstractPresenter(TView view)
        {
            if (view == null)
                throw new ArgumentNullException(nameof(view));
            _view = view;
            _view.Closed += (sender, args) => Dispose();
        }

        public void Show()
        {
            View.Show();
        }

        public void StartApplication()
        {
            View.StartApplication();
        }

        IView IPresenter.View => _view;
        public TView View => _view;

        public virtual void Initialize(object[] args)
        {
            
        }

        protected TModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                _view.DataSource = _model;
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