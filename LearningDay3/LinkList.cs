
using System.Collections;
/// <summary>
/// 链表实现
/// </summary>
namespace LearningDay3
{
    /// <summary>
    /// 链表节点
    /// 属性：节点值
    /// 字段：节点值，上级节点，下级节点
    /// 方法：获取节点值，设置节点值
    /// </summary>
    class ListNode
    {
        private int nodeValue;  //节点值
        public int NodeValue
        {
            get
            {
                return nodeValue;
            }
            set
            {
                nodeValue = value;
            }
        }

        public ListNode preNode;//上一级节点
        public ListNode nextNode;//下一级节点
    }

    /// <summary>
    /// 链表
    /// 字段：头结点，尾节点
    /// 方法：删除节点
    /// 要使链表可实现foreach循环，需继承接口System.Collections.IEnumerable中的GetEnumerator
    /// </summary>
    class LinkList : IEnumerable
    {
        public ListNode headNode;
        public ListNode taleNode;

        public ListNode AddLastNode (int value)
        {
            ListNode newNode = new ListNode();
            newNode.NodeValue = value;
            if (headNode == null)//若链表无节点，则新增节点为头结点
            {
                headNode = newNode;
                taleNode = newNode;
            }
            else//若链表当前有节点
            {
                ListNode tmp = taleNode;
                tmp.nextNode = newNode;
                newNode.preNode = tmp;
                taleNode = newNode;
            }
            return headNode;
        }

        public IEnumerator GetEnumerator ()
        {
            ListNode current = headNode;
            while (current != null)
            {
                yield return current.NodeValue;
                current = current.nextNode;
            }
        }
    }

    /// <summary>
    /// 泛型链表节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class ListNode<T>
    {
        private T nodeValue;
        public T NodeValue
        {
            get
            {
                return nodeValue;
            }
            set
            {
                nodeValue = value;
            }
        }
        public ListNode<T> preNode;
        public ListNode<T> nextNode;
    }
    /// <summary>
    /// 泛型链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkList<T> : IEnumerable
    {
        public ListNode<T> headNode;
        public ListNode<T> taleNode;

        public ListNode<T> AddLastNode (T value)
        {
            ListNode<T> newNode = new ListNode<T>();
            newNode.NodeValue = value;

            if (headNode == null)
            {
                headNode = newNode;
                taleNode = newNode;
            }
            else
            {
                ListNode<T> tmp = taleNode;
                tmp.nextNode = newNode;
                newNode.preNode = tmp;
                taleNode = newNode;
            }
            return headNode;
        }

        public IEnumerator GetEnumerator () //迭代器
        {
            ListNode<T> current = headNode;
            while (current != null)     //循环
            {
                yield return current.NodeValue;
                current = current.nextNode;
            }
        }
    }
}
