using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        #region 世界坐标转本地坐标
        //可以转换为本地坐标判断相对位置
         print(Vector3.forward);
         print("世界转本地");
        //世界坐标系的点 转换 为相对本地坐标系的点
        //受缩放的影响
        print("装换后的点"+this.transform.InverseTransformPoint(Vector3.forward));

        //世界坐标系的方向 转换 为相对本地坐标系的方向
            //1.不受缩放的影响
            print("装换后的方向(不受缩放影响)"+this.transform.InverseTransformDirection(Vector3.forward));
            //2.受缩放影响
            print("转换后的方向(受缩放影响)"+this.transform.InverseTransformVector(Vector3.forward));

        #endregion

        #region 本地坐标转世界坐标
        print("本地转世界");
        //本地坐标系的点 转换 为相对世界坐标系的点
        //受缩放的影响
        print("装换后的点"+this.transform.TransformPoint(Vector3.forward));

        //本地坐标系的方向 转换 为相对世界坐标系的方向
            //1.不受缩放的影响
            print("转换后的方向(不受缩放影响)"+this.transform.TransformDirection(Vector3.forward));
            //2.受缩放影响
            print("转换后的方向(受缩放影响)"+this.transform.TransformVector(Vector3.forward));
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
