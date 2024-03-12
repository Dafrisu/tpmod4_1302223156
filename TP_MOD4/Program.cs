// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> kodePosTabel;

    public KodePos()
    {
        kodePosTabel = new Dictionary<string, string>
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };
    }

    public string getKodePos(string kelurahan)
    {
        if (kodePosTabel.ContainsKey(kelurahan))
        {
            return kodePosTabel[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}
public class DoorMachine
{
    public enum DoorState
    {
        Terkunci,
        Terbuka
    }

    private DoorState currentState;

    public DoorMachine()
    {
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        currentState = DoorState.Terbuka;
        Console.WriteLine("Pintu tidak terkunci");
    }

    public void KunciPintu()
    {
        currentState = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }
}


class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine("Kode pos untuk Kelurahan Batununggal: " + kodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kode pos untuk Kelurahan Kujangsari: " + kodePos.getKodePos("Kujangsari"));
        Console.WriteLine("Kode pos untuk Kelurahan Mengger: " + kodePos.getKodePos("Mengger"));
        Console.WriteLine("Kode pos untuk Kelurahan Wates: " + kodePos.getKodePos("Wates"));
        Console.WriteLine("Kode pos untuk Kelurahan Cijaura: " + kodePos.getKodePos("Cijaura"));
        Console.WriteLine("Kode pos untuk Kelurahan Jatisari: " + kodePos.getKodePos("Jatisari"));
        Console.WriteLine("Kode pos untuk Kelurahan Margasari: " + kodePos.getKodePos("Margasari"));
        Console.WriteLine("Kode pos untuk Kelurahan Sekejati: " + kodePos.getKodePos("Sekejati"));
        Console.WriteLine("Kode pos untuk Kelurahan Kebonwaru: " + kodePos.getKodePos("Kebonwaru"));
        Console.WriteLine("Kode pos untuk Kelurahan Maleer: " + kodePos.getKodePos("Maleer"));
        Console.WriteLine("Kode pos untuk Kelurahan Samoja: " + kodePos.getKodePos("Samoja"));

        DoorMachine door = new DoorMachine();

        door.BukaPintu();
        door.KunciPintu();
    }
}