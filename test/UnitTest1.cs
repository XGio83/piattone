using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using toPaul;
using System.Linq;
using System.Diagnostics;

namespace test
{
	[TestClass]
	public class UnitTest1
	{
		private List<Auto> _autos;
		private List<Piattone> _expected;

		[TestInitialize]
		public void init()
		{
			_autos = new List<Auto>() {
				new Auto()
				{
					tipoAuto = "bmw",
					Ruote = Ruota.GetRuote()
				},
				new Auto()
				{
					tipoAuto = "fiat",
					Ruote = Ruota.GetRuote()
				},
				new Auto()
				{
					tipoAuto = "audi",
					Ruote = Ruota.GetRuote()
				}
			};

			_expected = new List<Piattone>() {
				new Piattone(){ tipoAuto="bmw", tipoRuota="ASX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="ASX", tipoBullone="due"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="ASX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="ASX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="ADX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="ADX", tipoBullone="due"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="ADX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="ADX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RSX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RSX", tipoBullone="due"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RSX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RSX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RDX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RDX", tipoBullone="due"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RDX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="bmw", tipoRuota="RDX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ASX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ASX", tipoBullone="due"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ASX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ASX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ADX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ADX", tipoBullone="due"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ADX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="ADX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RSX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RSX", tipoBullone="due"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RSX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RSX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RDX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RDX", tipoBullone="due"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RDX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="fiat", tipoRuota="RDX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ASX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ASX", tipoBullone="due"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ASX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ASX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ADX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ADX", tipoBullone="due"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ADX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="audi", tipoRuota="ADX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RSX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RSX", tipoBullone="due"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RSX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RSX", tipoBullone="quattro"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RDX", tipoBullone="uno"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RDX", tipoBullone="due"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RDX", tipoBullone="tre"},
				new Piattone(){ tipoAuto="audi", tipoRuota="RDX", tipoBullone="quattro"},
			};
		}

		[TestMethod]
		public void Linq()
		{
			var result = _autos.SelectMany(a => a.Ruote.SelectMany(r=> r.Bulloni.Select(b=> new Piattone() { tipoAuto = a.tipoAuto, tipoRuota = r.tipoRuota, tipoBullone = b.tipoBullone }))).ToList();
			Assert.IsTrue(_expected.SequenceEqual(result));
		}
	}
}
