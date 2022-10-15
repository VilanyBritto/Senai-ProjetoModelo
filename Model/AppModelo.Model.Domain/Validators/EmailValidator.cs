using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Validators
{
        public static partial class Validadores 
        // static não é instanciada com new e partical não faz a ação mas não representa algo importante no mundo real
        // Se cria uma classe com static não  precisa ser instanciada com new.
        {
            public static bool EmailEValido(string inputEmail)
            {
                var strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                var re = new Regex(strRegex);
                if (re.IsMatch(inputEmail))
                    return (true);
                else
                    return (false);
            }
        }
}

