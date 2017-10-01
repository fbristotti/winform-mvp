using System;
using System.Windows.Forms;
using winform_mvp;

namespace MyApplication.Main
{
    public partial class MainView : ViewBase<Model>, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            button1.Click += (sender, args) => AddDate?.Invoke(this, EventArgs.Empty);
            button2.Click += (sender, args) => ShowDetails?.Invoke(this, EventArgs.Empty);

            textBox1.TextChanged += (sender, args) =>
            {
                textBox1.DataBindings[0].WriteValue();
                NameChanged?.Invoke(this, EventArgs.Empty);
            };
        }

        public override string Text { get; set; } = "MainWindow";
     
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        public event EventHandler AddDate;
        public event EventHandler NameChanged;
        public event EventHandler ValueChanged;
        public event EventHandler ShowDetails;
    }
}
