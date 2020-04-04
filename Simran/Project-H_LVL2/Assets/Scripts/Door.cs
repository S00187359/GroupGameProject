using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DoorState
{
    Closed,
    Open
}

public class Door : MonoBehaviour
{
   

    public DoorState State = DoorState.Closed;
    public DoorState previousDoorState;
    Animator animator;
    protected GameObject Player;
    string trackTag = "Player";
    public float trackingDistance = 0;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag(trackTag);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) <= trackingDistance)
        {
            State = DoorState.Open;
        }
        else
        {
            State = DoorState.Closed;
        }

        animator.SetInteger("State", (int)State);
    }
}
