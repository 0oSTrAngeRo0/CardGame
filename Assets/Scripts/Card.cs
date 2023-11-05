namespace Game
{
    public interface ICard
    {
        public Cell CurrentCell { get; set; }

        public void OnActive();
    }
}