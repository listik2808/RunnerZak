using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayBtn()
   {
      SceneManager.LoadScene(1);
   }
}
