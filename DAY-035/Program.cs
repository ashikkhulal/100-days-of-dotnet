using System;

public class Program
{
    public static void Main()
    {
        Owner owner = new Owner();
        owner.HomeARoom();
        owner.HomeBRoom();
    }
}

class HomeA : IHomeARoom
{
    public void HomeARoom()
    {
        Console.WriteLine("Implementation of HomeARoom method from IHomeARoom interface at class HomeA");
    }
}

interface IHomeARoom
{
    void HomeARoom() { }
}

class HomeB : IHomeBRoom
{
    public void HomeBRoom()
    {
        Console.WriteLine("Implementation of HomeBRoom method from IHomeBRoom interface at class HomeB");
    }
}

interface IHomeBRoom
{
    void HomeBRoom() { }
}

class Owner : IHomeARoom, IHomeBRoom
{
    HomeA homeA = new HomeA();
    HomeB homeB = new HomeB();

    public void HomeARoom()
    {
        homeA.HomeARoom();
    }

    public void HomeBRoom()
    {
        homeB.HomeBRoom();
    }
}