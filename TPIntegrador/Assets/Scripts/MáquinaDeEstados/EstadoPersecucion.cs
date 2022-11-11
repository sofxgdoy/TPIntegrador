using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EstadoPersecucion : MonoBehaviour
{
    private MaquinaDeEstados maquinaDeEstados;
    // Start is called before the first frame update
    public Color ColorEstado = Color.red;
    private ControladorNavMesh controladorNavMesh;
    private ControladorVision controladorVision;

    private NavMeshAgent navMeshAgent;
    

    void Start()
    {
        maquinaDeEstados = GetComponent<MaquinaDeEstados>();
        controladorNavMesh = GetComponent<ControladorNavMesh>();
        controladorVision = GetComponent<ControladorVision>();
        navMeshAgent = GetComponent<NavMeshAgent>();

        
    }

    // Update is called once per frame
    void Update()
    {
        controladorNavMesh.ActualizarPuntoDestinoNavMeshAgent();
        
    }

    void OnEnable(){
        //maquinaDeEstados.MeshRendererIndicador.material.color = ColorEstado;
        
        

        
    }
}
