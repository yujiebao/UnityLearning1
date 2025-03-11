using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Transfrom 主要用来干什么
        //游戏对象(Gameobiect)位移、旋转、缩放、父子关系、坐标转换等相关操作都由它处理
        //它是unity提供的极其重要的类
        #endregion
    
        #region 知识点一 必备知识点 Vector3基础
        //Vector3主要是用来表示三维坐标系中的一个点 或者一向量
        //申明
        Vector3 v = new Vector3(1.2f,2,3);  //只传两个默认z为0
        
        //Vector的基本计算
        //+ - * /
        Vector3 v1 = new Vector3(1,2,3);
        Vector3 v2 = new Vector3(4,5,6);
        Vector3 v3 = v1 + v2;  //也可以 - * /
        print(v3);
        
        //常用
        print(Vector3.zero);
        print(Vector3.one);
        print(Vector3.up);  // 010    由左手系可以确定

        //计算两个点之间的距离
        print(Vector3.Distance(v1,v2));
        #endregion
    
        #region 知识点二 位置
        // 相对世界坐标
        //相对于世界坐标系的位置可能与面板不一致  因为如果对象有父子关系 并且父对象位置 不在原点 那么 和面板上肯定就是不一样的
        print(this.transform.position);  
        
        // 相对父对象
        //这两个坐标 对于我们来说 很重要 如果你想以面板坐标为准来进行位置设置
        //那一定是通过1ocalPosition来进行设置的
        print(this.transform.localPosition);      
        
        // 对象当前的各朝向
        print(this.transform.forward);  //对象当前的面朝向
        print(this.transform.right);   //对象当前的右朝向
        print(this.transform.up);    //对象当前的头顶朝向

        // 注意：位置的赋值不能直接改变x,y,z只能整体更改   不能单独改x y z 值
        #endregion
    
       
    }

    // Update is called once per frame
    void Update()
    {
        #region 位移
        //理解坐标系下的位移计算公式
        //路程 =方向*速度*时间
        
        //方式一  自己计算 
        //想要变化的 就是 position
        //用当前的位置 + 我要动多长距离  得出最终所在的位置
        this.transform.position += this.transform.forward * 1 * Time.deltaTime;    //this.transform.forward----自己的前面   vector3.forward----世界坐标下的前面

        //方式二调用API
        // 参数一:表示位移多少
        // 参数二:表示 相对坐标系 

        //相对于世界坐标系的Z轴 进行位移  始终是朝向世界坐标系的Z轴进行位移
        // this.transform.Translate(Vector3.forward*1, Space.World);

        //相对于世界坐标系 自己的面朝向去动   朝向自己的面朝向
        // this.transform.Translate(this.transform.forward * 1, Space.World);
        
        // 相对于自己的坐标系 自己面朝向进行位移   (一定不会这样让物体移动)
        // this.transform.Translate(this.transform.forward * 1, Space.Self);

        // 相对于自己的坐标系 下的Z轴的正方向移动  始终朝向自己的面朝向移动
        // this.transform.Translate(Vector3.forward * 1, Space.Self);
        // 注意：一般使用API来进行位移
        #endregion
    }
}
