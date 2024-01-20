using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreUI;

    private void ChangeScore()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreUI.text=score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
