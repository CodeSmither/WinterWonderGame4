using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    int delay = 0;
    GameObject a,b;
    public GameObject bullet,explosion;
    Rigidbody2D rb;
    public float speed;
    int health = 1;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        a = transform.Find("a").gameObject;
        b = transform.Find("b").gameObject;
    }

    void Start()
    {
        PlayerPrefs.SetInt("Health", health);
    }

    void Update()
    {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0));
        rb.AddForce(new Vector2(0,Input.GetAxis("Vertical") * speed));

        

    }

    public void Damage()
    {
        health--;
        PlayerPrefs.SetInt("Health", health);
        StartCoroutine(Blink());
        if (health == 0)
        {
            
            Destroy(gameObject, 0.1f);
        }
    }

    IEnumerator Blink()
    {
        GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
        yield return new WaitForSeconds(0.2f);
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }

    public void AddHealth()
    {
        health++;
        PlayerPrefs.SetInt("Health", health);
    }
}
