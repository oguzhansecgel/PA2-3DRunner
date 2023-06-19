using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;
public class CollectCoin : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI coinText;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Çarpýþma");
        }
    }
    public void AddCoin()
    {
        score++;
        coinText.text ="Score : "+score.ToString();
    }
}
