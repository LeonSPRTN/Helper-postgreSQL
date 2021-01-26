using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Helper_postgreSQL.ViewModels.Base
{
    internal abstract class ViewModel: INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
   
        protected virtual void OnPropertyChanget([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PeopsertName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanget(PeopsertName);
            return true;
        }
    }
}
