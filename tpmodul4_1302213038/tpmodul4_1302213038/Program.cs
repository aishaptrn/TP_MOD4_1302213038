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