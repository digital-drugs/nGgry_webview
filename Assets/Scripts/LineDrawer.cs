using UnityEngine;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer _lineRenderer;
    [SerializeField] private Transform _staticPoint;
    public Transform MovingPoint;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 2;
    }

    private void OnEnable()
    {

        _lineRenderer.startWidth = 0.1f;
        _lineRenderer.endWidth = 0.1f;
    }

    private void OnDisable()
    {
        _lineRenderer.startWidth = 0f;
        _lineRenderer.endWidth = 0f;
    }

    void Update()
    {
        _lineRenderer.SetPosition(0, _staticPoint.position); 
        _lineRenderer.SetPosition(1, MovingPoint.position); 
    }
}