using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson19 : MonoBehaviour
{
    private AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 获取设备麦克风信息
        string[] a = Microphone.devices;  //得到所有的麦克风设备
        foreach(string s in a)
        {
            Debug.Log(s);
        }
        #endregion
    
        #region 知识点四 获取音频数据用于存储或者传输
        //规则 用于存储数组数据的长度 是用 声道数 *剪辑长度
        float[] f = new float[audioClip.channels*audioClip.samples];
        audioClip.GetData(f,0);   //将音频数据存储到数组中
        print(f.Length);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点二 开始录制
        //参数一:设备名 传空使用默认设备
        //参数二:超过录制长度后 是否重头录制
        //参数三:录制时长
        //参数四:采样率

        if(Input.GetKeyDown(KeyCode.Space))
        {
            audioClip =  Microphone.Start(null, false, 10, 44100);
        }
        #endregion        
        #region 知识点三 结束录制
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Microphone.End(null);
            AudioSource s =  gameObject.GetComponent<AudioSource>();
            if(s == null)
            {
                s = gameObject.AddComponent<AudioSource>();
            }
            s.clip = audioClip; 
            s.Play();
        }
        #endregion
    }
}
