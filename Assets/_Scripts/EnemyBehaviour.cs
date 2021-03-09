using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {


            Destroy(this.gameObject);


        }
    }
    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(player.position);
    }
}
