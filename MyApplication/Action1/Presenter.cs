using System.Collections.Generic;
using winform_mvp;

namespace MyApplication.Action1
{
    public class Presenter : AbstractPresenter<Model, IView>
    {
        public Presenter()
            : base(new View())
        {
            Model = new Model();
        }

        public Presenter(IView view) : base(view)
            
        {
            Model = new Model();
        }

        public override void Initialize(object arg)
        {
            Model.Valores = (List<KeyValuePair<string, string>>) arg;
        }
    }
}