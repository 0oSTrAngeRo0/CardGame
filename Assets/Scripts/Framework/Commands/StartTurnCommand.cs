namespace Game
{
	public class StartTurnCommand : AbstractCommand
	{
		protected override void OnExecute()
		{
			// 开始下一个回合
			IMatchModel model = this.GetModel<IMatchModel>();
			uint playerId = model.CurrentPlayer.Value;	// 当前玩家编号
			uint turn = model.TurnCount.Value;			// 当前回合数
			turn++;
			playerId = (playerId + 1) % model.TotalPlayer.Value;
			model.TurnCount.Value = turn;
			model.CurrentPlayer.Value = playerId;
			IPlayer player = model.Players[playerId];
			
			this.SendEvent(new OnTurnBeginPhaseStart(playerId, turn));		// 回合开始阶段开始时
			this.GetUtility<ILogUtility>().Log("[Phase] Turn Begin");
			this.SendEvent(new OnTurnBeginPhaseEnd(playerId, turn));		// 回合开始阶段结束时
			
			this.SendEvent(new OnDrawPhaseStart(playerId, turn));			// 抽卡阶段开始时
			this.GetUtility<ILogUtility>().Log("[Phase] Draw");
			ICard card = player.Deck.Draw();
			player.Hand.Add(card);
			this.SendEvent(new OnDrawCardEvent(playerId, card));
			this.SendEvent(new OnDrawPhaseEnd(playerId, turn));				// 抽卡阶段结束时
			
			this.SendEvent(new OnCardSetPhaseStart(playerId, turn));		// 卡片设置阶段开始时
			this.GetUtility<ILogUtility>().Log("[Phase] Card Set");
			// 接下来的由玩家操作
		}
	}
}