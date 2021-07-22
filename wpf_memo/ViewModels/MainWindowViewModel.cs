using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using wpf_memo.Commands;

namespace wpf_memo.ViewModels
{
    /*
     * ViewModel
     * ViewとModelの間を取り持つクラス
     */
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
                }
            }

        }

        public ICommand PushButtonCommand
        {
            get
            {
                if (_pushButtonCommnad == null)
                {
                    _pushButtonCommnad = new PushButtonCommand(this);
                }

                return _pushButtonCommnad;
            }
        }

        private int _count;

        private ICommand _pushButtonCommnad;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
