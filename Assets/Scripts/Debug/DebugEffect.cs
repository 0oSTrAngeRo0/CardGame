using Effects;

namespace Game.Demo
{
    public class DebugEffect : EffectController
    {
        public string Name;

        public DebugEffect(string name)
        {
            Name = name;
        }
        public override void Apply(ICard card)
        {
            this.GetUtility<ILogUtility>().Log($"Effect Execute: [{Name}]");
        }
    }
}