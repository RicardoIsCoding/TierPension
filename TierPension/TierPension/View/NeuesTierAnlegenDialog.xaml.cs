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
using TierPension.ViewModel;

namespace TierPension.View
{
    /// <summary>
    /// Interaction logic for NeuesTierAnlegenDialog.xaml
    /// </summary>
    public partial class NeuesTierAnlegenDialog : Window
    {
        public NeuesTierAnlegenDialog()
        {
            InitializeComponent();
            NeuesTierAnlegenViewModel vm = new NeuesTierAnlegenViewModel(this);
            DataContext = vm;
        }
    }
}
