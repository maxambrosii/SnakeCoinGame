using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCoin : MonoBehaviour
{

    void OnTriggerEnter(Collider mainCoin)
    {
       
        if (mainCoin.CompareTag("MainCoin"))
        {
            mainCoin.GetComponent<CoinMovement>().AddChildCoin();
        }
        Destroy(gameObject);
    }

  
}
