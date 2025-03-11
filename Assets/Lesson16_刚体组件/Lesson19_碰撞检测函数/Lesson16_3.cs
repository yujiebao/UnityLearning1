using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16_3 : MonoBehaviour
{
    #region 碰撞和触发响应函数 属于 特殊的生命周期函数 也是通过反射调用
        // 碰撞检查函数是位于FixtUpdate和Update之间   碰撞检测函数的调用次数和物理引擎的帧率有关---->物理引擎的帧率
    #endregion

    #region 知识点一 物理碰撞检测响应函数
    //碰撞触发接触
    private void OnCollisionEnter(Collision other) {
        //包含了碰到的物体信息
        
        //相关参数
        // 1.碰撞对象的碰撞器
        // other.collider
        // 2.碰撞对象的依附对象
        // other.gameObject
        // 3.碰撞对象的依附对象的位置信息
        // other.transform.position
        // 4.碰撞点数相关
        // other.contactCount
        // 5.碰撞点信息
        // other.contacts[0].point
        print($"{this.name}被{other.gameObject.name}碰撞了");
    }
    //碰撞结束分离
    private void OnCollisionExit(Collision other) {
        print($"{this.name}和{other.gameObject.name}分离了");
    }
    //两个物体相互接触摩擦
    private void OnCollisionStay(Collision other) {
        print($"{this.name}和{other.gameObject.name}接触了");
    }
    #endregion
   
    #region 知识点二 触发器检测响应函数
    //主要处理没有物理效果的
    //触发开始的函数
    private void OnTriggerEnter(Collider other) {
        print($"{this.name}和{other.gameObject.name}触发了");
    }

    //触发结束的函数
    private void OnTriggerExit(Collider other) {
        print($"{this.name}和{other.gameObject.name}触发结束了");
    }

    //触发中的函数 水乳相融
    private void OnTriggerStay(Collider other) {
        print($"{this.name}和{other.gameObject.name}触发中");
    }
    #endregion
   
   #region  知识点三 触发条件、
   //1.只要挂载的对象 能和别的物体产生碰撞或者触发 那么对应的这6个函数 就能够被响应
   //2.6个函数不是说 我都得写 我们一般是根据需求来进行选择书写
   //3.如果是一个异形物体，刚体在父对象上，如果你想通过子对象上挂脚本检测碰撞是不行的 必须挂载到这个刚体父对象上才行
   //4.要明确 物理碰撞和触发器响应的区别
   #endregion
    
    #region 知识点四 碰撞和触发器函数都可以写成虚函数 在子类去重写逻辑
    //一般会把想要重写的 碰撞和触发函数 写成保护类型的 没有必要写成public  因为不会自己手动调用 
    //都是unity通过反射帮助我们自动调用的
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
