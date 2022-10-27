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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Animaciones
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

        private void btnAnimaBolita_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation a = new DoubleAnimation();
            a.By = -70;
            a.Duration = new Duration(TimeSpan.FromSeconds(1));
            a.AutoReverse = true;
            a.AccelerationRatio = 0.25;
            a.RepeatBehavior = new RepeatBehavior(3);
            bolitaTranslate.BeginAnimation
                (TranslateTransform.YProperty, a);
        }
    }
}
