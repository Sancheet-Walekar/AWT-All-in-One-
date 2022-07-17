using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //add this import statement
using System.Media;
//add this import statement

namespace Animal_Inheritance
{
    class Animal
    {
        //instance variables
        protected SoundPlayer p1;
        //protected PictureBox p2;
        protected string name;
        //get method
        public virtual void SetName()  //virtual keyword helps to reslove method at run time
        {
            this.name = "Animal";
        }
        public virtual String GetName()
        {
            return name;
        }
        public virtual void PlaySound()
        {
            p1 = new SoundPlayer(@"C:\Users\sanke\Desktop\PRACS\Shubham AWT\Animal_Inheritance\Animal_Inheritance\sounds\baboon_monkey.wav");
            p1.Play();
        }
        /* public virtual void PlayImage()
         {
             p2 = new PictureBox(@"D:\1222_.net\Animal_Inheritance\Animal_Inheritance\sounds\animal.jpg");
         }*/
        class Cat : Animal
        {
            public override void SetName()//override keyword need to be specify in override class for run-time reslove
            {
                name = "Cat";
            }
            public override void PlaySound()
            {
                p1 = new SoundPlayer(@"C:\Users\sanke\Desktop\PRACS\Shubham AWT\Animal_Inheritance\Animal_Inheritance\sounds\cat_y.wav");
                p1.Play();
            }
        }
        class Dog : Animal
        {
            public override void SetName()
            {
                name = "Dog";
            }
            public override void PlaySound()
            {
                p1 = new SoundPlayer(@"C:\Users\sanke\Desktop\PRACS\Shubham AWT\Animal_Inheritance\Animal_Inheritance\sounds\dog_bark4.wav");
                p1.Play();
            }
        }
        class Cow : Animal
        {
            public override void SetName()
            {
                name = "cow";
            }
            public override void PlaySound()
            {
                p1 = new SoundPlayer(@"C:\Users\sanke\Desktop\PRACS\Shubham AWT\Animal_Inheritance\Animal_Inheritance\sounds\cow3.wav");
                p1.Play();
            }
        }
    }
}
