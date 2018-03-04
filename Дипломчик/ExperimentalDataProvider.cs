using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дипломчик
{
    class ExperimentalDataProvider
    {
        public ExperimentalDataRecord getExperimentalData()
        {
            double p = 0.9011;
            List<double> arr = new List<double> { 488, 495, 494, 496, 546, 498, 508, 483, 477, 500, 487, 507,
497, 523, 503, 493, 508, 502, 493, 505, 524, 509, 508, 493, 511, 518, 522, 503 };
            ExperimentalDataRecord data = new ExperimentalDataRecord(p, arr);
            return data;
        }

    }
}
