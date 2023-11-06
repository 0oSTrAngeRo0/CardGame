namespace Game
{
    public struct OnEffectGeneratePhaseStart
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnEffectGeneratePhaseStart(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}