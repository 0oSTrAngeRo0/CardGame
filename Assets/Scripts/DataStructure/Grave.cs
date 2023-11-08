using System.Collections.Generic;

namespace Game
{
	/// <summary>
	/// 玩家墓地
	/// </summary>
	public interface IGrave
	{
		/// <summary>
		/// 按卡牌进入墓地的倒序，获取墓地中的所有卡牌
		/// </summary>
		public IEnumerable<ICard> Cards();
		
		/// <summary>
		/// 向墓地中添加卡牌
		/// </summary>
		public void Add(ICard card);
	}
	public class Grave : IGrave
	{
		private List<ICard> m_Cards;

		public Grave()
		{
			m_Cards = new List<ICard>();
		}

		public IEnumerable<ICard> Cards() => m_Cards;
		public void Add(ICard card) => m_Cards.Add(card);
	}
}