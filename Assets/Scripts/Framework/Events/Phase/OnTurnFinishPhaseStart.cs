namespace Game
{
    public struct OnTurnFinishPhaseStart
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnTurnFinishPhaseStart(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}