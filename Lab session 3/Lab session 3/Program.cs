using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_session_3
{ class Student {
        public int no { set; get; }//create a private instance variable no and assign get and set method for it


      /*  public int MyProperty
        {
            get { return ()GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(), typeof(ownerclass), new PropertyMetadata(0));
            */

        private int  sid;
        public int id {
            //  set { _id = value; }
            get { return sid; } 
            //for single line  definition we can use arrow
            set => sid = value;
        }
    }
    class Program :pole,i
    {
       // static void Main(string[] args)
        //{
            // Student s = new Student() { id = 7 };//work for a public id
            //Student sw = new Student();
            //sw.id = 7;
            //Console.WriteLine(sw.id);
            //int a = sw.id;
           // circle c = new circle();
            //c.radius1 = 5;
            //Console.WriteLine("Area equals to "+c.calculateArea());
            //Console.WriteLine("Perimeter of this circle is "+c.calculatePerimeter());
           // Square s = new Square();
         //   s.length = 15;
           // s.width = 27;
      //     Console.WriteLine("Area equals to " + s.calculateArea());
    //        Console.WriteLine("Perimeter of this square is  " + s.calculatePerimeter());



        //}

        public int hy()
        {
            throw new NotImplementedException();
        }

        public override int john()
        {
            throw new NotImplementedException();
        }
    }
    //default is public for interfaces
    interface i{
         int hy();
    }

    public abstract class pole {
       public abstract int john();
    }
    //cannot be extended(be a base class) 
    sealed class oop { };

    
    }













