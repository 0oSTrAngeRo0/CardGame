using System;
using System.Collections.Generic;
using Cards;
using Random = UnityEngine.Random;

namespace Game.Demo
{
	public class DebugCard : CardController
	{
		public int Name;

		public DebugCard()
		{
			Name = Random.Range(0, int.MaxValue);
			Effects = new List<IEffect>();
		}
		
		public override void Activate()
		{
			this.GetUtility<ILogUtility>().Log($"Card Active: [{Name}]");
		}

		public override List<IEffect> Effects { get; }
	}
}