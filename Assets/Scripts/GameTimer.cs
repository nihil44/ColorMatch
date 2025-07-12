using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 60f; // baştaki süre
    public TextMeshProUGUI timerText; // sayaç yazısı
    public GameObject gameOverPanel; // oyun bitince gösterilecek panel
    private bool isGameActive = true;

    void Update()
    {
        if (isGameActive)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                isGameActive = false;
                GameOver();
            }

            timerText.text = "Time: " + Mathf.CeilToInt(timeRemaining).ToString();
        }
    }

    void GameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        Debug.Log("Game Over!");
    }
    public void RestartGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
}