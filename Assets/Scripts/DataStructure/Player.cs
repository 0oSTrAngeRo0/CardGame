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
	}
}