using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        public double ValorNumerico{get; }//devolverá el valor de la instancia en sistema decimal.

        private SistemaDecimal BinarioADecimal()
        {
            
        }
        public Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            
        }
        protected bool EsNumeracionValida(string valor)
        {
            return false;
        }
        private bool EsSistemaBinarioValido(string valor)
        {

        }

        implicit operator SistemaBinario (string valor)
        {

        }

    }
}
