namespace SL
{
    public class Person
    {
        public Person(){

        }
        /*Tạo 1 constructor có tham số để tiện cho việc khởi tạo nhanh 
        đối tượng Person với các giá trị cho sẵn*/
        public Person(string name, int age)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Age = age;
        }

        public string? Name { get; set; }
        public int Age { get; set; }

        // private string Name;
        // private int Age;
        // private string p;
        // private int p_2;
        // public string Name {
        //     get {
        //         return Name;
        //     }
        //     set{
        //         Name = value;
        //     }
        // }
        // public string Age {
        //     get {
        //         return Age;
        //     }
        //     set{
        //         Age = value;
        //     }
        // }
        /*Override phương thức ToString() để khi cần có thể in thông tin của object*/
        public override string ToString()
        {
            //return $"Tên: {Name}, Tuổi: {Age}";
            return Name + " - " + Age;
        }
    }
}