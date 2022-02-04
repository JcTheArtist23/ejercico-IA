using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAController : MonoBehaviour
{
    //Target al que sigue la IA
    Transform target;
    Transform recolocacion;
    NavMeshAgent agent;

    public Transform[] destinationPoints;
    int destinationIndex;
    // Start is called before the first frame update
    void Start()
    {
       target = GameObject.Find("target 1").transform;
       recolocacion = GameObject.Find("puntoDeRecolocacion1").transform;
       agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Pone la posicion del target como objetivo de la IA
        //agent.destination = target.position;

        /*if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                //Pone el punto de colision del raycast como destino del agent
                agent.destination = hit.point;
            }
        }*/
        //si la distancia entre IA y target es menor de 5b sigue al target
        if(Vector3.Distance(transform.position, target.position) <5)
        {
            agent.destination = recolocacion.position;
        }
        //si el target esta mas lejos sigue con su patrulla
        /*else
        {
            //la IA va a los puntos de patrulla
        agent.destination = destinationPoints[destinationIndex].position;

        if(Vector3.Distance(transform.position, destinationPoints[destinationIndex].position) <0.5f)
        {
            if(destinationIndex < destinationPoints.Length -1)
            {
                //aumenta en 1 el index
                destinationIndex++;
            }
            //si llegamos al maximo de puntos en el array nos devuelve el index al valor 0
            else
            {
                destinationIndex = 0;
            }
        }
        }*/
        

    }
}
