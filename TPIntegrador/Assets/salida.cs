using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salida : MonoBehaviour
{
    // Start is called before the first frame update
    public bool recogido = false;
    public count count;
    void Start()
    {
        count = GameObject.FindGameObjectWithTag("Player").GetComponent<count>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(count.Huevos == 0) {
            recogido = true;
        }

        
        
    }

     public void OnTriggerEnter(Collider other) {

        
        
            
            

        
        if (other.tag == "Player" && recogido){
            //salida
            Debug.Log("Ganar");
            SceneManager.LoadScene("Final");

        }
        
        
        
        
        
        
    }
}
