using System;
using System.Collections.Generic;
using System.Text;

namespace SQLStoresAndQuerysCreator.Entidades
{
    public class SqlEntidad
    {
        public string Campo { get; set; }
        public string TipoDato { get; set; }

        public override string ToString()
        {
            return $"{Campo} - {TipoDato}";
        }
    }
}
