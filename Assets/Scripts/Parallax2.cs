using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax2 : MonoBehaviour
{

    public float depth = 1;

    Player player;

    public void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }
    public void FixedUpdate()
    {
        float realVelocity = player.velocity.x / depth;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;

        if (pos.x <= -25)
            pos.x = 80;

        transform.position = pos;
    }
}
