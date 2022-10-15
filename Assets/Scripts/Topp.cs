using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Topp : MonoBehaviour
{
    // Start is called before the first frame update
    durdurbaþlat db;
    Rigidbody rg;
    bool bitti = false;
    public Image duraklatimage;
    public GameObject sonn;
    public ParticleSystem ps;
    public Text cantext;
    public Text suretext;
    int sureint;
    float sure = 60;
    int sayac=3;
    void Start()
    {
        db = duraklatimage.GetComponent<durdurbaþlat>();
        GetComponentInParent<Animator>().enabled = false;
        sonn.GetComponent<Animator>().enabled = false;
        ps.Stop();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        rg = GetComponent<Rigidbody>();
        if (!bitti)
        {
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 hareket = new Vector3(yatay, 0, dikey);
            rg.AddForce(hareket);
            sure -= Time.deltaTime;
            sureint = (int)sure;
            suretext.text = "KALAN SÜRE:" + sureint.ToString();
            if (sureint == 0)
                Time.timeScale = 0;

        }
        else
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            GetComponent<Rigidbody>().useGravity = false;


            sure = sureint;
            suretext.text = "KALAN SÜRE:" + sureint.ToString();
        }

           



    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("duvar") && !bitti) {
            sayac--;
            cantext.text = sayac.ToString();
            if (sayac == 0)
                Time.timeScale = 0;
        }
            

        if (collision.gameObject.tag.Equals("bitiþ") && !bitti)
        {
            db.disableButton();
            GetComponentInParent<Animator>().enabled = true;
            sonn.GetComponent<Animator>().enabled = true;
            ps.Play();
            

            bitti = true;

        }
            

    }
}
