using System.Collections.Generic;

namespace Game
{
	public class StartMatchCommand : AbstractCommand
	{
		protected override void OnExecute()
		{
			IMatchModel model = this.GetModel<IMatchModel>();
			const int L_INIT_CARD = 3;
			foreach (KeyValuePair<uint, IPlayer> player in model.Players)
			{
				for (int i = 0; i < L_INIT_CARD; i++)
				{
					this.SendCommand(new DrawCardCommand(player.Key));
				}
			}

			model.TotalPlayer.Value = (uint)model.Players.Count;
			model.TurnCount.Value = 0;
			model.CurrentPlayer.Value = 0;
		}
	}
}