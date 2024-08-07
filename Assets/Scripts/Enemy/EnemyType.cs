using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EncounterType
{
    Enemy1,
    Enemy2,
    Enemy3,
    Enemy4,
    TestBattle
}
public class EnemyType : MonoBehaviour
{
    public EncounterType encounterType = EncounterType.Enemy1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
