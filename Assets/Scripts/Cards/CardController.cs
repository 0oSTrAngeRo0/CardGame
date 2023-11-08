using Game;

namespace Cards
{
	public abstract class CardController : ICard, IController
	{
		public IArchitecture GetArchitecture() => GameArchitecture.Interface;
		public abstract void Activate();
	}
}