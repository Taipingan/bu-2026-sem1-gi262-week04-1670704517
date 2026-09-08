using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
             LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> list = new List<string>();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Node 1");
            linkedList.AddLast("Node 2");
            linkedList.AddFirst("Node 0");
            PrintLinkedList(linkedList);
            
            LinkedListNode<string> firstNode = linkedList.First;
            //string firstNode2 = linkedList.First; เก็บข้อมูลเป็นโหนด
            Debug.Log("first: " + firstNode.Value);
            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("last: "+lastNode.Value);
            LinkedListNode<string> nodel1 = linkedList.Find("Node 1");
            Debug.Log("node: " +  nodel1.Value);
            Debug.Log(nodel1.Previous.Value);
            Debug.Log(nodel1.Next.Value);
            //Debug.Log(nodel1.Next.Next.Next.Next.Next.Next.Next.Next.Value);
            if (firstNode.Previous == null) { Debug.Log("firstNode.Previous is null"); }
            if (lastNode.Next == null) { Debug.Log("LastNode.Nexts is null"); }

            linkedList.AddAfter(nodel1,"Node 1.5");
            linkedList.AddBefore(nodel1, "Node 0.5");
            PrintLinkedList(linkedList);

            linkedList.RemoveFirst();
            PrintLinkedList(linkedList);
            linkedList.Remove("Node 2");//ถ้ามี Node2 มากกว่า1มันจะลบตัวแรกที่เจอห
            //linkedList.Remove(node1); ลบด้วยโหนด หรือ ค่าของตัวแปร
            PrintLinkedList(linkedList);
            linkedList.Clear();
            PrintLinkedList(linkedList);
        }
        void PrintLinkedList(LinkedList<string> linkedList)
        {
            Debug.Log("-----------linkedList-----------");
            foreach (string s in linkedList)
            {
                Debug.Log(s);
            }
        }
        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary[3] = "Cherry";//มีค่าเท่ากับ Add

            //Debug.Log(dictionary[4]);
            int keytocheck = 1;
            bool hasKey = dictionary.ContainsKey(keytocheck);
            Debug.Log($"has key {keytocheck}:{hasKey}");
            if (hasKey) { 
                Debug.Log(dictionary[keytocheck]);
            }
            foreach (int k in dictionary.Keys) { 
                Debug.Log(k);
            }
            foreach (string s in dictionary.Values){
                Debug.Log(s);
            }
            dictionary.Remove(1);
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
            dictionary.Clear();
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
        }

        #endregion
    }
}
