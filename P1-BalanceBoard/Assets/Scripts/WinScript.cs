using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    [SerializeField] private Canvas winCanvas;
    [SerializeField] private Button menuButton;
    [SerializeField] private Button retryButton;
    [SerializeField] private Button nextButton;

    void Start()
    {
        // Ensure the canvas is initially disabled
        winCanvas.gameObject.SetActive(false);

        // Assign button click listeners
        menuButton.onClick.AddListener(OnMenuButtonClicked);
        retryButton.onClick.AddListener(OnRetryButtonClicked);
        nextButton.onClick.AddListener(OnNextButtonClicked);
    }

    public void ShowWinCanvas()
    {
        winCanvas.gameObject.SetActive(true);
    }

    public void OnMenuButtonClicked()
    {
        // Load the main menu scene
        SceneManager.LoadScene("LevelSelector");
    }

    public void OnRetryButtonClicked()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnNextButtonClicked()
    {
        // Load the next level scene
        SceneManager.LoadScene("NextLevel");
    }
}
