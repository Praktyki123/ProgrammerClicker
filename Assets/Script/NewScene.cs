using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    [SerializeField]
    private string Scena;

    public void LoadScene()
    {
        SceneManager.LoadScene(Scena);
    }
}
