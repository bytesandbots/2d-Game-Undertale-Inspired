using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyMindEaterHealth : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int defense;
    public int speedBeforeKnockback;

    public dummyMindEaterAI dummyMindEaterAI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.transform.CompareTag("SwordDamageHitBox"))
            {

            }
        }
    }

    public IEnumerator DamageKnockBack()
    {
        dummyMindEaterAI.speed = -20f;
        yield return new WaitForSeconds(.2f);
        dummyMindEaterAI.speed = -20f;
    }
}
