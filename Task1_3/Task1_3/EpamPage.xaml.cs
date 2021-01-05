using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StringLibrary;

namespace Task1_3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EpamPage : ContentPage
	{
		public EpamPage ()
		{
			InitializeComponent ();
		}

        private void ButtonHello_Click (object sender, EventArgs e)
        {
            var helloMessage = new HelloMessage();
            var message = helloMessage.GetHelloMessage(_entryName.Text);

            _lableMessage.Text = helloMessage.GetHelloMessage(_entryName.Text);
        }


    }
}