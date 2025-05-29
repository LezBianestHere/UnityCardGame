using UnityEngine;

    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class CardScriptableObject : ScriptableObject
    {
        public string cardName;
        public int damage;
        public int cost;

    }