using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloppyMovement : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    [SerializeField] private Vector2 _hauteur;

    public void Saut()
    {
        Rigidbody.velocity = Vector3.zero;
        this.Rigidbody.AddForce(_hauteur,ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("t'as appuyé c'est bien");
            Saut();
        }


    }
}
