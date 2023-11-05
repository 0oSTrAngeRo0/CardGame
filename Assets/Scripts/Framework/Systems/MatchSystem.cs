using System.Collections.Generic;

namespace Game
{
    public class MatchSystem : AbstractSystem
    {
        public Cell[,] Map;
        public int MaxX;
        public int MaxY;

        protected override void OnInit()
        {
        }

        public void AddCard(int x, int y, ICard card)
        {
            // Todo: Check if "x" and "y" valid
            if (x < 0 || y < 0 || x > MaxX || y > MaxY) return;
            if (!Map[x, y].CanAddCard) return;
            Map[x, y].AddCard(card);
            card.CurrentCell = Map[x, y];
        }

        // Todo: optimize it with stack
        public void ActiveCard(int x, int y)
        {
            if (x < 0 || y < 0 || x > MaxX || y > MaxY) return;
            ActiveCard(x - 1, y - 1);
            ActiveCard(x - 1, y);
            ActiveCard(x - 1, y + 1);
            ActiveCard(x, y - 1);
            ActiveCard(x, y);
            ActiveCard(x, y + 1);
            ActiveCard(x + 1, y - 1);
            ActiveCard(x + 1, y);
            ActiveCard(x + 1, y + 1);
        }
    }
}