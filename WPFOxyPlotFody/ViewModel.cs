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
            //DrawingCollecionFunction();
            DrawingCollecionLambdaExpression();
            //DrawingCollecionLambdaExpressionWithAllCoefficients();
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

        Func<double, double> y = x => x * x;//Func<double, double> y(name) = x(function argument) => x * x(returned value)
                                            //GetFunctionValue and y lambda are equivalent

        //Func<double, double, double, double, double> y = (a, b, c, x) => a * x * x + b * x + c;

        void DrawingCollecionFunction()
        {
            for (double x = -10; x <= 10; x += 0.1)
            {
                Data.Add(new CollectionDataValue { xData = x, yData = GetFunctionValue(x) });
            }
        }

        void DrawingCollecionLambdaExpression()
        {
            for (double x = -10; x <= 10; x += 0.1)
            {
                Data.Add(new CollectionDataValue { xData = x, yData = y(x) });
            }
        }

        //void DrawingCollecionLambdaExpressionWithAllCoefficients()
        //{
        //    for (double x = -10; x <= 10; x+=0.1)
        //    {
        //        Data.Add(new CollectionDataValue { xData = x, yData = y(-1, 1, 1, x) });
        //    }
        //}
    }
}
