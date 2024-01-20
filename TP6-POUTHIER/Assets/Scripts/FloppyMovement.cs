// <copyright file = "FloppyMovement.cs" company = "elagmae">
// Copyright (c) elagmae. All rights reserved.
// </copyright>

using UnityEngine;

public class FloppyMovement : MonoBehaviour
{
    [SerializeField]
    private new Rigidbody2D rigidbody;
    [SerializeField]
    private Vector2 hauteur;

    public void Saut()
    {
        this.rigidbody.velocity = Vector3.zero;
        this.rigidbody.AddForce(this.hauteur, ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.Saut();
        }
    }
}
