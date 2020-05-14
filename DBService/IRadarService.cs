using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IRadarService
    {
        [OperationContract]
        Radar[] GetRadarList(string nameFilter);

        [OperationContract]
        Token GetEditToken(int id, string tableName,string UserName);

        [OperationContract]
        bool EditRadar(string token, Radar radar);


    }

   public class Token
    {
        public bool EditGranted { get; set; }
        public string TokenValue { get; set; }
        public string CurrentEditor { get; set; }
    }

}
