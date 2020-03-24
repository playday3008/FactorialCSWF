using System;
using System.Windows.Forms;

namespace FactorialCSWF
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()//Старт
		{
			Application.EnableVisualStyles();//Включити стилі
			Application.SetCompatibleTextRenderingDefault(false);//Режим сумісності тексту
			Application.Run(new MainWindow());//Запустити MainWindow.cs
		}
	}
}
