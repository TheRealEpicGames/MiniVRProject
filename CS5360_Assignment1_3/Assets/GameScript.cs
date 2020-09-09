using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour {

    public List<GameObject> lights = new List<GameObject>();
    public float timer = 0;
    public GameObject text;
    int score = 0;

    // Use this for initialization
    void Start () {
        
	}

    public void Flush()
    {

        foreach (GameObject l in lights)
        {
            l.SetActive(false);
        }

        int rand = Random.Range(0, 3);

        lights[rand].SetActive(true);

        timer = 0;

        score++;

        text.GetComponent<TextMesh>().text = "Score: " + score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        
        if(timer >= 3.0)
        {
            foreach(GameObject l in lights)
            {
                l.SetActive(false);
            }

            int rand = Random.Range(0, 3);

            lights[rand].SetActive(true);

            timer = 0;
        }
	}
}
