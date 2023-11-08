namespace Game
{
	/// <summary>
	/// 对局中的玩家信息
	/// </summary>
	public interface IPlayer
	{
		/// <summary>
		/// 抽卡区
		/// </summary>
		public IDeck Deck { get; }
		
		/// <summary>
		/// 墓地
		/// </summary>
		public IGrave Grave { get; }
		
		/// <summary>
		/// 手牌
		/// </summary>
		public IHand Hand { get; }
	}
	
	public class Player : IPlayer
	{
		public IDeck Deck { get; }
		public IGrave Grave { get; }
		public IHand Hand { get; }

		public Player(IDeck deck, IGrave grave, IHand hand)
		{
			Deck = deck;
			Grave = grave;
			Hand = hand;
		}
	}
}