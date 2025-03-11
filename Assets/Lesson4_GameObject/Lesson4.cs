using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 Gameobject中的成员变量
        //名字
        print(this.gameObject.name);
        this.gameObject.name = "我是一个游戏物体";   //也会更改场景中的对象的名字  在结束游戏时又会再次改回来
        print(this.gameObject.name);
        //是否激活
        print(this.gameObject.activeSelf);
        //是否是静态、
        print(this.gameObject.isStatic);
        //层级
        print(this.gameObject.layer);
        //标签
        print(this.gameObject.tag);
        //transform
        print(this.gameObject.transform.position);    //和this.transform是一样的
        #endregion 
    
        #region 知识点二 Gameobject中的静态方法
         //创建自带几何体
        GameObject obj =  GameObject.CreatePrimitive(PrimitiveType.Cube);    //返回创建的Gameobject对象  可以获取他的组件
        obj.name = "我是一个立方体"; 
        
        //查找对象相关的知识
        //1.查找单个对象
        //通过对象名查找     ----只能找到激活的对象
        //存在多个对象的时候  无法确定找到的是谁
        //这个查找比较低下  在场景中的所有对象去查找
        // 没有找到就返回null
        GameObject obj2 = GameObject.Find("我是一个立方体");
        if(obj2 != null)
        {
            print(obj2.name);
        }
        //根据标签(Tag)查找     -----只能找到激活的对象
        //存在多个对象的时候  无法确定找到的是谁
        // GameObject obj3 = GameObject.FindWithTag("Player");
        GameObject obj3 = GameObject.FindGameObjectWithTag("Player");     //和上面的方法的功能是一样的
        if(obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("没找到");
        }

        //得到某一个单个对象 目前有2种方式了
        //(1).是public从外部面板拖 进行关联
        //(2).通过API去找
        
        //2.查找多个对象
        //找多个对象的API 只能是通过tag去找多个 通过名字 是没有找多个的方法的

        //通过tag找到多个对象    只能找激活对象
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");

        //还有几个查找对象相关是用的比较少的方法 是Gameobject父类 object提供的方法
        //引出额外知识点 unity中的object和c#中的万物之父的区别
        //unity里面的object 不是指的万物之父object
        //unity里的object 命名空间在unityEngine中的 object类 也是集成万物之父的一个自定义类
        //c#中的object 命名空间是在system中的

        //它可以找到场景中挂载的某一个脚本对象    效率低  两次遍历 ----- 1.遍历对象 2.遍历脚本
        Lesson4 o = GameObject.FindObjectOfType<Lesson4>();

        //实例化对象(克隆对象) 的方法
        //实例化(克隆)对象 它的作用 是根据一个Gameobject对象 创建出一个和它一模一样的对象
        GameObject.Instantiate(obj);

        //删除对象的方法
        GameObject.Destroy(obj,5);   //第二个代表延时时间
        //删除脚本
        // GameObject.Destroy(this);
        //删除对象有两种作用
        //1.是删除指定的一个游戏对象
        //2.是删除一个指定的脚本对象
        //注意:这个Destroy方法 不会马上移除对象 只是给这个对象加了一个移除标识一般情况下 它会在下一帧时把这个对象移除并从内存中移除

        //如果没有特殊需求 就是一定要马上移除一个对象的话
        //建议使用上面的 Destroy方法 因为 是异步的 降低卡顿的几率
        //下面这个方法 就是立即把对象 从内存中移除了
        GameObject.DestroyImmediate(obj);

        //过场景不移除
        //默认情况 在切换场景时 场景中对象都会被自动删除掉
        //如果你希望某个对象 过场最不被移除
        //下面这句代码 就是不想谁过场景被移除 就传谁
        //一般都是传 依附的Gameobject对象
        //比如下面这句代码的意思 就是自己依附的Gameobject对象 过场景不被删除
        DontDestroyOnLoad(this.gameObject);
        #endregion
    
        #region 知识点三 Gameobject中的成员方法
        //创建空物体
        GameObject obj4 = new GameObject();
        GameObject obj5 = new GameObject("我是一个空物体");
        GameObject obj6 = new GameObject("我是一个空物体",typeof(Lesson1));   //加脚本

        //为对象添加脚本
        //继承M0noBehavior的脚本 是不能够去new
        //如果想要动态的添加继承MonoBehavior的脚本 在某一个对象上
        //直接使用Game0biect提供的方法即可
        Lesson1 lesson1 = obj4.AddComponent<Lesson1>();
        //通过返回值 可以得到加入的脚本信息
        //来进行一些处理

        //得到脚本的成员方法 和继承Mono的类得到脚本的方法 一模一样
        obj4.GetComponent<Lesson1>();

        //标签比较
        //下面两种方法是一样的
        if(obj4.tag == "Player")
        {
            print("我是一个玩家");
        }
        if(obj4.CompareTag("Player"))
        {
            print("我是一个玩家");
        }

        //设置激活失活 
        obj4.SetActive(true);

        //不建议使用的
        //通知自己 执行什么行为
        //命令自己 去执行这个TestFun这个函数 会在自己身上挂载的所有脚本去找这个名字的函数
        //它会去找到 自己身上所有的脚本 有这个名字的函数去执行
        this.gameObject.SendMessage("TestFun",199);   //后面可以接参数
        //广播行为 让自己和自己的子对象执行
        this.gameObject.BroadcastMessage("TestFun",199);
        //向父对象和自己发送消息 并执行
        this.gameObject.SendMessageUpwards("TestFun",199);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
