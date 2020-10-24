using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    //// shows text:"Goal" when the player triggers the finsihline
    public GameObject GoalTrger;
    
     private void OnTrigger   (Collider other)
     {
         if(other.gameObject.tag== "Player")
         {
             GoalTrger.gameObject.SetActive(true);
             
         }
     }
    
}
