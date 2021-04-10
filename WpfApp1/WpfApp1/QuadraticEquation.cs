using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    [Serializable]
    public class QuadraticEquation : IComparable, IComparable<QuadraticEquation>
    {
        private decimal _coeficient1;
        decimal _coeficient2;
        private decimal Coeficient3 { set; get; }
        public QuadraticEquation(decimal coeficient1, decimal coeficient2, decimal coeficient3)
        {
            Coeficient1 = coeficient1;
            Coeficient2 = coeficient2;
            Coeficient3 = coeficient3;
        }
        public QuadraticEquation()
        {
            Coeficient1 = 1;
            Coeficient2 = 2;
            Coeficient3 = 3;
        }
        public QuadraticEquation(decimal coeficient1, decimal coeficient2)
        {
            Coeficient1 = coeficient1;
            Coeficient2 = coeficient2;
        }
        public string Zapis
        {
            get
            {
                return ($"{Coeficient1}x^2" + (Coeficient2 < 0 ? "" : "+") + $"{Coeficient2}x" + (Coeficient3 < 0 ? "" : "+") + $"{Coeficient3}=0\n");
            }
        }
        public decimal Coeficient1
        {
            get
            {
                return _coeficient1;
            }
            set
            {
                _coeficient1 = value;
            }
        }
        public decimal Coeficient2
        {
            get
            {
                return _coeficient2;
            }
            set
            {
                _coeficient2 = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Перший коефiцiент рiвняння: {0}\n" + "Другий коефiцiент рiвняння: {1}\n" +
                "Третiй коефiцiент рiвняння: {2}\n" + "Запис у текстовому виглядi: {3}\n", _coeficient1, Coeficient2, Coeficient3, Zapis);
        }
        public int CompareTo(object obj)
        {
            var qe = obj as QuadraticEquation;
            if (qe == null)
            {
                throw new ArgumentException("Not " + nameof(QuadraticEquation));
            }
            else
            {
                return CompareTo(qe);
            }
        }
        public int CompareTo(QuadraticEquation other)
        {
            return Coeficient1.CompareTo(other.Coeficient1);
        }
    }
}

