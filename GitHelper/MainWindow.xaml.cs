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
//
//using System.Threading;
//using System.Threading.Tasks;

namespace GitHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (!textbox_branch.IsEnabled)
            {
                textbox_branch.IsEnabled = true;
            }

            textbox_branch.Text = "";
            textbox_branch.Focus();
        }

        private void btn_copy_Click(object sender, RoutedEventArgs e)
        {
            string cadena = "";

            if (checkbox1.IsChecked.Value)
            {
                cadena += "git add ." + Environment.NewLine;
            }

            cadena +="git commit -m \"" +textbox_commit.Text + "\""+Environment.NewLine;
            
            if (checkbox2.IsChecked.Value)
            {
                cadena += "git push origin "+textbox_branch.Text +Environment.NewLine;
            }
            
            Clipboard.SetText(cadena);

            lbl_notificar.Content = "se ha copiado la orden!! (" + (count++) + ")";
                        
        }
    }
}
