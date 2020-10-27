using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
   [SerializeField] private LevelGrid levelGrid;
    void Start()
    {
        Debug.Log("GameStart");
        levelGrid.Init();
    }
}
