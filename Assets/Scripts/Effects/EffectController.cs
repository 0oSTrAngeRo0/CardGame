using Game;

namespace Effects
{
    public abstract class EffectController : IEffect, IController
    {
        public IArchitecture GetArchitecture() => GameArchitecture.Interface;
        public abstract void Apply(ICard card);
    }
}