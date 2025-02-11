using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    [SerializeField] private Canvas winCanvas;
    [SerializeField] private Button menuButton;
    [SerializeField] private Button retryButton;
    [SerializeField] private Button nextButton;
    [SerializeField] private string nextLevelName; // Public string field for the next level name
    [SerializeField] private BallMovement playerController; // Reference to the player control script

    private Animator animator;

    void Start()
    {
        // Ensure the canvas is initially disabled
        winCanvas.gameObject.SetActive(false);

        // Assign button click listeners
        menuButton.onClick.AddListener(OnMenuButtonClicked);
        retryButton.onClick.AddListener(OnRetryButtonClicked);
        nextButton.onClick.AddListener(OnNextButtonClicked);

        // Get the Animator component
        animator = winCanvas.GetComponent<Animator>();
    }

    public void ShowWinCanvas()
    {
        winCanvas.gameObject.SetActive(true);
        animator.Play("Win Screen Test Animation");
        Debug.Log("You Win!");

        // Disable the player control script
        if (playerController != null)
        {
            playerController.enabled = false;
        }
        // Set the first selected button
        EventSystem.current.SetSelectedGameObject(nextButton.gameObject);
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
        // Load the next level scene based on the name provided in the Inspector
        if (!string.IsNullOrEmpty(nextLevelName))
        {
            SceneManager.LoadScene(nextLevelName);
        }
        else
        {
            Debug.LogWarning("Next level name is not set.");
        }
    }
}
