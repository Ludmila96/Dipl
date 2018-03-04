using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дипломчик
{
    class Statistika
    {
       // ExperimentalDataProvider p = new ExperimentalDataProvider();

        public static List<double> Calculation(ExperimentalDataProvider data)
        {
            ExperimentalDataRecord r = data.getExperimentalData();
            double pDov = r.getP();
            List<double> x = r.getArr();
            double z = 1.65; //не забудь реализовать подборку z
             List<double> xNew = new List<double>();
           // List<double> xNew = x;

            //while (xNew.Count != x.Count) 
            for(int j =0; j < 4; j++)
            {
                
                xNew.Clear();
                int n = x.Count;
                double xAvg = 0; //среднее массива Х
                double sigma = 0; //среднеквадратическое значение х
                List<double> xDelta = new List<double>(); //разница м/у значениями х и средним

                for (int i = 0; i < n; i++)
                    xAvg += x[i];
                xAvg = xAvg / n;

                for (int i = 0; i < n; i++)
                    xDelta.Add(0);

                for (int i = 0; i < n; i++)
                    xDelta[i] = x[i] - xAvg;

                for (int i = 0; i < n; i++)
                    sigma += (x[i] - xAvg) * (x[i] - xAvg);
                sigma = Math.Sqrt(sigma / (n - 1));

                double zs = z * sigma;
                for (int i = 0; i < n; i++)
                {
                    if (Math.Abs(xDelta[i]) < zs)
                    {
                        xNew.Add(x[i]);
                    }
                }

                x.Clear();
                for (int i = 0; i < xNew.Count; i++)
                {
                    x.Add(xNew[i]); 
                }
                    
            }

            x.Sort();

                return x;
        }

        public static List<double> Bin (List<double> x)
        {
            int r = 6; //реализовать поиск r
            double xDelta;
            int n = x.Count;

            xDelta = Math.Round((x.Max() - x.Min()) / r);
            List<double> xNew = new List<double>();
            for(int i =0; i<=r; i++)
            {
                xNew.Add(x.Min() + xDelta * i);
            }

            return xNew;
        }

        public static Evaluation Probability(List<double> bin, List<double> x) //расчет mi, Pi, pi
        {
            List<double> m = new List<double>();
            List<double> Pi = new List<double>();
            List<double> pi = new List<double>();
           
            int j = 0;

            while (j < bin.Count-1)
            {
                double xLev = bin[j];
                double xPrav = bin[j+1];
                m.Add(0);

                if (j == 0)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i] >= xLev && x[i] <= xPrav)
                        {
                            m[j]++;
                        }
                    }
                    j++;
                }
                else { 
                for(int i = 0; i < x.Count; i++)
                {
                    if (x[i] > xLev && x[i] <= xPrav)
                    {
                        m[j]++;
                    }
                }
                j++;
                }
            }
            int n = x.Count;
            for (int i = 0; i < m.Count; i++)
                Pi.Add(m[i] / n);

            for (int i = 0; i < m.Count; i++)
                pi.Add(Pi[i] / 6);

            Evaluation ev = new Evaluation(m, Pi, pi);
            return ev;
        }
    }
}
