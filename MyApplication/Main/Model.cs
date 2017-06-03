using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyApplication.Main
{
    public class Model : INotifyPropertyChanged
    {
        private DateTime _date;
        private bool _conservador;
        private string _nome;
        private decimal _value;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; OnPropertyChanged();}
        }

        public bool Conservador
        {
            get { return _conservador; }
            set { _conservador = value; OnPropertyChanged();}
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; OnPropertyChanged(); }
        }

        public decimal Value
        {
            get { return _value; }
            set { _value = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}