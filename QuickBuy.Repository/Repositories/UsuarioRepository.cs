﻿using QuickBuy.Dominio.Contract;
using QuickBuy.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository()
        {

        }
    }
}
