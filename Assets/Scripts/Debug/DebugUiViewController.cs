using System.Collections.Generic;
using UnityEngine.UI;

namespace Game.Demo
{
	public class DebugUiViewController : MonoController
	{
		public Button BtnTurnFinish;

		private void Awake()
		{
			BtnTurnFinish.onClick.AddListener(() => this.SendCommand(new EndTurnCommand()));
		}

		private void InitializeMatch()
		{
			IMatchModel model = this.GetModel<IMatchModel>();
			model.Players.Add(0, new Player(GenerateDebugDeck(10), new Grave(), new Hand()));
			model.Players.Add(1, new Player(GenerateDebugDeck(10), new Grave(), new Hand()));
		}

		private IDeck GenerateDebugDeck(int count)
		{
			List<ICard> cards = new List<ICard>();
			for (int i = 0; i < count; i++)
				cards.Add(new DebugCard());
			return new Deck(cards);
		}
	}
}