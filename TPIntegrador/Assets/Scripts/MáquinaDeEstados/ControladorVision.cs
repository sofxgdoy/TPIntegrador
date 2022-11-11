using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControladorVision : MonoBehaviour
{
    public Transform Ojos;
    public float rangoVision = 20f;
    public Vector3 offset = new Vector3(0f, 0.75f, 0f);

    private ControladorNavMesh controladorNavMesh;

    void Awake() {
        controladorNavMesh = GetComponent<ControladorNavMesh>();
    }
    
    public bool PuedeVerAlJugador(out RaycastHit hit, bool mirarHaciaElJugador= false) {
        Vector3 vectorDireccion;

        if (mirarHaciaElJugador){

            vectorDireccion = (controladorNavMesh.perseguirObjetivo.position + offset) - Ojos.position;

        } else {
            vectorDireccion = Ojos.forward;
        }
        //devuelve verdadero si en la dirreccion forward de los ojos, en menos de 20 unidad el rayo colisiona con algo , pero solo si es el Player.
        return Physics.Raycast(Ojos.position, vectorDireccion, out hit, rangoVision) && hit.collider.CompareTag("Player");
    }
}
