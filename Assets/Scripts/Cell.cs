using UnityEngine;

namespace Game
{
    public class Cell
    {
        public Vector2Int Coord { get; set; }
        public bool CanAddCard { get; set; }

        public void AddCard(ICard card)
        {
            
        }
    }
}