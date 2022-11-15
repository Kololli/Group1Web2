using Microsoft.Extensions.FileProviders.Embedded;

namespace Group1Web2.Models
{
    public class Profesori
    {
        public Profesori(string emri,string mbiemri)
        {
            Emri= emri;
            Mbiemri= mbiemri;

        }
        public String Emri { get; set; }
        public String Mbiemri { get; set; }
    }
}
