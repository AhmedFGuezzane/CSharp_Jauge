using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetGauge_V3_Test.DAL.DataDAL;
using projetGauge_V3_Test.Model;

namespace projetGauge_V3_Test.Service
{
    internal class DataService
    {
        #region Attribut
        private IDataDAO _dataDAO; // declaration du DAO prive - Acces au sein de cette classe seulement
        #endregion

        #region Constructeur 
        public DataService(IDataDAO dao)  // Prend en parametre un dao de type IDataDAO
        {
            _dataDAO = dao; 
        }
        #endregion

        #region Methode GetData  //  Retour : Data  //  Parametre : string
        public Data GetData(string timestamp)
        {
            return _dataDAO.SelectData(timestamp);
        }
        #endregion

        #region Methode GetDataList  //  Retour : List<Data>  //  Parametre : N/A
        public List<Data> GetDataList() 
        {
            return _dataDAO.GetDataList();
        }
        #endregion

        #region Methode SaveData  //  Retour : void  //  Parametre : Data
        public void SaveData(Data data)
        {
            _dataDAO.CreateData(data);
        }
        #endregion
    }
}
