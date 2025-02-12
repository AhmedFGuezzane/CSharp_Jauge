using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetGauge_V3_Test.Model
{
    internal class Theme
    {
        #region Atributs
        private string _themeName;
        private Color _gaugeHolderColor;
        private Color _gaugeColor;
        private Color _backColor;
        private Color _buttonColor;
        private Color _panels;
        private Color _textColor;
        #endregion

        #region Proprietes
        public string ThemeName 
        {
            get { return _themeName; }
            set { _themeName = value; }
        }
        public Color GaugeHolderColor 
        {
            get { return _gaugeHolderColor; } set { _gaugeHolderColor = value; }
        }
        public Color GaugeColor
            { get { return _gaugeColor; } set { _gaugeColor = value; } }
        public Color BackColor
            { get { return _backColor; } set { _backColor = value; } }
        public Color ButtonColor
            { get { return _buttonColor; } set { _buttonColor = value; } }
        
        public Color Panels
        {
            get { return _panels; }
            set { _panels = value; }
        }
        public Color TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }
        #endregion

        #region Constructeurs
        public Theme()
        {

        }
        #endregion

        #region Methode OVERRIDE ToString
        public Theme(string themeName, Color gaugeHolder, Color gauge, Color backColor, Color buttonColor, Color panelsColor, Color textColor)
        {
            ThemeName = themeName;
            GaugeHolderColor = gaugeHolder;
            GaugeColor = gauge;
            BackColor = backColor;
            ButtonColor = buttonColor;
            Panels = panelsColor;
            TextColor = textColor;
        }
        #endregion

    }
}
