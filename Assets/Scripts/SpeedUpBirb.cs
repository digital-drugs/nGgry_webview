using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpBirb : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _birdRB;

    void Awake()
    {
        _birdRB = GetComponent<Rigidbody2D>();
    }

    public void Push()
    {
        _birdRB.velocity *= _speed;
    }
}
