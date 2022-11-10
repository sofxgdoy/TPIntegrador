using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    private Animator anim;
    public FirstPersonMovement mov_Controller;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*if (mov_Controller.IsRunning == false) {
            Debug.Log("Check");

            anim.SetBool("Run", true);     
        }*/

        var HorizontalDown = Input.GetButton("Horizontal");
        var VerticalDown = Input.GetButton("Vertical");

        if (HorizontalDown || VerticalDown) {
            anim.SetBool("Run", true);
        } else {
            anim.SetBool("Run", false);
        }
        

        //MovGallina();
    }

    public void MovGallina() {

        /*if (mov_Controller.IsRunning) {
            anim.SetBool("Run", false);
        } else {
            anim.SetBool("Run", true);
        }*/

        /*if (Input.GetKey("Horizontal") || Input.GetKey("Vertical")) {
            anim.SetBool("Run", true);

        } else {
            anim.SetBool("Run", false);
        }*/

        


    }

}
