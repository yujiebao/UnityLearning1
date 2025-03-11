using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 获取重要静态成员
        //1.获取摄像机
        // 获取主摄像机
         print(Camera.main.name);   //通过这种方法快速获取摄像机，场景中必须有一个标签(tag)为MainCamera的摄像机。一般情况下只有一个主摄像机，多个也不会报错
        print(Camera.allCamerasCount);   // 获取摄像机的数量
        Camera[] allCameras = Camera.allCameras;    //获取所有的摄像机
        //2.渲染相关委托
        Camera.onPreCull += (c)=>{};//摄像机剔除前处理的函数
        Camera.onPreRender += (c)=>{};//摄像机渲染前处理的函数
        Camera.onPostRender += (c)=>{};//摄像机渲染后处理的函数
        #endregion
    
        #region 重要成员
        //1.界面上的参数  可以在Camera中获取到
        Camera.main.depth = 10;//获取相机的成员变量并修改(不是静态的是main相机的)   也可以获取其他的属性
        //2.世界坐标转屏幕坐标
        //转换后 x和y对应的就是屏幕坐标  z对应的是 这个3d物体离摄像机有多远
        Vector3 v =Camera.main.WorldToScreenPoint(this.transform.position);
        print("屏幕坐标"+v);
        //3.屏幕坐标转世界坐标
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //3.屏幕坐标转世界坐标
        print(Input.mousePosition);
        print(Camera.main.ScreenToWorldPoint(Input.mousePosition));   //ScreenToWorldPoint接受一个vector3参数，z代表与摄像机的距离，改变了z相当于摄像机前z距离的横截面
    }
}
