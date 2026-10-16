namespace Tombok
{
    internal class Program
    {

        static string[] torpok = new string[7];
        static void TorpokLetrehozasa()
        {
            torpok[0] = "Szundi";
            torpok[1] = "Szende";
            torpok[2] = "Hapci";
            torpok[3] = "Morgó";
            torpok[4] = "Tudor";
            torpok[5] = "Vidor";
            torpok[6] = "kuka";
        }

        static void TorpokKiirasa()
        {
            Console.WriteLine($"A törpök lista elemeinek száma: {torpok.Length}");
            for(int i = 0; i < torpok.Length; i++)
            {
                Console.WriteLine(torpok[i]);
            }
        }


        static void Csere()
        {
            Console.Write("Melyik törpöt cseréljük le?");
            string nev = Console.ReadLine();
            //kivalasztas tétele: van-e a tömben ilyen név, és ha van akkor hanyadik helyen
            int index = 0;
            while (index < torpok.Length && torpok[index]!=nev)
            {
                index ++;
            }
            if (index < torpok.Length)
            {
                
                Console.Write("Melyik törpöt cserljük le:");
                string ujnev = Console.ReadLine();
                torpok[index] = ujnev;
                Console.WriteLine("Lecserélve");
            }
            else
            {
                Console.WriteLine("Nincs ilyen törp a listában");
            }
        }




        static void Main(string[] args)
        {
            TorpokLetrehozasa();
            TorpokKiirasa();
            Csere();
            TorpokKiirasa();
        }
    }
}
