using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class CajeroAutomatico
    {
        int dineroARet, dineroRest;
        int billetesMil, billetesDocientos, billetesCien, billetesCincuenta, monedadDiez, monedasPeso;
        
        public void ObtenerDatos(int dinero)
        {
            dineroARet = dinero;
            dineroRest = dinero;
        }
        
        public int CalcularBilletesMil()
        {
            while(dineroRest >= 1000)
            {
                dineroRest = dineroRest - 1000;
                billetesMil++;
            }
            return billetesMil;
        }

        public int CalcularBilletesDocientos()
        {
            while (dineroRest >= 200)
            {
                dineroRest = dineroRest - 200;
                billetesDocientos++;
            }

            return billetesDocientos;
        }

        public int CalcularBilletesCien()
        {
            while (dineroRest >= 100)
            {
                dineroRest = dineroRest - 100;
                billetesCien++;
            }

            return billetesCien;
        }

        public int CalcularBilletesCincuenta()
        {
            while (dineroRest >= 50)
            {
                dineroRest = dineroRest - 50;
                billetesCincuenta++;
            }

            return billetesCincuenta;
        }

        public int CalcularMonedasDiez()
        {
            while (dineroRest >= 10)
            {
                dineroRest = dineroRest - 10;
                monedadDiez++;
            }

            return monedadDiez;
        }

        public int CalcularMonedasPeso()
        {
            while (dineroRest >= 1)
            {
                dineroRest = dineroRest - 1;
                monedasPeso++;
                
            }

            return monedasPeso;
        }
    }
}
