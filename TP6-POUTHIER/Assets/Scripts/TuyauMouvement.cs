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
    [SerializeField]
    private float vitesseBgMouvement;
    private float temps;
    private int index = 0;
    [SerializeField]
    private GameObject tuyau;
    [SerializeField]
    private List<GameObject> listeTuyaux;

    public void CreationTuyaux()
    {
        float aleatoire = Random.Range(-2.0f, 3.0f);
        this.tuyau = Instantiate(this.tuyau, new Vector2(7f, aleatoire), Quaternion.identity);
        this.listeTuyaux.Add(this.tuyau.gameObject);
    }

    public void MouvementTuyaux()
    {
        this.tuyau.transform.Translate(-Time.deltaTime * this.vitesseBgMouvement, 0, 0, this.arriveeTuyaux.transform);
    }

    private IEnumerator Destruction()
    {
        yield return new WaitForSeconds(1f);
        if (this.listeTuyaux.Count > 1)
        {
            Destroy(this.listeTuyaux[this.index]);
            this.listeTuyaux.Remove(this.listeTuyaux[this.index]);
        }
    }

    private IEnumerator Start()
    {
        while (this.tuyau != false)
        {
            yield return this.StartCoroutine("Destruction");
        }
    }

    private void Update()
    {
        this.temps += Time.deltaTime;
        if (this.temps > 1f)
        {
            this.CreationTuyaux();
            this.temps = 0f;
        }

        this.MouvementTuyaux();
    }
}
