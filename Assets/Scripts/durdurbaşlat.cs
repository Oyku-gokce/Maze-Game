using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class durdurbaşlat : MonoBehaviour
{
    // Start is called before the first frame update
    public Image duraklatresim, oynatresim;

    void Start()
    {
        oynatresim.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void duraklat()
    {
        duraklatresim.enabled = false;
        oynatresim.enabled = true;
        Time.timeScale = 0;
    }
    public void oynat()
    {
        duraklatresim.enabled = true;
        oynatresim.enabled = false;
        Time.timeScale = 1;
    }
    public void disableButton()
    {
        duraklatresim.GetComponent<Button>().interactable = false;
    }
}
