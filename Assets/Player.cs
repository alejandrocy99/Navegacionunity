using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Vector3 destination;
    public Transform routeFather;
    int indexChildren;
    public Vector3 max,min;
    void Start()
    {
        destination = routeFather.GetChild(indexChildren).position;
        destination = RandomDestination();
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }

    

    private void Update()
    {
    //sigue el click del raton
        //if(Input.GetButtonDown("Fire1"))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //   RaycastHit hit = new RaycastHit();
        //    {
        //       GetComponent<NavMeshAgent>().SetDestination(hit.point);
        //  }
        //}

    //ruta aleatoria
            // indexChildren = Random.Range(0,routeFather.childCount);
            //destination = routeFather.GetChild(indexChildren).position;
           // GetComponent<NavMeshAgent>().SetDestination(destination);

    //ruta aleatoria con punto delimitasor 
    //destination = RandomDestination();
    //GetComponent<NavMeshAgent>().SetDestination(destination);

        if (Vector3.Distance(transform.position, destination) < 2.5f)
        {
           Vector3 randoPoint = Random.insideUnitSphere * 50;
           NavMeshHit hit;
           NavMesh.SamplePosition(randoPoint,out hit,50,1);
           destination = hit.position;
           GetComponent<NavMeshAgent>().SetDestination(destination);
        }
    }

    private Vector3 RandomDestination()
    {
        return new Vector3(Random.Range(min.x,max.x),0,Random.Range(min.z,max.z));
    }
}
