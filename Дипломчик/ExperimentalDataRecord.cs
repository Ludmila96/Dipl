using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дипломчик
{
    class ExperimentalDataRecord
    {
        double pDoveritelnoe;
        List<double> arr;

        public ExperimentalDataRecord(double pDov, List<double> arrD)
        {
            pDoveritelnoe = pDov;
            arr = arrD;
        }

        public double getP()
        {
            return pDoveritelnoe;
        }

        public List<double> getArr()
        {
            return arr;
        }
    }
}
