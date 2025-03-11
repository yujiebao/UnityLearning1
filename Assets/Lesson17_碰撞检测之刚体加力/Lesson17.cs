using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    new Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 刚体自带添加力的方法
        //1.获取刚体组件
        rigidbody = GetComponent<Rigidbody>();

        //2.施加力
        //相对世界坐标
        //世界坐标系  z轴方向加了一个力
        // rigidbody.AddForce(Vector3.forward * 1000);

        //相对本地坐标
        //本地坐标系  x轴方向加了一个力
        // rigidbody.AddRelativeForce(Vector3.forward * 1000);      //等价于 rigidbody.AddForce(transform.forward * 1000);

        //添加扭矩力
        //相对世界坐标
        // rigidbody.AddTorque(Vector3.up * 1000);

        //相对本地坐标
        // rigidbody.AddRelativeTorque(Vector3.up * 1000);

        //直接改变速度
        // rigidbody.velocity = Vector3.forward * 1000;   //相对于世界坐标  较少使用

        //模拟爆炸效果
        //效果只模拟该个体的爆炸效果  模拟爆炸效果的物体都要加脚本执行该方法
        // rigidbody.AddExplosionForce(1000, transform.position, 10);   //参数1：力  参数2：爆炸位置  参数3：爆炸范围

        #endregion
    
        #region 知识点二 力的几种模式
        //第二个参数 力的模式  主要作用就是计算方式不同
        rigidbody.AddForce(Vector3.forward * 1000, ForceMode.Acceleration);

        //1.Acceleration   加速度模式
        //给物体添加一个持续的加速度忽略其质量   m默认为1
        //Ft = mv     -----> v = Ft/m     (m =1)
        //x = vt

        //2.Force  力模式
        //给物体添加一个持续的加速度   与物体的质量有关  计算m
        //Ft = mv     -----> v = Ft/m 
        //x = vt

        //3.Impulse  脉冲模式
        //给物体添加一个瞬间的力，与物体的质量有关,忽略时间 默认为1
        //v = Ft/m
        //t默认为1
        //x = vt

        //4.VelocityChange  速度改变模式
        //给物体添加一个瞬时的速度 忽略质量  t = 1 , m = 1
        #endregion
    
        #region 补充 刚体休眠     ----一定条件下刚体不进行计算
        //刚体是否休眠
        if(rigidbody.IsSleeping())
        {
            //唤醒刚体
            rigidbody.WakeUp();
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
