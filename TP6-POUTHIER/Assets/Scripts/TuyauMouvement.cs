// <copyright file="TuyauMouvement.cs" company="elagmae">
// Copyright (c) elagmae. All rights reserved.
// </copyright>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuyauMouvement : MonoBehaviour
{
    [SerializeField]
    private GameObject arriveeTuyaux;
    private float vitesseBgMouvement = 15;
    private int index = 0;
    [SerializeField]
    private GameObject tuyau;
    [SerializeField]
    private List<GameObject> listeTuyaux;

    public void MouvementTuyaux()
    {
        this.tuyau.transform.Translate(-Time.deltaTime * this.vitesseBgMouvement, 0, 0, this.arriveeTuyaux.transform);
    }

    private IEnumerator Destruction()
    {
        yield return new WaitForSeconds(0.8f);
        if (this.listeTuyaux.Count > 1)
        {
            Destroy(this.listeTuyaux[this.index]);
            this.listeTuyaux.Remove(this.listeTuyaux[this.index]);
        }
    }

    private IEnumerator Creation()
    {
        yield return new WaitForSeconds(0.3f);
        {
            float aleatoire = Random.Range(-2.1f, 2.3f);
            this.tuyau = Instantiate(this.tuyau, new Vector2(7f, aleatoire), Quaternion.identity);
            this.listeTuyaux.Add(this.tuyau.gameObject);
        }
    }

    private IEnumerator Start()
    {
        while (this.tuyau != false)
        {
            yield return this.StartCoroutine("Creation");
            yield return this.StartCoroutine("Destruction");
        }
    }

    private void Update()
    {
        this.MouvementTuyaux();
    }
}
