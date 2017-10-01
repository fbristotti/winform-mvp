using System.Collections.Generic;
using winform_mvp;

namespace MyApplication.Action1
{
    public class Model : EntityBase
    {
        private List<KeyValuePair<string, string>> _valores;

        public List<KeyValuePair<string, string>> Valores
        {
            get => _valores;
            set => SetValue(ref _valores, value);
        }
    }
}