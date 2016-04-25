using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskedEntry
{
    public class MKTTesteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string telefone;

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
                this.Notify("Telefone");
            }
        }

        public void Notify(string Property)
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(Property));
            }
        }
    }
}
