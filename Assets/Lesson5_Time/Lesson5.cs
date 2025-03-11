using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        #region Time相关内容主要用来干什么
        //时间相关内容 主要 用于游戏中参与位移、记时、时间暂停等 
        #endregion

        #region 知识点一 时间缩放比例
        //时间禁止
        // Time.timeScale = 0;
        //恢复正常
        // Time.timeScale = 1;
        //2倍速
        // Time.timeScale = 2;
        #endregion
    
        #region 知识点二 帧间隔时间
        //帧间隔时间 主要用来计算位移
        //路程=时间*速度
        //根据需求 选择参与计算的间隔时间
        //如果希望游戏暂停时就不动的 那就使用deltaTime
        //如果希望不受暂停影响 unscaledDeltaTime

        //帧间隔时间:最近的一帧 用了多长时间(秒)
        // Time.timeScale = 2;
        //受scale影响
        // print("帧间隔时间:"+Time.deltaTime);     //相当于不受影响的时间*timeScale
        //不受scale影响
        // print("帧间隔时间(不受scale影响):"+Time.unscaledDeltaTime);
        #endregion
    
        #region 知识点三 游戏开始到现在的时间
        //它主要用来计时 单机游戏中计时
        //受scale影响
        // print("游戏开始到现在的时间:"+Time.time);   
        //不受scale影响
        // print("游戏开始到现在的时间(不受scale影响):"+Time.unscaledTime);             
        #endregion
    
        #region 知识点五 帧数
        //从开始到现在游戏跑了多少帧(次循环)
        print(Time.frameCount);
        #endregion
    }
    void FixedUpdate()
    {
        #region 知识点四 物理帧间隔时间 FixedUpdate
        //受scale影响
        // print("物理帧间隔时间:"+Time.fixedDeltaTime);
        //不受scale影响
        // print("物理帧间隔时间(不受scale影响):"+Time.fixedUnscaledDeltaTime);
        #endregion
    }
}
