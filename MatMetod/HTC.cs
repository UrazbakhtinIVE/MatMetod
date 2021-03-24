using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatMetod
{

   
    public class HTC
    {
        //Задане параметров модели ХТС

        //Длина реактора,м
        public double L { get; set; }
        //Диаметр реактора, м
        public double D { get; set; }
        //расход потока через реактор,л/мин
        public double Q { get; set; }
        //концентрация сырьевого компонента А на входе в реактор, моль/л
        public double CAin { get; set; }
        //температура смеси в реакторе, градусы
        public double T { get; set; }
        //варируемая температура смеси в реакторе,градусы, шаг=30
        public double Tvar { get; set; }
        //предэкспоненциональный множитель для константы скорости 1ой реакции, 1/мин
        public double K01 { get; set; }
        //энергия активации первой реакции, Дж/моль
        public double EA1 { get; set; }
        //предэкспоненциональный множитель для константы скорости 2ой реакции, 1/мин
        public double K02 { get; set; }
        //энергия активации первой реакции, Дж/моль
        public double EA2 { get; set; }
        //универсальная газовая постоянная
        public double R { get; set; }

        public HTC(double l, double d, double q, double t, double r, double k01, double ea2)
        {

            L = l;
            D = d;
            Q = q;
            T = t;
            R = r;
            K01 = k01;
            EA2 = ea2;
        }



        public double modelHTS()
        {
            double u;

            u = Q / (D * L);
            return u;
        }



        public double timeVar()
        {
            return L / modelHTS();
        }



        public double k1()
        {
           double tmp =Math.Pow(10, 11);
            return K01 * tmp * Math.Exp(-EA2 / (R * T));
        }

    }
}
