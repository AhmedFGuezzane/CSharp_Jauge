using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetGauge_V3_Test.DAL.DataDAL;
using projetGauge_V3_Test.Model;
using projetGauge_V3_Test.Persistence;

namespace projetGauge_V3_Test.DAL
{
    internal class DataDAO_InMemory : IDataDAO
    {
        #region Attributs
        private RegistreData _regData; // Pas besoin de propriete car les manipulation sur le registre ne se font que dans cette classe
        #endregion

        #region Constructeur
        public DataDAO_InMemory() 
        {
            _regData = RegistreData.GetInstance(); // Recuperation de l'instance du registre pour s'assurer que nous travaillons sur un seul registre
        }
        #endregion

        #region Methode CreateData  //  Retour : void  //  Parametre : Data
        void IDataDAO.CreateData(Data data)
        {
            _regData.DataList.Add(data); // Ajout des donnees dans la liste du registre
        }
        #endregion

        #region Methode GetDataList  //  Retour : List<Data>  //  Parametre : N/A
        List<Data> IDataDAO.GetDataList()
        {
            return _regData.DataList;
        }
        #endregion

        #region Methode SelectData  //  Retour : Data  //  Parametre : string
        Data IDataDAO.SelectData(string timestamp)
        {
            return _regData
                   .DataList.First(d => d.Date == timestamp); // Retournes le premier data trouve avec ce timestamp (il n'est cense en avoir qu'un seul)        
        }
        #endregion
    }
}
