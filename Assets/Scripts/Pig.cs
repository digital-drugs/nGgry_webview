using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    [SerializeField] private float _stamina = 3f; 

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.relativeVelocity.magnitude > _stamina) 
        {
            Destroy(gameObject); 
        }
    }
}
