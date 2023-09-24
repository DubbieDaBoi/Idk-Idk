using UnityEngine;
using UnityEngine.SceneManagement; 

public class Won : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
           
            SceneManager.LoadScene("Win");
        }
    }
}
