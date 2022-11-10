using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HuevoColl : MonoBehaviour
{
    //public GameObject esteHuevo;

    public count count;
    public Text scoreText;

    public bool recogido = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.FindGameObjectWithTag("Player").GetComponent<count>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = (count.Huevos).ToString();

        if(count.Huevos == 0) {
            recogido = true;
        }
        
    }

    public void OnTriggerEnter(Collider other) {

        
        if (other.tag == "Player"){
            
            count.Huevos = count.Huevos - 1;
            Debug.Log(count.Huevos);
            Destroy(gameObject);

        }
        
        
        
        
        
        
    }
}
