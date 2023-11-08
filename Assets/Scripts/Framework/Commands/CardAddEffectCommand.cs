namespace Game
{
    public class CardAddEffectCommand : AbstractCommand
    {
        public ICard Card;
        public IEffect Effect;

        public CardAddEffectCommand(ICard card, IEffect effect)
        {
            Card = card;
            Effect = effect;
        }

        protected override void OnExecute()
        {
            Card.Effects.Add(Effect);
        }
    }
}