using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
    public int total_item_cnt;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;

    private void Awake()
    {
        stageCountText.text = "/ "+ total_item_cnt;
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }
    }

}
