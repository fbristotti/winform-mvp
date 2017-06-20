using System;
using System.Windows.Forms;
using winform_mvp;

namespace MyApplication.Main
{
    public partial class MainView : ViewBase, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            this.dateDateTimePicker.DataBindings.Add(new Binding("Value", this.modelBindingSource, "Date", true));

            button1.Click += (sender, args) => AddDate?.Invoke(this, EventArgs.Empty);

            textBox1.TextChanged += (sender, args) =>
            {
                textBox1.DataBindings[0].WriteValue();
                NameChanged?.Invoke(this, EventArgs.Empty);
            };
            //valueTextBox.TextChanged += (sender, args) =>
            //{
            //    ValueChanged?.Invoke(this, EventArgs.Empty);
            //};
        }

        public override string Text { get; set; } = "MainWindow";
     
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 newMDIChild = new Form1
            //{
            //    MdiParent = _window
            //};
            //// Set the Parent Form of the Child window.  
            //// Display the new form.  
            //newMDIChild.Show();
        }


        public event EventHandler AddDate;
        public event EventHandler NameChanged;
        public event EventHandler ValueChanged;
    }
}
