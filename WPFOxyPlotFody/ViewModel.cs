using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.Windows.Threading;

namespace WPFOxyPlotFody
{
    //[ImplementPropertyChanged]
    class ViewModel
    {
        public Collection<CollectionDataValue> Data { get; set; }

        public class CollectionDataValue
        {
            public double xData { get; set; }
            public double yData { get; set; }
        }

        public ViewModel()
        {
            Data = new Collection<CollectionDataValue>();
            DrawingCollecion();
        }

        public double GetFunctionValue(double a, double b, double c, double x)
        {
            double y;

            y = a * x * x + b * x + c;

            return y;
        }

        public double GetFunctionValue(double x)
        {
            double y;

            y = x * x;

            return y;
        }

        void DrawingCollecion()
        {
            for (double i = -10; i <= 10; i+=0.1)
            {
                Data.Add(new CollectionDataValue { xData = i, yData = GetFunctionValue(i) });
            }
        }
    }
}
