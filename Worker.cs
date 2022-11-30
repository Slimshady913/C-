using System;

class Worker: Person {
    public string order;

    public Worker(String _name): base(_name){
        order = "";


    }
    public void delivery(Person deliv_obj){
        System.Console.WriteLine(this.name + "이" + deliv_obj.name + "에게 요리(주문)를 줬습니다.");
    }
}
