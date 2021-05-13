using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void EarthButtonDown()
    {
        SceneManager.LoadScene("EarthPlayScene");
    }

    public void EnceladusButtonDown()
    {
        SceneManager.LoadScene("EnceladuPlayScene");
    }

    public void GanymedeButtonDown()
    {
        SceneManager.LoadScene("GanymedePlayScene");
    }

    public void JunoButtonDown()
    {
        SceneManager.LoadScene("JunoPlayScene");
    }

    public void JupiterButtonDown()
    {
        SceneManager.LoadScene("JupiterPlayScene");
    }

    public void Kepler1ButtonDown()
    {
        SceneManager.LoadScene("KeplerPlayScene");
    }

    public void Kepler2ButtonDown()
    {
        SceneManager.LoadScene("Kepler2PlayScene");
    }

    public void PlasmaButtonDown()
    {
        SceneManager.LoadScene("PlasmaPlayScene");
    }

    public void Saturn1ButtonDown()
    {
        SceneManager.LoadScene("Saturn1PlayScene");
    }

    public void Saturn2ButtonDown()
    {
        SceneManager.LoadScene("Saturn2PlayScene");
    }

    public void Saturn3ButtonDown()
    {
        SceneManager.LoadScene("Saturn3PlayScene");
    }

    public void Voyager1ButtonDown()
    {
        SceneManager.LoadScene("Voyager1PlayScene");
    }

    public void Voyager2ButtonDown()
    {
        SceneManager.LoadScene("Voyager2PlayScene");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
