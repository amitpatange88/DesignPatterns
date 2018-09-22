<h1 style="color:#fff;">.NET Design Patterns</h1>
<div class="post-body entry-content">
<br>
<span style="font-size: large;">What is Design Patterns ? </span><br>
<br>
Design patterns may be said as a set of probable solutions for a particular problem which is tested to work best in certain situations. In other words, Design patterns, say you have found a problem. Certainly, with the evolution of software industry, most of the others might have faced the same problem once. Design pattern shows you the best possible way to solve the recurring problem.<br>
<br>
<span style="font-size: large;">Uses of Design Patterns </span><br>
<br>
While creating an application, we think a lot on how the software will behave in the long run. It is very hard to predict how the architecture will work for the application when the actual application is built completely. There might issues which you cant predict and may come while implementing the software. Design patterns helps you to find tested proven design paradigm. Following design pattern will prevent major issues to come in future and also helps the other architects to easily understand your code.<br>
<br>
<span style="font-size: large;">History of Design Patterns </span><br>
<br>
When the word design pattern comes into mind, the first thing that one may think is the classical book on Design Pattern "Gangs of Four" which was published by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides.  In this book, it is first discussed capabilities and pitfalls of Object oriented programming, and later on it discusses about the classic Design Patterns on OOPS.<br>
<br>
<span style="font-size: large;">Types of Design Pattern</span><br>
<br>
Design patterns can be divided into 3 categories.<br>
<ol><li><b>Creational Patterns</b> : These patterns deals mainly with creation of objects and classes. </li>
<li><b>Structural Patterns</b> : These patterns deals with <i>Class and Object Composition</i>. </li>
<li><b>Behavioural Patterns</b> : These mainly deals with <i>Class - Object communication</i>. That means they are concerned with the communication between class and objects. </li>
</ol>In this article, I am going to discuss few examples of these patterns.<br>
<br><br>

<table class="table table-condensed" style="width:100%;font-size:15px;">
                            <tbody><tr>
                                <td class="table-heading table-heading-simple" colspan="2">Creational Patterns</td>
                            </tr>
                            <tr>
                                <td style="width:30%;border:0;">&nbsp;&nbsp;<a class="nobr" href="/net/abstract-factory-design-pattern">Abstract Factory</a></td>
                                <td style="width:70%;border:0;">Creates an instance of several families of classes</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/builder-design-pattern">Builder</a></td>
                                <td>Separates object construction from its representation</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/factory-method-design-pattern">Factory Method</a></td>
                                <td>Creates an instance of several derived classes</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/prototype-design-pattern">Prototype</a></td>
                                <td>A fully initialized instance to be copied or cloned</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/singleton-design-pattern">Singleton</a></td>
                                <td>A class of which only a single instance can exist</td>
                            </tr>
                        </tbody></table>

                        <br><br>

                        <table class="table table-condensed" style="width:100%;font-size:15px;">
                            <tbody><tr>
                                <td class="table-heading table-heading-simple" colspan="2">Structural Patterns</td>
                            </tr>
                            <tr>
                                <td style="width:30%;border:0;">&nbsp;&nbsp;<a class="nobr" href="/net/adapter-design-pattern">Adapter</a></td>
                                <td style="width:70%;border:0;">Match interfaces of different classes</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/bridge-design-pattern">Bridge</a></td>
                                <td>Separates an object’s interface from its implementation</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/composite-design-pattern">Composite</a></td>
                                <td>A tree structure of simple and composite objects</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/decorator-design-pattern">Decorator</a></td>
                                <td>Add responsibilities to objects dynamically</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/facade-design-pattern">Facade</a></td>
                                <td>A single class that represents an entire subsystem</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/flyweight-design-pattern">Flyweight</a></td>
                                <td>A fine-grained instance used for efficient sharing</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/proxy-design-pattern">Proxy</a></td>
                                <td>An object representing another object</td>
                            </tr>
                        </tbody></table>

                        <br><br>

                        <table class="table table-condensed" style="width:100%;font-size:15px;">
                            <tbody><tr>
                                <td class="table-heading table-heading-simple" colspan="2">Behavioral Patterns</td>
                            </tr>
                            <tr>
                                <td style="width:30%;border:0;">&nbsp;&nbsp;<a class="nobr" href="/net/chain-of-responsibility-design-pattern">Chain of Resp.</a></td>
                                <td style="width:70%;border:0;">A way of passing a request between a chain of objects</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/command-design-pattern">Command</a></td>
                                <td>Encapsulate a command request as an object</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/interpreter-design-pattern">Interpreter</a></td>
                                <td>A way to include language elements in a program</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/iterator-design-pattern">Iterator</a></td>
                                <td>Sequentially access the elements of a collection</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/mediator-design-pattern">Mediator</a></td>
                                <td>Defines simplified communication between classes</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/memento-design-pattern">Memento</a></td>
                                <td>Capture and restore an object's internal state</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/observer-design-pattern">Observer</a></td>
                                <td>A way of notifying change to a number of classes</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/state-design-pattern">State</a></td>
                                <td>Alter an object's behavior when its state changes</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/strategy-design-pattern">Strategy</a></td>
                                <td>Encapsulates an algorithm inside a class</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/template-method-design-pattern">Template Method</a></td>
                                <td>Defer the exact steps of an algorithm to a subclass</td>
                            </tr>
                            <tr>
                                <td>&nbsp;&nbsp;<a class="nobr" href="/net/visitor-design-pattern">Visitor</a></td>
                                <td>Defines a new operation to a class without change</td>
                            </tr>
                        </tbody></table><br><br>


