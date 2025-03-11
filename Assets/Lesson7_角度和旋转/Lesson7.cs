using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 角度相关
        //相对世界坐标的角度
        print(transform.eulerAngles);

        //相对父对象的角度
        print(transform.localEulerAngles);

        //注意:设置角度和设置位置一样 不能单独设置xyz 要一起设置
        #endregion
    
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点二 旋转相关
        //自己计算
        //-----

        //API
        //自转 
        //第一个参数 相当于 是旋转的角度 每一帧
        //第二个参数 默认不填 就是相对于自己坐标系 进行的旋转
        this.transform.Rotate(Vector3.up * 1 * Time.deltaTime);

        // this.transform.Rotate(Vector3.up * 1 * Time.deltaTime,Space.World);   世界坐标系

        // this.transform.Rotate(Vector3.up,10*Time.deltaTime,Space.Self);  //三个参数的  第一个围绕的轴 第二个旋转的角度 第三个是空间类型

        //围绕一个点转
        // transform.RotateAround(Vector3.zero,Vector3.up,10*Time.deltaTime);  //参数一 围绕的点 参数二 围绕的轴 参数三 旋转的角度
        #endregion
    }
}
