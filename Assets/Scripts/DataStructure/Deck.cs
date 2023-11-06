using System.Collections.Generic;

namespace Game
{
	/// <summary>
	/// 玩家抽卡区信息
	/// </summary>
	public interface IDeck
	{
		/// <summary>
		/// 从卡组中抽一张卡
		/// </summary>
		public ICard Draw();
		
		/// <summary>
		/// 按接下来的抽牌顺序预览卡牌
		/// </summary>
		public IEnumerable<ICard> PreviewCards();
		
		/// <summary>
		/// 乱序查看卡组中剩余的牌
		/// </summary>
		public IEnumerable<ICard> PreviewCardsWithoutSorted();
		
		/// <summary>
		/// 洗牌
		/// </summary>
		public void Shuffle();
		
		/// <summary>
		/// 添加多张卡牌
		/// </summary>
		public void AddRange(IEnumerable<ICard> cards);

		/// <summary>
		/// 添加单张卡牌
		/// </summary>
		public void Add(ICard card);
	}
}