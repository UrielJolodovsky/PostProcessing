using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class angetscript : MonoBehaviour
{
    public NavMeshAgent agent30;
    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent30.destination = destination.position;
    }
}
