namespace Game
{
    public class DrawCardCommand : AbstractCommand
    {
        public uint Player;

        public DrawCardCommand(uint player)
        {
            Player = player;
        }

        protected override void OnExecute()
        {
            IMatchModel model = this.GetModel<IMatchModel>();
            bool success = model.Players.TryGetValue(Player, out IPlayer player);
            if (!success)
            {
                this.GetUtility<ILogUtility>().Log($"[Draw Card] Invalid player id: [{Player}]");
                return;
            }

            ICard card = player.Deck.Draw();
            this.SendEvent(new OnDrawCardEvent(Player, card));
            player.Hand.Add(card);
            this.SendEvent(new OnHandAddedEvent(Player, card));
        }
    }
}