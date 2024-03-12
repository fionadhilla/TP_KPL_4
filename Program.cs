// Class untuk menyimpan data kode pos

using static KodePos;
public class KodePos
{
    private Dictionary<string, string> kodePos;

    // Konstruktor untuk inisialisasi data kode pos
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

    // Method untuk mendapatkan kode pos berdasarkan kelurahan
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

class Program
{
    static void Main(string[] args)
    {
        // Menggunakan teknik table-driven untuk mendapatkan kode pos
        KodePos kodePosObj = new KodePos();
        string kelurahan = "Batununggal";
        string kodePos = kodePosObj.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

        kelurahan = "Kujangsari";
        kodePos = kodePosObj.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

        kelurahan = "Cijaura";
        kodePos = kodePosObj.GetKodePos(kelurahan);
        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");

    }
}