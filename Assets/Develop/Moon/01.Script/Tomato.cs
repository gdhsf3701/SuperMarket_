using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    public static Tomato Instance = null;
    public int Seed = 0;
    public int colaCount = 0;
    public bool invincible = false;
    public int hp = 1;
    private float _defaultSpeed;
    public float attackPower = 5;

    [SerializeField] Fire fire;
    public GameObject collison;
    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (!invincible || value == 101010)
            {
                if (hp - 1 <= 0)
                {
                    hp = 0;
                    GameOver();
                }
                else
                {
                    hp -= 1;
                }
            }
        }
    }
    public float defaultSpeed
    {
        get
        {
            return _defaultSpeed;
        }
        set
        {
            _defaultSpeed = value;
            GetComponent<PlayerMovement>().SpeedChange();
            GetComponent<CarMove>().SpeedChange();
            GetComponent<BalloonMove>().SpeedChange();
            GetComponent<AirMove>().SpeedChange();
            GetComponent<RobotMove>().SpeedChange();
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Seed = 0;
            colaCount = 0;
            invincible = false;
            collison = transform.Find("Collison").gameObject;
            _defaultSpeed = 5; 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SeedEvolution()
    {   
        fire.melon = true;
        Seed = 0;
        defaultSpeed *= 1.25f;
        attackPower *= 0.75f;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
    }
}
