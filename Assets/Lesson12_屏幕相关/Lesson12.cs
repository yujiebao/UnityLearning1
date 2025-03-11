using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 静态属性
        #region 常用
        //当前屏幕分辨率
        Resolution r = Screen.currentResolution;
        print("当前分辨率为：" + r.width + "*" + r.height);

        //获取当前窗口的宽高
        //这得到的 是当前 窗口的 宽高 不是设备分辨率的宽高
        //一般写代码 要用窗口宽高 做计算时 就用他们
        print(Screen.width);
        print(Screen.height);

        //屏幕休眠模式
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        #endregion
        
        #region 不常用
        // 运行时是否全屏
        Screen.fullScreen = true;

        // 窗口模式
        // 独占全屏
        // Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        // 全屏窗口
        // Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        // 最大化窗口
        // Screen.fullScreenMode = FullScreenMode.MaximizedWindow;
        // 窗口模式 
        // Screen.fullScreenMode = FullScreenMode.Windowed;

        //移动设备旋转相关  了解就行
        // Screen.orientation = ScreenOrientation.LandscapeLeft;  // 横屏...还有其他的省略
        // //固定屏幕方向
        // Screen.autorotateToLandscapeLeft = true;
        #endregion
        #endregion
    
        #region 知识点二 静态方法
        //设置分辨率 一般移动设备不使用
        Screen.SetResolution(1920,1080,false);   //false 表示 不全屏
        #endregion    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
