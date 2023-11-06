namespace Game
{
    public struct OnCardSetPhaseEnd
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnCardSetPhaseEnd(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}