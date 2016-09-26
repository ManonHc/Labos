using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact manon = new PrivateContact("Manon", "Libert", "manon@gmail.com", 0471243525);
            PrivateContact leandro = new PrivateContact("Leandro", "Gaone", "Leandro@pb.be", 02727482, new DateTime(1986,09,26));
            ProfessionalContact john = new ProfessionalContact("Jonathan", "Giacomello", "consultant", 01847292, "john@gmail.com");
            ProfessionalContact olivier = new ProfessionalContact("Olivier", "Beguin", "indépendant", 0198424, "olivier@apple.be");
            ProfessionalContact antho = new ProfessionalContact("Anthony","Maniscalco","consultant",)
            System.Console.Write(manon);
            System.Console.Write("\n\n");
            System.Console.Write(leandro);
            System.Console.Read();
            
        }
    }
}
