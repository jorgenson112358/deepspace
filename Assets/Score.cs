using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Player player;

    // Update is called once per frame
    void Update()
    {
        decimal temp = (decimal)player.currentHullIntegrity / (decimal)player.maxHullIntegrity;
        int health = (int)(temp * 100);
        if (health > 100) {
            health = 100;
        }
        //Debug.Log(string.Format("Hull: {0}", health));

        GetComponent<TMP_Text>().SetText(string.Format("Hull Integrity: {0}%", health));
    }
}
