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

namespace investimentoDoacao
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double vDoacao, vInvest;

            //Entrada de dados
            vDoacao = Convert.ToDouble(txtDoacao.Text);

            //Efetuando o cálculo baseado em uma condição
            if (vDoacao <= 1000)
            {
                vInvest = vDoacao * 0.05;
            }
            else
            {
                vInvest = vDoacao * 0.15;
            }

            //Saída
            lblValorInvestir.Content = "O valor do investimento deve ser de: R$" +
                vInvest.ToString("0.00");
        }
    }
}
