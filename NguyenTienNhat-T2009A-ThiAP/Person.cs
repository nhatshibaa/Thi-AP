using System;

namespace NguyenTienNhat_T2009A_ThiAP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Show()
        {
            Console.WriteLine($"Person details - Name = {Name}, Age = {Age}");
            Console.WriteLine($"Person details (After incrementing age) - Name = {Name}, Age = {Age+1}");
        }
    }
}