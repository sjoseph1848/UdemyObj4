//methods are ways of expressing behaviors in code
//what can the object do? 
//clouds can move East or West, Shrink or Grow 
using static System.Console;//needed to make use of the Console class and its writeline method
class Cloud//template for representing and making clouds 
{
    //introduce one instance variable to hold the length of one cloud=Abstraction
    //reduction of the world to just a few simple char is called abstraction
    private double length;

    public Cloud(double l)
    {
        length = l; //set the value of the length variable for each cloud object you make
    }
    //void keyword represents the fact an action is performed 
    //but no value is given back, going outside and yelling but nothing returned
    //name of method is Grow
    public void Grow()
    {
        //write code to define what it means for a cloud to grow
        WriteLine("I've grown!");//
    }
    public void Shrink()
    {
        WriteLine("I've shrunk!");
    }
}
class Test //class used for testing only 
{
    static void Main() //entry point into program 
    {
        Cloud cd = new Cloud(10); //declare and create a cloud object of length 10
        //name of object.name of method to be invoked on the object
        cd.Grow();//invoke grow on the cloud object or instance named cd 
        cd.Shrink(); //invoke shrink on the cloud object or instance named cd
        ReadKey();
    }
}

//1. add a method called shrink and code up the body of the method
//2. make sure to call the method on the object inside Main

