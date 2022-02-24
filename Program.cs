﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    class Program
    {
        static void Main(string[] args)
        {
			RMQ rmq = new RMQ();
			Console.WriteLine("Tekan tombol apapun untuk inisialisasi RMQ parameters.");
			Console.ReadKey();
			rmq.InitRMQConnection(); // inisialisasi parameter (secara default) untuk koneksi ke server RMQ
			Console.WriteLine("Tekan tombol apapun untuk membuka koneksi ke RMQ.");
			Console.ReadKey();
			rmq.CreateRMQConnection(); // memulai koneksi dengan RMQ
			Console.Write("Masukkan nama queue channel untuk menerima pesan melalui RMQ.\n>> ");
			string queue_name = Console.ReadLine();
			Console.WriteLine("Menunggu pesan masuk...");
			rmq.WaitingMessage(queue_name);
		}
    }
}
