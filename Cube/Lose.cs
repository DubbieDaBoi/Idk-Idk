using UnityEngine;
using UnityEngine.SceneManagement; 

public class Lose : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
           
            SceneManager.LoadScene("GameOver");
        }
    }
}
