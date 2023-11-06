﻿using System.Collections.Generic;

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
}