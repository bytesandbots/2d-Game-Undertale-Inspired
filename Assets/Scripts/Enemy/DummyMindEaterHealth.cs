using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyMindEaterHealth : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public dummyMindEaterAI dummyMindEaterAI;

    public GameObject damageColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject, .5f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("SwordDamageHitbox"))
        {
            print("BEANMS");
            health -= 9;
            damageColor.SetActive(true);
            StartCoroutine(DamageIndicator());
        }
    }


    public void DamageMindEater(int damage)
    {
        health -= damage;
    }

    public IEnumerator DamageIndicator()
    {
        yield return new WaitForSeconds(.5f);
        damageColor.SetActive(false);
    }
}
