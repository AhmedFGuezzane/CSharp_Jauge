using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetGauge_V3_Test.Model;

namespace projetGauge_V3_Test.Persistence
{
    internal class RegistreData
    {
        #region Attributs
        private List<Data> _dataList;
        private static RegistreData _instance = null;
        #endregion

        #region Propriete
        public List<Data> DataList { get { return _dataList; } set { _dataList = value; } }
        #endregion

        #region Methode Get Instance  //  Retour : RegistreData  //  Parametre : N/A
        public static RegistreData GetInstance()
        { if (_instance == null)
            {
                _instance = new RegistreData();  // Si l'instance est nulle, il fait appel au Constructeur prive
            } 
          return _instance; // Retournes l'instance
        }
        #endregion

        #region Constructeur prive
        private RegistreData() 
        {
            DataList = new List<Data>();
        }
        #endregion
    }
}
