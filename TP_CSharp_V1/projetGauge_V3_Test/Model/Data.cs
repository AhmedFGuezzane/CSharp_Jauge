using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGauge_V3_Test.Model
{
    internal class Data
    {
        #region Attributs
        private string _date;
        private double _currentValue;
        private double _minimumValue;
        private double _maximumValue;
        #endregion

        #region Proprietes
        public String Date {get{ return _date; } set { _date = value; } }
        public double CurrentValue { get { return _currentValue; } set {_currentValue = value; } }
        public double MaximumValue { get { return _maximumValue; } set {_maximumValue = value; } }
        public double MinimumValue { get { return _minimumValue; } set {_minimumValue = value; } }
        #endregion

        #region Constructeurs
        public Data() { }
        public Data(double currVal, double maxVal, double minVal) 
        {
            Date = DateTime.Now.ToString();
            CurrentValue = currVal;
            MinimumValue = minVal;
            MaximumValue = maxVal;
        }
        #endregion

        #region Methode OVERRIDE ToString
        public override string ToString()
        {
            return "TimeStamp : " + Date + "\n" +
                   "Current Value : " + CurrentValue + "\n" +
                   "Minimum Value : " + MinimumValue + "\n" +
                   "Maximum Value : " + MaximumValue + "\n";
        }
        #endregion

    }
}
