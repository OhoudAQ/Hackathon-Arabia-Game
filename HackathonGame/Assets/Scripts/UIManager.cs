using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager  : MonoBehaviour{


    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name,LoadSceneMode.Single);
    }


    public void ShowPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void HidePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
