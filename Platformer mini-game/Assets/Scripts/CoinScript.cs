using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public double scoreValue;
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            ScoreScript.scoreValue += 0.5;
            Destroy(gameObject);
        }
    }
}
