using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Enums;
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

            PreencheEnums();

        }

        private void PreencheEnums()
        {
            foreach (EMarca marca in Enum.GetValues(typeof(EMarca)))
            {
                listBox_marca.Items.Add(marca);
            }

            foreach (ECategoria categoria in Enum.GetValues(typeof(ECategoria)))
            {
                listBox_categoria.Items.Add(categoria);
            }

            foreach (ECor cor in Enum.GetValues(typeof(ECor)))
            {
                listBox_cor.Items.Add(cor);
            }

            foreach (ESubCategoria subCategoria in Enum.GetValues(typeof(ESubCategoria)))
            {
                listBox_subcategoria.Items.Add(subCategoria);
            }
        }
    }
}
