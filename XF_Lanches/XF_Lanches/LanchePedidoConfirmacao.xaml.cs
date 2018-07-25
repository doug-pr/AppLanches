using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Lanches.Models;

namespace XF_Lanches
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LanchePedidoConfirmacao : ContentPage
	{
		public LanchePedidoConfirmacao (Lanche lanche)
		{
			InitializeComponent ();
            this.BindingContext = lanche;
		}
	}
}