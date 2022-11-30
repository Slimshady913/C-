Person a = new Person("A");
Owner b = new Owner("B");
a.pay(50000, b);

Owner o = new Owner("사장");
Server s = new Server("서빙 담당");
Cook co = new Cook("요리 담당");
Customer c1 = new Customer("손님1");
Menu m1 = new Menu("정식", 5000);
Menu m2 = new Menu("특식", 7000);
Menu m3 = new Menu("콜라", 2000);
Menu m4 = new Menu("사이다", 2000);
c1.order(m1, 1, s);
c1.order(m4, 1, s);
s.delivery(co);
co.delivery(s);
s.delivery(c1);
c1.pay(c1.price, s);
s.pay(c1.price, o);

Customer c2 = new Customer("손님2");
Customer c3 = new Customer("손님3");
c2.order(m2, 2, s);
c2.order(m3, 2, s);
s.delivery(co);
co.delivery(s);
s.delivery(c2);
c2.pay(c2.price, s);
s.pay(c2.price, o);
o.pay(50000, s);
o.pay(50000, co);
System.Console.WriteLine("장사를 마치고" + o.name+ "이 "+ "가진 잔액은 "+ o.money+"입니다.");

