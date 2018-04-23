# How to register custom layout items in LayoutControl


<p><strong>Problem:</strong></p><p>I've created my own layout control items with a custom functionality. How can I make the LayoutControl use them instead of default items?</p><p><strong>Solution:</strong></p><p>You should create a custom LayoutControl that uses a custom LayoutControlImplementor. In the LayoutControlImplementor, you should override corresponding methods, for example CreateLayoutItem and CreateLayoutGroup. Please see the attached sample for additional information.</p>

<br/>


