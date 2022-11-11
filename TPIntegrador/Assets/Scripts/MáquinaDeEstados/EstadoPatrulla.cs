using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPatrulla : MonoBehaviour
{
    public Transform[] WayPoints;
    public Color ColorEstado = Color.green;
    private MaquinaDeEstados maquinaDeEstados;
    private ControladorNavMesh controladorNavMesh;
    private ControladorVision controladorVision;
    private int siguienteWayPoint;
    void Start()
    {

        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        controladorNavMesh = GetComponent<ControladorNavMesh>();
        controladorVision = GetComponent<ControladorVision>();
    }

    // Update is called once per frame
    void Update()
    {
        //ve al jugador, entra estado persecucion
        RaycastHit hit;
        if (controladorVision.PuedeVerAlJugador(out hit)){
            controladorNavMesh.perseguirObjetivo = hit.transform;
            maquinaDeEstados.ActivarEstado(maquinaDeEstados.EstadoPersecucion);
            return;

        }

        if (controladorNavMesh.HemosLlegado()) {
            siguienteWayPoint = (siguienteWayPoint + 1) % WayPoints.Length;
            ActualizarWayPointDestino();

        }
        
    }

    void OnEnable() {
        //maquinaDeEstados.MeshRendererIndicador.material.color = ColorEstado;
        ActualizarWayPointDestino();
        
        

    }

    void ActualizarWayPointDestino() {
        controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent(WayPoints[siguienteWayPoint].position);
    }
}
