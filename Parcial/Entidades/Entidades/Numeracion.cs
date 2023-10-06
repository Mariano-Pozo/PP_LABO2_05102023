using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Numeracion
    {
        protected string msgError;
        protected string valor;


        private Numeracion() { }

        protected Numeracion(string valor)
        {  
            InicializaValor(valor);
            this.msgError = "Numero Invalido";
        }


        public string Valor { get; }
        internal abstract double ValorNumerico{get; }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        /*Verifica si una cadena es una numeración válida
         *True si la cadena no es nula y contiene al menos un carácter que no es un espacio en blanco
         *False si la cadena es nula o contiene solo espacios en blanco
         */
        protected bool EsNumeracionValida(string valor)
        {
            if (valor == null)
            {  
                return false;
            }
            foreach (char caracter in valor)
            {
                if (caracter != ' ')
                {
                    return true;
                }
            }
            return false;
        }

        private void InicializaValor (string valor)
        {

            //if (EsNumeracionValida(valor))
            //{
            //    this.valor = valor;
            //}
            //else
            //{
            //    this.valor = msgError;
            //}
        }

        


    }
}
