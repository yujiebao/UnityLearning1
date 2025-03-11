using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 3D碰撞器的种类
        //盒状
        //球状
        //胶囊体
        //网格  不常用  性能消耗大   精确  加刚体必须凹面(Convex)
        //轮胎  不常用  相关游戏少  环形碰撞器
        //地形  不常用  性能消耗大
        #endregion
    
        #region 共同的参数
        // 是触发器   如果启用此属性则该碰撞体将用于触发事件，并被物理引擎忽略主要用于进行没有物理效果的碰撞检测
        //材质(Material)  物理材质 确定碰撞体和其他对象碰撞的交互(表现)方式   
        //Center 碰撞体在对象局部空间中的中心点位置   改变产生体积效果的位置
        #endregion

        #region 异形物体可以通过组合的形式创建出各种形状的碰撞体
        //父对象碰撞体是父对象碰撞体和所有子对象的碰撞体
        //所以可以通过给对象推荐子对象来构建复杂的碰撞体(空对象也可以加碰撞体)
        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
