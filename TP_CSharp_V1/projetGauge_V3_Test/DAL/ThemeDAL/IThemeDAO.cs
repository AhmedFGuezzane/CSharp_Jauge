using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetGauge_V3_Test.Model;

namespace projetGauge_V3_Test.DAL
{
    internal interface IThemeDAO
    {
        // signature de la methode GetThemeByKey
        Theme GetThemeByTitle(string themeTitle);

        // signature de la methode GetThemeList
        List<Theme> GetThemeList();
    }
}
