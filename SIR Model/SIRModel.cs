using System;
using System.Collections.Generic;

namespace SIR_Model
{
    class SIRModel
    {
        readonly double s_0; // initial susceptable proportion
        readonly double i_0; // initial infected proportion

        public SIRModel(double _s_0, double _i_0)
        {
            s_0 = _s_0;
            i_0 = _i_0;
        }

        public Dictionary<DateTime, double> Calculate(DateTime start, DateTime end, double b, double k)
        {
            Dictionary<DateTime, double> infections = new Dictionary<DateTime, double>();
            infections.Add(start, i_0);
            DateTime currentDate = start.AddDays(1);
            double sPrev = s_0;
            double iPrev = i_0;

            while (currentDate <= end)
            {
                double s = sPrev - (b * sPrev * iPrev);
                double i = iPrev + (b * sPrev * iPrev - k * iPrev);
                infections.Add(currentDate, i);

                sPrev = s;
                iPrev = i;
                currentDate = currentDate.AddDays(1);
            }
            return infections;
        }

    }

}
