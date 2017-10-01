using System;
using System.Windows.Forms;

namespace winform_mvp
{
    public partial class ViewBase<T> : UserControl, IView<T>
    {
        private Form _window;
        private T _dataContext;

        public ViewBase()
        {
            InitializeComponent();
            dataContextBindingSource.DataSource = typeof(T);
        }

        public event EventHandler Closed;
        object IView.DataSource
        {
            get => DataSource;
            set => DataSource = (T)value;
        }

        public T DataSource
        {
            get => _dataContext;
            set => dataContextBindingSource.DataSource = _dataContext = value;
        }

        public void ShowView()
        {
            _window = new Form
            {
                Text = Text,
            };

            _window.Closed += (sender, args) => Closed?.Invoke(this, EventArgs.Empty);
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            _window.Show();
        }

        public void Close()
        {
        }

        public void ShowViewDialog()
        {
            _window = new Form
            {
                Text = Text
            };

            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            _window.ShowDialog();
        }

        protected void Bind<TControl, T>(TControl control, Func<TControl, T> property, string propertyName)
        {
        }
    }
}