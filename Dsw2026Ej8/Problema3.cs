using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {

        public string CompararCopias(int originalValue, Product product)
        {
            int valueCopy = originalValue;
            valueCopy++;

            Product productCopy = product;
            productCopy.Update("Descripcion modificada");

            return $"{originalValue}-{valueCopy}-{productCopy.GetDescription}";
            





        }


    }
}
