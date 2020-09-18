using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMovement : MonoBehaviour
{
   
    public float Speed;
    public float RotationSpeed;

    public List<GameObject> childCoins = new List<GameObject>();

    [HideInInspector]
    public float z_offset = 0.3f;

    public GameObject childCoin;
    public float CurrentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        childCoins.Add(gameObject);
    }

    void Update()
    {
        
        transform.Translate(Vector3.right * CurrentSpeed * Time.deltaTime);

        CurrentSpeed = Speed;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0,0,RotationSpeed));
        
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, RotationSpeed*-1));
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            CurrentSpeed = Speed * 4;
        }
    }

    public void AddChildCoin()
    {
        Debug.Log("Added");
        Vector3 newChildCoinPosition = childCoins[childCoins.Count - 1].transform.position;//childCoins[childCoins.Count-1].transform.position;
        newChildCoinPosition.z -= z_offset;
    
        childCoins.Add(Instantiate(childCoin, newChildCoinPosition, Quaternion.identity));

    }
}
