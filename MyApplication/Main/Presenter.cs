using System;
using System.Collections.Generic;
using winform_mvp;

namespace MyApplication.Main
{
    public class Presenter : AbstractPresenter<Model, IMainView>
    {
        private string _id;

        public Presenter() : this(new MainView())
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

        public virtual void OnShowDetails()
        {
            Presenters.Show<Action1.Presenter>(new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("a", "aiga"),
                new KeyValuePair<string, string>("b", "biga"),
                new KeyValuePair<string, string>("c", "ciga"),
                new KeyValuePair<string, string>("d", "diga"),
            });
        }

        public virtual void OnValueChanged()
        {
            var value = Model.Quantidade;
            System.Diagnostics.Debug.WriteLine(value);
            Model.Financeiro = 3.5M * value;
        }

        public override void Initialize(object args)
        {
            Model.Nome = (string)args;
        }
    }
}