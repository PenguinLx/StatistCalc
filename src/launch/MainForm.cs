using System;
using Eto.Forms;
using Eto.Drawing;
using StatistCalc.src.models;
using StatistCalc.src.models;


namespace EmbedGtkInEto
{
	public class MainForm : Form
	{
		public MainForm()
		{
			Menu = new MenuBar();

			// create a new native MonoMac view and wrap it in an eto control
			var nativeControl = new MyNativeWidget().ToEto();

			Content = new TableLayout
			{
				Padding = new Padding(20),
				Spacing = new Size(5, 5),
				Rows =
				{
					nativeControl,
					null,
					new TableLayout(new TableRow(null, new Button { Text = "An Eto.Forms button" })),
				}
			};
		}
	}
}