using System.Collections.Generic;
using UnityEngine.UI;

namespace Game.Demo
{
    public class DebugUiViewController : MonoController
    {
        public Button BtnTurnFinish;
        public Button BtnStartMatch;
        public Text TxtCurrentPlayer;
        public Text TxtTurnCount;

        private void Awake()
        {
            IMatchModel model = this.GetModel<IMatchModel>();
            BtnTurnFinish.onClick.AddListener(() =>
            {
                this.SendCommand(new EndTurnCommand());
                this.SendCommand(new StartTurnCommand());
            });

            BtnStartMatch.onClick.AddListener(() =>
            {
                model.Players.Add(0, new Player(GenerateDebugDeck(10), new Grave(), new Hand()));
                model.Players.Add(1, new Player(GenerateDebugDeck(10), new Grave(), new Hand()));
                this.SendCommand(new StartMatchCommand());
            });

            this.RegisterEvent<OnDrawCardEvent>(e =>
            {
                this.GetUtility<ILogUtility>().Log($"Draw Card: [{e.Player}] [{((DebugCard)e.Card).Name}]");
            });

            model.CurrentPlayer.Register(player => TxtCurrentPlayer.text = $"Current Player: [{player}]");
            model.TurnCount.Register(turn => TxtTurnCount.text = $"Turn Count: [{turn}]");
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