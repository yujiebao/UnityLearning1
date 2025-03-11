using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 刚体是碰撞产生的必要条件之一  两个物体至少要有一个有物理碰撞的物体才行
        //有刚体的物体能够受到力的作用
        #region 参数
        // 质量    ---单位kg   质量越大 惯性越大
        
        // 阻力    ---空气阻力  0---表示没有空气阻力
        
        //角阻力(扭矩阻力)    ---碰撞后旋转的阻力  0---表示没有
        
        // IsInvoking Kinematic    开启此选项  对象不会被物理引擎驱动  只能通过transform对齐操作   对于移动平台或者如果要动画化附加了HingeJoint等组件的刚体此组件非常有用  
        
        // 插值   在物理帧更新时间间隔大时  可以使用插值来使刚体物体移动平滑
        
        //碰撞检测(Collision Detection)
        //解决的问题:移动太快直接穿过物体而未进行碰撞检测
        //1.离散检测
        //2.持续检测
        //3.持续动态检测
        //4.持续推测检测(Continuous Speculative)

        //constraint  约束  约束是物理引擎的一个功能  约束是物理引擎对刚体的附加约束  ---位置和角度
       
        //info  调试参数  只读
        #endregion
    
        #region 补充
        // 物理相关计算受到物理帧更新的影响   
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
