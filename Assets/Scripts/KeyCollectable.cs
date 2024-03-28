using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectable : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.keyCount = controller.keyCount + 1;
            Debug.Log ("ruby has collected " + controller.keyCount) ;
            Destroy(gameObject);

        }
       

    }
}
