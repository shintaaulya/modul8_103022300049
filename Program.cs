using modul8_103022300049;

class Program
{
    public static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        BankTransferConfig data = config.ReadconfigFile();
        int amount;

        if (data.lang.Equals("en"))
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
        } else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
        }

        int amount = Convert.ToInt32(Console.ReadLine);
        int fee;
        if (amount <= data.transfer.threshold)
        {
            fee = data.transfer.low_fee;
        }
        else
        {
            fee = data.transfer.high_fee;
        }
        if (data.lang.Equals("en"))
        {
            Console.WriteLine($"Transfer fee = {fee} dan Total amount = {amount + fee}");
        } else
        {
            Console.WriteLine($"Biaya Transfer fee = {fee} dan Total biaya = {amount + fee}");
        }
        if (data.lang.Equals("en"))
        {
            Console.WriteLine(" Select transfer method: ");
        } else
        {
            Console.WriteLine("Pilih metode transfer: ");
        }
        for (int i = 0; i < data.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {data.methods[i]}");
        }
        int method = Convert.ToInt32(Console.ReadLine()) - 1;

        if (data.lang.Equals("en"))
        {
            Console.WriteLine("Please type yes to confirm the transaction: ");
        } else
        {
            Console.WriteLine("Ketik ya untuk mengkonfirmasi transaksi: ");
        }
        String confirm = Console.ReadLine();
        if ((confirm == data.confirmation.en) && data.lang.Equals("en"))
        {
            Console.WriteLine(" The transfer is completed");
        }
        else if ((confirm == data.confirmation.id) && data.lang.Equals("id"))
        {
            Console.WriteLine("Proses transfer berhasil");
        }
        else if ((confirm != data.confirmation.en) && data.lang.Equals("en")) 
    }
}