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

namespace Animaciones
{
    public enum Carga { Positiva,Negativa}
    /// <summary>
    /// Lógica de interacción para ParticleUC.xaml
    /// </summary>
    public partial class ParticleUC : UserControl
    {
        
        public Carga Carga
        {
            get { return (Carga)GetValue(CargaProperty); }
            set
            {
                SetValue(CargaProperty, value);
                if (value == Carga.Positiva)
                {
                    SetValue(SignoProperty, "+");
                    SetValue(BrushProperty, Brushes.OrangeRed);
                }
                else
                {
                    SetValue(SignoProperty, "-");
                    SetValue(BrushProperty, Brushes.CadetBlue);
                }

            }
        }
        public static readonly DependencyProperty CargaProperty =
            DependencyProperty.Register("Carga", typeof(Carga), typeof(ParticleUC), new PropertyMetadata(Carga.Positiva));
        public string signo
        {
            get
            {
                return (string)GetValue(SignoProperty);
            }
        }
        public static readonly DependencyProperty SignoProperty =
            DependencyProperty.Register("Signo", typeof(string), typeof(ParticleUC), new PropertyMetadata("+"));

        public Brush brush
        {
            get
            {
                return (Brush)GetValue(BrushProperty);
            }
        }
        public static readonly DependencyProperty BrushProperty =
            DependencyProperty.Register("Brush", typeof(Brush), typeof(ParticleUC), new PropertyMetadata(Brushes.OrangeRed));
        public ParticleUC()
        {
            InitializeComponent();
            DataContext = this;
            Carga = Carga.Positiva;
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            txtSigno.LineHeight = this.ActualHeight;
            txtSigno.FontSize = this.ActualHeight/2;
        }
    }
}
