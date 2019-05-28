using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public bool enter = true;
    public int speed;
    public ObstacleSpawn speedSetter;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
        speed=-15;
        scoreText.text="Score: "+score;        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public int GetScore()
    {
        return score;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        score++;
        scoreText.text="Score: "+score;
        if (score>36)
        {
            speed=-34;
        }
        else if (score>32)
        {
            speed=-30;
        }
        else if (score>27)
        {
            speed=-26;
        }
        else if (score>20)
        {
            speed=-24;
        }
        else if (score>17)
        {
            speed=-23;
        }
        else if (score>12)
        {
            speed=-21;
        }
        else if (score>7)
        {
            speed=-18;
        }          
        speedSetter.UpdateSpeed(speed);
    }

    void OnTriggerEnter2D(Collider2D strike)
    {
        
        if (enter)
        {
            score++;
            if (score>36)
            {
                speed=-34;
            }
            else if (score>32)
            {
                speed=-30;
        }
            if (score>27)
            {
                speed=-26;
            }
            else if (score>20)
            {
                speed=-24;
            }
            else if (score>17)
            {
                speed=-23;
            }
            else if (score>12)
            {
                speed=-21;
            }
            else if (score>7)
            {
                speed=-18;
            } 
        speedSetter.UpdateSpeed(speed);
        scoreText.text="Score: "+score;
        }
    }
}