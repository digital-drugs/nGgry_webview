using UnityEngine;

public class CameraReturn : MonoBehaviour
{
    [SerializeField] private float _returnSpeed = 2f; 
    private Vector3 _initialPosition;
    public bool IsReturning = false;    

    void Start()
    {

        _initialPosition = transform.position;
    }

    void Update()
    {
        
        if (IsReturning)
        {
            Debug.Log("returning");
            transform.position = Vector3.Lerp(transform.position, _initialPosition, Time.deltaTime * _returnSpeed);

            if (Vector3.Distance(transform.position, _initialPosition) < 0.1f)
            {
                
                IsReturning = false;
                Debug.Log(IsReturning);
            }
        }

    }
}