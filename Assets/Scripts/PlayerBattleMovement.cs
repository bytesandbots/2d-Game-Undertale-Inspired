using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBattleMovement : MonoBehaviour
{
    public float moveSpeed;
    public float activeMoveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveInput;
    public KeyCode rollKey = KeyCode.Space;
    public float rollSpeed;

    public float rollLength = .5f;
    public float rollCooldown = 1f;

    private float rollCounter;
    private float rollCoolCounter;

    public bool rolling;

    public BattleManager battleManager;


    // Start is called before the first frame update
    void Start()
    {
        activeMoveSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();


        if (!rolling) { rb.velocity = moveInput * activeMoveSpeed * battleManager.battleTime; }

        if (Input.GetKeyDown(rollKey))
        {
            if(rollCoolCounter <= 0 && rollCounter <= 0)
            {
                activeMoveSpeed = rollSpeed;
                rollCounter = rollLength;
                rolling = true;
                rb.velocity = moveInput * activeMoveSpeed * battleManager.battleTime;
            }
        }

        if(rollCounter > 0)
        {
            rollCounter -= Time.deltaTime;

            if(rollCounter <= 0)
            {
                rolling = false;
                activeMoveSpeed = moveSpeed;
                rollCoolCounter = rollCooldown;
            }
        }

        if(rollCoolCounter > 0)
        {
            rollCoolCounter -= Time.deltaTime;
        }
    }
}
