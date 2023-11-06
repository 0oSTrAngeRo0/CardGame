namespace Game
{
    public struct OnTurnBeginPhaseEnd
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnTurnBeginPhaseEnd(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}