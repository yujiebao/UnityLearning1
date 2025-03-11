using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    #region 知识点一 了解帧的概念
    //unity 底层已经帮助我们做好了死循环
    //我们需要学习unity的生命周期函数
    //利用它做好的规则来执行我们的游戏逻辑就行了
    #endregion

    #region 知识点二 生命周期函数的概念
    //所有继承MonoBehavior的脚本 最终都会挂载到Gameobject游戏对象上
    //生命周期函数 就是该脚本对象依附的Gameobject对象从出生到消亡整个生命周期中
    //会通过反射自动调用的一些特殊函数
    
    //unity帮助我们记录了一个Gameobject对象依附了哪些脚本
    //会自动的得到这些对象，通过反射去执行一些固定名字的函数
    #endregion

    #region 知识点三 生命周期函数
    //注意:
    //生命周期函数的访问修饰符一般为private和protected
    //因为不需要再外部自己调用生命周期函数 都是unity自己帮助我们调用的
    #endregion
    
    #region 知识点四 生命周期函数支持继承多态

    #endregion


    //出生时调用,类似构造函数 一个对象只会掉用一次
    //当对象(自己这个类对象)被创建时 才会调用该生命周期函数
    private void Awake() {
        //在unity中打印信息的两种方式
        //1.没有继承MonoBehavior类的时候
        Debug.Log("123");
        Debug.LogError("出错了!!!");
        Debug.LogWarning("警告!!!");
        //2.继承MonoBehavior类的时候
        print("123");
    }

    //依附的Gameobject对象每次激活时调用
    //对于我们来说 想要当一个对象被激活时 进行一些逻辑处理 就可以写在这个函数
    private void OnEnable() {
        print("OnEnable");
    }

    //从自己被创建出来后，第一次帧更新之前调用一个对象只会调用一次
    //主要作用还是用于初始化信息的 但是它相对Awake来说 要晚一点   因为它是在对象 进行第一次帧更新之前才会执行的
    private void Start() {
        print("Start");
    }

    //固定间隔时间执行，间隔时间可以设置
    //它主要是用于 进行物理更新
    //它是每一帧的执行的 但是 这里的帧 和游戏帧 有点不同
    private void FixedUpdate() {
        print("FixedUpdate");
    }

    //逻辑帧更新   每帧执行
    //主要用于处理游戏核心逻辑更新的函数
    private void Update() {
        
    }

    //每帧执行，于Update之后执行
    //一般这个更新是用来处理 摄像机位置更新相关内容的
    //Update和Lateupdate之间 unity进了一些处理 处理我们动画相关的更新
    private void LateUpdate() {
        
    }

    //依附的GameObject对象每次失活时调用
    private void OnDisable() {
        
    }

    //当对象被销毁时调用            销毁时候会先调用OnDisable  再调用OnDestroy
    private void OnDestroy() {
        
    }
}
