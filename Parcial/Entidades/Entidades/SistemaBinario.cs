using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
