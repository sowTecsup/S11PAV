using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button btn;

    void Start()
    {
        btn.onClick.Invoke();
        btn.onClick.AddListener(test);
    }
    public void test()
    {

    }

    public void LoadScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
    public void ApplicationQuit()
    {
        Application.Quit();
    }

}
