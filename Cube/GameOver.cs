using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Again()
    {
        SceneManager.LoadScene("Game");
    }
}
