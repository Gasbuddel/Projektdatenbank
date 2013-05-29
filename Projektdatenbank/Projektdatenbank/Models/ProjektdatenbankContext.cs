using System.Data.Entity;

namespace Projektdatenbank.Models
{
	public class ProjektdatenbankContext : DbContext
	{
        // Sie können der Datei benutzerdefinierten Code hinzufügen. Änderungen werden nicht überschrieben.
        // 
        // Wenn Entity Framework die Datenbank bei jeder Änderung des Modellschemas automatisch löschen und erneut generieren soll, so ergänzen Sie die Application_Start-Methode in der Datei "Global.asax" um den folgenden Code. 
        // Hinweis: Dieser Code bewirkt, dass die Datenbank bei jeder Änderung des Modells gelöscht und neu erstellt wird.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Projektdatenbank.Models.ProjektdatenbankContext>());

        public ProjektdatenbankContext() : base("name=ProjektdatenbankContext")
        {
        }

		public DbSet<TKunde> TKunde { get; set; }
	}
}
