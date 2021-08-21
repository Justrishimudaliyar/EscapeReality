using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    Player player;
    TextMeshProUGUI distanceText;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        distanceText = GameObject.Find("DistanceText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        int distance = Mathf.FloorToInt(player.distance);
        distanceText.text = distance + " m";
    }
}