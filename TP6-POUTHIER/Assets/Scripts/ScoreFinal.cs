using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreFinal : MonoBehaviour
{
    public TextMeshProUGUI ScoreFinalUI;

    private void AffichageScore()
    {
        ScoreFinalUI.text = GameManager.Instance.score.ToString();
    }

    private void Start()
    {
        AffichageScore();
    }
}
