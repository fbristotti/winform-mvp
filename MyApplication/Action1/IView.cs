using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication.Action1
{
    public interface IView : winform_mvp.IView
    {
        event EventHandler RefreshData;
    }
}
