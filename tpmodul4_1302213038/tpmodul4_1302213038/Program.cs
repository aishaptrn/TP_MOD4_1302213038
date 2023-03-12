// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

public class KodePos
{
    public enum lurah { Batununggal, Kujangsari, Mengger, Wates, Cijawura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja}
    public static int getKodePos(lurah kelurahan)
    {
        int[] kodePos = { 40266, 40287, 40267, 402562, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodePos[(int)kelurahan];
    }
}

public class DoorMachine
{
    enum State { terkunci, terbuka };

    public static void Main()
    {
        KodePos kodePos = new KodePos();
        int getKdp = KodePos.getKodePos(KodePos.lurah.Kujangsari);
        Console.WriteLine("Kode Pos kelurahan Kujangsari adalah " + getKdp + ".\n");

        State state = State.terkunci;
        string[] doorLabel = { "Pintu terkunci", "Pintu tidak terkunci"};

        while (state != null)
        {
            Console.WriteLine(doorLabel[(int)state]);
            Console.Write("Input Wanted State: ");

            string input = Console.ReadLine();
            switch (state)
            {
                case State.terkunci:
                    if (input == "KunciPintu")
                    {
                        state = State.terbuka;
                    } else if (input == "BukaPintu") {
                        state = State.terbuka;
                    } else
                    {
                        state = State.terkunci;
                        Console.WriteLine("Invalid input!\n");
                    }
                    break;

                case State.terbuka:
                    if (input == "KunciPintu")
                    {
                        state = State.terkunci;
                    } else if (input == "BukaPintu")
                    {
                        state = State.terbuka;
                    } else
                    {
                        state = State.terbuka;
                        Console.WriteLine("Invalid input!\n");
                    }
                    break;
            }
        }
    }
}