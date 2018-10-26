using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xF.Recursos.App_Code;

namespace xF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListaMenu { get { return lstMenu; } }
		public MenuView ()
		{
			InitializeComponent();
            InicializarMenu();
		}

        private void InicializarMenu()
        {

            ObservableCollection<OpcoesMenu> menuItens = new ObservableCollection<OpcoesMenu>();
            menuItens.Add(new OpcoesMenu()
            {
                Descricao = "Pagina inicial",
                Icone = "",
                TargetType = typeof(HomeView)

            });
            lstMenu.ItemsSource = menuItens;
        }
    }
}