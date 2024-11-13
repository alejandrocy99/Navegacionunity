using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    Vector3 destination;
    public Transform routeFather;
    int indexChildren;
    void Start()
    {
        destination = routeFather.GetChild(indexChildren).position;
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }


    private void Update()
    {

        //if(Input.GetButtonDown("Fire1"))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //   RaycastHit hit = new RaycastHit();
        //    {
        //       GetComponent<NavMeshAgent>().SetDestination(hit.point);
        //  }
        //}



        if (Vector3.Distance(transform.position, destination) < 2.5f)
        {
            indexChildren = Random.Range(0,routeFather.childCount);
            destination = routeFather.GetChild(indexChildren).position;
            GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    }
}
