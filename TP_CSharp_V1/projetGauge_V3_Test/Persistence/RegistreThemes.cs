using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetGauge_V3_Test.Model;

namespace projetGauge_V3_Test.Persistence
{
    internal class RegistreThemes
    {

        #region Attributs
        private List<Theme> _themes;
        private static RegistreThemes _instance = null; // instance
        #endregion

        #region Proprietes
        public List<Theme> Themes 
        {  
            get { return _themes; } 
            set { _themes = value; }
        }
        #endregion

        #region Methode GetInstance  //  Retour : RegistreTheme  //  Parametre : N/A
        public static RegistreThemes GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RegistreThemes();
            }
            return _instance;
        }
        #endregion

        #region Constructeur
        private RegistreThemes()
        {

            // Instancier la liste et la populer 

            Themes = new List<Theme>();  

            Themes.Add(
                new Theme(
                    "Forest Green",
                    ColorTranslator.FromHtml("#e0fbfc"),
                    ColorTranslator.FromHtml("#e76f51"),
                    ColorTranslator.FromHtml("#2a9d8f"),
                    ColorTranslator.FromHtml("#e76f51"),
                    ColorTranslator.FromHtml("#e0fbfc"),
                    Color.White
                    )
            );


            Themes.Add(
                new Theme(
                    "Light Blue",
                    ColorTranslator.FromHtml("#f8f9fb"),
                    ColorTranslator.FromHtml("#71a5de"),
                    ColorTranslator.FromHtml("#e1ecf7"),
                    ColorTranslator.FromHtml("#71a5de"),
                    ColorTranslator.FromHtml("#e3f2fd"),
                    ColorTranslator.FromHtml("#5aa9e6")
                    )
            );

            Themes.Add(
                new Theme(
                    "Flaming Red",
                    ColorTranslator.FromHtml("#f1faee"),
                    ColorTranslator.FromHtml("#e63946"),
                    ColorTranslator.FromHtml("#a8dadc"),
                    ColorTranslator.FromHtml("#e63946"),
                    ColorTranslator.FromHtml("#f1faee"),
                    ColorTranslator.FromHtml("#e63946")
                    )
            );

            Themes.Add(
                new Theme(
                    "Natural Pink",
                    ColorTranslator.FromHtml("#f6f2f0"),
                    ColorTranslator.FromHtml("#d0b49f"),
                    ColorTranslator.FromHtml("#e7d1c9"),
                    ColorTranslator.FromHtml("#d0b49f"),
                    ColorTranslator.FromHtml("#f7f0e3"),
                    Color.Black
                    )
            );

            Themes.Add(
                new Theme(
                    "Gotham Purple",
                    ColorTranslator.FromHtml("#f8f7ff"),
                    ColorTranslator.FromHtml("#9381ff"),
                    ColorTranslator.FromHtml("#b8b8ff"),
                    ColorTranslator.FromHtml("#9381ff"),
                    ColorTranslator.FromHtml("#f2f7ff"),
                    Color.Black
                    )
            );

            Themes.Add(
                new Theme(
                    "Default",
                    ColorTranslator.FromHtml("#f7f7f7"),
                    SystemColors.MenuHighlight,
                    SystemColors.ControlLight,
                    SystemColors.MenuHighlight,
                    SystemColors.Control,
                    Color.Black
                    )
            );
        }
        #endregion
    }
}
