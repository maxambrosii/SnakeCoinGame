using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGeneration : MonoBehaviour
{
    [SerializeField]
    private GameObject foodCoin;

    private float XSize = 10.9f;
    private float ZSizeFront = 5.4f;
    private float ZSizeBack = -2.4f;

    private Vector3 currentPosition;
    private GameObject currentChildrenCoin;

    void GenerateRandomPosition()
    {
        currentPosition = new Vector3(Random.Range(XSize*-1, XSize), 0f, Random.Range(ZSizeBack, ZSizeFront));
    }
  
    public void GenerateCoin()
    {
        GenerateRandomPosition();
        Debug.Log("Coin Generated");
        currentChildrenCoin = GameObject.Instantiate(foodCoin, currentPosition, Quaternion.identity);
    }

    private void Start()
    {
        GenerateCoin();
    }
    void Update()
    {
        if (currentChildrenCoin == null)
        {
            GenerateCoin();
        }   
    }
}
