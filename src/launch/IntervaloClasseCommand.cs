using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eto.Forms;

namespace StatistCalc.src.launch
{
    public class IntervaloClasseCommand : Command
    {
        public IntervaloClasseCommand(){
            ID = "toolbar_example";
            MenuText = "C&lick Me, Command";
			ToolBarText = "Click Me";
			ToolTip = "This shows a dialog for no reason";
			//Image = Icon.FromResource ("MyResourceName.ico");
			//Image = Bitmap.FromResource ("MyResourceName.png");
			Shortcut = Application.Instance.CommonModifier | Keys.M;
        }
        protected override void OnExecuted(EventArgs e)
		{
			base.OnExecuted(e);

			MessageBox.Show(Application.Instance.MainForm, "You clicked me!", "Tutorial 2", MessageBoxButtons.OK);
        
    }
    }
}