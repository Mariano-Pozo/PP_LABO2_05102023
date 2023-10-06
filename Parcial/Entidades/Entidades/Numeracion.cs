using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Numeracion
    {
        public static string msgError;
        protected string valor;

        
        private Numeracion() { }

        protected Numeracion(string valor)
        {  
            this.InicializaValor(valor);
            
        }

        static Numeracion()
        {
            Numeracion.msgError = "Numero Invalido";
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
            //validará que el valor
            //recibido sea una numeración valida,
            //de lo contrario el atributo
            //almacenará un mensaje de error
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = Numeracion.msgError;
            }
        }
        
        
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 is null && n2 is null)
            {
                return true;
            }

            if (n1 is null || n2 is null)
            {
                return false;
            }

            return n1.GetType() == n2.GetType();
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            
            return numeracion.ValorNumerico;
        }


    }
}
