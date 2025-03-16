using MeuApp.Models;

namespace MeuApp.View;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

	private async void ToolbarItem_Clicked(object sender, EventArgs e)
	{
		try
		{
			Produto p = new Produto
			{
				Descricao = texto_descricao.Text,
                Quantidade = Convert.ToDouble(texto_quantidade.Text),
				Preco = Convert.ToDouble(texto_preco.Text),

			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

		}catch(Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}