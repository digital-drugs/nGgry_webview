using UnityEngine;

public class WebViewController : MonoBehaviour
{
    [SerializeField] private GameObject _rootPanel;
    private UniWebView _webView;

    void Start()
    {
        // �������� � ������������� UniWebView
        _webView = gameObject.AddComponent<UniWebView>();

        // ��������� �������� � ���������
        _webView.Frame = new Rect(0, 0, Screen.width, Screen.height); // �������� ���� �����

        // ��������� URL
        _webView.Load("https://www.google.com");

        _webView.OnShouldClose +=  Hide;
       
    }

    //void OnDestroy()
    //{
    //    _webView.Hide();
    //    _webView = null;
    //}

    public void Show()
    {
        _webView.Show();
    }

    public bool Hide(UniWebView view)
    {
        _webView.Hide();
        Destroy(_webView);
        _webView = null;
        _rootPanel.SetActive(false);
        return true;
    }
}