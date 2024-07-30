using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathMusicDecider : MonoBehaviour
{
    public GameObject Paneltitle;
    public GameObject Paneldetermination;
    public int chanceOfTitle;
    public void DEATHMUSICBEANS()
    {
        if (Random.Range(1, chanceOfTitle) == 1) { Paneldetermination.SetActive(false); Paneltitle.SetActive(true); }
        else { Paneldetermination.SetActive(true); Paneltitle.SetActive(false); }
    }
}
