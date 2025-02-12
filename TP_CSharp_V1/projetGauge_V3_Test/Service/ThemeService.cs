using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaugeV3;
using projetGauge_V3_Test.DAL;
using projetGauge_V3_Test.Model;

namespace projetGauge_V3_Test.Service
{
    internal class ThemeService
    {
        #region Attribut
        private IThemeDAO _themeDAO; // dao prive - utilisation au sein de la classe seulement
        #endregion

        #region Constructeur 
        public ThemeService(IThemeDAO themeDAO) // prend en parametre un dao de type IThemeDAO
        {
            this._themeDAO = themeDAO;
        }
        #endregion

        #region Methode GetThemeByKey  //  Retour : Theme  //  Parametre : string 
        public Theme GetThemeByTitle(string themeTitle) 
        {
            return _themeDAO.GetThemeByTitle(themeTitle);  // Retournes le theme qui a comme titre le string passe en parametre 
        }
        #endregion

        #region Methode GetThemes  //  Retour : List<Theme>  //  Parametre : N/A 
        public List<Theme> GetThemes()
        {
            return _themeDAO.GetThemeList();  // Retournes la liste de themes
        }
        #endregion
    }
}
