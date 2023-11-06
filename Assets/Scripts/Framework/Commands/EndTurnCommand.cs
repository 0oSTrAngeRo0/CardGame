namespace Game
{
	/// <summary>
	/// 玩家声明回合结束
	/// </summary>
	public class EndTurnCommand : AbstractCommand
	{
		protected override void OnExecute()
		{
			IMatchModel model = this.GetModel<IMatchModel>();
			uint player = model.CurrentPlayer.Value;	// 当前玩家编号
			uint turn = model.TurnCount.Value;			// 当前回合数
			
			// 玩家操作结束，进行卡牌结算
			this.SendEvent(new OnCardSetPhaseEnd(player, turn));			// 卡片设置阶段结束时
			
			this.SendEvent(new OnEffectGeneratePhaseStart(player, turn));	// 卡牌效果生成阶段开始时
			// 插入卡牌效果生成阶段要做的事情，生成这回合卡牌的效果
			this.SendEvent(new OnEffectGeneratePhaseEnd(player, turn));	// 卡牌效果生成阶段结束时
			
			this.SendEvent(new OnEffectExecutePhaseStart(player, turn));	// 卡牌效果应用阶段开始时
			// 插入卡牌效果应用阶段要做的事情，执行上一回合生成的卡牌效果
			this.SendEvent(new OnEffectExecutePhaseEnd(player, turn));	// 卡牌效果应用阶段开始时
			
			this.SendEvent(new OnTurnFinishPhaseStart(player, turn));		// 回合结束阶段开始时
			// 插入回合结束阶段要做的事情
			this.SendEvent(new OnTurnFinishPhaseEnd(player, turn));		// 回合结束阶段结束时

			// 开始下一个回合
			turn++;
			player = (player + 1) % model.TotalPlayer.Value;
			model.TurnCount.Value = turn;
			model.CurrentPlayer.Value = player;
			
			this.SendEvent(new OnTurnBeginPhaseStart(player, turn));		// 回合开始阶段开始时
			// 插入回合开始阶段要做的事情
			this.SendEvent(new OnTurnBeginPhaseEnd(player, turn));		// 回合开始阶段结束时
			
			this.SendEvent(new OnDrawPhaseStart(player, turn));			// 抽卡阶段开始时
			// 插入抽卡阶段要做的事情
			this.SendEvent(new OnDrawPhaseEnd(player, turn));				// 抽卡阶段结束时
			
			this.SendEvent(new OnCardSetPhaseStart(player, turn));		// 卡片设置阶段开始时
			// 接下来的由玩家操作
		}
	}
}