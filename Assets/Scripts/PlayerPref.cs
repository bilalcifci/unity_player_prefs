using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPref : MonoBehaviour
{
    private GameObject panel;
    private Slider slider;

    public Text text_1;
    public Text text_2;
    public Text text_3;

    public InputField eleman_1;
    public InputField eleman_2;
    public InputField eleman_3;

    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("Panel (2)");
        slider = panel.transform.Find("Slider").GetComponent<Slider>();
        //slider.value = PlayerPrefs.GetFloat("saglik");
        slider_value(slider);


        //PlayerPrefs.SetInt("para_deger", 89);
        //PlayerPrefs.SetFloat("saglik", 44f);
        //PlayerPrefs.Save();
        //PlayerPrefs.SetString("ad", "Bilal");

        text_1.text = PlayerPrefs.GetInt("para_deger").ToString();
        text_2.text = PlayerPrefs.GetString("ad");
        text_3.text = PlayerPrefs.GetFloat("saglik").ToString();

        //Equals("para_deger", "saglik");

        //PlayerPrefs.DeleteAll();

        //PlayerPrefs.DeleteKey("saglik");
        //Debug.Log(PlayerPrefs.GetFloat("saglik").ToString());
        //text_3.text = PlayerPrefs.GetFloat("saglik").ToString();
        //if (PlayerPrefs.HasKey("para_deger"))
        //{
        //    Debug.Log("Evet var");
        //}
        //else
        //{
        //    Debug.Log("Hayir yok");
        //}

        //Debug.Log(PlayerPrefs.GetInt("para_deger").ToString());

        //PlayerPrefs.SetInt("para_deger", 10);
        //PlayerPrefs.SetInt("para_deger", PlayerPrefs.GetInt("para_deger") + 5);

        //Debug.Log(PlayerPrefs.GetInt("para_deger").ToString());
        //text_1.text = PlayerPrefs.GetInt("para_deger").ToString();

        //PlayerPrefs.SetInt("para_deger", 60); // key daha once sisteme eklenmis ise deger guncellenir
        //PlayerPrefs.SetInt("elmas_deger", 20); // key daha once sisteme eklenmemis ise key eklenerek deger atanir

    }
    public void veri_yaz()
    {
        PlayerPrefs.SetInt("para_deger", 89);
        PlayerPrefs.SetFloat("saglik", 44f);
        PlayerPrefs.SetString("ad", "Bilal");
        PlayerPrefs.Save();
        veri_guncelle();
    }
    private void veri_guncelle()
    {
        text_1.text = PlayerPrefs.GetInt("para_deger").ToString();
        text_2.text = PlayerPrefs.GetString("ad");
        text_3.text = PlayerPrefs.GetFloat("saglik").ToString();
    }
    public void yeni_veri_yaz()
    {
        if (eleman_1.text != "")
        {
            PlayerPrefs.SetInt("para_deger", int.Parse(eleman_1.text));
        }
        if (eleman_3.text != "")
        {
            PlayerPrefs.SetFloat("saglik", float.Parse(eleman_3.text));
        }
        if (eleman_2.text != "")
        {
            PlayerPrefs.SetString("ad", (eleman_2.text));
        }

        veri_guncelle();
        //text_1.text = PlayerPrefs.GetInt("para_deger").ToString();
        //text_2.text = PlayerPrefs.GetString("ad");
        //text_3.text = PlayerPrefs.GetFloat("saglik").ToString();
    }
    public void hepsini_sil()
    {
        PlayerPrefs.DeleteAll();
        veri_guncelle();
    }
    public void anlik_deger_guncelle(float deger)
    {
        PlayerPrefs.SetFloat("saglik", deger);
        veri_guncelle(); 
    }
    private void slider_value(Slider slider)
    {
        slider.value = PlayerPrefs.GetFloat("saglik");
    }
}
