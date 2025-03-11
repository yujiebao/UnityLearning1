using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 缩放
        print(transform.lossyScale);   //相对于世界坐标  不能改
        print(transform.localScale);  //相对于本地坐标(父对象)

        // 注意：
        //1.同样缩放不能只改xyz  只能一起改(相对于世界坐标系的缩放大小只能得 不能改)
        //所以 我们一般要修改缩放大小 都是改的 相对于父对象的 缩放大小 1ocalscale
        // this.transform.localScale = new Vector3(2,2,2);

        //2.Unity没有提供关于缩放的API
        //之前的 旋转 位移 都提供了 对应的 API 但是 缩放并没有
        //如果你想要 让 缩放 发生变化 只能自己去写 (自己计算)  
        // transform.localScale += new Vector3(0.1f,0.1f,0.1f)*Time.deltaTime; 
        #endregion
    
        #region 知识点二 看向
        //看向一个点 相对于世界坐标系的
        //让一个对象的面朝向 可以一直看向某一个点或者某一个对象
        // this.transform.LookAt(new Vector3(0,0,0));

        //看向一个对象
        // this.transform.LookAt(obj.transform);    具有传入对象transform的重载
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
