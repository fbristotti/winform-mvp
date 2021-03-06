﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_mvp;

namespace winform_mvp_test
{
    public partial class ViewBase : UserControl, IView
    {
        private Form _window;

        public ViewBase()
        {
            InitializeComponent();
        }

        public event EventHandler Closed;
        public object DataSource { get; set; }
        public void ShowView()
        {
            _window = new Form();
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            _window.Show();
        }

        public void Close()
        {
            _window.Close();
        }

        public void ShowViewDialog()
        {
            _window = new Form {FormBorderStyle = FormBorderStyle.SizableToolWindow};
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            _window.ShowDialog();
        }

        public void StartApplication()
        {
            _window = new Form();
            _window.Controls.Add(this);
            Dock = DockStyle.Fill;
            Application.Run(_window);
        }
    }
}
