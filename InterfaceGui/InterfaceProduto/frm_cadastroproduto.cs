using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Interface;

namespace InterfaceGui.InterfaceProduto
{
    public partial class frm_cadastroproduto : Form
    {

        private readonly IProdutoService _produtoService;
        public frm_cadastroproduto(IProdutoService produtoService)
        {


            _produtoService = produtoService;
            InitializeComponent();
            
        }        

    }
}
