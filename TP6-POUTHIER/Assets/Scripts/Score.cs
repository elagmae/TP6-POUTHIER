// <copyright file="Score.cs" company="elagmae">
// Copyright (c) elagmae. All rights reserved.
// </copyright>

using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreUI;
    [SerializeField]
    private TextMeshProUGUI scoreFinal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.score++;
        this.scoreUI.text = GameManager.Instance.score.ToString();
        this.scoreFinal.text = GameManager.Instance.score.ToString();
    }
}
