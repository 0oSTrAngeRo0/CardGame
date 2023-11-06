namespace Game
{
    public struct OnEffectExecutePhaseEnd
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnEffectExecutePhaseEnd(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}