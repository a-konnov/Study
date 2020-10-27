using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;

public class LevelGrid : MonoBehaviour
{
    private Vector2Int foodGridPosition;
    private int width;
    private int height;
    [SerializeField] public GameObject _food;

   
    public void Init() {
        width = 20;
        height = 20;

    }
    private void SpawnFood() {
        foodGridPosition = new Vector2Int(Random.Range(0, width), Random.Range(0, height));
        Instantiate(_food, new Vector3(foodGridPosition.x, foodGridPosition.y), Quaternion.identity);
        
    }
}
