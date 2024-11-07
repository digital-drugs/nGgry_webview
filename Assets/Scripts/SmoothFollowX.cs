using UnityEngine;

public class SmoothFollowX : MonoBehaviour
{
    public Transform Target; 
    [SerializeField] private float _smoothSpeed = 0.125f; 
    [SerializeField] private Vector3 _offset; 

    private void Awake()
    {
       _offset =  Target.position - transform.position;
    }
    void LateUpdate()
    {
        if (Target != null)
        {
            
            Vector3 desiredPosition = new Vector3(Target.position.x + _offset.x, transform.position.y, transform.position.z);

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);

            transform.position = smoothedPosition;
        }
    }
}