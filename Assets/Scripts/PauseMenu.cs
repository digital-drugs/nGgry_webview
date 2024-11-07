using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void Stop()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time .timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
