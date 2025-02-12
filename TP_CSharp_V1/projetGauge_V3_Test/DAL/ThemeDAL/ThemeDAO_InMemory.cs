using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using projetGauge_V3_Test.Model;
using projetGauge_V3_Test.Persistence;

namespace projetGauge_V3_Test.DAL
{
    internal class ThemeDAO_InMemory:IThemeDAO
    {
        #region Attributs
        private RegistreThemes _regTheme;
        #endregion

        #region Constructeur
        public ThemeDAO_InMemory() 
        {
            _regTheme = RegistreThemes.GetInstance();  // recuperation de l'instance pour s'assurer qu'on travaille sur un seul et meme registre
        }
        #endregion

        #region Methode GetThemeByTitle  //  Retour : Theme  //  Parametre : string
        public Theme GetThemeByTitle(string themeTitle)
        {
            return _regTheme.Themes.First(t => t.ThemeName == themeTitle); // Retournes le Theme associe au string passe en parametres
        }
        #endregion

        #region Methode GetThemeList  //  Retour : List<Theme>  //  Parametre : N/A
        public List<Theme> GetThemeList()
        {
            return _regTheme.Themes.ToList(); // Retournes une liste de themes
      
        }
        #endregion

    }
}
