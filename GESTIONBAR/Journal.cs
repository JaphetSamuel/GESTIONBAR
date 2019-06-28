using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace GESTIONBAR
{
    
    static class  Journal 
    {
        [JsonProperty("id")]
        private static int id;

        [JsonProperty("recette")]
        public static int Recette { get; set; }

        [JsonProperty("sommeDepart")]
        public static int SommeDepart { get; set; }

        [JsonProperty("date")]
        public static DateTime date { get; private set; }

        [JsonProperty("operations")]
        public static Dictionary<DateTime, string> Operations = new Dictionary<DateTime, string>();

        public static Dictionary<string, string> Dictionnaire;


        public static void Sauvegarder()
        {
            Journal.id = int.Parse(Properties.Resources.nombreJournaux);
            
            string nomFichier = @"C:\Users\TheName\Documents\ResumeBar.bar";

            Journal.Dictionnaire = new Dictionary<string, string>
        {
            {"id", Journal.id.ToString() },
            {"recette",Journal.Recette.ToString() },
            {"sommeDepart",Journal.SommeDepart.ToString() },
            {"date", Journal.date.ToLongDateString() },
            {"operations", JsonConvert.SerializeObject(Operations) }
        };

            string serial = JsonConvert.SerializeObject(Dictionnaire);
            File.AppendAllText(nomFichier, serial + "\n");
            Operations.Clear();
            Console.Write("sauvegarde reussie!!");
            
        }

        public static void Charger()
        {
            string[] jsonJournalString = File.ReadAllLines(@"C:\Users\TheName\Documents\ResumeBar.bar");
            string journelActuelle = jsonJournalString[jsonJournalString.Length - 1];

            Dictionnaire = JsonConvert.DeserializeObject<Dictionary<string, string>>(journelActuelle);

           
                Journal.Recette = int.Parse(Dictionnaire["recette"]);
                Journal.SommeDepart = int.Parse(Dictionnaire["sommeDepart"]);
                Journal.id = int.Parse(Dictionnaire["id"]);
                Journal.date = DateTime.Parse(Dictionnaire["date"]);
                Journal.Operations = JsonConvert.DeserializeObject<Dictionary<DateTime, string>>(Dictionnaire["operations"]);
            
        }

        public static void Vendu(int somme, string phrase = "")
        {
            Journal.Recette += somme;
            if(phrase == "")
            {
                phrase = $"xxx quantite de xxx vendu a {somme}";
            }

            Operations[DateTime.Now] = phrase;
        }

        public static void Depenser(int somme, string phrase = "")
        {
            if(Journal.Recette > somme)
            {
                Journal.Recette -= somme;

            }
            else if(Journal.SommeDepart > somme)
            {
                Journal.SommeDepart -= somme;
            }
            else
            {
                return;
            }
            
            if (phrase == "")
            {
                phrase = $"{somme} fcfa sortie pour xxx";
            }

            Operations[DateTime.Now] = phrase;
        }
        
        public static void Archiver()
        {
            string fichierResumer = @"C:\Users\TheName\Documents\ResumeBar.bar";
            string fichierArchive = @"C:\Users\TheName\Documents\archivebar" + DateTime.Now.ToLongDateString() + ".arb".Replace(" ", "_");

            //File.Create(fichierArchive);
            File.Copy(fichierResumer, fichierArchive);
            File.Delete(fichierResumer);
        }
        
    }
}
