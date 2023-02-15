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
using ClassLibraryBewerking;
namespace Rekening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bankrekening br;
        public MainWindow()
        {
            
            InitializeComponent();
            br = new Bankrekening(0);
        }
    
        private void input_keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int bedrag = int.Parse(input.Text);
                if (bedrag > 0)
                {
                    BedragVerhogen(bedrag);
                }
                else
                {
                    BedragVerlagen(bedrag);
                }
            }
        }

        private void BedragVerhogen(int bedrag) { 
        
        }

        private void BedragVerlagen(int bedrag)
        {

        }
    }
}
