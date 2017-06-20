using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using winform_mvp;

namespace MyApplication.Main
{
    public class Model : EntityBase
    {
        private DateTime _date;
        private bool _conservador;
        private string _nome;
        private decimal _value;
        private decimal _financeiro;

        public DateTime Date
        {
            get { return _date; }
            set { SetValue(ref _date, value); }
        }

        public bool Conservador
        {
            get { return _conservador; }
            set { SetValue(ref _conservador, value); }
        }

        public string Nome
        {
            get { return _nome; }
            set { SetValue(ref _nome, value); }
        }

        public decimal Quantidade
        {
            get { return _value; }
            set { SetValue(ref _value, value); }
        }

        public decimal Financeiro
        {
            get { return _financeiro; }
            set { SetValue(ref _financeiro, value); }
        }
    }
}