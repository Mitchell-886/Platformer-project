using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHP : MonoBehaviour
{
    public int health = 50;
    public Text HP;
    public Slider Healthslider;
    public int lives = 0;

    //public void SavePlayer ()
    //{
    //    SaveSystem.SavePlayer(this);
   // }

    //public void LoadPlayer ()
   // {
    //    PlayerData data = SaveSystem.LoadPlayer();

        //level = data.Level;
    //    health = data.Health;

   //     Vector3 position;
   //     position.x = data.position[0];
   //     position.y = data.position[1];
   //     position.z = data.position[2];
   //     transform.position = position;
   // }

    private void Start()
    {
        HP.text = "Health: " + health;
        Healthslider.maxValue = health;
        Healthslider.value = health;
        lives = PlayerPrefs.GetInt("lives");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            {
                health = health - 3;
                HP.text = "Health: " + health;
                Healthslider.value = health;
                if (health < 1)
                {
                    {
                        SceneManager.LoadScene("Death");
                    }
                }
            }
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            HP.text = "Health: " + health;
            Healthslider.value = health;
            if (health < 1)
            { 
                {
                    SceneManager.LoadScene("Death");
                }   
            }
        }
        if (collision.gameObject.tag == "Spike")
        {
            health = health - 10;
            if (health < 1)
            {
                {
                    SceneManager.LoadScene("Death");
                }
            }
        }
    }
    //private void OnCollisionExit2D(Collision2D collision)
  // {
      //  if (collision.gameObject.tag == "")
      //  {

      //  }
   // }
}

    
