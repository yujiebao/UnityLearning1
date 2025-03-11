using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson18 : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        #region 知识点三 如何动态控制音效播放
        //1.直接在要播放的对象上挂载脚本 控制播放

        // 2.实例化挂载音效脚本的对象
        //这种方法用的少   每次都要实例化对象  要管理对象

        //3.用一个audio source来控制播放不同的音效          ----------一个对象可以挂在多个audiosource
        //新添加一个audiosource  再为audiosource添加audio clip
        // AudioSource aus = this.gameObject.AddComponent<AudioSource>();
        // aus.clip = clip资源;
        // aus.Play();
        #endregion
       
    }

    // Update is called once per frame
    void Update()
    {
         #region 知识点一 代码控制播放停止
        if(Input.GetKeyDown(KeyCode.P))
        {
            // 播放
            audioSource.Play(10);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            //播放
            audioSource.Stop();    
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //暂停    
            audioSource.Pause();  
            //  audioSource.UnPause();    --> 恢复播放和播放play一样
        }
        #endregion
    
        #region 知识点二 如何检测播放完毕
        //如果你希望某一个音效播放完毕后 想要做什么事情不停的去检测 它的 该属性
        //那就可以在update生命周期函数中
        //如果是false就代表播放完毕
        if(audioSource.isPlaying)
        {
            //播放中
        }

        #endregion
    }
}
