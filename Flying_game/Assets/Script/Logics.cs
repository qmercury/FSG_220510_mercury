using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logics : MonoBehaviour
{

    public enum PLAYER_DIR { NONE = 0, LEFT = 1, RIGHT = 2 };
    public PLAYER_DIR DIR = PLAYER_DIR.NONE;

    public GameObject player;

    public float speed = 10f;

    private static Logics instance = null;
    public static Logics Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance == null) instance = this;
    }

    private void FixedUpdate()
    {

        if (DIR == PLAYER_DIR.LEFT)
        {
            player.transform.position -= new Vector3(speed * Time.fixedDeltaTime, 0, 0);
        }
        else if (DIR == PLAYER_DIR.RIGHT)
        {
            player.transform.position += new Vector3(speed * Time.fixedDeltaTime, 0, 0);
        }

    }
}