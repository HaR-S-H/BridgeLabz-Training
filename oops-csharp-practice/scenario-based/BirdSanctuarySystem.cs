    using System;

    public interface IFlyable //interface declaration
    { 
        void Fly(); //method in base bird class
    }

    public interface ISwimmable
    { //interface declaration
       void Swim(); //mehtod  in base bird class
    }

    abstract class Bird
    {
        protected string _name; //private field we need to make geter and setter for this 

        public Bird(string _name)
        { //parameterized constructor
            this._name = _name;
        }
        public void DisplayInfo() //showing name of bird
        {
            Console.WriteLine("Name: " + _name);
        }
    }

    class Eagle : Bird, IFlyable //Eagle class inherits from Bird class and implements IFlyable interface
    {
        public Eagle(string _name) : base(_name) { } //parameterized constructor
        public void Fly()  //method which has to be override in base bird class
        {
            Console.WriteLine(_name + " is flying");
        }
    }
    class Sparrow:Bird,IFlyable //Sparrow class inherits from Bird class and implements IFlyable interface
    {
        public Sparrow(string _name) : base(_name) { } //parameterized constructor
        public  void Fly() //method which has to be override in base bird class
        {
            Console.WriteLine(_name + " is flying");
        }
    }
    class Duck : Bird, ISwimmable //Duck class inherits from Bird class and implements ISwimmable interface
    {
        public Duck(string _name) : base(_name) { } //parameterized constructor
        public  void Swim() //method which has to be override in base bird class
        {
            Console.WriteLine(_name + " is swimming");
        }
    }

    class Penguin : Bird, ISwimmable //Penguin class inherits from Bird class and implements ISwimmable interface
    {
        public Penguin(string _name) : base(_name) { } //parameterized constructor
        public void Swim() //method which has to be override in base bird class
        {
            Console.WriteLine(_name + " is swimming");
        }
    }

    class Seagull : Bird, IFlyable, ISwimmable //Seagull class inherits from Bird class and implements IFlyable interface
    {
        public Seagull(string _name) : base(_name) { } //parameterized constructor
        public  void Fly() //method which has to be override in base bird class
        {
            Console.WriteLine(_name + " is flying");
        }
        public  void Swim()
        {
            Console.WriteLine(_name + " is swimming");
        }
    }

    class Program
    {
        static void Main()
        {
            Bird[] birds = new Bird[]
            {
                new Eagle("Eagle"),
                new Sparrow("Sparrow"),
                new Duck("Duck"),
                new Penguin("Penguin"),
                new Seagull("Seagull")
            };

            foreach(Bird bird in birds)
            {
                bird.DisplayInfo();
            if (bird is IFlyable)
                {
                    ((IFlyable)bird).Fly();
                }
                if(bird is ISwimmable)
                {
                    ((ISwimmable)bird).Swim();
                }
            }
        }
    }