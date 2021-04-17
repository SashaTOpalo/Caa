using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        [Serializable]
        class CvadratneRivnyanya : IComparable<CvadratneRivnyanya>
        {
            private int _coeficient1;
            private string _zapis;
            public int Coeficient1
            {
                get { return _coeficient1; }
                set
                {
                    if (value >= 0)
                    {
                        _coeficient1 = value;
                    }
                }
            }
            public int Coeficient2 { get; set; }
            public int Coeficient3 { get; set; }
            public CvadratneRivnyanya(int coeficient1Value, int

            coeficient2Value, int coeficient3Value, string zapisValue)

            {
                _zapis = zapisValue;
                _coeficient1 = coeficient1Value;
                Coeficient3 = coeficient3Value;
                Coeficient2 = coeficient2Value;
            }
            public int CompareTo(CvadratneRivnyanya other)
            {
                if (Coeficient1 == other.Coeficient1)
                {
                    return 0;
                }
                else
                if (Coeficient1 > other.Coeficient1)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            public override string ToString()
            {
                return String.Format("Перший коефіціент рівняння:{ 0}\n Другий коефіціент рівняння: { 1}\nТретій коефіціент рівняння: { 2}\n Запис у
текстовому вигляді: { 3}", _coeficient1, Coeficient2, Coeficient3, _zapis);

}
        }