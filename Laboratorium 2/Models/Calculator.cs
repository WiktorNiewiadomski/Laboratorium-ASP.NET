using static Laboratorium_2.Controllers.CalculatorController;

namespace Laboratorium_2.Models
{
    public class Calculator
    {
        public Operators? op { get; set; }
        public double? a { get; set; }
        public double? b { get; set; }

        public String Op
        {
            get
            {
                switch (op)
                {
                    case Operators.Add:
                        return "+";
                    case Operators.Sub:
                        return "-";
                    case Operators.Div:
                        return "/";
                    case Operators.Mul:
                        return "*";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return op != null && a != null && b != null;
        }

        public double Calculate()
        {
            switch (op)
            {
                case Operators.Add:
                    return (double)(a + b);
                    break;
                case Operators.Sub:
                    return (double)(a - b);
                    break;
                case Operators.Div:
                    return (double)(a / b);
                    break;
                case Operators.Mul:
                    return (double)(a * b);
                    break;

                default: 
                    return double.NaN;
            }
        }
    }
}
