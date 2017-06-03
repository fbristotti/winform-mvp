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

            button1.Click += (sender, args) => AddDate?.Invoke(this, EventArgs.Empty);
            textBox1.TextChanged += (sender, args) =>
            {
                textBox1.DataBindings[0].WriteValue();
                NameChanged?.Invoke(this, EventArgs.Empty);
            };
            valueTextBox.Validated += (sender, args) =>
            {
                //valueTextBox.DataBindings[0].WriteValue();
                ValueChanged?.Invoke(this, EventArgs.Empty);
            };
        }

        public override string Text { get; set; } = "MainWindow";

        public event EventHandler Closed;

        public object DataSource
        {
            get { return modelBindingSource.DataSource; }
            set { modelBindingSource.DataSource = value; }
        }

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
            Show(true);
        }

        void IView.Show()
        {
            Show(false);
        }

        private void Show(bool startApplication)
        {
            _window = new Form
            {
                Text = Text,
                IsMdiContainer = true,
                
            };
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            if (startApplication)
                Application.Run(_window);
            else
                _window.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1
            {
                MdiParent = _window
            };
            // Set the Parent Form of the Child window.  
            // Display the new form.  
            newMDIChild.Show();
        }


        public event EventHandler AddDate;
        public event EventHandler NameChanged;
        public event EventHandler ValueChanged;
    }
}
