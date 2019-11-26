using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MudarCena()
    {
        SceneManager.LoadScene("Game");
    }

    public void AbrirOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void Voltar()
    {
        SceneManager.LoadScene("Menu");
    }
}
