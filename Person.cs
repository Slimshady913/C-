using System;

public class Person {
    public string name;
    public int money;

    public Person(string _name) {
        name = _name;
        money = 1000000;
    }
    ~Person() {
        System.Console.WriteLine("Instance removed.");
    }

    public void pay(int new_money, Person money_obj) {
        this.money -= new_money;
        money_obj.money += new_money;
        System.Console.WriteLine(this.name + "이 " + money_obj.name + "에게 " + new_money + "원을 줬습니다.");
    }
}