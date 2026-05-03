using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {

        protected decimal _importe;

        public Sale(decimal importe)
        {
            _importe = importe;
        }

        public virtual decimal CalculateTotal()
        {

            return _importe;
        }
    }
}