using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFragDeath : MonoBehaviour
{
    public float maxYeetnessY;
    public float maxYeetnessX;
    public Rigidbody2D rb;
    public deathMusicDecider deathMusicDecider;

    private void Start()
    {
        StartCoroutine(yeetDaFrag());
    }

    public IEnumerator yeetDaFrag()
    {
        yield return new WaitForSeconds(2.5f);
        rb.AddForce(new Vector2(Random.Range(-maxYeetnessX, maxYeetnessX), Random.Range(250, maxYeetnessY)));
        rb.gravityScale = 1;
        deathMusicDecider.DEATHMUSICBEANS();
    }
}
