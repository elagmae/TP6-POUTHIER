// <copyright file = "Fin.cs" company = "elagmae">
// Copyright (c) elagmae. All rights reserved.
// </copyright>

using UnityEngine;

public class Fin : MonoBehaviour
{
    private bool vivant = true;
    [SerializeField]
    private GameObject finTuyaux;

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
        }
    }
}