You can Read the entire article from<br>
<a href="http://www.dotnetfunda.com/articles/article889-design-pattern-implementation-using-csharp-.aspx">http://www.dotnetfunda.com/articles/article889-design-pattern-implementation-using-csharp-.aspx</a><br>
<br>
or <br>
<a name="more"></a><span style="font-size: large;"><span style="font-size: x-large;">CREATIONAL PATTERNS</span> </span><br>
<br>
<span style="font-size: large;">Singleton Pattern </span><br>
<br>
Singleton pattern creates a class which can have a single object throughout the application, so that whenever any other object tries to access the object of the class, it will access the same object always.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RYs06oH2I/AAAAAAAAC9s/ShTxLAjkBDQ/s1600/singleton.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" src="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RYs06oH2I/AAAAAAAAC9s/ShTxLAjkBDQ/s1600/singleton.JPG"></a></div><br>
<div class="separator" style="clear: both; text-align: center;"></div><br>
<span style="color: orange; font-size: large;">Implementation </span><br>
<pre class="csharpcode"><span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Implementation of Singleton Pattern</span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">public</span> <span class="kwrd">sealed</span> <span class="kwrd">class</span> SingleTon
    {
        <span class="kwrd">private</span> <span class="kwrd">static</span> SingleTon _instance =<span class="kwrd">null</span>;
        <span class="kwrd">private</span> SingleTon() <span class="rem">// Made default constructor as private </span>
        {
        }
        <span class="rem">/// &lt;summary&gt;</span>
        <span class="rem">/// Single Instance</span>
        <span class="rem">/// &lt;/summary&gt;</span>
        <span class="kwrd">public</span> <span class="kwrd">static</span> SingleTon Instance 
        {
            get
            {
                <span class="kwrd">lock</span> (_instance)
                {
                    _instance = _instance ?? <span class="kwrd">new</span> SingleTon();
                    <span class="kwrd">return</span> _instance;
                }
            }
        }

        # region Rest of Implementation Logic

        <span class="rem">//Add As many method as u want here as instance member. No need to make them static.</span>

        # endregion
    }</pre><br>
