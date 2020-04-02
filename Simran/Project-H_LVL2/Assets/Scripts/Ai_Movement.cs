using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_Movement : NavMeshMover
{
    public string trackTag = "Player";
    GameObject trackedPlayer;

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
            MoveTo(trackedPlayer);
        }
    }
}
