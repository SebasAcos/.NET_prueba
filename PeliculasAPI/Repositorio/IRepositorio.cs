﻿using PeliculasAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositorio
{
   public interface IRepositorio
    {
        List<Genero> ObtenerTodosLosGeneros();
    }
}
