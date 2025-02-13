using System;
using Eto.Forms;
using Eto.Drawing;
using StatistCalc.src.models;
using Eto.GtkSharp.Forms.Menu;



namespace StatistCalc.src.launch
{
	public class MainForm : Form
	{
		public MainForm()
		{

			ClientSize = new Size(800, 600);
			Title = "Bem-Vindo ao StatistCalc!";
			Content = new Label { Text = "Calculadora de Estatística", VerticalAlignment = VerticalAlignment.Center, TextAlignment = TextAlignment.Center };
			
			   var quitCommand = new Command((sender, e) => Application.Instance.Quit())
        { 
            MenuText = "Quit", 
            Shortcut = Application.Instance.CommonModifier | Keys.Q
        };
			var appMenu = new ButtonMenuItem
{
    Text = "&Calc",
    Items =
    {
        new IntervaloClasseCommand(),
        new ButtonMenuItem { Text = "Click Me, MenuItem" },
		quitCommand
    }
};

// Criar a barra de menu e modificar ApplicationMenu indiretamente
 Menu = new MenuBar
        {
            Items =
            {
                appMenu // Adiciona "Calc" como o menu principal
            },
            AboutItem = new Command((sender, e) => new Dialog {
                Content = new Label { 
                    Text = @"A statistic calculator

project repository: https://github.com/PenguinLx/StatistCalc

Made in 🇧🇷"
                }, 
                ClientSize = new Size(200, 200), 
                Title = "Help"
            }.ShowModal(this))
            { 
                ToolBarText = "About",
                MenuText = "About my app"
            }
};

// Se o ApplicationMenu já existir, tentar modificar seu texto
if (Menu.ApplicationMenu != null) {

	 foreach (var item in Menu.ApplicationMenu.Items.ToArray())
            {
                appMenu.Items.Add(item);
            }
		
		 Menu.Items.Remove(Menu.ApplicationMenu);
	//Menu.ApplicationMenu = appMenu;
     //Menu.ApplicationMenu.Text = "&Calc";
	 
}

			// Menu = new MenuBar
			// {
				
			// 	 ApplicationMenu = new ButtonMenuItem{

			// 	 }
			// 	Items =
			// 	{
			// 		//Menu.ApplicationMenu = "s";
			// 		new ButtonMenuItem
			// 		{ 
			// 			Text = "&Calc",
			// 			Items =
			// 			{ 
			// 				// you can add commands or menu items
			// 				new IntervaloClasseCommand(),
			// 				new ButtonMenuItem { Text = "Click Me, MenuItem" }
			// 			}
			// 		} 
			// 	},
			// 	// quit item (goes in Application menu on OS X, File menu for others)
			// 	QuitItem = new Command((sender, e) => Application.Instance.Quit())
			// 	{ 
			// 		MenuText = "Quit", 
			// 		Shortcut = Application.Instance.CommonModifier | Keys.Q
			// 	},
			// 	// about command (goes in Application menu on OS X, Help menu for others)
			// 	AboutItem = new Command((sender, e) => new Dialog {
			// 		 Content = new Label { 
			// 		 Text = @"				A statistic calculator

			// 	project repository: https://github.com/PenguinLx/StatistCalc



			// 		 				Made in 🇧🇷
			// 		 " }, ClientSize = new Size(200, 200) , Title = "Help"}.ShowModal(this))
			// 	{ 
			// 		ToolBarText = "About",
			// 		MenuText = "About my app"
			// 	}
			// };

			// create toolbar
			ToolBar = new ToolBar
			{
				Items =
				{ 
					new IntervaloClasseCommand(),
					new SeparatorToolItem(),
					new ButtonToolItem { Text = "Click Me, ToolItem" }
				}
			};
            ComboBox comboBox = new ComboBox();
            comboBox.DataStore = ["cavalo","mosca","tartaruga","zebra"];//dados para a escolha

			// create a new native MonoMac view and wrap it in an eto control
			//var nativeControl = new MyNativeWidget().ToEto();

			// Content = new TableLayout
			// {
			// 	Padding = new Padding(20),
			// 	Spacing = new Size(5, 5),
			// 	Rows =
			// 	{
			// 		nativeControl,
			// 		comboBox,
			// 		new TableLayout(new TableRow(new Button { Text = "An Eto.Forms button" })),
			// 	}
			// };
		}
	}
}