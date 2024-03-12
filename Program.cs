using static KodePos;
public class KodePos
{
    private Dictionary<string, string> kodePos;


    public KodePos()
    {
        kodePos = new Dictionary<string, string>
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

    public string GetKodePos(string kelurahan)
    {
        if (kodePos.ContainsKey(kelurahan))
        {
            return kodePos[kelurahan];
        }
        else
        {
            return "Kode Pos Tidak Ditemukan";
        }
    }
}

public enum DoorState
{
    Terkunci,
    Terbuka
}


public class DoorMachine
{
    private DoorState currentState;
 
    public DoorMachine()
    {
        currentState = DoorState.Terkunci;
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

        KodePos kodePosObj = new KodePos();
        string kelurahan = "Batununggal";
        string kodePos = kodePosObj.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

        kelurahan = "Wates";
        kodePos = kodePosObj.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

        kelurahan = "Samoja";
        kodePos = kodePosObj.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

        DoorMachine doorMachine = new DoorMachine();
        Console.WriteLine("");
        Console.WriteLine("Dooormachine");
        Console.WriteLine("");
        Console.WriteLine("state pertama: ");
        doorMachine.KunciPintu();
        Console.WriteLine("");
        Console.WriteLine("state kedua: ");
        doorMachine.BukaPintu();


    }
}