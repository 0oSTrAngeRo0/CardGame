using System;
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
		}
		
		public override void Activate()
		{
			this.GetUtility<ILogUtility>().Log($"Card Active: [{Name}]");
		}
	}
}