using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toPaul
{
	public class Auto
	{
		public string tipoAuto;
		public List<Ruota> Ruote;
	}

	public class Ruota
	{
		public string tipoRuota;
		public List<Bullone> Bulloni;
		public static List<Ruota> GetRuote() => new List<Ruota>() {
			new Ruota(){ tipoRuota="ASX", Bulloni = Bullone.GetBulloni() },
			new Ruota(){ tipoRuota="ADX", Bulloni = Bullone.GetBulloni() },
			new Ruota(){ tipoRuota="RSX", Bulloni = Bullone.GetBulloni() },
			new Ruota(){ tipoRuota="RDX", Bulloni = Bullone.GetBulloni() }
		};
	}

	public class Bullone
	{
		public string tipoBullone;

		public Bullone(string code) { this.tipoBullone = code; }
		public static List<Bullone> GetBulloni() => new List<Bullone>() {
			new Bullone("uno"),
			new Bullone("due"),
			new Bullone("tre"),
			new Bullone("quattro")
		};
	}

	public class Piattone: IEquatable<Piattone>
	{
		public string tipoAuto;
		public string tipoRuota;
		public string tipoBullone;

		public bool Equals(Piattone other)
		{
			return this.tipoAuto == other.tipoAuto && this.tipoRuota == other.tipoRuota && this.tipoBullone == other.tipoBullone;
		}
	}
}
