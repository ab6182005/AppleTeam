using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    int coin = 0;
    public Text coinText;

    public void Start()
    {
        coinText.text = coin.ToString();
    }
    public void setCoin(int value)
    {
        coin += value;
        Showcoin();
    }

    public int getCoin()
    {
        return coin;
    }

    public void Showcoin()
    {

        coinText.text = coin.ToString();

    }
}
