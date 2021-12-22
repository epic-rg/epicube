using UnityEngine.SceneManagement;
using UnityEngine;

public class Back : MonoBehaviour
{
    public void backToLevel()
    {
        SceneManager.LoadScene(2);
    }
}
