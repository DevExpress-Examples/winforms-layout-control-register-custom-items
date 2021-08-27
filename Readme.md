<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633106/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2422)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DXExample/Form1.cs) (VB: [Form1.vb](./VB/DXExample/Form1.vb))
<!-- default file list end -->
# How to register custom layout items in LayoutControl


<p><strong>Problem:</strong></p><p>I've created my own layout control items with a custom functionality. How can I make the LayoutControl use them instead of default items?</p><p><strong>Solution:</strong></p><p>You should create a custom LayoutControl that uses a custom LayoutControlImplementor. In the LayoutControlImplementor, you should override corresponding methods, for example CreateLayoutItem and CreateLayoutGroup. Please see the attached sample for additional information.</p>

<br/>


