namespace Game
{
	public class StartMatchCommand : AbstractCommand
	{
		protected override void OnExecute()
		{
			IMatchModel model = this.GetModel<IMatchModel>();
			const int L_INIT_CARD = 3;
			foreach (IPlayer player in model.Players.Values)
			{
				for (int i = 0; i < L_INIT_CARD; i++)
				{
					
				}
			}
		}
	}
}