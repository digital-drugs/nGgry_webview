using UnityEngine;

public class OrientationLock : MonoBehaviour
{
    [SerializeField] private bool m_IsLocked;
    void Awake()
    {
        if (m_IsLocked)
        Screen.orientation = ScreenOrientation.LandscapeRight;
    }
}