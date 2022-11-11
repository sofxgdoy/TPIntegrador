using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeEstados : MonoBehaviour
{
    //ref a cada componente de estado
    public MonoBehaviour EstadoPatrulla; 
    public MonoBehaviour EstadoPersecucion;
    public MonoBehaviour EstadoInicial;

    //public MeshRenderer MeshRendererIndicador;

    private MonoBehaviour estadoActual;
    void Start()
    {
        ActivarEstado(EstadoInicial);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void ActivarEstado(MonoBehaviour nuevoEstado) {
        if(estadoActual!=null) estadoActual.enabled = false;
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;
    }
}
