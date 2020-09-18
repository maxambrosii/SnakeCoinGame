using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{

    private CoinMovement coinMain;
    private GameObject tailTargetObj;
    private Vector3 tailTargetPosition;

    private int indexOfChild;
    private float Speed;
    
    void Start()
    {
        coinMain = GameObject.FindGameObjectWithTag("MainCoin").GetComponent<CoinMovement>();
        
        tailTargetObj = coinMain.childCoins[coinMain.childCoins.Count - 2];
         Speed = coinMain.Speed + 2f;
    }

    // Update is called once per frame
    void Update()
    {
       
        tailTargetPosition = tailTargetObj.transform.position;
        transform.LookAt(tailTargetPosition, tailTargetPosition);
        
        transform.position = Vector3.Lerp(transform.position, tailTargetPosition, Time.deltaTime * Speed);
    }

 
}
