using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace InterfaceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button btnRelatorio;
        private Button btnVoltar;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnFaturamento_Click(object sender, RoutedEventArgs e)
        {
            btnRelatorio = CriarBotao("Relatório\nFaturamento");
            btnVoltar = BotaoVoltar();
            
        }



        public Button CriarBotao(string nomeBotao)
        {
            
            Button btn = new Button();
            btn.Height = 60;
            btn.IsEnabled = true;
            btn.Width = 130;
            btn.FontSize = 14;
            btn.VerticalAlignment = VerticalAlignment.Top;
            btn.Content = nomeBotao;
            
            

            // Configurar a cor do texto usando um objeto SolidColorBrush
            btn.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFBF9F9"));

            btn.Margin = new Thickness(10, 0, 300, 0);

            LinearGradientBrush gradienteBrush = new LinearGradientBrush(
                Color.FromRgb(49, 50, 51), // Cor no ponto inicial (azul)
                Color.FromRgb(70, 130, 180),   // Cor no ponto final (azul escuro)
                new Point(0.5, 0),             // Ponto inicial
                new Point(0.5, 1));            // Ponto final
                        

            btn.Background = gradienteBrush;

            // Adicionar o botão a algum contêiner (por exemplo, um StackPanel ou Grid)
            // Substitua "seuConteiner" pelo nome do contêiner real onde você deseja adicionar o botão.
            painel_buttons.Children.Clear();
            painel_buttons.Children.Add(btn);

            return btn;
        }

        public Button BotaoVoltar()
        {
            Button btnVoltar = new Button();
            btnVoltar.Height = 60;
            btnVoltar.IsEnabled = true;
            btnVoltar.Width = 130;
            btnVoltar.FontSize = 14;
            btnVoltar.VerticalAlignment = VerticalAlignment.Top;
            btnVoltar.Content = "Voltar";



            // Configurar a cor do texto usando um objeto SolidColorBrush
            btnVoltar.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));

            btnVoltar.Margin = new Thickness(15, 0, 10, 0);
            btnVoltar.Click += btnVoltar_Click; 

            LinearGradientBrush gradienteBrush = new LinearGradientBrush(
                Color.FromRgb(49, 50, 51), // Cor no ponto inicial (azul)
                Color.FromRgb(70, 130, 180),   // Cor no ponto final (azul escuro)
                new Point(0.5, 0),             // Ponto inicial
                new Point(0.5, 1));           // Ponto final


            
            // Adicionar o botão a algum contêiner (por exemplo, um StackPanel ou Grid)
            // Substitua "seuConteiner" pelo nome do contêiner real onde você deseja adicionar o botão.
            
            painel_buttons.Children.Add(btnVoltar);
            

            return btnVoltar;
        }

        

      

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            Button btnFaturamento = new Button();
            btnFaturamento.Height = 60;
            btnFaturamento.IsEnabled = true;
            btnFaturamento.Width = 130;
            btnFaturamento.FontSize = 14;
            btnFaturamento.VerticalAlignment = VerticalAlignment.Top;
            btnFaturamento.Content = "Faturamento";

            // Configurar a cor do texto usando um objeto SolidColorBrush
            btnFaturamento.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFBF9F9"));

            btnFaturamento.Margin = new Thickness(10, 0, 300, 0);

            LinearGradientBrush gradienteBrush = new LinearGradientBrush(
                Color.FromRgb(49, 50, 51), // Cor no ponto inicial (azul)
                Color.FromRgb(70, 130, 180),   // Cor no ponto final (azul escuro)
                new Point(0.5, 0),             // Ponto inicial
                new Point(0.5, 1));            // Ponto final


            btnFaturamento.Background = gradienteBrush;

            Button btnEstoque = new Button();
            btnEstoque.Height = 60;
            btnEstoque.IsEnabled = true;
            btnEstoque.Width = 130;
            btnEstoque.FontSize = 14;
            btnEstoque.VerticalAlignment = VerticalAlignment.Top;
            btnEstoque.Content = "Estoque";

            // Configurar a cor do texto usando um objeto SolidColorBrush
            btnEstoque.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFBF9F9"));

            btnEstoque.Margin = new Thickness(15, 0, 10, 0);

            btnEstoque.Background = gradienteBrush;

            Button btnCadastrosGerais = new Button();
            btnCadastrosGerais.Height = 60;
            btnCadastrosGerais.IsEnabled = true;
            btnCadastrosGerais.Width = 130;
            btnCadastrosGerais.FontSize = 14;
            btnCadastrosGerais.VerticalAlignment = VerticalAlignment.Top;
            btnCadastrosGerais.Content = "Cadastros Gerais";

            // Configurar a cor do texto usando um objeto SolidColorBrush
            btnCadastrosGerais.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFBF9F9"));

            btnCadastrosGerais.Margin = new Thickness(304, 0, 0, 0);

            btnCadastrosGerais.Background = gradienteBrush;

            btnFaturamento.Click += btnFaturamento_Click;
            btnEstoque.Click += btnEstoque_Click;
            btnCadastrosGerais.Click += btnCadastrosGerais_Click;

            // Adicionar o botão a algum contêiner (por exemplo, um StackPanel ou Grid)
            // Substitua "seuConteiner" pelo nome do contêiner real onde você deseja adicionar o botão.
            painel_buttons.Children.Clear();
            painel_buttons.Children.Add(btnFaturamento);
            painel_buttons.Children.Add(btnEstoque);
            painel_buttons.Children.Add(btnCadastrosGerais);
        }

        private void btnCadastrosGerais_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEstoque_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }

 
   
}
