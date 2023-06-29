using System;
using System.Collections.Generic;
namespace GenericCS
{
    public class MyGeneric<T>{
        private T[] items;
        public T[]  Items { get { return items; } }
        public MyGeneric(int Size){
            items = new T[Size];
        }
        public T GetByIndex(int index){
            if(index < 0 || index >= items.Length){
                throw new InvalidOperationException();
            }else{
                return items[index];
            }
        }
        public void SetItemValue(int index, T value){
            if(index<0 || index >= items.Length){
                throw new InvalidOperationException();
            }else{
                items[index] = value;
            }
        }
    }
}