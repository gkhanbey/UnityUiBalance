using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiBallance : MonoBehaviour
{
    
    private int coinVarsayilan = 1;
 
    public Text coinText; // UI Text nesnesi


    public Button coinartir;
    public Button coinazalt;
   
    

    void Start()
    {
        // "coin" adlı bilgi daha önce kaydedilmiş mi diye kontrol ediyoruz.
        if (!PlayerPrefs.HasKey("coin"))
        {
            // "coin" adlı bilgi kaydedilmemişse, varsayılan değer olan 1 kaydediliyor.
            PlayerPrefs.SetInt("coin", coinVarsayilan);
            PlayerPrefs.Save();
            }
    int coin = PlayerPrefs.GetInt("coin");

    Debug.Log("Test:" + coin);


    // coin stringe cevirip CoinText ekranda gözükmesi için değer atanır.
    coinText.text = "Coin Miktarı: "+coin.ToString();


    coinartir.onClick.AddListener(coinartirma);


    coinazalt.onClick.AddListener(coinazaltma);
    }
void coinartirma()
    {
        int coin = PlayerPrefs.GetInt("coin");
        coin += 200;

        PlayerPrefs.SetInt("coin", coin);
        PlayerPrefs.Save();

        coinText.text = "Coin Miktarı: "+coin.ToString();



    }

void coinazaltma()
    {
        int coin = PlayerPrefs.GetInt("coin");
        coin -= 200;

        PlayerPrefs.SetInt("coin", coin);
        PlayerPrefs.Save();

        coinText.text = "Coin Miktarı: "+coin.ToString();



    }





}
