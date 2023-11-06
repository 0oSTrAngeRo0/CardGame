namespace Game
{
    public struct OnTurnFinishPhaseEnd
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnTurnFinishPhaseEnd(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}