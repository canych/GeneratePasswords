using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeneratePasswords
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Кол-во генерируемых паролей
                int count;
                // Диалог для ввода
                string c = Microsoft.VisualBasic.Interaction.InputBox("Введите необходимое количество паролей");

                // Проверка корректности ввода
                if (!int.TryParse(c, out count))
                {
                    throw new FormatException();
                }

                // Список для паролей
                ListPasswords list = new ListPasswords();
                // строка для пароля
                string part = "abcdefghijklmnopqrstuvwxyz0123456789";
                // 
                Random rnd = new Random();

                for (int i = 0; i < count; i++)
                {
					// Временное хранилище для строки
					StringBuilder tmpStr = new StringBuilder();
					
					for (int j = 0; j < 6; j++)
					{
						if (j == 2 || j == 4)
						{
							tmpStr.Append(part[rnd.Next(26, 36)]);
						}
                        else if (j == 0 || j == 1)
                        {
                            tmpStr.Append(part[rnd.Next(0, 26)]);
                        }
						else
						{
							tmpStr.Append(part[rnd.Next(0, 36)]);
						}
					}

                    list.Add(new Passwords(tmpStr.ToString()));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод!", "Ошибка");
            }
        }
    }
}
