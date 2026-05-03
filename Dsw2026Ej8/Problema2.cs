using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {

        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice) {

            decimal total = quantity * unitPrice;


            if (quantity <= 0) {

                total = 0;

            }

            var anon = new(productCode, productDescription, quantity, unitPrice);



            return null
        }


    }
}
