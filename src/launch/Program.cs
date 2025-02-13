using Eto.Forms;

namespace StatistCalc.src.launch
{
   static class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			
			new Application().Run(new MainForm());
		}
	}
}