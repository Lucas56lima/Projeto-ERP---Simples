﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Commands;

namespace Domain.Interface
{
    public interface IEstoqueRepository
    {
        Task<string> PutEstoqueAsync(EstoqueCommand estoque);
    }
}