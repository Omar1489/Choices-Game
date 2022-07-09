using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas5Controller : MonoBehaviour
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
        SceneManager.LoadScene(5);
    }

    public void button1Click()
    {
        SceneManager.LoadScene(4);
    }
}
