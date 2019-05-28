using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject greyOb;
    public GameObject whiteOb;
    public GameObject blackOb;
    public Score spawnerShifter;
    public Transform spawnPosition;
    public int tempSpeed = -15;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("MyCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MyCoroutine ()
    {
        while(true)
        {
            //Debug.Log(velocity);
            if (spawnerShifter.GetScore()>30 && spawnerShifter.GetScore()<39)
            {
                spawnPosition.position = new Vector3 (25.45f,11.17f,0f);
            }
            else if (spawnerShifter.GetScore()>10 && spawnerShifter.GetScore()<19)
            {
                spawnPosition.position = new Vector3 (25.45f,11.17f,0f);
            }
            else
            {
                spawnPosition.position = new Vector3 (25.45f,6.89f,0f);
            }

            int y = Random.Range(1,4);
            if (y==1)
            {
                UpdateSpeed(tempSpeed);
                GameObject obstacle1 = Instantiate (greyOb, spawnPosition.position,Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
            if (y==2)
            {
                UpdateSpeed(tempSpeed);
                GameObject obstacle2 = Instantiate (blackOb, spawnPosition.position,Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
            if (y==3)
            {
                UpdateSpeed(tempSpeed);
                GameObject obstacle3 = Instantiate (whiteOb, spawnPosition.position,Quaternion.identity);            
                yield return new WaitForSeconds(1f);
            }
        }
    }

    public void UpdateSpeed(int newSpeed)
    {
        tempSpeed = newSpeed;
        greyOb.GetComponent<ObstacleBehaviour>().speed=newSpeed;
        blackOb.GetComponent<ObstacleBehaviour>().speed=newSpeed;
        whiteOb.GetComponent<ObstacleBehaviour>().speed=newSpeed;
    }
}
