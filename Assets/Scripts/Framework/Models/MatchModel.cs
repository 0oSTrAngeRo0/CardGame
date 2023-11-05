namespace Game.Models
{
    public interface IMatchModel : IModel
    {
        public BindableProperty<int> TurnCount { get; }
        public BindableProperty<uint> CurrentPlayer { get; }
        public BindableProperty<uint> TotalPlayer { get; }
    }

    public class MatchModel : AbstractModel, IMatchModel
    {
        protected override void OnInit()
        {
            TurnCount = new BindableProperty<int>();
            CurrentPlayer = new BindableProperty<uint>();
            TotalPlayer = new BindableProperty<uint>();
        }

        public BindableProperty<int> TurnCount { get; private set; }
        public BindableProperty<uint> CurrentPlayer { get; private set; }
        public BindableProperty<uint> TotalPlayer { get; private set; }
    }
}