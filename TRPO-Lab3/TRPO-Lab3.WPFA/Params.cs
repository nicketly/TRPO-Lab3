using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.WPFA
{
    public class Params : INotifyPropertyChanged                                //ViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private double length, height, volume;

        private void UpdateResult()
        {
            Volume = FormulaLib.Pyramid_Reg4_Volume(length, height);
        }
        public double Length 
        {
            get { return length; }
            set { length = value; OnPropertyChanged(); UpdateResult(); } 
        }
        public double Height 
        {
            get { return height; }
            set { height = value; OnPropertyChanged(); UpdateResult(); }
        }
        public double Volume
        {
            get { return volume; }
            set { volume = value; OnPropertyChanged(nameof(Volume)); }
        }
    }
}
