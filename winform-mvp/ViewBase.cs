using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_mvp
{
    public partial class ViewBase : UserControl, IView
    {
        private Form _window;
        private BindingSource _modelBindingSource;

        public ViewBase()
        {
            InitializeComponent();
            _modelBindingSource = new BindingSource();
        }

        protected void Bind<TControl, T>(TControl control, Func<TControl, T> property, string propertyName)
        {
            
        }

        public event EventHandler Closed;

        public object DataSource
        {
            get { return _modelBindingSource.DataSource; }
            set { _modelBindingSource.DataSource = value; }
        }

        public void ShowView()
        {
            _window = new Form
            {
                Text = Text,
            };

            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            _window.Show();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ShowViewDialog()
        {
            _window = new Form
            {
                Text = Text,
            };

            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            _window.ShowDialog();
        }

        public void StartApplication()
        {
            throw new NotImplementedException();
        }
    }
}
