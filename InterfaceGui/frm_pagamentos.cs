using Domain.Interface;

namespace InterfaceGui
{
    public partial class frm_pagamentos : Form
    {
        private readonly IProdutoService _produtoService;

        public frm_pagamentos(IProdutoService produtoService)
        {
            _produtoService = produtoService;
            InitializeComponent();
        }        
       
    }
}
