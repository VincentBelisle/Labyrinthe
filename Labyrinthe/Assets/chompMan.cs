using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class chompMan : MonoBehaviour
{


    public GameObject cible;
    public float speed = 0.001f;

    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        speed = PlayerPrefs.GetFloat("ChompSpeed");
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(cible.transform.position);
        navMeshAgent.speed = speed;
    }
}
