namespace Game
{
    public struct OnEffectExecutePhaseStart
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnEffectExecutePhaseStart(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}