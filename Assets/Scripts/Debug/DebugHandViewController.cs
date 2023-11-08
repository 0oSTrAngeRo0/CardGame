using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Demo
{
    public class DebugHandViewController : MonoController
    {
        public Dictionary<Toggle, ICard> Hands;
        public ToggleGroup Group;
        public ICard CurrentPickedCard;
        public GameObject CardPrefab;

        private void Awake()
        {
            Hands = new Dictionary<Toggle, ICard>();
            IMatchModel model = this.GetModel<IMatchModel>();
            model.CurrentPlayer.Register(player => RefreshHands(model.Players[player].Hand.Cards()));
            this.RegisterEvent<OnHandAddedEvent>(e =>
            {
                if (e.Player != model.CurrentPlayer.Value) return;
                RefreshHands(model.Players[e.Player].Hand.Cards());
            });
        }

        private void RefreshHands(IEnumerable<ICard> cards)
        {
            foreach (KeyValuePair<Toggle, ICard> hand in Hands)
            {
                Destroy(hand.Key.gameObject);
            }

            Hands.Clear();
            foreach (ICard card in cards)
            {
                GameObject go = Instantiate(CardPrefab, transform);
                go.GetComponentInChildren<Text>().text = ((DebugCard)card).Name.ToString();
                Toggle toggle = go.GetComponent<Toggle>();
                toggle.onValueChanged.AddListener(on =>
                {
                    if (!on) return;
                    CurrentPickedCard = Hands[toggle];
                    this.GetUtility<ILogUtility>().Log($"[Pick Card] {((DebugCard)CurrentPickedCard).Name}");
                });
                toggle.group = Group;
                Group.RegisterToggle(toggle);
                Hands.Add(toggle, card);
            }

            Toggle first = Hands.Keys.ElementAt(0);
            first.isOn = true;
            first.Select();
        }
    }
}