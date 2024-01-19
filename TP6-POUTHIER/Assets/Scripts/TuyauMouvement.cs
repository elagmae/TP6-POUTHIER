using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class TuyauMouvement : MonoBehaviour
{
    [SerializeField] private float _vitesseBgMouvement;
    public GameObject Tuyau;
    public List<GameObject> ListeTuyaux;
    [SerializeField] private Vector2 PositionFin;
    private float temps;
    public GameObject ArriveeTuyaux;
    private int index = 0;
    public void CreationTuyaux()
    {
        float aleatoire = Random.Range(-2.0f,3.0f);
        Tuyau = Instantiate(Tuyau, new Vector2(6,aleatoire), Quaternion.identity);
        ListeTuyaux.Add(Tuyau.gameObject);
    }    

    public void MouvementTuyaux()
    {
        Tuyau.transform.Translate(-Time.deltaTime*_vitesseBgMouvement, 0, 0, ArriveeTuyaux.transform);
    }

    IEnumerator Destruction()
    {
        yield return new WaitForSeconds(2f);
        if (ListeTuyaux.Count>1) 
        {
            Destroy(ListeTuyaux[index]);            
            ListeTuyaux.Remove(ListeTuyaux[index]);
        }

    }

    IEnumerator Start()
    {
        while(Tuyau!=false)
        {
            yield return StartCoroutine("Destruction");
        }

    }

        private void Update()
    {   
    
        temps += Time.deltaTime;
        if (temps > 2f)
        {
            CreationTuyaux();              
            temps = 0f;
        }
        MouvementTuyaux();
    }

}
