using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 重要成员
        print(this.gameObject.name);
        print(this.transform.position);    //this.gameObject.transform = this.transform;   做了一个封装
        this.enabled   = false;
        #endregion

        #region 重要方法
        //得到依附对象上挂载的其他脚本

        // 1.得到自己挂载的单个脚本
        //根据脚本名获取
        // Rigidbody a =  this.GetComponent("Rigidbody") as Rigidbody;    //里氏替换原则  很少用
        //根据Type的方式
        //Rigidbody a =  this.GetComponent(typeof(Rigidbody)) as Rigidbody;
        Rigidbody rb = this.GetComponent<Rigidbody>();
        //通过泛型获取 建议使用泛型获取 因为不用二次转换
        //只要你能得到场景中别的对象或者对象依附的脚本
        //那你就可以获取到它的所有信息  
        
        //2.得到自己挂载的多个脚本
        //多个脚本用得到单个脚本的方法不能确定得到的脚本是哪个
        //Lesson3[] array = this.GetComponents<Lesson3>();   
        List<Lesson3> list = new List<Lesson3>();
        this.GetComponents<Lesson3>(list);

        //3.得到子对象挂载的脚本(它默认也会找自己身上是否挂载该脚本)
        //函数是有一个参数的 默认不传 是fa1se 意思就是 如果子对象失活 是不会去找这个对象上是否有某个脚本的
        //如果传true 即使 失活 也会找
        this.GetComponentInChildren<Lesson3>(true);  
        // this.GetComponentsInChildren<Lesson3>(true);//多个

        //4.得到父对象挂载的脚本(它默认也会找自己身上是否挂载该脚本)   父对象父对象的父对象...一直找上去
        this.GetComponentInParent<Lesson3>();  //没有参数 不存在失活
        Lesson3[] lts = this.GetComponentsInParent<Lesson3>();

        //5.尝试获取脚本
        //提供了一个更加安全的 获取单个脚本的方法 如果得到了  会返回true
        //然后再来进行逻辑处理即可
        Lesson3  lesson3 = null;
        if(this.TryGetComponent<Lesson3>(out lesson3)){
        }
 
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
