using System.Collections.Generic;

namespace Game
{
	public interface ICard
	{
		public void Activate();
		public List<IEffect> Effects { get; }
	}
}