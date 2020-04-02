using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_Distanace_Move : NavMeshMover
{
    public string trackTag = "Player";
    GameObject trackedPlayer;
  
    public float trackingDistance = 4;
    public override void Start()
    {
        trackedPlayer = GameObject.FindGameObjectWithTag(trackTag);
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (trackedPlayer != null)
        {
            if (Vector3.Distance(transform.position, trackedPlayer.transform.position) <= trackingDistance)
            {
                Resume();
                MoveTo(trackedPlayer);
            }
            else
            {

                MoveTo(transform.position);
                stop();
            }

        }


    }
}
