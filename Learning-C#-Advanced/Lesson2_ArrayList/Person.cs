using System;
using System.Collections.Generic;
namespace ArrayList
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        /*Tạo 1 constructor có tham số để tiện cho việc khởi tạo nhanh 
        đối tượng Person với các giá trị cho sẵn*/
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        /*Override phương thức ToString() để khi cần có thể in thông tin của object*/
        public override string ToString()
        {
        return $"Tên: {Name}, Tuổi: {Age}";
        }
    }
}