using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject spotlight;
    public AudioSource background;
    public AudioSource choice;

    public void ButtonAppear()
    {
        button1.SetActive(true);
        button2.SetActive(true);
        spotlight.SetActive(true);
        background.Pause();
        choice.Play();
    }

    public void buttonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void button1Click()
    {
        SceneManager.LoadScene(3);
    }
}
