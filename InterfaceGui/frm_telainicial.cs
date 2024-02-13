using Domain.Interface;

namespace InterfaceGui
{
    public partial class frm_telainicial : Form
    {
        private readonly IProdutoService _produtoService;        

        public frm_telainicial(IProdutoService produtoService)
        {
            _produtoService = produtoService; 
            InitializeComponent();
            screenWidth();
        }

        public void screenWidth()
        {
            Screen primaryScreen = Screen.PrimaryScreen;
            int screenWidth = primaryScreen.Bounds.Width;
            int screenHeight = primaryScreen.Bounds.Height;            
            double percentualWidth = (885.00 / screenWidth);
            double percentualHeight = (312.00 / screenHeight);
            panel1.Size = new Size(Convert.ToInt32(screenWidth-3),Convert.ToInt32(screenHeight));
            panel_inicial.Size = new Size(screenWidth-2, screenHeight-2);

            Console.WriteLine(percentualWidth);
            flowmodulos.Size = new Size(Convert.ToInt32(screenWidth * percentualWidth), Convert.ToInt32(screenHeight * percentualHeight));
            percentualWidth = 435.00 / screenWidth;
            flow_iniciorapido.Size = new Size(Convert.ToInt32(screenWidth * percentualWidth), Convert.ToInt32(screenHeight * percentualHeight));
        }

       

    }
}
