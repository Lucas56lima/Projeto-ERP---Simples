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
using Infrastructure.Repository;
using Service.Services;

namespace InterfaceGui
{
    public partial class frm_telainicial : Form
    {
        private readonly IProdutoService _produtoService;        

        public frm_telainicial(IProdutoService produtoService)
        {

            _produtoService = produtoService; 
            InitializeComponent();

        }
       
    }
}
