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
	public partial class LanchePedidoPage : ContentPage
	{
        Lanche _lanche;
        Usuario _usuario;

		public LanchePedidoPage (Lanche lanche)
		{
			InitializeComponent ();
            this._lanche = lanche;
            this.BindingContext = _lanche;
		}

        async void btnPedido_Clicked(object sender, EventArgs e)
        {
            if (_lanche == null)
                return;

            if (string.IsNullOrEmpty(strNome.Text))
                return;

            if (string.IsNullOrEmpty(strFone.Text))
                return;

            if (string.IsNullOrEmpty(strEmail.Text))
                return;

            _usuario = new Usuario();
            _usuario.Nome = strNome.Text;
            _usuario.Telefone = strFone.Text;
            _usuario.Email = strEmail.Text;

            await this.Navigation.PushModalAsync(new LanchePedidoConfirmacao(_lanche));
        }
	}
}