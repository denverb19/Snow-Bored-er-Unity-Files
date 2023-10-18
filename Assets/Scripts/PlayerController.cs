using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 25f;
    Rigidbody2D playerBody;
    SurfaceEffector2D slopeEffector;
    bool movementEnabled = true;
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        slopeEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        BoostPlayer();
    }
    private void RotatePlayer()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && movementEnabled)
        {
            playerBody.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow) && movementEnabled)
        {
            playerBody.AddTorque(-(torqueAmount));
        }
    }
    private void BoostPlayer()
    {
        if(Input.GetKey(KeyCode.UpArrow) && movementEnabled)
        {
            slopeEffector.speed = 60;
        }
        else if(movementEnabled)//Dont want to set the slopeEffector to slow if player is already dead
        {
            slopeEffector.speed = 30;
        }
    }
    public void KillMovement()
    {
        movementEnabled = false;
    }
}
