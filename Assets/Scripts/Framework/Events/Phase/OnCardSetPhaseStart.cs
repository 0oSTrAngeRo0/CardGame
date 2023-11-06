namespace Game
{
    public struct OnCardSetPhaseStart
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnCardSetPhaseStart(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}