using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




public class NavMeshMover : MonoBehaviour
{
    protected NavMeshAgent agent;
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public virtual void MoveTo(GameObject target)
    {
        MoveTo(target.transform.position);
    }
    public virtual void MoveTo(Vector3 position)
    {
        agent.SetDestination(position);
    }

    public virtual void stop()
    {
        agent.isStopped = true;
    }
    public virtual void Resume()
    {
        agent.isStopped = false;
    }

    private float RangeThreshold = 0.1f;
    public void HasReacheddestination()
    {
        if (Vector3.Distance(transform.position, agent.destination) <= RangeThreshold)
        {

        }
    }

  

   


}
