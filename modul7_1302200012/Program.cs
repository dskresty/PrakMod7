using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_1302200012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankTransferConfig BTC = new BankTransferConfig();

            dynamic cfg = BTC.ReadJson();

            if (cfg.lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");

            }else if (cfg.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }

            String a = Console.ReadLine();

            int threshold = int.Parse(a);

            int fee;

            if (threshold < (int)cfg.transfer.threshold)
            {
                fee = cfg.transfer.low_fee;
            } else
            {
                fee = cfg.transfer.high_fee;
            }

            if (cfg.lang == "en")
            {
                Console.WriteLine("Transfer fee = " + fee);
                Console.WriteLine("Total amount = " + threshold + fee);
            } else if (cfg.lang == "id")
            {
                Console.WriteLine("Biaya transfer = " + fee);
                Console.WriteLine("Total biaya = " + threshold + fee);
            }

            if (cfg.lang == "en")
            {
                Console.WriteLine("Select transfer method: ");
            } else {
                Console.WriteLine("Pilih metode transfer: ");
            }

            int i = 0;
            foreach (var c in cfg.methods)
            {
                i++;
                Console.WriteLine(i + " " + c);
            }

            string metode = Console.ReadLine();
            if (cfg.lang == "id")
            {
                Console.Write("Metode transfer yang dipilih adalah ");
                if (metode == "1")
                {
                    Console.WriteLine("RTO (real-time)");
                }
                else if (metode == "2")
                {
                    Console.WriteLine("SKN");
                }
                else if (metode == "3")
                {
                    Console.Write("RTGS");
                }
                else if (metode == "4")
                {
                    Console.WriteLine("BI FAST");
                }
                else
                {
                    Console.WriteLine("Pemilihan metode transfer tidak valid!");
                }
            } else
            {
                Console.Write("Method chosen is  ");
                if (metode == "1")
                {
                    Console.WriteLine("RTO (real-time)");
                }
                else if (metode == "2")
                {
                    Console.WriteLine("SKN");
                }
                else if (metode == "3")
                {
                    Console.Write("RTGS");
                }
                else if (metode == "4")
                {
                    Console.WriteLine("BI FAST");
                }
                else
                {
                    Console.WriteLine("Method not valid!");
                }
            }

            if (cfg.lang == "id")
            {
                Console.WriteLine("Ketik 'ya' untuk mengkonfirmasi transaksi: ");
            } else
            {
                Console.WriteLine("Please type 'yes' to confirm the transaction: ");
            }

            String masukan = Console.ReadLine();
            if (cfg.lang == "en")
            {
                if (masukan == "yes")
                {
                    Console.WriteLine("The transfer is completed");
                } else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            } else
            {
                if (masukan == "ya")
                {
                    Console.WriteLine("Proses Transfer Berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }

        }
    }
}
