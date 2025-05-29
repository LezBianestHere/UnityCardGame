using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class CardController : MonoBehaviour
{
    [SerializeField]
    private CardScriptableObject card;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(this.transform);
        GameObject damageGameObject = this.transform.Find("Canvas/DamageText")?.gameObject;
        GameObject costGameObject = this.transform.Find("Canvas/CostText")?.gameObject;

        if (damageGameObject != null)
        {
            TextMeshProUGUI damageText = damageGameObject.GetComponent<TextMeshProUGUI>();
            damageText.text = card.damage.ToString();
        }

        if (costGameObject != null)
        {
            TextMeshProUGUI costText = costGameObject.GetComponent<TextMeshProUGUI>();
            costText.text = card.cost.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
