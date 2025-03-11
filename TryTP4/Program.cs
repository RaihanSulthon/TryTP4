using TryTP4;

class Program
{
    static void Main()
    {
        KodePos kodepos = new KodePos();

        Console.WriteLine("Masukkan Nama Kelurahan: ");
        String input = Console.ReadLine();
        string hasil = kodepos.GetKodePos(input);
        Console.WriteLine(hasil);
        Console.WriteLine();

        //NO 2
        DoorMachine pintu = new DoorMachine();

        Console.WriteLine("Menjalankan simulasi pintu....");
        pintu.BukaPintu();
        pintu.BukaPintu();
        pintu.TutupPintu();
        pintu.TutupPintu();
        pintu.BukaPintu();
    }
}