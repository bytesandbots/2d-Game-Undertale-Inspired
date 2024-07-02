using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public Dictionary<GameObject, int> backpack = new Dictionary<GameObject, int>();
    public GameObject bandagePrefab;
    public GameObject bandagePremiumPrefab;
    public TMP_Text inBattleBandageText;
    public TMP_Text inBattleBandagePremiumText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (backpack.ContainsKey(bandagePrefab))
            {
                backpack[bandagePrefab] += 1;
            }
            else
            {
                backpack.Add(bandagePrefab, 1);
            }
            inBattleBandageText.text = "Bandage " + backpack[bandagePrefab].ToString() + "x";
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (backpack.ContainsKey(bandagePremiumPrefab))
            {
                backpack[bandagePremiumPrefab] += 1;
            }
            else
            {
                backpack.Add(bandagePremiumPrefab, 1);
            }
            inBattleBandagePremiumText.text = "Bandage Premium " + backpack[bandagePremiumPrefab].ToString() + "x";
        }

        
        
    }
}
