// <copyright file="Fin.cs" company="elagmae">
// Copyright (c) elagmae. All rights reserved.
// </copyright>

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Fin : MonoBehaviour
{
    private bool vivant = true;
    [SerializeField]
    private GameObject finTuyaux;
    [SerializeField]
    private GameObject finUI;
    [SerializeField]
    private GameObject score;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.vivant = false;
    }

    private void Update()
    {
        if (this.vivant == false)
        {
            this.GetComponent<FloppyMovement>().enabled = false;
            this.finTuyaux.GetComponent<TuyauMouvement>().enabled = false;
            this.finUI.SetActive(true);
            this.score.SetActive(false);
        }
    }
}
