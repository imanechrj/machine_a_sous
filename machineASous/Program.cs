namespace machineASous;

class Program
{
    /*Programme Kata Machine à sous :
    5€ la partie
    4 symboles : Cerise, Banane, Pomme, 7

    Double Cerise : 12€
    Triple Cerise : 20€
    Triple Banane : 30€
    Triple Pomme : 50€
    Triple 7 : 100€ 
*/
    static void Main(string[] args)
    {
        int miseDeDepart =2000;
        int prixPartie = 5;
        int nombreDeTours = miseDeDepart/prixPartie;
        int sommeGagnee = 0;
        int benefice;


        for (int i = 1; i <= nombreDeTours; i++)
        {
            Console.WriteLine("Tour n"+i);
            var rand = new Random();
            int aleatoire1 = rand.Next(1, 4);
            int aleatoire2 = rand.Next(1, 4);
            int aleatoire3 = rand.Next(1, 4);

            string symbole1 = " ";
            string symbole2 = " ";
            string symbole3 = " ";

            switch (aleatoire1)
            {
                case 1:
                    Console.WriteLine("cerise");
                    symbole1 = "cerise";
                    break;
                case 2:
                    Console.WriteLine("Banane");
                    symbole1 = "banane";
                    break;
                case 3:
                    Console.WriteLine("Pomme");
                    symbole1 = "pomme";
                    break;
                case 4:
                    Console.WriteLine("Sept");
                    symbole1 = "sept";
                    break;
                default:
                    break;
            }

            switch (aleatoire2)
            {
                case 1:
                    Console.WriteLine("cerise");
                    symbole2 = "cerise";
                    break;
                case 2:
                    Console.WriteLine("Banane");
                    symbole2 = "banane";
                    break;
                case 3:
                    Console.WriteLine("Pomme");
                    symbole2 = "pomme";
                    break;
                case 4:
                    Console.WriteLine("Sept");
                    symbole2 = "sept";
                    break;
                default:
                    break;
            }

            switch (aleatoire3)
            {
                case 1:
                    Console.WriteLine("cerise");
                    symbole3 = "cerise";
                    break;
                case 2:
                    Console.WriteLine("Banane");
                    symbole3 = "banane";
                    break;
                case 3:
                    Console.WriteLine("Pomme");
                    symbole3 = "pomme";
                    break;
                case 4:
                    Console.WriteLine("Sept");
                    symbole3 = "sept";
                    break;
                default:
                    break;
            }



            if ((symbole1 == "cerise" && symbole2 == "cerise")|| (symbole2 == "cerise" && symbole3 == "cerise") || (symbole1 == "cerise" && symbole3 == "cerise"))
            {
                sommeGagnee += 12;
            }

            if(symbole1 == "cerise" && symbole2 == "cerise" && symbole3 == "cerise")
            {
                sommeGagnee += 20;
            }

            if (symbole1 == "banane" && symbole2 == "banane" && symbole3 == "banane")
            {
                sommeGagnee += 30;
            }

            if (symbole1 == "pomme" && symbole2 == "pomme" && symbole3 == "pomme")
            {
                sommeGagnee += 50;
            }

            if (symbole1 == "sept" && symbole2 == "sept" && symbole3 == "sept")
            {
                sommeGagnee += 100;
            }
        }
        Console.WriteLine("Vous avez gagné : " + sommeGagnee);
        benefice = sommeGagnee - miseDeDepart;
        Console.WriteLine("Par rapport a votre mise de départ vos bénéfice sont de : " + benefice);
    }
}

