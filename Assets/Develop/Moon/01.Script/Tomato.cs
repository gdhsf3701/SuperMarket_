using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tomato : MonoBehaviour
{
    public static Tomato Instance = null;
    private int seed;
    public int Seed 
    { get { return seed; } 
        set 
        {
            if (fire.melon)
            {
                if(value > 50)
                {
                    seed = 50;
                }
                else
                {
                    seed = value;
                }
            }
            else
            {
                if (value > 20)
                {
                    seed = 20;
                }
                else
                {
                    seed = value;
                }
            }
            ChangeUI(); 
        } 
    }
    public int colaCount = 0;
    public bool invincible = false;
    public int hp = 1;
    [SerializeField]private float _defaultSpeed;
    public float attackPower = 4;


    [SerializeField] Fire fire;
    public GameObject collison;

    [SerializeField]
    TMP_Text text;

    [SerializeField]
    GameObject gameOver;

    [SerializeField]
    Image itemUI;
    Vector3[] childTransformScale;
    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (!invincible || value == -101010)
            {
                if (hp - 1 <= 0)
                {
                    hp = 0;
                    GameOver();
                }
                else
                {
                    hp -= 1;
                    ScaleReset();
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
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        Seed = 0;
        colaCount = 0;
        invincible = false;
        defaultSpeed = 5;
        attackPower = 4;
        collison = transform.Find("Collison").gameObject;
        childTransformScale = new Vector3[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            childTransformScale[i] = transform.GetChild(i).localScale;
        }
    }
    public void SeedEvolution()
    {   
        fire.melon = true;
        Seed = 0;
        defaultSpeed *= 1.25f;
        attackPower = 3;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }
    public void ScaleReset()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).localScale = childTransformScale[i];
        }
    }
    private void ChangeUI()
    {
        text.text = $"³²Àº ¾¾¾Ñ:{Seed}";
        if (Seed <= 0)
        {
            itemUI.sprite = null;
        }
    }
}
