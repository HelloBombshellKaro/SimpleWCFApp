using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DBService
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    public class RadarService : IRadarService
    {
        public bool EditRadar(string token, Radar radar)
        {
            throw new NotImplementedException();
        }

        public Token GetEditToken(int id, string tableName, string UserName)
        {
            throw new NotImplementedException();
        }

        public Radar[] GetRadarList(string nameFilter)
        {
           WPKMapaModel db = new WPKMapaModel();
           return   db.Radary.Where(r => r.Nazwa.Contains(nameFilter)).Take(100).ToArray();
        }
    }
}
