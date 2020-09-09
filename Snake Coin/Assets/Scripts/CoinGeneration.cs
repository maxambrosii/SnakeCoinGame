using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGeneration : MonoBehaviour
{
    [SerializeField]
    private GameObject childCoin;

    private float XSize = 10.9f;
    private float ZSizeFront = 5.4f;
    private float ZSizeBack = -2.4f;

    private Vector3 currentPosition;
    private GameObject currentChildrenCoin;

    //Left : X = 10.9
    //Right : X = -10.9

    //Back Z = -2.6
    //Front: 5.4
    void Start()
    {
        InvokeRepeating("GenerateCoin", 1,1);    
    }

    void GenerateRandomPosition()
    {
        currentPosition = new Vector3(Random.Range(XSize*-1, XSize), 0.5f, Random.Range(ZSizeBack, ZSizeFront));
    }
  
    void GenerateCoin()
    {
        GenerateRandomPosition();
        currentChildrenCoin = GameObject.Instantiate(childCoin, currentPosition, Quaternion.identity);
        GenerateRandomPosition();
        currentChildrenCoin = GameObject.Instantiate(childCoin, currentPosition, Quaternion.identity);
        GenerateRandomPosition();
        currentChildrenCoin = GameObject.Instantiate(childCoin, currentPosition, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
