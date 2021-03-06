<h1>Singleton Design Pattern</h1>
<div class="user-content"> <div class="b-row" style="padding: 0 15px;"> <div class="content-head-link clearfix"> <div id="ctl00_lstDownloadFiles" class="download-items" style="position:relative"><div class="icon-box"><i class="d-icon icon-28 icon-download-content" title="Download Files"></i></div><div class="file-box"></div></div> <div class="ad-items linkAdContainer" id="LinkAdContainerTop"><div class="LinkAd"></div></div> </div> </div> <div id="div2" class="PaddingLeft5"><p align="justify"></p> <div><strong>What is Singleton Design Pattern?</strong></div> <ol> <li>Ensures a class has only one instance and provides a global point of access to it.</li> <li>A singleton is a class that only allows a single instance of itself to be created, and usually gives simple access to that instance.</li> <li>Most commonly, singletons don't allow any parameters to be specified when creating the instance,&nbsp;since a second request of an instance with a different parameter could be problematic! (If the same instance should be accessed for all requests with the same parameter then the factory pattern is more appropriate.)</li></ol>There are various ways to implement the Singleton Pattern in C#. The following are the common characteristics of a Singleton Pattern.
<ul> <li>A single constructor, that is private and parameterless.</li> <li>The class is sealed.</li> <li>A static variable that holds a reference to the single created instance, if any.</li> <li>A public static means of getting the reference to the single created instance, creating one if necessary.</li> </ul> <div><strong>Advantages</strong></div><div>&nbsp;</div> <div>The advantages of a Singleton Pattern are:</div> <ol> <li>Singleton pattern can be implemented interfaces.</li> <li>It can be also inherit from other classes.</li> <li>It can be lazy loaded.</li> <li>It has Static Initialization.</li> <li>It can be extended into a factory pattern.</li> <li>It helps to hide dependencies.</li> <li>It provides a single point of access to a particular instance, so it is easy to maintain.</li> </ol> <div><strong>Disadvantages</strong></div><div>&nbsp;</div> <div>The disadvantages of a Singleton Pattern are:</div> <ol> <li>Unit testing is more difficult (because it introduces a global state into an application).</li> <li>This pattern reduces the potential for parallelism within a program, because to access the singleton in a multi-threaded system, an object must be serialized (by locking).</li> </ol> <div><strong>Singleton class vs. Static methods</strong></div><div>&nbsp;</div> <div>The following conpares Singleton class vs. Static methods:</div> <ol> <li>A Static Class cannot be extended whereas a singleton class can be extended.</li> <li>A Static Class can still have instances (unwanted instances) whereas a singleton class prevents it.</li> <li>A Static Class cannot be initialized with a STATE (parameter), whereas a singleton class can be.</li> <li>A Static class is loaded automatically by the CLR when the program or namespace containing the class is loaded.</li> </ol> <div><strong>How to Implement Singleton Pattern in your code<br> </strong>&nbsp;</div><div>There are many way to implement a Singleton Pattern in C#.</div> <ol> <li>No Thread Safe Singleton.</li> <li>Thread-Safety Singleton.</li> <li>Thread-Safety Singleton using Double-Check Locking.</li> <li>Thread-Safe Singleton without using locks and no lazy instantiation.</li> <li>Fully lazy instantiation.</li> <li>Using .NET 4's Lazy&lt;T&gt; type.</li> </ol> <div><strong>1. No Thread Safe Singleton</strong></div><div>&nbsp;</div><div>Explanation of the following code:</div> <ol> <li>The following code is not thread-safe.</li> <li>Two different threads could both have evaluated the test (if instance == null) and found it to be true, then both creates instances, which violates the singleton pattern.</li> <li>Note that in fact the instance may already have been created before the expression is evaluated, but the memory model doesn't guarantee that the new value of instance will be seen by other threads unless suitable memory barriers have been passed.</li> </ol> <div></div> <div class="dp-highlighter"> <div class="bar"></div> <ol start="1" class="dp-c"> <li class="alt"><span><span class="comment">//&nbsp;Bad&nbsp;code!&nbsp;Do&nbsp;not&nbsp;use!</span><span>&nbsp;&nbsp;</span></span></li> <li class=""><span><span class="keyword">public</span><span>&nbsp;</span><span class="keyword">sealed</span><span>&nbsp;</span><span class="keyword">class</span><span>&nbsp;Singleton&nbsp;&nbsp;</span></span></li> <li class="alt"><span>{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//Private&nbsp;Constructor.</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;Singleton()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;instance&nbsp;=&nbsp;</span><span class="keyword">null</span><span>;&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;Instance&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">get</span><span>&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">if</span><span>&nbsp;(instance&nbsp;==&nbsp;</span><span class="keyword">null</span><span>)&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;instance&nbsp;=&nbsp;<span class="keyword">new</span><span>&nbsp;Singleton();&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;instance;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>}&nbsp;&nbsp;</span></li> </ol> </div> <div><strong>2. Thread Safety Singleton</strong></div><div>&nbsp;</div> <div>Explanation of the following code:</div> <ol> <li>This implementation is thread-safe.</li> <li>In the following code, the thread is locked on a shared object and checks whether an instance has been created or not.</li> <li>This takes care of the memory barrier issue and ensures that only one thread will create an instance.</li> <li>For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it, the first thread will have created the instance, so the expression will evaluate to false.</li> <li>The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.</li></ol> <div></div> <div class="dp-highlighter"> <div class="bar"></div> <ol start="1" class="dp-c"> <li class="alt"><span><span class="keyword">public</span><span>&nbsp;</span><span class="keyword">sealed</span><span>&nbsp;</span><span class="keyword">class</span><span>&nbsp;Singleton&nbsp;&nbsp;</span></span></li> <li class=""><span>{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;Singleton()&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;</span><span class="keyword">readonly</span><span>&nbsp;</span><span class="keyword">object</span><span>&nbsp;padlock&nbsp;=&nbsp;</span><span class="keyword">new</span><span>&nbsp;</span><span class="keyword">object</span><span>();&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;instance&nbsp;=&nbsp;</span><span class="keyword">null</span><span>;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;Instance&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">get</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">lock</span><span>&nbsp;(padlock)&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">if</span><span>&nbsp;(instance&nbsp;==&nbsp;</span><span class="keyword">null</span><span>)&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;instance&nbsp;=&nbsp;<span class="keyword">new</span><span>&nbsp;Singleton();&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;instance;&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>}&nbsp;&nbsp;</span></li> </ol> </div> <div><strong>3. Thread Safety Singleton using Double Check Locking</strong></div><div>&nbsp;</div> <div>Explanation of the following code:</div> <ol> <li>In the following code, the thread is locked on a shared object and checks whether an instance has been created or not with double checking.</li></ol> <div></div> <div class="dp-highlighter"> <div class="bar"></div> <ol start="1" class="dp-c"> <li class="alt"><span><span class="keyword">public</span><span>&nbsp;</span><span class="keyword">sealed</span><span>&nbsp;</span><span class="keyword">class</span><span>&nbsp;Singleton&nbsp;&nbsp;</span></span></li> <li class=""><span>{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;Singleton()&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;</span><span class="keyword">readonly</span><span>&nbsp;</span><span class="keyword">object</span><span>&nbsp;padlock&nbsp;=&nbsp;</span><span class="keyword">new</span><span>&nbsp;</span><span class="keyword">object</span><span>();&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;instance&nbsp;=&nbsp;</span><span class="keyword">null</span><span>;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;Instance&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">get</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">if</span><span>&nbsp;(instance&nbsp;==&nbsp;</span><span class="keyword">null</span><span>)&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">lock</span><span>&nbsp;(padlock)&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">if</span><span>&nbsp;(instance&nbsp;==&nbsp;</span><span class="keyword">null</span><span>)&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;instance&nbsp;=&nbsp;<span class="keyword">new</span><span>&nbsp;Singleton();&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;instance;&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>}</span></li></ol></div> <div><strong>4. Thread Safe Singleton without using locks and no lazy instantiation</strong></div><div>&nbsp;</div><div>Explanation of the following code:</div> <ol> <li>The preceding implementation looks like very simple code.</li> <li>This type of implementation has a static constructor, so it executes only once per Application Domain.</li> <li>It is not as lazy as the other implementation.</li></ol> <div></div> <div class="dp-highlighter"> <div class="bar"></div> <ol start="1" class="dp-c"> <li class="alt"><span><span class="keyword">public</span><span>&nbsp;</span><span class="keyword">sealed</span><span>&nbsp;</span><span class="keyword">class</span><span>&nbsp;Singleton&nbsp;&nbsp;</span></span></li> <li class=""><span>{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;</span><span class="keyword">readonly</span><span>&nbsp;Singleton&nbsp;instance&nbsp;=&nbsp;</span><span class="keyword">new</span><span>&nbsp;Singleton();&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//&nbsp;Explicit&nbsp;static&nbsp;constructor&nbsp;to&nbsp;tell&nbsp;C#&nbsp;compiler</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//&nbsp;not&nbsp;to&nbsp;mark&nbsp;type&nbsp;as&nbsp;beforefieldinit</span><span>&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">static</span><span>&nbsp;Singleton()&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;Singleton()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;Instance&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">get</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;instance;&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>}&nbsp;&nbsp;</span></li> </ol> </div> <div><strong>5. Fully lazy instantiation</strong></div><div>&nbsp;</div><div>Explanation of the following code:</div> <ol> <li>Here, instantiation is triggered by the first reference to the static member of the nested class, that only occurs in Instance.</li> <li>This means the implementation is fully lazy, but has all the performance benefits of the previous ones.</li> <li>Note that although nested classes have access to the enclosing class's private members, the reverse is not true, hence the need for instance to be internal here.</li> <li>That doesn't raise any other problems, though, as the class itself is private.</li> <li>The code is more complicated in order to make the instantiation lazy.</li></ol> <div></div> <div class="dp-highlighter"> <div class="bar"></div> <ol start="1" class="dp-c"> <li class="alt"><span><span class="keyword">public</span><span>&nbsp;</span><span class="keyword">sealed</span><span>&nbsp;</span><span class="keyword">class</span><span>&nbsp;Singleton&nbsp;&nbsp;</span></span></li> <li class=""><span>{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;</span><span class="keyword">readonly</span><span>&nbsp;Singleton&nbsp;instance&nbsp;=&nbsp;</span><span class="keyword">new</span><span>&nbsp;Singleton();&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//&nbsp;Explicit&nbsp;static&nbsp;constructor&nbsp;to&nbsp;tell&nbsp;C#&nbsp;compiler</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="comment">//&nbsp;not&nbsp;to&nbsp;mark&nbsp;type&nbsp;as&nbsp;beforefieldinit</span><span>&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">static</span><span>&nbsp;Singleton()&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;Singleton()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;Instance&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">get</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;instance;&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>}&nbsp;&nbsp;</span></li> </ol> </div> <div></div> <div><strong>6. Using .NET 4's Lazy&lt;T&gt; type</strong></div><div>&nbsp;</div> <div>Explanation of the following code:</div> <ol> <li>If you're using .NET 4 (or higher) then you can use the System.Lazy&lt;T&gt; type to make the laziness really simple.</li> <li>All you need to do is pass a delegate to the constructor that calls the Singleton constructor, which is done most easily with a lambda expression.</li> <li>It also allows you to check whether or not the instance has been created with the IsValueCreated property.</li></ol> <div></div> <div class="dp-highlighter"> <div class="bar"></div> <ol start="1" class="dp-c"> <li class="alt"><span><span class="keyword">public</span><span>&nbsp;</span><span class="keyword">sealed</span><span>&nbsp;</span><span class="keyword">class</span><span>&nbsp;Singleton&nbsp;&nbsp;</span></span></li> <li class=""><span>{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;Singleton()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;</span><span class="keyword">readonly</span><span>&nbsp;Lazy&lt;Singleton&gt;&nbsp;lazy&nbsp;=&nbsp;</span><span class="keyword">new</span><span>&nbsp;Lazy&lt;Singleton&gt;(()&nbsp;=&gt;&nbsp;</span><span class="keyword">new</span><span>&nbsp;Singleton());&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Singleton&nbsp;Instance&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">get</span><span>&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;lazy.Value;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>}&nbsp;&nbsp;</span></li> </ol> </div> <div><strong>Example</strong></div><div>&nbsp;</div> <div>The final example is here:</div> <div></div> <div class="dp-highlighter"> <div class="bar"></div> <ol start="1" class="dp-c"> <li class="alt"><span><span class="keyword">namespace</span><span>&nbsp;Singleton&nbsp;&nbsp;</span></span></li> <li class=""><span>{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">class</span><span>&nbsp;Program&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">static</span><span>&nbsp;</span><span class="keyword">void</span><span>&nbsp;Main(</span><span class="keyword">string</span><span>[]&nbsp;args)&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Calculate.Instance.ValueOne&nbsp;=&nbsp;10.5;&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Calculate.Instance.ValueTwo&nbsp;=&nbsp;5.5;&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Addition&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Addition());&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Subtraction&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Subtraction());&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Multiplication&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Multiplication());&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Division&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Division());&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"\n----------------------\n"</span><span>);&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Calculate.Instance.ValueTwo&nbsp;=&nbsp;10.5;&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Addition&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Addition());&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Subtraction&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Subtraction());&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Multiplication&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Multiplication());&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="string">"Division&nbsp;:&nbsp;"</span><span>&nbsp;+&nbsp;Calculate.Instance.Division());&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.ReadLine();&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">sealed</span><span>&nbsp;</span><span class="keyword">class</span><span>&nbsp;Calculate&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;Calculate()&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">private</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Calculate&nbsp;instance&nbsp;=&nbsp;</span><span class="keyword">null</span><span>;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">static</span><span>&nbsp;Calculate&nbsp;Instance&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">get</span><span>&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">if</span><span>&nbsp;(instance&nbsp;==&nbsp;</span><span class="keyword">null</span><span>)&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;instance&nbsp;=&nbsp;<span class="keyword">new</span><span>&nbsp;Calculate();&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;instance;&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">double</span><span>&nbsp;ValueOne&nbsp;{&nbsp;</span><span class="keyword">get</span><span>;&nbsp;</span><span class="keyword">set</span><span>;&nbsp;}&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">double</span><span>&nbsp;ValueTwo&nbsp;{&nbsp;</span><span class="keyword">get</span><span>;&nbsp;</span><span class="keyword">set</span><span>;&nbsp;}&nbsp;&nbsp;</span></span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">double</span><span>&nbsp;Addition()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;ValueOne&nbsp;+&nbsp;ValueTwo;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">double</span><span>&nbsp;Subtraction()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;ValueOne&nbsp;-&nbsp;ValueTwo;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">double</span><span>&nbsp;Multiplication()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;ValueOne&nbsp;*&nbsp;ValueTwo;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">public</span><span>&nbsp;</span><span class="keyword">double</span><span>&nbsp;Division()&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="keyword">return</span><span>&nbsp;ValueOne&nbsp;/&nbsp;ValueTwo;&nbsp;&nbsp;</span></span></li> <li class=""><span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class="alt"><span>&nbsp;&nbsp;&nbsp;&nbsp;}&nbsp;&nbsp;</span></li> <li class=""><span>}&nbsp;&nbsp;</span></li> </ol> </div> <div>Please provide your feedback on this article.<br> </div> <p></p></div> <div id="ArticleExtentionContainer"> 




<input type="hidden" name="ctl00$hiddenArticleUrl" id="hiddenArticleUrl" value="/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/">
<input type="hidden" name="ctl00$HiddenCategoryID" id="HiddenCategoryID" value="144">
<input type="hidden" name="ctl00$HiddenArticleID" id="HiddenArticleID" value="e63e94cb-9a26-4992-9cff-a0bc443a1b39">
<input type="hidden" name="ctl00$HiddenLoginCheckReturnUrl" id="HiddenLoginCheckReturnUrl" value="https://www.c-sharpcorner.com/userregistration/logincheck.aspx?returnurl=https://www.c-sharpcorner.com/uploadfile/8911c4/singleton-design-pattern-in-c-sharp/">
</div> </div>