using UnityEngine;

namespace Game
{
    public class TestCard : ICard
    {
        public Cell CurrentCell { get; set; }
        public void OnActive()
        {
            Debug.Log("Card Active!");
        }
    }
}