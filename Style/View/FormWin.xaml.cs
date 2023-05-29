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
using System.Windows.Shapes;

namespace Style.View
{
    /// <summary>
    /// Логика взаимодействия для FormWin.xaml
    /// </summary>
    public partial class FormWin : Window
    {
        public (string Rus, string Eng)[] values =
        {
            ("Форма ввода DemoStyles", "Forms input Demostyle"),
            ("Фамилия", "Surname"),
            ("Отчество", "Middle name"),
            ("Адрес проживания", "Residental address"),
            ("Год рождения", "Year of birth"),
            ("Образование", "Education"),
            ("Национальность", "Education"),
            ("Сохранить", "Save"),
            (" Выход ", " Exit ")
        };
        private void CheckLang(object sender, RoutedEventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio == null)
            {
                return;
            }
            switch (radio.Name)
            {
                case "Eng":
                    L1.Content = values[0].Eng;
                    L2.Content = values[1].Eng;
                    L3.Content = values[2].Eng;
                    L4.Content = values[3].Eng;
                    L5.Content = values[4].Eng;
                    L6.Content = values[5].Eng;
                    L7.Content = values[6].Eng;
                    L8.Content = values[7].Eng;
                    break;
                case "Rus":
                    L1.Content = values[0].Rus;
                    L2.Content = values[1].Rus;
                    L3.Content = values[2].Rus;
                    L4.Content = values[3].Rus;
                    L5.Content = values[4].Rus;
                    L6.Content = values[5].Rus;
                    L7.Content = values[6].Rus;
                    L8.Content = values[7].Rus;
                    break;
            }
        }
        public FormWin()
        {
            InitializeComponent();
        }

        private void ClickSave(object sender, RoutedEventArgs e)
        {

        }

        private void ClickExit(object sender, RoutedEventArgs e)
        {

        }
    }
}
