using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    // Refer�ncias p�blicas para os bot�es
    public Button buttonScene1;
    public Button buttonScene2;
    public Button buttonScene3;

    // Nomes das cenas para transi��o
    public string sceneName1 = "NegativeStage";
    public string sceneName2 = "";
    public string sceneName3 = "Scene3";

    private void Start()
    {
        // Adiciona listeners para os bot�es
        if (buttonScene1 != null)
            buttonScene1.onClick.AddListener(() => LoadScene(sceneName1));

        if (buttonScene2 != null)
            buttonScene2.onClick.AddListener(() => LoadScene(sceneName2));

        if (buttonScene3 != null)
            buttonScene3.onClick.AddListener(() => LoadScene(sceneName3));
    }

    // Fun��o para carregar a cena
    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
