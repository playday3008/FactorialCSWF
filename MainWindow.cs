using System;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCSWF//Простір імен
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm//Використання теми MetroUI
    {
        public MainWindow()//Ініціалізація вікна
        {
            InitializeComponent();//Ініціалізація
        }

        private async void MetroButton1_Click(object sender, EventArgs e)//Якщо натиснути кнопку "Start"
        {
            Stopwatch stopWatch = new Stopwatch();//Ініціалізація таймеру
            Outputbox.Text = String.Empty;//Очищення відповіні при новому запуску
            string z = Inputbox.Text;//Переведення цифр з поля Inputbox в string
            foreach (var value in z)
            {
                bool success = Int32.TryParse(z, out int number);//Перевірка на число
                if (success)// Якщо введено любий символ окрім цифр
                {
                    var n = int.Parse(z);
                    if (n >= 0 || n <= 2147483647)// Якщо число вийшло з діапазону (0-2147483647)
                    {
                        if (n <= 268609166)//Перевірка на число більше ніж 268609166
                        {
                            Timelabel.Text = "Please wait";//Замінити текст на "Please wait" якщо почато обчислення
                            Counterbox.Text = "Please wait";//Замінити текст на "Please wait" якщо почато обчислення
                            stopWatch.Start();//Запустити таймер
                            var factorial = BigInteger.One;// Ініціалізація factorial
                            for (int i = 1; i <= n; i++)//Запуск обчислення
                            {
                                await Task.Run(() => factorial *= i);//Асинхронне обчислення
                            }
                            stopWatch.Stop();//Зупинення таймера
                            TimeSpan ts = stopWatch.Elapsed;//Ініціалізація перемінної stopWatch.Elapsed
                            string elapsedTime = String.Format("Time: {0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);//Переведення значень таймера в string
                            Timelabel.Text = String.Empty;//Очищення
                            Timelabel.Text += elapsedTime;//Виведення значень таймера
                            Outputbox.Text += factorial;//Виведення відповіді
                            string cc = factorial.ToString();//Переведення factorial в string
                            int ccc = cc.Length;//Переведення string в довжину
                            string count = String.Format("Numbers in answer: {0}", ccc);//Переведення довжини в string
                            Counterbox.Text = String.Empty;//Очищення Counterbox
                            Counterbox.Text = count;//Виведення кількості цифр
                        }
                        else
                        {
                            Timelabel.Text = "Please wait";//Замінити текст на "Please wait" якщо почато обчислення
                            Outputbox.Text = "Output in My Documents";//Виведння тексту в Outputbox
                            stopWatch.Start();//Запустити таймер
                            var factorial = BigInteger.One;// Ініціалізація factorial
                            for (int i = 1; i <= n; i++)//Запуск обчислення
                            {
                                await Task.Run(() => factorial *= i);//Асинхронне обчислення
                            }
                            stopWatch.Stop();//Зупинення таймера
                            TimeSpan ts = stopWatch.Elapsed;//Ініціалізація перемінної stopWatch.Elapsed
                            string elapsedTime = String.Format("Time: {0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);//Переведення значень таймера в string
                            Timelabel.Text = String.Empty;//Очищення
                            Timelabel.Text += elapsedTime;//Виведення значень таймера
                            string cc = factorial.ToString();//Переведення factorial в string
                            int ccc = cc.Length;//Переведення string в довжину
                            string count = String.Format("Numbers in answer: {0}", ccc);//Переведення довжини в string
                            Counterbox.Text = String.Empty;//Очищення Counterbox
                            Counterbox.Text = count;//Виведення кількості цифр
                            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//Пошук шляху до папки "Документи"
                            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "FactorialResult.txt")))//Виведення і створення в файл FactorialResult.txt
                            {
                                outputFile.WriteLine("Output from {0}", n);//Вивід цього рядка в FactorialResult.txt
                                outputFile.WriteLine("Numbers in answer: {0}:", count);//Вивід цього рядка в FactorialResult.txt
                                outputFile.WriteLine(factorial.ToString());//Вивід відповіді в FactorialResult.txt
                            }
                        }
                    }
                    else//Якщо ні
                    {
                        Outputbox.Text = "Nubmers ONLY or to big number(";// Якщо число вийшло з діапазону (0-2147483647)
                    }
                }
                else//Якщо ні
                {
                    Outputbox.Text = "Nubmers ONLY or to big number(";// Якщо введено любий символ окрім цифр
                }
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)//Якщо натиснути на кнопку Open Documents folder
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//Пошук шляху до папки "Документи"
            Process.Start("explorer.exe", docPath);//Запустити explorer.exe в папці Документи
        }

        private void MetroTextBox1_KeyDown(object sender, KeyEventArgs e)//Якщо натиснути кнопу в полі вводу
        {
            if (e.KeyCode == Keys.Enter)//Якщо кнопка Enter
            {
                MetroButton1_Click(this, new EventArgs());//Запускає процес metroButton1_Click
            }
        }
    }
}
