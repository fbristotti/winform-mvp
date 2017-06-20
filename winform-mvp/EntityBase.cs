using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace winform_mvp
{
    public class EntityBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T value, T newValue, [CallerMemberName] string propertyName = null, bool forceUpdate = false)
        {
            if(Equals(value, newValue) && !forceUpdate)
                return;

            value = newValue;
            OnPropertyChanged(propertyName);
        }

        protected void SetValue<T>(T value, [CallerMemberName] string propertyName = null, bool forceUpdate = false)
        {
            if(propertyName == null)
                return;

            var prop = TypeDescriptor.GetProperties(this)[propertyName];
            if(prop == null)
                return;

            var currentValue = prop.GetValue(this);

            if (Equals(currentValue, value) && !forceUpdate)
                return;

            prop.SetValue(this, value);
            OnPropertyChanged(propertyName);
        }
    }
}
