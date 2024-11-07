using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Bird : MonoBehaviour
{
    private Rigidbody2D _birdRigidbody;
    private SpringJoint2D _slingSpring;
    [SerializeField] private Rigidbody2D _anchorRigid; 

    [SerializeField] private float _maxDistance = 3f; 

    [SerializeField] private bool _isPressed = false; 

    [SerializeField] private SpeedUpBirb _speedUp;
    [SerializeField] private SmoothFollowX _smoothFollowX;

    [SerializeField] private LineDrawer[] _lineDrawers;

    private void Awake()
    {
        _birdRigidbody = GetComponent<Rigidbody2D>();
        _slingSpring = GetComponent<SpringJoint2D>();
    }

    private void Update()
    {
        if (_isPressed) 
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

            if (Vector2.Distance(mousePos, _anchorRigid.position) > _maxDistance) 
            {
                _birdRigidbody.position = _anchorRigid.position + (mousePos - _anchorRigid.position).normalized * _maxDistance; 
            }

            else
            {
                _birdRigidbody.position = mousePos; 
            }
        }
    }

    private void OnMouseDown() 
    {
        _isPressed = true; 
        _birdRigidbody.isKinematic = true; 
    }

    private void OnMouseUp() 
    {
        _isPressed = false; 
        _birdRigidbody.isKinematic = false; 

        StartCoroutine(LetGo()); 
    }

    IEnumerator LetGo()
    {
        yield return new WaitForSeconds(0.1f);
        _lineDrawers[0].enabled = false;
        _lineDrawers[1].enabled = false;
        _slingSpring.enabled = false;
        _smoothFollowX.enabled = true;
        _speedUp.Push();
        enabled = false; 

        yield return new WaitForSeconds(2); 

    }
}
