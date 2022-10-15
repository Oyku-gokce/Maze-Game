using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void restartGameMethod()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void menuDon()
    {
        SceneManager.LoadScene("anamenu");

    }
    public void oyundanCik()
    {
        Application.Quit();
    }
}
