using System.Runtime.Serialization;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimetoWait;
    Rigidbody rb;
        void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimetoWait )
        {
            rb.useGravity = true;
        }
    }
}
