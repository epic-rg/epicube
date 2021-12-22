using UnityEngine.SceneManagement;
using UnityEngine;

public class TutorialComplete : MonoBehaviour
{
    public void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
