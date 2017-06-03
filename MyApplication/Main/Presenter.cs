using System;
using winform_mvp;

namespace MyApplication.Main
{
    public class Presenter : AbstractPresenter<Model, IMainView>
    {
        public Presenter() 
            : this(new MainView())
        {
            
        }

        public Presenter(IMainView view) 
            : base(view)
        {
            Model = new Model
            {
                Date = DateTime.Today,
                Conservador = true
            };
        }

        public virtual void OnAddDate()
        {
            var date = Model.Date;
            Model.Date = date.AddDays(1);
        }

        public virtual void OnNameChanged()
        {
            string nome = Model.Nome;

            System.Diagnostics.Debug.WriteLine(nome);
        }

        public virtual void OnValueChanged()
        {
            var value = Model.Value;

            System.Diagnostics.Debug.WriteLine(value);
        }
    }
}