using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GaugeV3
{
    public partial class Gauge : UserControl
    {

        // Attributes
        #region Attributes
        private float _minValue;
        private float _maxValue;
        private float _currentValue;
        private int _noOfDivisions;
        private Color _textColor;
        private Color _gaugeHolderColor;
        private Color _gaugeColor;
        private Color _innerGaugeTxtColor;
        private bool _showSubDivision;
        #endregion

        // Each Property is linked to a category (Values, Ruler and Gauge Colors)
        #region Properties
        [Category("@Values")]
        [DefaultValue(0)]
        [Description("Valeur minimum sur la gauge")]
        public float MinValue
        {
            get { return _minValue; }
            set
            {
                if (value < MaxValue)
                {
                    _minValue = value;
                    if (CurrentValue < _minValue)
                    {
                        CurrentValue = _minValue;
                    }      
                }
                this.Invalidate();
            }
        }

        [Category("@Values")]
        [DefaultValue(100)]
        [Description("Valeur maximum sur la gauge")]
        public float MaxValue
        {
            get { return _maxValue; }
            set
            {
                if (value > MinValue)
                {
                    _maxValue = value;
                    if (CurrentValue > _maxValue)
                    {
                        CurrentValue = _maxValue;
                    }      
                }
                this.Invalidate();
            }
        }

        [Category("@Values")]
        [DefaultValue(0)]
        [Description("Valeur actuelle a afficher sur la gauge")]
        public float CurrentValue
        {
            get { return _currentValue; }
            set
            {
                if (value >= MinValue && value <= MaxValue)
                {
                    _currentValue = value;     
                }

                this.Invalidate();
            }
        }

        [Category("@Ruler")]
        [DefaultValue(5)]
        [Description("Nombre de divisions sur l'echelle de la gauge (Maximum 10)")]
        public int NoOfDivision
        {
            get { return _noOfDivisions; }
            set
            {
                _noOfDivisions = (value > 10) ? 10 : value;
                this.Invalidate();
            }
            
        }

        [Category("@Ruler")]
        [DefaultValue(false)]
        [Description("Set to True if you want to show subdivision")]
        public bool ShowSubDivision
        {
            get { return _showSubDivision; }
            set
            {
                _showSubDivision = value;
                this.Invalidate();
            }
            
        }

        [Category("@Gauge Colors")]
        [Description("Set the color for the Text")]
        public Color TextColor 
        {
            get { return _textColor; }
            set { _textColor = value; }
        }

        [Category("@Gauge Colors")]
        [DefaultValue("#f7f7f7")]
        [Description("Set the color of the gauge holder (background)")]
        public Color GaugeHolderColor
        {
            get { return _gaugeHolderColor; }
            set 
            { 
                _gaugeHolderColor = value;
                this.Invalidate();
            }
        }

        [Category("@Gauge Colors")]
        [DefaultValue("Menu Highlight")]
        [Description("Set the color of the gauge")]
        public Color GaugeColor
        {
            get { return _gaugeColor; }
            set 
            { 
                _gaugeColor = value;
                this.Invalidate();
            }
        }

        [Category("@Gauge Colors")]
        [DefaultValue("White")]
        [Description("Set the color of the inner text of the gauge (current value)")]
        public Color InnerGaugeTxtColor
        {
            get { return _innerGaugeTxtColor; }
            set
            {
                _innerGaugeTxtColor = value;
                this.Invalidate();
            }
        }
        #endregion

        // Default constructors initializing the attributes by their properties
        #region Constructors
        public Gauge()
        {
            InitializeComponent();
            MinValue = 0;
            MaxValue = 100;
            CurrentValue = 0;
            NoOfDivision = 5;
            GaugeHolderColor = ColorTranslator.FromHtml("#f7f7f7");
            GaugeColor = SystemColors.MenuHighlight;
            InnerGaugeTxtColor = Color.White;
            TextColor = Color.Black;
            ShowSubDivision = false;

        }
        #endregion

        // OnPaint
        #region OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            
            Graphics graphics = e.Graphics;


            // Setting the GaugeHolder. This is in OnPaintBackground because it doesn't need to change. It is not dynamic.
            float gaugeHolderWidth = Width * 90 / 100;
            float gaugeHolderHeight = Height * 40 / 100;
            float gaugeHolderX = (Width - gaugeHolderWidth) / 2;
            float gaugeHolderY = (Height - gaugeHolderHeight) / 2;

            RectangleF _gaugeRect = new RectangleF(gaugeHolderX, gaugeHolderY, gaugeHolderWidth, gaugeHolderHeight);
            graphics.FillRectangle(new SolidBrush(GaugeHolderColor), _gaugeRect);

            
            
            DrawCalibration(graphics, _gaugeRect, NoOfDivision, ShowSubDivision, MinValue, MaxValue);

            // Only draw the gauge rectangle if the current value is greater than 0
            if (CurrentValue > 0 && CurrentValue > MinValue)
            {
                // Calculate the width of the gauge rectangle based on the current value
                float gaugeRectWidth = (CurrentValue - MinValue) / (MaxValue - MinValue) * _gaugeRect.Width;

                RectangleF gaugeRect = new RectangleF(_gaugeRect.Left, _gaugeRect.Top, gaugeRectWidth, _gaugeRect.Height);
                graphics.FillRectangle(new SolidBrush(GaugeColor), gaugeRect);


                // Draw the current value inside the gauge rectangle
                string currentValueText = CurrentValue.ToString(); 
                SizeF textSize = graphics.MeasureString(currentValueText, this.Font);
                float textX = gaugeRect.Left + (gaugeRect.Width - textSize.Width) / 2; // Center value horizontally
                float textY = gaugeRect.Top + (gaugeRect.Height - textSize.Height) / 2; // Center value vertically

                // Draw the current value text
                using (SolidBrush textBrush = new SolidBrush(InnerGaugeTxtColor)) // White color for text
                {
                    graphics.DrawString(currentValueText, this.Font, textBrush, textX, textY);
                }
            }

        }
        #endregion


        #region OnPaintBackground
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Seul le rectangle qui nous sert de gabarit (GaugeHolder) est dans OnPaintBackground car il reste toujours le meme
            Graphics graphics = e.Graphics;
            graphics.Clear(Parent.BackColor);
            // Setting a rectangle that will hold the whole component as transparent or a solid color
            graphics.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, Width, Height);
        }
        #endregion



        //Creating the ruler (Draw Calibration)
        #region Method to create the Ruler 

        private void DrawCalibration(Graphics g, RectangleF rect, int noOfDivisions, bool showSubDivision, float minValue, float maxValue)
        {
            // Calculate the gap for divisions
            float rulerWidth = rect.Width;
            float startX = rect.Left;
            float topLineY = rect.Top - 20; // Starting point for the lines above the rectangle (-20px for the space between ruler and gauge)
            float divisionLineHeight = 10; // Height of division lines
            float subDivisionLineHeight = 6; // Height of subdivision lines (a bit smaller than the division lines)

            // Calculate step values
            float divisionStep = rulerWidth / noOfDivisions;
            float valueStep = (maxValue - minValue) / noOfDivisions;

            // Fonts for division and subdivision text
            Font divisionFont = this.Font;
            Font subdivisionFont = new Font(this.Font.FontFamily, this.Font.Size * 0.8f, this.Font.Style); // Subdivision font is 80% of the main font size

            // Use a pen with this.TextColor for both division and subdivision lines
            using (Pen divisionPen = new Pen(this.TextColor, 2)) // Use this.TextColor for divisions
            using (Pen subDivisionPen = new Pen(this.TextColor, 1)) // Use this.TextColor for subdivisions
            {
                // Draw lines and text for main divisions
                for (int i = 0; i <= noOfDivisions; i++)
                {
                    float currentX = startX + (i * divisionStep);
                    float currentValue = minValue + (i * valueStep);

                    // Draw the division line
                    g.DrawLine(divisionPen, currentX, topLineY, currentX, topLineY + divisionLineHeight);

                    // Draw the value as text above the rectangle
                    string text = currentValue.ToString("0.0");
                    SizeF textSize = g.MeasureString(text, divisionFont);
                    float textX = currentX - textSize.Width / 2;
                    float textY = topLineY - textSize.Height - 5; // Padding

                    g.DrawString(text, divisionFont, new SolidBrush(this.TextColor), textX, textY); // Use this.TextColor
                }

                // Draw lines and text for subdivisions if showSubDivision is true
                if (showSubDivision)
                {
                    float subDivisionStep = divisionStep / 2; // One subdivision in the middle of each division
                    float subValueStep = valueStep / 2;

                    for (int i = 0; i < noOfDivisions; i++)
                    {
                        float currentX = startX + (i * divisionStep) + subDivisionStep;
                        float currentValue = minValue + (i * valueStep) + subValueStep;

                        // Draw the subdivision line
                        g.DrawLine(subDivisionPen, currentX, topLineY, currentX, topLineY + subDivisionLineHeight);

                        // Draw the subdivision value as text above the rectangle
                        string subText = currentValue.ToString("0.0");
                        SizeF textSize = g.MeasureString(subText, subdivisionFont);
                        float textX = currentX - textSize.Width / 2;
                        float textY = topLineY - textSize.Height - 5; // Padding

                        g.DrawString(subText, subdivisionFont, new SolidBrush(this.TextColor), textX, textY); // Use this.TextColor
                    }
                }
            }
        }

        #endregion

        // Updating the gauge - to be called when button is pressed on the form
        #region Update Gauge
        public void UpdateGauge(string inputCurrentValue, string inputMinValue, string inputMaxValue) 
        {
            
            // We first test that the values are all filled in
            if (inputCurrentValue == "" || inputMaxValue == "" || inputMinValue == "")
            {
                MessageBox.Show("Current Value, Minimum Value and Maximum Value are required.");
                return;
            }

            // Parsing the Strings int float values
            float parsedCurrVal = float.Parse(inputCurrentValue);
            float parsedMaxValue = float.Parse(inputMaxValue);
            float parsedMinValue = float.Parse(inputMinValue);


            // Testing if the current value input is withing the minimum and maximum range set
            if (parsedCurrVal < parsedMinValue || parsedCurrVal > parsedMaxValue)
            {
                MessageBox.Show("Current Value needs to be within Gauge range.");
                return;
            }

            // Validating that the Max Value input is higher then the Min Value input
            if (parsedMaxValue < parsedMinValue) 
            {
                MessageBox.Show("Maximum Value can't be lower than Minimum Value.");
                return;
            }

            // Accessing the properties of the Gauge Values 

            MinValue = parsedMinValue;
            MaxValue = parsedMaxValue;
            
            CurrentValue = parsedCurrVal;
        }
        #endregion






    }
}
