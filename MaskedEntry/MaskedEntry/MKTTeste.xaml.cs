using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MaskedEntry
{
    public partial class MKTTeste : ContentPage
    {
        MKTTesteViewModel mkPhone = new MKTTesteViewModel();
        public MKTTeste()
        {
            InitializeComponent();
            this.BindingContext = this.mkPhone;
            //this.txtTeste.Unfocused += TxtTeste_Unfocused;
        }

        private void TxtTeste_Unfocused(object sender, FocusEventArgs e)
        {
            var entry = sender as Entry;
            string texto = entry.Text;
        }
    }
}
