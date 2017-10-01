using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_mvp;

namespace MyApplication.Action1
{
    public partial class View : ViewBase<Model>, IView
    {
        public View()
        {
            InitializeComponent();
        }

        public event EventHandler RefreshData;
    }
}
