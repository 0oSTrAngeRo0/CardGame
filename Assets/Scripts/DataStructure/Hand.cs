using System.Collections.Generic;

namespace Game
{
	public interface IHand
	{
		public IEnumerable<ICard> Cards();
		public void Add(ICard card);
		public void Remove(ICard card);
	}
	
	public class Hand : IHand
	{
		private HashSet<ICard> m_Cards;

		public Hand()
		{
			m_Cards = new HashSet<ICard>();
		}
		
		public IEnumerable<ICard> Cards() => m_Cards;
		public void Add(ICard card) => m_Cards.Add(card);
		public void Remove(ICard card) => m_Cards.Remove(card);
	}
}