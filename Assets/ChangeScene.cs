using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
      public void MoveToMainGame()
    {
        SceneManager.LoadScene("gameplay");
    }
}
