using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using wpf_memo.Commands;
using wpf_memo.Models;

namespace wpf_memo.ViewModels
{
    /*
     * ViewModel
     * ViewとModelの間を取り持つクラス
     */
    class MainWindowViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// コンストラクタ
        /// Modelインスタンス
        /// </summary>
        public MainWindowViewModel()
        {
            Count = new Count();
        }

        public int Value
        {
            get
            {
                return Count.Val;
            }

            set
            {
                Count.Val = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
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

        // private int _count;
        public Count Count { get; set; }

        private ICommand _pushButtonCommnad;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
