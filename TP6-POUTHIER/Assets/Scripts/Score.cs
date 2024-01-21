// <copyright file="Score.cs" company="elagmae">
// Copyright (c) elagmae. All rights reserved.
// </copyright>

using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField]
    private TextMeshProUGUI scoreUI;
    [SerializeField]
    private TextMeshProUGUI scoreFinal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.score++;
        this.scoreUI.text = this.score.ToString();
        this.scoreFinal.text = this.score.ToString();
    }
}
