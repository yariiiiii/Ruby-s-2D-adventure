using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Start is called before the first frame update
  void OnTriggerEnter2D(Collider2D other)
{
     RubyController controller = other.GetComponent<RubyController>();

     if (controller != null)
     {
          if(controller.health < controller.maxHealth)
          {
	       controller.ChangeHealth(1);
	       Destroy(gameObject);
          }
     }
}
   
        
        


    // Update is called once per frame
    
}   
   
