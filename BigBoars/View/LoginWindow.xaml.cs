using BigBoars.Model;
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

namespace BigBoars.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
                using (BigBoarsBDEntities db = new BigBoarsBDEntities())
                {
                    var users = db.Boars.ToList();

                    bool isEnter = false;

                    foreach (var user in users)
                    {
                        if (tb1.Text != "" && tb2.Text != "" && tb1.Text == user.Name && tb2.Text == user.Password)
                        {
                            isEnter = true;

                            Zoo zoo = new Zoo();
                            zoo.Show();
                            this.Hide();
                            break;
                        }
                    }
                }
            

        }
    }
}
