<h1>Decorator Design Pattern</h1>
<p><strong>Decorator Pattern<br> </strong><br> <img width="588" height="221" alt="" src="https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/damubetha/decorator-pattern-in-csharp/Images/Lexus-Before-and-after-Wrap.jpg" border="0"><br> <br>
The Decorator Pattern provides a flexible alternative to sub classing for extending functionality dynamically.<br> <br>
The idea of the Decorator Pattern is&nbsp;to wrap an existing class, add other functionality to it, then expose the same interface to the outside world. Because of this our decorator exactly looks like the original class to the people who are using it.<br> <br>
It is used to extend or alter the functionality at runtime. It does this by wrapping them in an object of the decorator class without modifying the original object. So it can be called a wrapper pattern.<br> <br> <strong>Advantages of Decorator Pattern </strong></p>
<p align="justify"></p>
<ol> <li>Adds functionality to existing objects dynamically</li> <li>Alternative to sub classing</li> <li>Flexible design</li> <li>Supports Open Closed Principle </li> </ol>
<p><strong>When to use Decorator Pattern</strong></p>
<ol> <li>Legacy System</li> <li>Contorls</li> <li>Sealed Classes </li> </ol>
<p>The following class diagram shows us the Decorator Pattern's design:<br> <br> <img width="453" height="424" alt="" src="https://csharpcorner-mindcrackerinc.netdna-ssl.com/UploadFile/damubetha/decorator-pattern-in-csharp/Images/decorator.png" border="0"><br> </p>
<ul> <li><strong>Component: </strong>It defines the interface of the actual object that needs functionality to be added dynamically to the ConcreteComponents.</li> <li><strong>ConcreteComponent:</strong> The actual object in which the functionalities could be added dynamically.</li> <li><strong>Decorator: </strong>This defines the interface for all the dynamic functionalities that can be added to the ConcreteComponent.</li> <li><strong>ConcreteDecorator: </strong>All the functionalities that can be added to the ConcreteComponent. Each needed functionality will be one ConcreteDecorator class. </li> </ul>
<p>A decorated class is a base class of concrete decorator classes and it inherits from the base component class. So the decorators can be used in the place of concrete components.<br> <br>
Let's start learning the Decorator Pattern with one real time problem. Suppose we need to build an application for a car show room that sells cars along with car accessories. Economy, Deluxe and Luxury are the car categories that come with the optional accessories packages Basic, Advanced and Sport. So the application must provide the car cost adding the cost of accessory package if the user chooses any of the preceding packages.<br> <br>
Okay. Let's start designing our application with the ICar interface that will be implemented by Economy, Deluxe and Luxury Car category classes.<br> </p>
<br>
<strong>Link :</strong> <br>
https://www.c-sharpcorner.com/UploadFile/damubetha/decorator-pattern-in-csharp/ <br>
https://www.youtube.com/watch?v=YObNH6IkIos
