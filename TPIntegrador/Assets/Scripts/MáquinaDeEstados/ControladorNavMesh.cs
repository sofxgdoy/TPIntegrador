using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorNavMesh : MonoBehaviour
{
    [ HideInInspector]
    public Transform perseguirObjetivo;
    private NavMeshAgent navMeshAgent;
    
    void Awake() {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void ActualizarPuntoDestinoNavMeshAgent(Vector3 puntoDestino) {
        navMeshAgent.destination = puntoDestino;
        navMeshAgent.Resume();
    }

    public void ActualizarPuntoDestinoNavMeshAgent(){
        ActualizarPuntoDestinoNavMeshAgent(perseguirObjetivo.position);
    }

    //saber si alcanzó el destino
    public bool HemosLlegado(){
        return navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance && !navMeshAgent.pathPending;
    }
}
