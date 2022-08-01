using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Counter_WinUI3_MVVMToolkit7
{
    internal class ViewModel : ObservableObject
    {
        public ViewModel()
        {
            CountUpCommand = new RelayCommand(() => ++Count);
            ResetCommand = new RelayCommand(() => Count = 0);
        }

        private CounterModel counter = new CounterModel();
        public int Count
        {
            get => counter.Counter;
            set => SetProperty(counter.Counter, value, counter, (c, v) => c.Counter = v);
        }

        public ICommand CountUpCommand { get; }
        public ICommand ResetCommand { get; }
    }
}
