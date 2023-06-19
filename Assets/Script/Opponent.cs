using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Opponent : MonoBehaviour
{

    public NavMeshAgent OppenentAgent;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        OppenentAgent = GetComponent<NavMeshAgent>();        
    }

    // Update is called once per frame
    void Update()
    {
        OppenentAgent.SetDestination(Target.transform.position);
    }
}
