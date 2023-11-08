using System.Collections.Generic;
using Game;

namespace Cards
{
    public abstract class CardController : ICard, IController
    {
        public IArchitecture GetArchitecture() => GameArchitecture.Interface;
        public abstract void Activate();
        public abstract List<IEffect> Effects { get; }
    }
}