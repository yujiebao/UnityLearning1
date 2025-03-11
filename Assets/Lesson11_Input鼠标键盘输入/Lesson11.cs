using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 注意:输入相关内容肯定是写在update中
        
        #region 知识点一 检测鼠标在屏幕上的位置
        //屏幕坐标的原点是在屏幕的画布左下角   右为X正 上为Y正
        // print(Input.mousePosition);
        #endregion

        #region 知识点二 检测鼠标输入
        //鼠标按下一瞬间 进入
        //只用按下的这一瞬间 进入一次 
        if(Input.GetMouseButtonDown(0))   //0 代表鼠标左键   1代表鼠标右键   2代表鼠标中键
        {
            print("鼠标左键按下");
        }

        //鼠标抬起一瞬间 进入
        if(Input.GetMouseButtonUp(0))
        {
            print("鼠标左键抬起");
        }
        
        // 检测鼠标是否按着
        if(Input.GetMouseButton(1))
        {
            print("鼠标右键按着");
        }

        //中建滚动
        //返回值 y -1是下 0 1是上
        //它的返回值 是vector的值 我们鼠标中键滚动 会改变其中的Y值
        print(Input.mouseScrollDelta);
        #endregion 
    
        #region 知识点三 检测键盘输入
        //检测键盘是否按下
        // if(Input.GetKeyDown("a"))  //注意要小写
        if(Input.GetKeyDown(KeyCode.A))

        {
            print("按下了A");
        }

        //检测键盘是否抬起
        if(Input.GetKeyUp(KeyCode.A))
        {
            print("抬起了A");
        }

        //检测键盘是否按着
        if(Input.GetKey(KeyCode.A))
        {
            print("按着A");
        }
        #endregion
   
        #region 知识点四  检测默认轴输入   (-1  1)之间的数
        if(Input.GetAxis("Horizontal") > 0)
        {
            print("向右");
        }
        // Horizontal 默认轴是水平轴   键盘
        //Vertical 默认轴是垂直轴       键盘
        //Mouse X  鼠标水平轴   鼠标
        //Mouse Y  鼠标垂直轴   鼠标

        //GetAxisRaw()和GetAxis()使用方法相同
        //只不过 它的返回值 只会是 -1 0 1 不会有中间值
        #endregion
    
        #region 其他
        if(Input.anyKey)
        {
            // 如果有任何键被持续按下，则进入此条件
            print("至少有一个键被按着");
        }
        if(Input.anyKeyDown)
        {
            // 如果有任何键在这一帧被按下，则进入此条件
            print("至少有一个键被按下");
        }
        // 输出自上一帧以来输入的字符串（通常用于文本输入）
        print(Input.inputString);

        //手柄相关
        //得到连接的手柄的所有按钮的名字
        string[] array = Input.GetJoystickNames();
        //某个按钮是否被按下
        if(Input.GetButtonDown("Fire1"))
        {
               print("按下了Fire1");
        }
        //某个按钮是否被抬起
        if(Input.GetButtonUp("Fire1"))
        {
               print("抬起了Fire1");
        }
        //某个按钮是否按着
        if(Input.GetButton("Fire1"))
        {
               print("按着Fire1");
        }

        //移动设备触摸相关
        if(Input.touchCount > 0)
        {
            Touch t1 = Input.GetTouch(0);

            //位置
            print(t1.position);
            //相对上次位置的偏移量
            print(t1.deltaPosition);
        }
        // Input.multiTouchEnabled = true; //是否启用多点触控

        //陀螺仪(重力感应)
        //是否开启陀螺仪 必须开启 才能正常使用
        
        //重力加速度向量
        // print(Input.gyro.gravity);

        //旋转速度
        // print(Input.gyro.rotationRate);
        
        //陀螺仪 当前的旋转四元数
        //比如 用这个角度信息来控制场景上的一个3D物体受到重力影响
        //手机怎么动 它怎么动
        // print(Input.gyro.attitude);
        #endregion
    }
}
