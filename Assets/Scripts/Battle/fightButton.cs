using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightButton : MonoBehaviour
{
    public GameObject fightPanel;
    public BattleManager battleManager;
    // Start is called before the first frame update
    void Start()
    {
        battleManager = GetComponent<BattleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void openFightPanel()
    {
        fightPanel.SetActive(true);
    }

    public void closeFightPanel()
    {
        fightPanel.SetActive(false);
    }
    public void confirmFight()
    {
        battleManager.isBattleFighting = true;
    }
}
