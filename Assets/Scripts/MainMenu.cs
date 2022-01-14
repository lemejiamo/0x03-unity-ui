using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // seriously needs a explanation
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
        Color trap, goal;

        if (colorblindMode.isOn)
        {
            trap = new Color32(255, 112, 0, 1);
            goal = new Color(0, 0, 1, 1);
        }
        else
        {
            trap = new Color(1, 0, 0, 1);
            goal = new Color(0, 1, 0, 1);
        }

        trapMat.color = trap;
        goalMat.color = goal;
    }

    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    } 
}
