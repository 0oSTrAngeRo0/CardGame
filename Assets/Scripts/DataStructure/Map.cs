using System.Collections.Generic;

namespace Game
{
    public interface IMap
    {
        public bool IsValid(uint x, uint y);
        public ICell Get(uint x, uint y);
        public bool TrySet(uint x, uint y, ICard card);
        public void Active(uint x, uint y);
        public IEnumerable<ICard> Cards();
    }

    public class Map : IMap
    {
        private ICell[][] m_Cells;
        private uint m_MaxX;
        private uint m_MaxY;

        public bool IsValid(uint x, uint y) => x < m_MaxX && y < m_MaxY;

        public ICell Get(uint x, uint y) => IsValid(x, y) ? m_Cells[x][y] : null;

        public bool TrySet(uint x, uint y, ICard card)
        {
            if (!IsValid(x, y)) return false;
            ICell cell = m_Cells[x][y];
            if (cell.Card == null) return false;
            cell.Card = card;
            return true;
        }

        public void Active(uint x, uint y)
        {
            if (!IsValid(x, y)) return;
            ICell cell = m_Cells[x][y];
            if (cell.Card == null) return;
            cell.Card.Activate();
            Active(x - 1, y);
            Active(x + 1, y);
            Active(x, y + 1);
            Active(x, y - 1);
        }

        public IEnumerable<ICard> Cards()
        {
            List<ICard> cards = new List<ICard>();
            foreach (ICell[] cells in m_Cells)
            {
                foreach (ICell cell in cells)
                {
                    if (cell.Card == null) continue;
                    cards.Add(cell.Card);
                }
            }

            return cards;
        }
    }
}