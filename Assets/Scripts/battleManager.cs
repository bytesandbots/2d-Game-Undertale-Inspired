using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleManager : MonoBehaviour
{
    public bool isBattleFighting;
    public float battleTime;
    public float battleTimer;
    public float maxBattleTimer;
    public GameObject battleDecisionPanel;
    public GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        battleTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBattleFighting) { battleTime = 1; }
        if (!isBattleFighting) { battleTime = 0; }
        battleTime += Time.time;

        battleDecisionPanel.SetActive(!isBattleFighting);
        healthBar.SetActive(!isBattleFighting);
    }
}
