using System;
using System.Windows.Forms;
using winform_mvp;

namespace MyApplication.Main
{
    public partial class MainView : UserControl, IMainView
    {
        private Form _window;

        public MainView()
        {
            InitializeComponent();
        }

        public event EventHandler Closed;
        public object DataContext { get; set; }
        public void Close()
        {
            _window.Close();
            Closed?.Invoke(this, EventArgs.Empty);
        }

        public object ShowDialog()
        {
            _window = new Form
            {
                Text = Text
            };
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            return _window.ShowDialog();
        }

        public void StartApplication()
        {
            _window = new Form
            {
                Text = Text
            };
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            Application.Run(_window);
        }

        void IView.Show()
        {
            _window = new Form
            {
                Text = Text
            };
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            _window.Show();
        }
    }

    public interface IMainView : IView
    {
        
    }

    public class Model
    {
        public DateTime Date { get; set; }

    }

    public class Presenter : AbstractPresenter<Model, IMainView>
    {
        public Presenter() : this(new MainView())
        {
            
        }

        public Presenter(IMainView view) : base(view)
        {
        }
    }
}
