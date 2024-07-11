using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public bool isBattleFighting;
    public float battleTime;
    public float battleTimer;
    public float maxBattleTimer;
    public GameObject battleDecisionPanel;
    public GameObject healthBar;
    static BattleManager Instance;
    public static BattleManager instance
    {
        get
        {
            if (Instance == null)
            {
                Instance = new BattleManager();
            }
            return Instance;
        }
    }

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
        battleTimer += Time.time / 10000 * battleTime;

        battleDecisionPanel.SetActive(!isBattleFighting);
        //healthBar.SetActive(!isBattleFighting);

        if (Input.GetKeyDown(KeyCode.F5)) { isBattleFighting = !isBattleFighting; }


        if(battleTimer > maxBattleTimer)
        {
            battleTimer = 0;
            isBattleFighting = false;
        }
    }


}
