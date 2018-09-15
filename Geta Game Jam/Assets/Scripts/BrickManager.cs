using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BrickColor { Red, Blue }

public struct Brick
{
    public GameObject brick;
    public Vector2 position;
    public BrickColor color;
}

public class BrickManager : MonoBehaviour
{
    Brick[,] bricks = new Brick[27,27];

    [SerializeField]
    GameObject redBrick;
    
    private void Start()
    {
        SetupSpawning();
    }

    private void SetupSpawning()
    {

        for (int j = 0; j < 8; j++)
        {
            for (int i = 0; i < bricks.GetLength(0); i++)
            {
                Instantiate(redBrick, new Vector2(-8.33F + i * 0.64f, 4.8f - j * 0.327f), Quaternion.identity);
            }
        }
    }
}
