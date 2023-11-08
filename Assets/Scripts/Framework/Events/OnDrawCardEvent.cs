namespace Game
{
	public struct OnDrawCardEvent
	{
		public uint Player;
		public ICard Card;

		public OnDrawCardEvent(uint player, ICard card)
		{
			Player = player;
			Card = card;
		}
	}
}