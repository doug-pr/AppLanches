using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF_Lanches.Models;

namespace XF_Lanches
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            lvLanches.ItemsSource = new List<Lanche>
            {
                new Lanche { Nome="Cheese Burger", Descricao="", Status="Ativo", Preco=12.90M ,ImagemUrl="http://www.macoratti.net/Imagens/lanches/cheeseBurger.jpg" },
                new Lanche { Nome="Cheese Salada", Descricao="", Status="Ativo", Preco=14.50M ,ImagemUrl="http://www.macoratti.net/Imagens/lanches/chesseSalada.jpg" },
                new Lanche { Nome="Cheese Egg", Descricao="", Status="Ativo", Preco=15.50M ,ImagemUrl="http://www.macoratti.net/Imagens/lanches/cheeseEgg.jpg" },
                new Lanche { Nome="Cheese Tudo", Descricao="", Status="Ativo", Preco=18.00M ,ImagemUrl="http://www.macoratti.net/Imagens/lanches/cheeseTudo.jpg" },
                new Lanche { Nome="Lanche de Frango", Descricao="", Status="Ativo", Preco=13.90M ,ImagemUrl="http://www.macoratti.net/Imagens/lanches/lancheFrango.jpg" },
                new Lanche { Nome="Misto Quente", Descricao="", Status="Ativo", Preco=10.50M ,ImagemUrl="http://www.macoratti.net/Imagens/lanches/lancheMistoQuente.jpg" }
            };
		}

        public async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var lanche = e.SelectedItem as Lanche;

            if (lanche == null)
                return;

            await this.Navigation.PushAsync(new LancheDetailsPage(lanche));
        }
	}
}
