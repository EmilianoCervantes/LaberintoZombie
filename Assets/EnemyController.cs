using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {


    public Transform target;
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(target.position);
        gameObject.GetComponent<Animator>().SetBool("avanza", true);
	}
}
