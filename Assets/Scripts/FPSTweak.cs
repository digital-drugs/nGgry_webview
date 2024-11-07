using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSTweak : MonoBehaviour
{
    [Range(30, 60)] [SerializeField] private int _fps;
    void Awake()
    {
        Application.targetFrameRate = _fps;
    }
}
