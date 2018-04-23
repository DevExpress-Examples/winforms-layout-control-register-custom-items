Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports System.IO

Namespace DXExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class MyLayoutControl
		Inherits LayoutControl
		Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
			Return New MyLayoutControlImplementor(Me)
		End Function
	End Class
	Public Class MyLayoutControlImplementor
		Inherits LayoutControlImplementor
		Public Sub New(ByVal owner As ILayoutControlOwner)
			MyBase.New(owner)
		End Sub
		Public Overrides Function CreateLayoutGroup(ByVal parent As LayoutGroup) As LayoutGroup
			Return New MyLayoutControlGroup()
		End Function
		Public Overrides Function CreateLayoutItem(ByVal parent As LayoutGroup) As BaseLayoutItem
			Return New MyLayoutControlItem()
		End Function
	End Class
	Public Class MyLayoutControlGroup
		Inherits LayoutControlGroup
		Public Overrides Property TextVisible() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)

			End Set
		End Property
		Public Overrides Property Text() As String
			Get
				Return DateTime.Now.ToLongTimeString()
			End Get
			Set(ByVal value As String)

			End Set
		End Property
	End Class
	Public Class MyLayoutControlItem
		Inherits LayoutControlItem
		Public Overrides Property TextVisible() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)

			End Set
		End Property
		Public Overrides Property Text() As String
			Get
				Return DateTime.Now.ToLongTimeString()
			End Get
			Set(ByVal value As String)

			End Set
		End Property
	End Class
End Namespace