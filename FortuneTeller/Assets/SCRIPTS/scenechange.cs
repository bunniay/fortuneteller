using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
   
   public void OnStartClick()
    {
        SceneManager.LoadScene("Closet");
    }
}
