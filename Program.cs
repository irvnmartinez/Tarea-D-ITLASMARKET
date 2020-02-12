using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDP_ITLAMarket
{
    class Program
    {
		public static int presupuesto = 0;
		public static int devuelta = 0;
        public static int total = 0;
		
        static void Main(string[] args)
        {

		    bool repetir = true;
			Console.WriteLine("D'ITLAS MARKET\n \n¿Con que presupuesto cuenta ? ");
			presupuesto = int.Parse(Console.ReadLine());
			Console.Clear();
			while (repetir)
			{

				Console.WriteLine("D'ITLAS MARKET\n \n¿Que desea comprar?\n \n [1] Naranjas\n [2] Cebolla\n [3] Doritos\n [4] Platanos\n [5] Chicles\n [6] Leche evaporada\n [7] Lipton - Ice Tea\n [8] Botella de agua\n [9] Cafe instantaneo\n [10] Pan");
				int opcion = int.Parse(Console.ReadLine());
				Console.Clear();
				switch (opcion)
				{
					case 1:
						Naranjas();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 2:
						Cebolla();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 3:
						Doritos();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 4:
						Platanos();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 5:
						Chicles();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 6:
						LecheEvaporada();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 7:
						liptonIceTea();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 8:
						BotellaDeAgua();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 9:
						CafeInstantaneo();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break;
					case 10:
						Pan();
						Console.ReadKey();
						Console.Clear();
						ComprarOtroProducto();
						Console.Clear();
						break; 

				}



			}
		}

		
		static void Naranjas()
		{

			Console.WriteLine("\nNaranjas --- 30 RD$ (Limite de compra, 10)\n \n ¿Cuantas desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 10)
			{
				total = llevar * 15;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de 10 tomates");
			}
		}

		static void Cebolla()
		{


			Console.WriteLine("\nCebolla --- 10 RD$ (Limite de compra, 10)\n \n ¿Cuantas desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 10)
			{
				total = llevar * 10;
			
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
					
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de  10 cebollas");
			}


		}

		static void Doritos()
		{

			Console.WriteLine("\nDoritos --- 30 RD$ (Limite de compra, 10)\n  \n ¿Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 10)
			{
				total = llevar * 30;
			

				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de 10 doritos");
			}
		}

		static void Platanos()
		{

			Console.WriteLine("\nPlatanos --- 26 RD$ (Limite de compra, 10)\n  \n ¿Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 10)
			{
				total = llevar * 26;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de  10 cebollas");
			}

		}

		static void Chicles()
		{
			
			Console.WriteLine("\nChicle --- 5 RD$ (Limite de compra, 15)\n \n ¿Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 15)
			{
				total = llevar * 5;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de  10 chicles");
			}
		}

		static void LecheEvaporada()
		{

			Console.WriteLine("\nLeche evaporada carnation --- 50 RD$ (Limite de compra, 10)\n \n ¿Cuantas desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 10)
			{
				total = llevar * 50;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
		}

		static void liptonIceTea()
		{

			Console.WriteLine("\nLipton Ice Tea --- 35 RD$ (Limite de compra, 5)\n \n ¿Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 5)
			{
				total = llevar * 35;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de  5 liptons");
			}
		}

		static void BotellaDeAgua()
		{

			Console.WriteLine("\nBotella de agua --- 15 RD$ (Limite de compra, 10)\n \n ¿Cuantas desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 10)
			{
				total = llevar * 15;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de  10 botellas de agua");
			}
		}

		static void CafeInstantaneo()
		{

			Console.WriteLine("\nCafe instantaneo --- 15 RD$ (Limite de compra, 10)\n \n ¿Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 10)
			{
				total = llevar * 25;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de  10 cafes instantaneos");
			}
		}

		static void Pan()
		{

			Console.WriteLine("\nPan --- 5 RD$ (Limite de compra, 10)\n \n ¿Cuantos desea llevar?");
			int llevar = int.Parse(Console.ReadLine());
			if (llevar <= 15)
			{
				total = llevar * 5;
				if (presupuesto < total)
				{
					Console.WriteLine("Disculpe, usted no tiene el dinero suficiente");
				}
				if (presupuesto >= total)
				{
					devuelta = presupuesto - total;
					Console.WriteLine("Gracias por su compra\n Le restan " + devuelta);
				}
				presupuesto = devuelta;
			}
			else
			{
				Console.WriteLine("Lo sentimos, no podemos darle mas de  15 panes");
			}
		}

		static void ComprarOtroProducto()
		{
			Console.WriteLine("¿Quiere comprar algo mas?\n" +
			" [1] Si\n [2] No (Salir)");
			int opcion = int.Parse(Console.ReadLine());
			switch(opcion)
			{
				case 1:
					Console.ReadKey();
					break;
				case 2:
					Console.Clear();
					Console.WriteLine("\nGracias por comprar en D'ITLAS MARKET");
					Console.ReadKey();
					Environment.Exit(1);
					break;
			}
		}





	}

}

