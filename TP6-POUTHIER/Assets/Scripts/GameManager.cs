using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject score = new GameObject("Score");
                instance = score.AddComponent<GameManager>();
                DontDestroyOnLoad(instance.gameObject);
            }

            return instance;
        }
    }
}
