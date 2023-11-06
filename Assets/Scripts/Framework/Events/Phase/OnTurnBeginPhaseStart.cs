namespace Game
{
    public struct OnTurnBeginPhaseStart
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnTurnBeginPhaseStart(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}