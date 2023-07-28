using UnityEngine;
using UnityEngine.UI;

public class HullIntegritySlider : MonoBehaviour
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

       GetComponent<Slider>().value = health;
    }
}


