using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin : MonoBehaviour
{
    private bool _vivant = true;
    [SerializeField] private GameObject FinTuyaux;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _vivant = false;
    }

    private void Update()
    {
        if (_vivant == false)
        {
            this.GetComponent<FloppyMovement>().enabled=false;
            FinTuyaux.GetComponent<TuyauMouvement>().enabled = false;

        }
    }
}
