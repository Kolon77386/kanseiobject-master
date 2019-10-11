using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class kipputext : MonoBehaviour
{
    public TextMeshPro Jyousyaeki;
    public TextMeshPro Kara;
    public TextMeshPro Kukan;
    public TextMeshPro Hiduke;
    public TextMeshPro Jikoku;
    public GameObject Ana;

    public TMP_FontAsset hankaku;

    string ZerotoO(string txt)
    {
        string text = txt.Replace("0", "O");
        txt = text;
        return (text);
    }
    void KippuPrint()
    {
        Hiduke.text = System.DateTime.Now.Year.ToString("0000")
            + "." + System.DateTime.Now.Month.ToString("00")
            + "." + System.DateTime.Now.Day.ToString("00");
        Hiduke.text = "<mspace=0.46em>" + ZerotoO(Hiduke.text);
        Jikoku.text = Random.Range(0, 10000).ToString("0000")+" "
            + System.DateTime.Now.Hour.ToString("00")
            + ":" + System.DateTime.Now.Minute.ToString("00");
        Jikoku.text = "<mspace=0.46em>" + ZerotoO(Jikoku.text);
    }
    // Start is called before the first frame update
    void Start()
    {
        Jyousyaeki.text = "国会議事堂前";//テキストアセットから取得
        Kukan.text = "250";//テキストアセットから取得
        if (Jyousyaeki.text == "国会議事堂前")
        {
            Jyousyaeki.text = "<mspace=0.42em>" + "国会議事堂前";
            Jyousyaeki.font = hankaku;
            Vector3 Karapos = Kara.transform.localPosition;
            Karapos.x = 0.0315f;
            Kara.transform.localPosition = Karapos;
            Vector3 Kukanpos = Kukan.transform.localPosition;
            Kukanpos.x = 0.0405f;
            Kukan.transform.localPosition = Kukanpos;
        }
    }
    bool kippufind=true;
    bool WillRide = true;
    // Update is called once per frame
    void Update()
    {
        if(kippufind)//切符を見つけたフラグが立つ
        {
            KippuPrint();
            kippufind = false;
            if(WillRide)
            {
                Ana.SetActive(true);
            }
        }
    }
}
