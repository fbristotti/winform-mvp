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

        public void ShowView()
        {
            View.ShowView();
        }

        public void ShowViewDialog()
        {
            View.ShowViewDialog();
        }

        public void StartApplication()
        {
            View.StartApplication();
        }

        IView IPresenter.View => _view;

        public abstract void Initialize(object arg);

        public TView View => _view;

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

    public abstract class AbstractPresenter<TModel, TView, TArgs> : IPresenter<TArgs> where TView : class, IView
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

        public void ShowView()
        {
            View.ShowView();
        }

        public void ShowViewDialog()
        {
            View.ShowViewDialog();
        }

        public void StartApplication()
        {
            View.StartApplication();
        }

        IView IPresenter.View => _view;
        public void Initialize(object args)
        {
            Initialize((TArgs)args);
        }

        public TView View => _view;

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

        public abstract void Initialize(TArgs args);

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