using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In_Range_Appear : MonoBehaviour
{

    public float trackingDistance = 0;
    public bool isMesh;
    public bool isCanvas;
    string trackTag = "Player";
    MeshRenderer mesh;
    Canvas canvas;
   
    

    protected GameObject Player;

    // Start is called before the first frame update
    public void Start()
    {
        
        Player = GameObject.FindGameObjectWithTag(trackTag);
        mesh = GetComponent<MeshRenderer>();
        canvas= GetComponent<Canvas>();
      
           
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (isMesh)
        {
            if (Vector3.Distance(transform.position, Player.transform.position) <= trackingDistance)
            {
                mesh.enabled = true;


            }
            else
            {
                mesh.enabled = false;


            }
        }

        else if (isCanvas)
        {
            if (Vector3.Distance(transform.position, Player.transform.position) <= trackingDistance)
            {
                canvas.enabled = true;


            }
            else
            {
                canvas.enabled = false;


            }
        }
        

       
        
        
    }
}
