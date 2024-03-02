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
using System.Windows.Shapes;

namespace BigBoars.View
{
    /// <summary>
    /// Логика взаимодействия для Zoo.xaml
    /// </summary>
    public partial class Zoo : Window
    {
        public Zoo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (BigBoarsBDEntities db = new BigBoarsBDEntities())
            {
                Boars user = new Boars();
                
                
                user.Password = tbAdd2.Text.ToString();
                user.Name = tbAdd.Text.ToString();

                db.Boars.Add(user);
                db.SaveChanges();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
