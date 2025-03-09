using System;
using System.Collections.Generic;

public class KodePos
{

    private Dictionary<string, string> kodePosTable;

    public KodePos()
    {
        kodePosTable = new Dictionary<string, string>
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" },
            { "Samoja", "40273" }
        };
    }


    public string getKodePos(string kelurahan)
    {
        if (kodePosTable.ContainsKey(kelurahan))
        {
            return kodePosTable[kelurahan];
        }
        else
        {
            return "Kode Pos Tidak Ditemukan";
        }
    }
}

public class DoorMachine
{

    private enum DoorState
    {
        Locked,
        Unlocked
    }


    private DoorState currentState;

    public DoorMachine()
    {
        currentState = DoorState.Locked;
    }

    public void LockDoor()
    {
        if (currentState == DoorState.Unlocked)
        {
            currentState = DoorState.Locked;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }

    public void UnlockDoor()
    {
        if (currentState == DoorState.Locked)
        {
            currentState = DoorState.Unlocked;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void ChangeState()
    {
        if (currentState == DoorState.Locked)
        {
            Console.WriteLine("Pintu terkunci");
        }
        else if (currentState == DoorState.Unlocked)
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}

public class Program
{
    public static void Main()
    {

        KodePos kodePos = new KodePos();


        Console.WriteLine("Kode pos untuk Batununggal: " + kodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kode pos untuk Wates: " + kodePos.getKodePos("Wates"));
        Console.WriteLine("Kode pos untuk Cijaura: " + kodePos.getKodePos("Cijaura"));
        Console.WriteLine();


        DoorMachine door = new DoorMachine();


        door.ChangeState();
        Console.WriteLine();

        door.UnlockDoor();

        door.LockDoor();
    }
}