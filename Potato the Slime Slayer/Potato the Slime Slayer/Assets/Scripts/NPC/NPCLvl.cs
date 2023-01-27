using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCLvl : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
