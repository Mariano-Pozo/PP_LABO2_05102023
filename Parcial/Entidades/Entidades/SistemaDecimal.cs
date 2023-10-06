using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        protected double ValorNumerico
        {
            get
            {
                return double.Parse(this.valor);
            }
        }
        public SistemaDecimal(string valor) : base(valor)
        {
            
        }
        public  Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if(sistema ==ESistema.Binario)
            {

            }
            else if(sistema == ESistema.Decimal)
            {

            }
            //devolverá una Numeración
            //en el sistema recibido.
        }
        private SistemaBinario DecimalBinario()
        {

        }
        protected bool EsSistemaDecimalValido(string valor)
        {

        }


    }
}
