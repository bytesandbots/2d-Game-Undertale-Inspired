using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightButton : MonoBehaviour
{
    public GameObject fightPanel;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