In the above code you can see I have intentionally made the <b>constructor as private.</b> This will make sure that the class cant be instantiated from outside. On the other hand, you also need to make a property which will return the static instance of the object present within the class itself.  Hence the object will be shared between all the external entities.<br>
<br>
<span style="font-size: large;">Factory Pattern</span><br>
<br>
Factory pattern deals with the instantiation of object without exposing the instantiation logic. In other words, a Factory is actually a creator of object which has common interface.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RaN0qt2BI/AAAAAAAAC9w/v_cy_PNyapI/s1600/factory.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="311" src="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RaN0qt2BI/AAAAAAAAC9w/v_cy_PNyapI/s320/factory.JPG" width="320"></a></div><br>
<br>
<div class="separator" style="clear: both; text-align: center;"></div><span style="background-color: #f1c232; color: black; font-size: large;">Implementation</span><br>
<br>
<pre class="csharpcode"><span class="rem">//Empty vocabulary of Actual object</span>
    <span class="kwrd">public</span> <span class="kwrd">interface</span> IPeople
    {
        <span class="kwrd">string</span> GetName();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Villagers : IPeople
    {

        <span class="preproc">#region</span> IPeople Members

        <span class="kwrd">public</span> <span class="kwrd">string</span> GetName()
        {
            <span class="kwrd">return</span> <span class="str">"Village Guy"</span>;
        }

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> CityPeople : IPeople
    {

        <span class="preproc">#region</span> IPeople Members

        <span class="kwrd">public</span> <span class="kwrd">string</span> GetName()
        {
            <span class="kwrd">return</span> <span class="str">"City Guy"</span>;
        }

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">enum</span> PeopleType
    {
        RURAL,
        URBAN
    }

    <span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Implementation of Factory - Used to create objects</span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">public</span> <span class="kwrd">class</span> Factory
    {
        <span class="kwrd">public</span> IPeople GetPeople(PeopleType type)
        {
            IPeople people = <span class="kwrd">null</span>;
            <span class="kwrd">switch</span> (type)
            {
                <span class="kwrd">case</span> PeopleType.RURAL :
                    people = <span class="kwrd">new</span> Villagers();
                    <span class="kwrd">break</span>;
                <span class="kwrd">case</span> PeopleType.URBAN:
                    people = <span class="kwrd">new</span> CityPeople();
                    <span class="kwrd">break</span>;
                <span class="kwrd">default</span>:
                    <span class="kwrd">break</span>;
            }
            <span class="kwrd">return</span> people;
        }
    }</pre><br>
<br>
In the above code you can see I have created one interface called IPeople and implemented two classes from it as Villagers and CityPeople. Based on the type passed into the factory object, I am sending back the original concrete object as the Interface IPeople.<br>
<br>
<span style="font-size: large;">Factory Method</span><br>
<br>
A Factory method is just an addition to Factory class. It creates the object of the class through interfaces but on the other hand, it also lets the subclass to decide which class to be instantiated.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"></div><div class="separator" style="clear: both; text-align: center;"><a href="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RbTPlViOI/AAAAAAAAC90/5k2WeV6P2aE/s1600/factorymethod.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="274" src="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RbTPlViOI/AAAAAAAAC90/5k2WeV6P2aE/s320/factorymethod.JPG" width="320"></a></div><br>
<span style="background-color: #f1c232;"><span style="font-size: large;">IMPLEMENTATION</span></span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">interface</span> IProduct
    {
        <span class="kwrd">string</span> GetName();
        <span class="kwrd">string</span> SetPrice(<span class="kwrd">double</span> price);
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> IPhone : IProduct 
    {
        <span class="kwrd">private</span> <span class="kwrd">double</span> _price;
        <span class="preproc">#region</span> IProduct Members

        <span class="kwrd">public</span> <span class="kwrd">string</span> GetName()
        {
            <span class="kwrd">return</span> <span class="str">"Apple TouchPad"</span>;
        }

        <span class="kwrd">public</span> <span class="kwrd">string</span> SetPrice(<span class="kwrd">double</span> price)
        {
            <span class="kwrd">this</span>._price = price;
            <span class="kwrd">return</span> <span class="str">"success"</span>;
        }

        <span class="preproc">#endregion</span>
    }

    <span class="rem">/* Almost same as Factory, just an additional exposure to do something with the created method */</span>
    <span class="kwrd">public</span> <span class="kwrd">abstract</span> <span class="kwrd">class</span> ProductAbstractFactory
    {
        <span class="kwrd">public</span> IProduct DoSomething()
        {
            IProduct product = <span class="kwrd">this</span>.GetObject();
            <span class="rem">//Do something with the object after you get the object. </span>
            product.SetPrice(20.30);
            <span class="kwrd">return</span> product;
        }
        <span class="kwrd">public</span> <span class="kwrd">abstract</span> IProduct GetObject();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> ProductConcreteFactory : ProductAbstractFactory
    {

        <span class="kwrd">public</span> <span class="kwrd">override</span> IProduct GetObject() <span class="rem">// Implementation of Factory Method.</span>
        {
            <span class="kwrd">return</span> <span class="kwrd">this</span>.DoSomething();
        }
    }</pre><br>
You can see I have used GetObject in concreteFactory. As a result, you can easily call DoSomething() from it to get the IProduct.<br>
<br>
You might also write your custom logic after getting the object in the concrete Factory Method. The GetObject is made abstract in the Factory interface.<br>
<br>
<span style="font-size: large;">Abstract Factory </span><br>
<br>
Abstract factory is the extension of basic Factory pattern. It provides Factory interfaces for creating a family of related classes. In other words, here I am declaring interfaces for Factories, which will in turn work in similar fashion as with Factories.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"></div><div class="separator" style="clear: both; text-align: center;"><a href="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RVzbZysGI/AAAAAAAAC9k/Om6kMgsSHSw/s1600/abstractfactory.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="182" src="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RVzbZysGI/AAAAAAAAC9k/Om6kMgsSHSw/s320/abstractfactory.JPG" width="320"></a></div><br>
<span style="background-color: #f1c232; font-size: large;">IMPLEMENTATION</span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">interface</span> IFactory1
    {
        IPeople GetPeople();
    }
    <span class="kwrd">public</span> <span class="kwrd">class</span> Factory1 : IFactory1
    {
        <span class="kwrd">public</span> IPeople GetPeople()
        {
            <span class="kwrd">return</span> <span class="kwrd">new</span> Villagers();
        }
    }

    <span class="kwrd">public</span> <span class="kwrd">interface</span> IFactory2
    {
        IProduct GetProduct();
    }
    <span class="kwrd">public</span> <span class="kwrd">class</span> Factory2 : IFactory2
    {
        <span class="kwrd">public</span> IProduct GetProduct()
        {
            <span class="kwrd">return</span> <span class="kwrd">new</span> IPhone();
        }
    }

    <span class="kwrd">public</span> <span class="kwrd">abstract</span> <span class="kwrd">class</span> AbstractFactory12
    {
        <span class="kwrd">public</span> <span class="kwrd">abstract</span> IFactory1 GetFactory1();
        <span class="kwrd">public</span> <span class="kwrd">abstract</span> IFactory2 GetFactory2();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> ConcreteFactory : AbstractFactory12
    {

        <span class="kwrd">public</span> <span class="kwrd">override</span> IFactory1 GetFactory1()
        {
            <span class="kwrd">return</span> <span class="kwrd">new</span> Factory1();
        }

        <span class="kwrd">public</span> <span class="kwrd">override</span> IFactory2 GetFactory2()
        {
            <span class="kwrd">return</span> <span class="kwrd">new</span> Factory2();
        }
    }</pre><br>
The factory method is also implemented using common interface each of which returns objects.<br>
<br>
<span style="font-size: large;">Builder Pattern</span><br>
<br>
This pattern creates object based on the Interface, but also lets the subclass decide which class to instantiate. It also has finer control over the construction process.<br>
<br>
There is a concept of <b>Director </b>in Builder Pattern implementation. The director actually creates the object and also runs a few tasks after that.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"></div><div class="separator" style="clear: both; text-align: center;"></div><br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RYTZhHAXI/AAAAAAAAC9o/L6J0-mjdR_I/s1600/builder.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="149" src="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RYTZhHAXI/AAAAAAAAC9o/L6J0-mjdR_I/s320/builder.JPG" width="320"></a></div><br>
<br>
<div class="separator" style="clear: both; text-align: center;"></div><span style="background-color: #f1c232;"><span style="font-size: large;">IMPLEMENTATION</span></span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">interface</span> IBuilder
    {
        <span class="kwrd">string</span> RunBulderTask1();
        <span class="kwrd">string</span> RunBuilderTask2();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Builder1 : IBuilder
    {

        <span class="preproc">#region</span> IBuilder Members

        <span class="kwrd">public</span> <span class="kwrd">string</span> RunBulderTask1()
        {
            <span class="kwrd">throw</span> <span class="kwrd">new</span> ApplicationException(<span class="str">"Task1"</span>);
        }

        <span class="kwrd">public</span> <span class="kwrd">string</span> RunBuilderTask2()
        {
            <span class="kwrd">throw</span> <span class="kwrd">new</span> ApplicationException(<span class="str">"Task2"</span>);
        }

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Builder2 : IBuilder
    {
        <span class="preproc">#region</span> IBuilder Members

        <span class="kwrd">public</span> <span class="kwrd">string</span> RunBulderTask1()
        {
            <span class="kwrd">return</span> <span class="str">"Task3"</span>;
        }

        <span class="kwrd">public</span> <span class="kwrd">string</span> RunBuilderTask2()
        {
            <span class="kwrd">return</span> <span class="str">"Task4"</span>;
        }

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Director
    {
        <span class="kwrd">public</span> IBuilder CreateBuilder(<span class="kwrd">int</span> type)
        {
            IBuilder builder = <span class="kwrd">null</span>;
            <span class="kwrd">if</span> (type == 1)
                builder = <span class="kwrd">new</span> Builder1();
            <span class="kwrd">else</span>
                builder = <span class="kwrd">new</span> Builder2();
            builder.RunBulderTask1();
            builder.RunBuilderTask2();
            <span class="kwrd">return</span> builder;
        }
    }</pre><br>
In case of Builder pattern you can see the Director is actually using CreateBuilder to create the instance of the builder. So when the Bulder is actually created, we can also invoke a few common task in it.<br>
<br>
<span style="font-size: large;">Prototype Pattern</span><br>
<br>
This pattern creates the kind of object using its prototype. In other words, while creating the object of Prototype object, the class actually creates a clone of it and returns it as prototype.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_Rbpu0sYiI/AAAAAAAAC94/Uyc5X0UGKVk/s1600/prototype.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="246" src="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_Rbpu0sYiI/AAAAAAAAC94/Uyc5X0UGKVk/s320/prototype.JPG" width="320"></a></div><br>
<div class="separator" style="clear: both; text-align: center;"></div><br>
<span style="font-size: large;"><span style="background-color: #f1c232;">IMPLEMENTATION </span></span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">abstract</span> <span class="kwrd">class</span> Prototype
    {
       
        <span class="rem">// normal implementation</span>

        <span class="kwrd">public</span> <span class="kwrd">abstract</span> Prototype Clone();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> ConcretePrototype1 : Prototype
    {

        <span class="kwrd">public</span> <span class="kwrd">override</span> Prototype Clone()
        {
            <span class="kwrd">return</span> (Prototype)<span class="kwrd">this</span>.MemberwiseClone();
        }
    }

    <span class="kwrd">class</span> ConcretePrototype2 : Prototype
    {

        <span class="kwrd">public</span> <span class="kwrd">override</span> Prototype Clone()
        {
            <span class="kwrd">return</span> (Prototype)<span class="kwrd">this</span>.MemberwiseClone(); <span class="rem">// Clones the concrete class.</span>
        }
    }
</pre><br>
You can see here, I have used MemberwiseClone method to clone the prototype when required.<br>
<br>
<hr><br>
<span style="font-size: x-large;">STRUCTURAL PATTERN</span><br>
<br>
<span style="font-size: x-large;"><span style="font-size: large;">Adapter Pattern</span><br>
<span style="font-size: small;"> </span></span><br>
<span style="font-size: x-large;"><span style="font-size: small;">Adapter pattern converts one instance of a class into another interface which client expects. In other words, Adapter pattern actually makes two classes compatible.</span></span><br>
<span style="font-size: x-large;"><span style="font-size: small;"><br>
</span></span><br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RPvFQGH8I/AAAAAAAAC9U/jFhPMXCovlY/s1600/adapter.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="185" src="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RPvFQGH8I/AAAAAAAAC9U/jFhPMXCovlY/s320/adapter.JPG" width="320"></a></div><span style="font-size: x-large;"><span style="font-size: small;"><br>
</span></span><br>
<span style="font-size: x-large;"><span style="font-size: small;"><br>
</span></span><br>
<span style="font-size: x-large;"><span style="font-size: small;"><span style="font-size: large;"><span style="background-color: #f1c232;">IMPLEMENTATION</span></span> </span></span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">interface</span> IAdapter
    {
        <span class="rem">/// &lt;summary&gt;</span>
        <span class="rem">/// Interface method Add which decouples the actual concrete objects</span>
        <span class="rem">/// &lt;/summary&gt;</span>
        <span class="kwrd">void</span> Add();
    }
    <span class="kwrd">public</span> <span class="kwrd">class</span> MyClass1 : IAdapter
    {
        <span class="kwrd">public</span> <span class="kwrd">void</span> Add()
        {
        }
    }
    <span class="kwrd">public</span> <span class="kwrd">class</span> MyClass2
    {
        <span class="kwrd">public</span> <span class="kwrd">void</span> Push()
        {

        }
    }
    <span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Implements MyClass2 again to ensure they are in same format.</span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">public</span> <span class="kwrd">class</span> Adapter : IAdapter 
    {
        <span class="kwrd">private</span> MyClass2 _class2 = <span class="kwrd">new</span> MyClass2();

        <span class="kwrd">public</span> <span class="kwrd">void</span> Add()
        {
            <span class="kwrd">this</span>._class2.Push();
        }
    }</pre><br>
Here in the structure, the adapter is used to make MyClass2 incompatible with IAdapter.<br>
<br>
<span style="font-size: large;">Bridge Pattern</span><br>
<br>
Bridge pattern compose objects in tree structure. It decouples abstraction from implementation. Here abstraction represents the client where from the objects will be called.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RPorddRmI/AAAAAAAAC9Q/2f0b1XzhudQ/s1600/bridge.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="214" src="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RPorddRmI/AAAAAAAAC9Q/2f0b1XzhudQ/s320/bridge.JPG" width="320"></a></div><br>
<br>
<span style="font-size: large;"><span style="background-color: #f1c232;">IMPLEMENTATION </span></span><br>
<br>
<pre class="csharpcode"># region The Implementation
    <span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Helps in providing truely decoupled architecture</span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">public</span> <span class="kwrd">interface</span> IBridge
    {
        <span class="kwrd">void</span> Function1();
        <span class="kwrd">void</span> Function2();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Bridge1 : IBridge
    {

        <span class="preproc">#region</span> IBridge Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> Function1()
        {
            <span class="kwrd">throw</span> <span class="kwrd">new</span> NotImplementedException();
        }

        <span class="kwrd">public</span> <span class="kwrd">void</span> Function2()
        {
            <span class="kwrd">throw</span> <span class="kwrd">new</span> NotImplementedException();
        }

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Bridge2 : IBridge
    {
        <span class="preproc">#region</span> IBridge Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> Function1()
        {
            <span class="kwrd">throw</span> <span class="kwrd">new</span> NotImplementedException();
        }

        <span class="kwrd">public</span> <span class="kwrd">void</span> Function2()
        {
            <span class="kwrd">throw</span> <span class="kwrd">new</span> NotImplementedException();
        }

        <span class="preproc">#endregion</span>
    }
    # endregion

    # region Abstraction
    <span class="kwrd">public</span> <span class="kwrd">interface</span> IAbstractBridge
    {
        <span class="kwrd">void</span> CallMethod1();
        <span class="kwrd">void</span> CallMethod2();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> AbstractBridge : IAbstractBridge 
    {
        <span class="kwrd">public</span> IBridge bridge;

        <span class="kwrd">public</span> AbstractBridge(IBridge bridge)
        {
            <span class="kwrd">this</span>.bridge = bridge;
        }
        <span class="preproc">#region</span> IAbstractBridge Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> CallMethod1()
        {
            <span class="kwrd">this</span>.bridge.Function1();
        }

        <span class="kwrd">public</span> <span class="kwrd">void</span> CallMethod2()
        {
            <span class="kwrd">this</span>.bridge.Function2();
        }

        <span class="preproc">#endregion</span>
    }
    # endregion</pre><br>
Thus you can see the Bridge classes are the Implementation, which uses the same interface oriented architecture to create objects. On the other hand the abstraction takes an object of the implementation phase and runs its method. Thus makes it completely decoupled with one another.<br>
<br>
<span style="font-size: large;"> Decorator Pattern</span><br>
<br>
Decorator pattern is used to create responsibilities dynamically. That means each class in case of Decorator patter adds up special characteristics.In other words, Decorator pattern is the same as inheritance.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RPgqg6igI/AAAAAAAAC9M/u_TcjVbP5ng/s1600/Decorator.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" src="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RPgqg6igI/AAAAAAAAC9M/u_TcjVbP5ng/s1600/Decorator.JPG"></a></div><br>
<br>
<span style="background-color: #f1c232; font-size: large;">IMPLEMENTATION</span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">class</span> ParentClass
    {
        <span class="kwrd">public</span> <span class="kwrd">void</span> Method1()
        {
        }
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> DecoratorChild : ParentClass 
    {
        <span class="kwrd">public</span> <span class="kwrd">void</span> Method2()
        {
        }
    }</pre><br>
This is the same parent child relationship where the child class adds up new feature called Method2 while other characteristics is derived from the parent.<br>
<br>
<span style="font-size: large;">Composite Pattern</span><br>
<br>
Composite pattern treats components as a composition of one or more elements so that components can be separated between one another. In other words, Composite patterns are those for whom individual elements can easily be separated.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://4.bp.blogspot.com/_DSP5FXX4Isw/S_RQV1jQX1I/AAAAAAAAC9Y/x-eyn9ucheU/s1600/composite.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="234" src="http://4.bp.blogspot.com/_DSP5FXX4Isw/S_RQV1jQX1I/AAAAAAAAC9Y/x-eyn9ucheU/s320/composite.JPG" width="320"></a></div><div style="background-color: #f1c232;"><span style="font-size: large;">IMPLEMENTATION</span></div><br>
<pre class="csharpcode"><span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Treats elements as composition of one or more element, so that components can be separated</span>
    <span class="rem">/// between one another</span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">public</span> <span class="kwrd">interface</span> IComposite
    {
        <span class="kwrd">void</span> CompositeMethod();
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> LeafComposite :IComposite 
    {

        <span class="preproc">#region</span> IComposite Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> CompositeMethod()
        {
            <span class="rem">//To Do something</span>
        }

        <span class="preproc">#endregion</span>
    }

    <span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Elements from IComposite can be separated from others </span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">public</span> <span class="kwrd">class</span> NormalComposite : IComposite
    {

        <span class="preproc">#region</span> IComposite Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> CompositeMethod()
        {
            <span class="rem">//To Do Something</span>
        }

        <span class="preproc">#endregion</span>

        <span class="kwrd">public</span> <span class="kwrd">void</span> DoSomethingMore()
        {
            <span class="rem">//Do Something more .</span>
        }
    }</pre><br>
Here in the code you can see that in NormalComposite, IComposite elements can easily be separated.<br>
<br>
<span style="font-size: large;">Flyweight Pattern</span><br>
<br>
Flyweight allows you to share bulky data which are common to each object. In other words, if you think that same data is repeating for every object, you can use this pattern to point to the single object and hence can easily save space.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RSucdML_I/AAAAAAAAC9c/equxYXoBUT4/s1600/flyweight.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="203" src="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RSucdML_I/AAAAAAAAC9c/equxYXoBUT4/s320/flyweight.JPG" width="320"></a></div><div style="background-color: #f1c232;"><span style="font-size: large;"> IMPLEMENTATION</span></div><div class="separator" style="clear: both; text-align: center;"></div><br>
<pre class="csharpcode"><span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Defines Flyweight object which repeats iteself.</span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">public</span> <span class="kwrd">class</span> FlyWeight
    {
        <span class="kwrd">public</span> <span class="kwrd">string</span> Company { get; set; }
        <span class="kwrd">public</span> <span class="kwrd">string</span> CompanyLocation { get; set; }
        <span class="kwrd">public</span> <span class="kwrd">string</span> CompanyWebSite { get; set; }
        <span class="rem">//Bulky Data</span>
        <span class="kwrd">public</span> <span class="kwrd">byte</span>[] CompanyLogo { get; set; } 
    }
    <span class="kwrd">public</span> <span class="kwrd">static</span> <span class="kwrd">class</span> FlyWeightPointer
    {
        <span class="kwrd">public</span> <span class="kwrd">static</span> FlyWeight Company = <span class="kwrd">new</span> FlyWeight
        {
            Company = <span class="str">"Abc"</span>,
            CompanyLocation = <span class="str">"XYZ"</span>,
            CompanyWebSite = <span class="str">"<a class="vglnk" href="http://www.abc.com" rel="nofollow"><span>www</span><span>.</span><span>abc</span><span>.</span><span>com</span></a>"</span>
        };
    }
    <span class="kwrd">public</span> <span class="kwrd">class</span> MyObject
    {
        <span class="kwrd">public</span> <span class="kwrd">string</span> Name { get; set; }
        <span class="kwrd">public</span> FlyWeight Company
        {
            get
            {
                <span class="kwrd">return</span> FlyWeightPointer.Company;
            }
        }
    
    }</pre><br>
Here the FlyweightPointer creates a static member Company, which is used for every object of MyObject.<br>
<br>
<span style="font-size: large;"><span style="color: white;">Memento Pattern</span></span><br>
<br>
Memento pattern allows you to capture the internal state of the object without violating encapsulation and later on you can undo/ revert the changes when required.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RTzRBYTgI/AAAAAAAAC9g/-3sgBf8lU44/s1600/memento.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="152" src="http://1.bp.blogspot.com/_DSP5FXX4Isw/S_RTzRBYTgI/AAAAAAAAC9g/-3sgBf8lU44/s320/memento.JPG" width="320"></a></div><span style="font-size: large;"><span style="background-color: #f1c232;">IMPLEMENTATION</span></span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">class</span> OriginalObject
    {
        <span class="kwrd">public</span> <span class="kwrd">string</span> String1 { get; set; }
        <span class="kwrd">public</span> <span class="kwrd">string</span> String2 { get; set; }
        <span class="kwrd">public</span> Memento MyMemento { get; set; }

        <span class="kwrd">public</span> OriginalObject(<span class="kwrd">string</span> str1, <span class="kwrd">string</span> str2)
        {
            <span class="kwrd">this</span>.String1 = str1;
            <span class="kwrd">this</span>.String2 = str2;
            <span class="kwrd">this</span>.MyMemento = <span class="kwrd">new</span> Memento(str1, str2);
        }
        <span class="kwrd">public</span> <span class="kwrd">void</span> Revert()
        {
            <span class="kwrd">this</span>.String1 = <span class="kwrd">this</span>.MyMemento.String1;
            <span class="kwrd">this</span>.String2 = <span class="kwrd">this</span>.MyMemento.String2;
        }
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Memento
    {
        <span class="kwrd">public</span> <span class="kwrd">string</span> String1 { get; set; }
        <span class="kwrd">public</span> <span class="kwrd">string</span> String2 { get; set; }

        <span class="kwrd">public</span> Memento(<span class="kwrd">string</span> str1, <span class="kwrd">string</span> str2)
        {
            <span class="kwrd">this</span>.String1 = str1;
            <span class="kwrd">this</span>.String2 = str2;
        }
    }</pre><br>
Here you can see the Memento Object is actually used to Revert the changes made in the object.<br>
<br>
<hr><br>
<span style="font-size: x-large;">BEHAVIOURAL PATTERN </span><br>
<br>
<span style="font-size: x-large;"><span style="font-size: large;">Mediator Pattern </span></span><br>
<br>
<span style="font-size: x-large;"><span style="font-size: large;"><span style="font-size: small;">Mediator pattern ensures that the components are loosely coupled, such that they don't call each others explicitly, rather they always use a separate Mediator implementation to do those jobs. </span></span></span><br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://2.bp.blogspot.com/_DSP5FXX4Isw/S_RdaLEI4vI/AAAAAAAAC98/YKKIxzyrbic/s1600/mediator.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="145" src="http://2.bp.blogspot.com/_DSP5FXX4Isw/S_RdaLEI4vI/AAAAAAAAC98/YKKIxzyrbic/s320/mediator.JPG" width="320"></a></div><br>
<span style="background-color: #f1c232; font-size: large;"><span style="font-size: large;"> IMPLEMENTATION</span> </span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">interface</span> IComponent
    {
        <span class="kwrd">void</span> SetState(<span class="kwrd">object</span> state);
    }
    <span class="kwrd">public</span> <span class="kwrd">class</span> Component1 : IComponent
    {
        <span class="preproc">#region</span> IComponent Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> SetState(<span class="kwrd">object</span> state)
        {
            <span class="rem">//Do Nothing</span>
            <span class="kwrd">throw</span> <span class="kwrd">new</span> NotImplementedException();
        }

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Component2 : IComponent
    {

        <span class="preproc">#region</span> IComponent Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> SetState(<span class="kwrd">object</span> state)
        {
            <span class="rem">//Do nothing</span>
            <span class="kwrd">throw</span> <span class="kwrd">new</span> NotImplementedException();
        }

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Mediator <span class="rem">// Mediages the common tasks</span>
    {
        <span class="kwrd">public</span> IComponent Component1 { get; set; }
        <span class="kwrd">public</span> IComponent Component2 { get; set; }

        <span class="kwrd">public</span> <span class="kwrd">void</span> ChageState(<span class="kwrd">object</span> state)
        {
            <span class="kwrd">this</span>.Component1.SetState(state);
            <span class="kwrd">this</span>.Component2.SetState(state);
        }
    }</pre><br>
Here you can see the mediator Registers all the Components within it and then calls its method when required.<br>
<br>
<span style="font-size: large;">Observer Pattern</span><br>
<br>
When there are relationships between one or more objects, an observer will notify all the dependent elements when something is modified in the parent. Microsoft already implemented this pattern as ObservableCollection. Here let me implement the most basic Observer Pattern.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RiTK0AChI/AAAAAAAAC-A/HE0zLdsm1rM/s1600/observer.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="320" src="http://3.bp.blogspot.com/_DSP5FXX4Isw/S_RiTK0AChI/AAAAAAAAC-A/HE0zLdsm1rM/s320/observer.JPG" width="305"></a></div><br>
<br>
<br>
<br>
<br>
<span style="font-size: large;"><span style="background-color: #f1c232;">IMPLEMENTATION</span></span><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">delegate</span> <span class="kwrd">void</span> NotifyChangeEventHandler(<span class="kwrd">string</span> notifyinfo);
    <span class="kwrd">public</span> <span class="kwrd">interface</span> IObservable
    {
        <span class="kwrd">void</span> Attach(NotifyChangeEventHandler ohandler);
        <span class="kwrd">void</span> Detach(NotifyChangeEventHandler ohandler);
        <span class="kwrd">void</span> Notify(<span class="kwrd">string</span> name);
    }
    
    <span class="kwrd">public</span> <span class="kwrd">abstract</span> <span class="kwrd">class</span> AbstractObserver : IObservable
    {
        <span class="kwrd">public</span> <span class="kwrd">void</span> Register(NotifyChangeEventHandler handler)
        {
            <span class="kwrd">this</span>.Attach(handler);
        }

        <span class="kwrd">public</span> <span class="kwrd">void</span> UnRegister(NotifyChangeEventHandler handler)
        {
            <span class="kwrd">this</span>.Detach(handler);
        }

        <span class="kwrd">public</span> <span class="kwrd">virtual</span> <span class="kwrd">void</span> ChangeState()
        {
            <span class="kwrd">this</span>.Notify(<span class="str">"ChangeState"</span>);
            
        }

        <span class="preproc">#region</span> IObservable Members

        <span class="kwrd">public</span> <span class="kwrd">void</span> Attach(NotifyChangeEventHandler ohandler)
        {
            <span class="kwrd">this</span>.NotifyChanged += ohandler;
        }

        <span class="kwrd">public</span> <span class="kwrd">void</span> Detach(NotifyChangeEventHandler ohandler)
        {
            <span class="kwrd">this</span>.NotifyChanged -= ohandler;
        }

        <span class="kwrd">public</span> <span class="kwrd">void</span> Notify(<span class="kwrd">string</span> name)
        {
            <span class="kwrd">if</span> (<span class="kwrd">this</span>.NotifyChanged != <span class="kwrd">null</span>)
                <span class="kwrd">this</span>.NotifyChanged(name);
        }

        <span class="preproc">#endregion</span>

        <span class="preproc">#region</span> INotifyChanged Members

        <span class="kwrd">public</span> <span class="kwrd">event</span> NotifyChangeEventHandler NotifyChanged;

        <span class="preproc">#endregion</span>
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Observer : AbstractObserver 
    {
        <span class="kwrd">public</span> <span class="kwrd">override</span> <span class="kwrd">void</span> ChangeState()
        {
            <span class="rem">//Do something.</span>
            <span class="kwrd">base</span>.ChangeState();
            
        }
    }</pre><br>
You can definitely got the idea that after you Register for the Notification, you will get it when ChangeState is called.<br>
<br>
<span style="font-size: large;">Iterator Pattern</span><br>
<br>
This pattern provides a way to access elements from an aggregate sequentially. Microsoft's IEnumerable is one of the example of this pattern. Let me introduce this pattern using this interface.<br>
<br>
<div class="separator" style="clear: both; text-align: center;"><a href="http://2.bp.blogspot.com/_DSP5FXX4Isw/S_RlZVQGJyI/AAAAAAAAC-E/d32I8RZOXfQ/s1600/Iterator.JPG" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" height="254" src="http://2.bp.blogspot.com/_DSP5FXX4Isw/S_RlZVQGJyI/AAAAAAAAC-E/d32I8RZOXfQ/s320/Iterator.JPG" width="320"></a></div><br>
<br>
<br>
<br>
<br>
<div style="background-color: #f1c232;"><span style="font-size: large;">IMPLEMENTATION</span></div><br>
<br>
<pre class="csharpcode"><span class="kwrd">public</span> <span class="kwrd">class</span> Element
    {
        <span class="kwrd">public</span> <span class="kwrd">string</span> Name { get; set; }
    }

    <span class="kwrd">public</span> <span class="kwrd">class</span> Iterator: IEnumerable&lt;element&gt;
    {
        <span class="kwrd">public</span> Element[] array;
        <span class="kwrd">public</span> Element <span class="kwrd">this</span>[<span class="kwrd">int</span> i]
        {
            get
            {
                <span class="kwrd">return</span> array[i];
            }
        }

        <span class="preproc">#region</span> IEnumerable&lt;element&gt; Members

        <span class="kwrd">public</span> IEnumerator&lt;element&gt; GetEnumerator()
        {
            <span class="kwrd">foreach</span> (Element arr <span class="kwrd">in</span> <span class="kwrd">this</span>.array)
                <span class="kwrd">yield</span> <span class="kwrd">return</span> arr;
        }

        <span class="preproc">#endregion</span>

        <span class="preproc">#region</span> IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            <span class="kwrd">foreach</span> (Element arr <span class="kwrd">in</span> <span class="kwrd">this</span>.array)
                <span class="kwrd">yield</span> <span class="kwrd">return</span> arr;
        }

        <span class="preproc">#endregion</span>
    }</pre><br>
<br>
<a href="http://cid-bafa39a62a57009c.skydrive.live.com/self.aspx/.Public/DesignPatterns.zip">Download Source code here</a><br>
<br>
OR<br>
<br>
<a href="http://www.blogger.com/script/Membership/Uploads/4293807/DesignPatterns.zip">DesignPatterns.zip (55.3 KB)</a><br>
<br>
<span style="font-size: large;">Conclusion</span><br>
<br>
These are the basic design patterns. There are still few design patterns left to be implemented. Stay tuned for those updates.<br>
Thank you for reading.
<div style="clear: both;"></div>
<div addthis:title="Design Patterns in C#" addthis:url="http://www.abhisheksur.com/2010/05/design-patterns.html" class="addthis_toolbox addthis_default_style">
<a href="http://dotnetshoutout.com/Submit?url=http://www.abhisheksur.com/2010/05/design-patterns.html&amp;title=Design Patterns in C#" id="Blog1_kickit" rel="nofollow" rev="vote-for" target="blank">
<img alt="Shout it" src="http://dotnetshoutout.com/image.axd?url=http://www.abhisheksur.com/2010/05/design-patterns.html" style="border:0px"></a>
<a href="http://www.dotnetkicks.com/submit/?url=http://www.abhisheksur.com/2010/05/design-patterns.html&amp;title=Design Patterns in C#" id="Blog1_kickit" rel="nofollow" target="blank"><img alt="Submit this story to DotNetKicks" src="http://www.dotnetkicks.com/Services/Images/KickItImageGenerator.ashx?url=http://www.abhisheksur.com/2010/05/design-patterns.html"></a>
<a class="addthis_button" href="http://www.addthis.com/bookmark.php?v=250&amp;username=xa-4bf2fe7779fac760" target="blank"><img alt="Bookmark and Share" src="http://s7.addthis.com/static/btn/sm-share-en.gif" style="border:0" width="83"></a>
<script src="http://s7.addthis.com/js/250/addthis_widget.js#username=xa-4bf2fe7779fac760" type="text/javascript"></script>
<script type="text/javascript">var dzone_url = 'http://www.abhisheksur.com/2010/05/design-patterns.html';
var dzone_title = 'Design Patterns in C#';
var dzone_blurb = 'Handy Tricks and Tips to do your .NET code Fast, Efficient and Simple. Some common questions that comes into mind. Please check if you could find them listed or not.';
var dzone_style = '2';</script>
<script language="javascript" src="http://widgets.dzone.com/links/widgets/zoneit.js"></script>
<br>
<iframe allowtransparency="true" frameborder="0" scrolling="no" src="http://www.facebook.com/plugins/like.php?href=http://www.abhisheksur.com/2010/05/design-patterns.html&amp;layout=standard&amp;show_faces=false&amp;width=100&amp;action=like&amp;font=arial&amp;colorscheme=light" style="border:none; overflow:hidden; width:450px; height:40px;"></iframe>
<div class="atclear"></div></div>
<a href="p/disclaimer.html" target="_blank">Read Disclaimer Notice</a>
<div class="post-footer">
<div class="post-footer-line post-footer-line-1">
<span class="post-icons">
<span class="item-action">
<a href="https://www.blogger.com/email-post.g?blogID=2366485263164379453&amp;postID=8111050616552891980" title="Email Post">
<img alt="" class="icon-action" height="13" src="http://www.blogger.com/img/icon18_email.gif" width="18">
</a>
</span>
<span class="item-control blog-admin pid-159325442">
<a href="https://www.blogger.com/post-edit.g?blogID=2366485263164379453&amp;postID=8111050616552891980&amp;from=pencil" title="Edit Post">
<img alt="" class="icon-action" height="18" src="http://www.blogger.com/img/icon18_edit_allbkg.gif" width="18">
</a>
</span>
</span>
</div>
</div>
<div class="post-footer-line post-footer-line-3"></div>
</div>