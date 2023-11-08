namespace Game
{
    public class CardExecuteEffectCommand : AbstractCommand
    {
        public ICard Card;

        public CardExecuteEffectCommand(ICard card)
        {
            Card = card;
        }

        protected override void OnExecute()
        {
            Card.Effects.ForEach(effect => effect.Apply(Card));
        }
    }
}