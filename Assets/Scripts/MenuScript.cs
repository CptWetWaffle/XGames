using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayClick()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitClick()
    {
        Application.Quit();
    }
}
