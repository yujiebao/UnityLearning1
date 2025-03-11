using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 获取和设置父对象
        //获取父对象
        print(transform.parent.name);
        //设置父对象 断绝父子关系
        transform.parent = null;
        //设置父对象 认爸爸
        // transform.parent = GameObject.Find("Father2").transform;

        //通过API来进行父子关系的设置
        this.transform.SetParent(null);
        this.transform.SetParent(GameObject.Find("Father2").transform);
        //参数一 为父对象 参数二 为是否保持相对位置
        this.transform.SetParent(GameObject.Find("Father3").transform, true);  //true 保持世界坐标中的信息，计算新的信息   false保持本地坐标中的信息(相对父对象)不计算
        #endregion
    
        #region  知识点二 抛妻弃子
        // this.transform.DetachChildren();
        #endregion
   
        #region 知识点三 获取子对象
        //按名字找儿子   只能找儿子  不能找孙子...
        Transform obj = transform.Find("Son");     //能找到失活的对象
        
        print(this.transform.childCount);  // 只找儿子
        //通过索引号 去得到自己对应的儿子
        //如果编号 超出了儿子数量的范围 那会直接报错的
        this.transform.GetChild(0);
        //遍历儿子
        foreach (Transform son in transform)
        {
            print(son.name);
        }
        #endregion
   
        #region 知识点四 儿子的操作
        //判断爸爸是谁
        print(obj.IsChildOf(this.transform)?"是爸爸的子对象":"不是爸爸的子对象");

        //得到自己作为儿子的编号
        print(obj.GetSiblingIndex());

        //把自己设置为第一个儿子
        obj.SetAsFirstSibling();

        //把自己设置为最后一个儿子
        obj.SetAsLastSibling();

        //把自己设置为兄弟中指定位置   //溢出时候默认最后一个（小和大都是最后一个）
        obj.SetSiblingIndex(transform.childCount - 2);
        #endregion
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
