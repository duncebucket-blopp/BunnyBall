using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string level1;
    public string level2;
    public string level3;

    public void LoadLevel1()
    {
        SceneManager.LoadScene(level1.name);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(level2.name);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(level3.name);
    }
}
