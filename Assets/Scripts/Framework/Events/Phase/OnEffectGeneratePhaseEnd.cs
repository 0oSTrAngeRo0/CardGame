namespace Game
{
    public struct OnEffectGeneratePhaseEnd
    {
        public uint CurrentPlayer;
        public uint TurnCount;

        public OnEffectGeneratePhaseEnd(uint player, uint turn)
        {
            CurrentPlayer = player;
            TurnCount = turn;
        }
    }
}