﻿工厂方法模式
定义一个用于创建对象的接口，让子类决定实例化哪一个类。Factory Method 使一个类的实例化延迟到其子类。
当一个类不知道它所必须创建的对象的类的时候。 
当一个类希望由它的子类来指定它所创建的对象的时候。 
当类将创建对象的职责委托给多个帮助子类中的某一个，并且你希望将哪一个帮助子类是代理者这一信息局部化的时候。 


  对象在工厂方法中创建，使用时通过工厂方法创建对象，工厂方法还可以通过反射创建，可以提供多种方式创建对象
  当需要新增新种族时添加一个新种族和对应的工厂方法，上层通过工厂方法创建新种族，相较简单工厂无需修改代码
  可以结合简单工厂使用

War3：对象结构
FactoryMethod:工厂方法