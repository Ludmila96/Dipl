using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дипломчик
{
    class Evaluation
    {
        List<double> m = new List<double>();
        List<double> Pi = new List<double>();
        List<double> pi = new List<double>();

        public Evaluation(List<double> mNew, List<double> PiNew, List<double> piNew)
        {
            m = mNew;
            Pi = PiNew;
            pi = piNew;
        }

        public List<double> getM()
        {
            return m;
        }

        public List<double> getP()
        {
            return Pi;
        }

        public List<double> getp()
        {
            return pi;
        }
 
    }
}
