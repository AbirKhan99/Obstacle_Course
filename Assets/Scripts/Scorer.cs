using UnityEngine;

public class Scorer : MonoBehaviour
{
            int Hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hits")
        {
            Hits++;
            Debug.Log("You have bumped into the wall " + Hits + " times");
        }
        
        
    }
    }

