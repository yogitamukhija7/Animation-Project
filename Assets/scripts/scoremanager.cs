using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {
    public static int score;
    public AudioClip x;
    public AudioSource y;
	    
   // public GameObject GameOver;
    public Text Score;
    // Use this for initialization
	void Awake () {
        score = 0;
        Score.text = ("Score : " + score);
        y = GetComponent<AudioSource>();
       
        setcount();
	}
	
	/* Update is called once per frame
	public void AddPoints(int pointScored) {
        score += pointScored;
        Score.text = ("Score:" + score);

	}*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coins"))
        {
            y.PlayOneShot(x, 1F);
        
            score++;
            setcount();

        }
    }
    void setcount()
    {
        Score.text = "Score:" + score.ToString();

    }

}
