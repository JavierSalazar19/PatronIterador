﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterador
{
    public abstract class Catalogo <TElemento, TIterador>
        where TElemento : Elemento 
        where TIterador : Iterador<TElemento>, new()
    {
        protected IList<TElemento> contenido = new List<TElemento>();
        public TIterador busqueda(string palabraClaveConsulta)
        {
            TIterador resultado = new TIterador();
            resultado.palabraClaveConsulta = palabraClaveConsulta;
            resultado.contenido = contenido;
            return resultado;
        }
    }
}
