using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    #region 隐藏  显示
    //1.
    public int a ;
    [SerializeField]
    private aa aaclass;
    private int l;
    [SerializeField]  //序列化  显示私有成员
    private int b;

    [HideInInspector]   //隐藏
    public int c;
    //不能显示的   自定义类型变量   字典
    
    //2.显示自定义类型变量
    [System.Serializable]
    private class aa
    {
        public int  a;
        public int v;
    }
    #endregion
    
    #region 一些辅助特性
    //为成员分组
    //1.分组说明特性Header
    //Header特性
    //[Header("分组说明")]
    [Header("分组属性")]
    public int a1;
    public bool ax;

    //2.悬停注释Tooltip
    //为变量添加说明
    //[Tooltip(“说明内容")]
    [Tooltip("说明")] public int stop;

    //3.间隔特性 space()
    //让两个字段间出现间隔
    //[space()]
    [Space(50)]
    public int a2;

    //4.修饰数值的滑条范围Range
    //[Range(最小值，最大值)]
    [Range(0,100)]
    public int HP;

    //5.多行显示字符串 默认不写参数显示3行
    //写参数就是对应行
    //[Multiline(4)]
    [Multiline(4)]
    public string str;

    //6.滚动条显示字符串下
    //默认不写参数就是超过3行显示滚动条
    //[TextArea(3，4)]
    //最少显示3行，最多4行，超过4行就显示滚动条
    [TextArea(3,4)]
    public string str1;

    //7.为变量添加快捷方法 ContextMenuItem
    //参数1 显示按钮名
    //参数2 方法名 不能有参数
    //[contextMenuItem("显示按钮名"，“方法名")]
    [ContextMenuItem("显示排名","Show")]
    public int a3;
    
    //[contextMenu("测试函数")]
    //8.为方法添加特性能够在Inspector中执行
    [ContextMenu("测试函数")]
    void print()
    {
        print("123");
    }
    #endregion

    #region 总结
    //1.Inspector窗口中的变量关联的就是对象的成员变量，运行时改变他们就是在改变成员变量
    //2.拖曳到Gameobject对象后 再改变脚本中变量默认值 界面上不会改变
    //3.运行中修改的信息不会保存
    #endregion
    public void Show()
    {
        print(a3);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
