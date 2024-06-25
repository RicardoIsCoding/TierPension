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
using TierPension.Model;
using TierPension.ViewModel;

namespace TierPension.View
{
    /// <summary>
    /// Interaction logic for TierAbholenDialog.xaml
    /// </summary>
    public partial class TierAbholenDialog : Window
    {
        public TierAbholenDialog()
        {
            InitializeComponent();
            TierAbholenViewModel vm = new TierAbholenViewModel(this);
            DataContext = vm;

            abholenButton.IsEnabled = false;
            abholenButton.Click += AbholenButton_Click;
        }

        private void AbholenButton_Click(object sender, RoutedEventArgs e)
        {
            TestForStyleChange();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TestForStyleChange();
        }

        private void TestForStyleChange()
        {
            Tier t;
            if (TierComboBox.SelectedItem != null)
            {
                abholenButton.IsEnabled = true;
                t = TierComboBox.SelectedItem as Tier;

                if (!t.IstPensioniert)
                {
                    abholenButton.Style = (Style)FindResource("DeleteButtonStyle");
                    buttonText.Text = "löschen";
                }
                else
                {
                    abholenButton.Style = (Style)FindResource("CheckButtonStyle");
                    buttonText.Text = "abholen";
                }
            }
            else
            {
                abholenButton.IsEnabled = false;
            }
        }
    }
}
