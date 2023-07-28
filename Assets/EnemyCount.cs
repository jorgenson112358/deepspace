using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    public MainController mainCtrl;

    private string tag = "EnemyShip";
    // Update is called once per frame
    void Update()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(tag);
        //Debug.Log(string.Format("Count: {0}", objs.Length));

        GetComponent<TMP_Text>().SetText(string.Format("Enemies: {0}", objs.Length));

        if (objs.Length == 0) {
            mainCtrl.MissionVictory();
        }
    }
}
