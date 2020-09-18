using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public PlayerDirection direction;
    [HideInInspector]
    public float step_Length = 0.2f;
    [HideInInspector]
    public float mpvement_Frequency = 0.1f;

    private float counter;
    private bool move;

    [SerializeField]
    private GameObject tailPrefab;

    private List<Vector3> delta_Position;

    private List<Rigidbody> nodes;


    private Rigidbody main_Body;
    private Rigidbody headBody;
    private Transform transform_obj;

    private bool create_Node_At_Tail;
    // Start is called before the first frame update
    void Awake()
    {
        transform_obj = transform;
        main_Body = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitSnakeNodes()
    {
        nodes = new List<Rigidbody>();
        nodes.Add(transform_obj)
    }
}
