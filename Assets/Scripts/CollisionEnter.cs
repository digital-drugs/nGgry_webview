using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnter : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private SmoothFollowX _smoothFollowX;
    [SerializeField] private CameraReturn _returnCamera;
    [SerializeField] private BirdSwitcher _birdSwitcher;

    private bool _coroutineEnabled = false;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(_birdSwitcher != null)
        {
            _birdSwitcher.Next();
            _birdSwitcher = null;
        }
        _rb.velocity = Vector2.zero;
        
        _smoothFollowX.enabled = false;
        StartCoroutine(TimeToReturnCam());
        _coroutineEnabled = true;
        
    }

    private IEnumerator TimeToReturnCam()
    {
        if (!_coroutineEnabled)
        {
            Debug.Log("coroutine camera return");
            yield return new WaitForSeconds(1);
            _returnCamera.IsReturning = true;
            Destroy(gameObject);
        }
        yield return null;
       
    }
}
