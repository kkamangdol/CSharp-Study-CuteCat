using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    // internal(class) = private(다른 곳에 using (class명) 넣으면 사용가능)
    public class Cat
    {

        public String Name;
        public int Age;

        private int Happiness = 50;


        public Cat(string name, int age)
        {
            //this 필수 헷갈리지않게
            this.Name = name;
            this.Age = age;  
        }

        // 아무것도 하지 않을 경우 10씩 감소
        public void GetBored()
        {
            Happiness = Happiness - 10;

            if(Happiness < 0)
               Happiness = 0;
        }

        //놀때
        public void Play()
        {
            Happiness = Happiness + 10;

            if (Happiness > 100)
                Happiness = 100;
        }

        //먹을때
        public void Eat()
        {
            Happiness = Happiness + 20;

            if (Happiness > 100)
                Happiness = 100;
        }

        // 메세지
        public string Express()
        {
            string message = "";

            if (Happiness >= 80)
                message = "I'm very happy.";
            else if (Happiness >= 60)
                message = "I'm happy.";
            else if (Happiness >= 40)
                message = "I'm so so.";
            else if (Happiness >= 20)
                message = "I'm gloomy.";
            else
                message = "I'm sad.";

            return this.Name + ": " + message;
        }
    }
}
