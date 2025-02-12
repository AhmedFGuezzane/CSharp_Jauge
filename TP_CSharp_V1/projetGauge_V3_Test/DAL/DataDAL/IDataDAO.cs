using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetGauge_V3_Test.Model;

namespace projetGauge_V3_Test.DAL.DataDAL
{
    internal interface IDataDAO
    {

        // signature de la methode CreateData pour rajouter une donnee dans le registre de donnees
        void CreateData(Data data);
        
        // signature de la methode GetDataList pour recuper la liste de donnees
        List<Data> GetDataList();
        
        // signature de la methode SelectData pour recuperer un historique en fonction du timestamp
        Data SelectData(string timestamp);
    }
}
