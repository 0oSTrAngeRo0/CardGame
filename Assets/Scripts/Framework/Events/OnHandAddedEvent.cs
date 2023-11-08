namespace Game
{
    public struct OnHandAddedEvent
    {
        public uint Player;
        public ICard Card;

        public OnHandAddedEvent(uint player, ICard card)
        {
            Player = player;
            Card = card;
        }
    }
}