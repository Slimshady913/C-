using System;

class Customer: Person {
    public int price;
    public Customer(String _name): base(_name){
        this.price = 0;

    }
    public void order(Menu menu_obj, int count, Worker order_obj) {
        this.price += count * menu_obj.price;
        order_obj.order = menu_obj.menu;
        System.Console.WriteLine(this.name+ "이" + menu_obj.menu + "을(를) 주문했습니다.");
    }
}

