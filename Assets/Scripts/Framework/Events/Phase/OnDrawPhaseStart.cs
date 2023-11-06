namespace Game
{
    public struct OnDrawPhaseStart
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnDrawPhaseStart(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}