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
			uint playerId = model.CurrentPlayer.Value;	// 当前玩家编号
			uint turn = model.TurnCount.Value;			// 当前回合数
			
			// 玩家操作结束，进行卡牌结算
			this.SendEvent(new OnCardSetPhaseEnd(playerId, turn));			// 卡片设置阶段结束时
			
			this.SendEvent(new OnEffectGeneratePhaseStart(playerId, turn));	// 卡牌效果生成阶段开始时
			this.GetUtility<ILogUtility>().Log("[Phase] Effect Generate");
			this.SendEvent(new OnEffectGeneratePhaseEnd(playerId, turn));	// 卡牌效果生成阶段结束时
			
			this.SendEvent(new OnEffectExecutePhaseStart(playerId, turn));	// 卡牌效果应用阶段开始时
			this.GetUtility<ILogUtility>().Log("[Phase] Effect Execute");
			this.SendEvent(new OnEffectExecutePhaseEnd(playerId, turn));	// 卡牌效果应用阶段开始时
			
			this.SendEvent(new OnTurnFinishPhaseStart(playerId, turn));		// 回合结束阶段开始时
			this.GetUtility<ILogUtility>().Log("[Phase] Turn Finish");
			this.SendEvent(new OnTurnFinishPhaseEnd(playerId, turn));		// 回合结束阶段结束时


		}
	}
}