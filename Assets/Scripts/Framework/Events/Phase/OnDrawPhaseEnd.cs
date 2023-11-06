namespace Game
{
    public struct OnDrawPhaseEnd
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnDrawPhaseEnd(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}