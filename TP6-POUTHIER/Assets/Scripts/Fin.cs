// <copyright file="Fin.cs" company="elagmae">
// Copyright (c) elagmae. All rights reserved.
// </copyright>

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Fin : MonoBehaviour
{
    private bool vivant = true;

    public void LoadTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.vivant = false;
    }

    private void Update()
    {
        if (this.vivant == false)
        {
            LoadTheScene("Fin");
        }
    }
}
