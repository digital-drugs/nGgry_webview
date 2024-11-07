
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] _spritesToTurnOff;
    [SerializeField] private GameObject[] _gameObjectsToTurnOn;
    [SerializeField] private SmoothFollowX _follower;
    [SerializeField] private LineDrawer[] _lineDrawers;
    private int _currentIndex = 0;

    public void Next()
    {
        if(_currentIndex < _spritesToTurnOff.Length)
        { 
            _spritesToTurnOff[_currentIndex].SetActive(false);
            _gameObjectsToTurnOn[_currentIndex].SetActive(true);
            _follower.Target = _gameObjectsToTurnOn[_currentIndex].transform;
            _lineDrawers[0].MovingPoint = _gameObjectsToTurnOn[_currentIndex].transform;
            _lineDrawers[1].MovingPoint = _gameObjectsToTurnOn[_currentIndex].transform;
            _lineDrawers[0].enabled = true;
            _lineDrawers[1].enabled = true;
            _currentIndex++;
        }
        else
        {
            StartCoroutine(Delay());
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
