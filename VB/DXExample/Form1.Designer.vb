Imports Microsoft.VisualBasic
Imports System
Namespace DXExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.myLayoutControl1 = New DXExample.MyLayoutControl()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.myLayoutControlGroup1 = New DXExample.MyLayoutControlGroup()
			Me.myLayoutControlGroup3 = New DXExample.MyLayoutControlGroup()
			Me.myLayoutControlItem1 = New DXExample.MyLayoutControlItem()
			Me.myLayoutControlGroup2 = New DXExample.MyLayoutControlGroup()
			Me.myLayoutControlItem2 = New DXExample.MyLayoutControlItem()
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.myLayoutControl1.SuspendLayout()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myLayoutControl1
			' 
			Me.myLayoutControl1.Controls.Add(Me.textEdit2)
			Me.myLayoutControl1.Controls.Add(Me.textEdit1)
			Me.myLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myLayoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControl1.Name = "myLayoutControl1"
			Me.myLayoutControl1.Root = Me.layoutControlGroup1
			Me.myLayoutControl1.Size = New System.Drawing.Size(488, 306)
			Me.myLayoutControl1.TabIndex = 0
			Me.myLayoutControl1.Text = "myLayoutControl1"
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(317, 76)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(135, 20)
			Me.textEdit2.StyleController = Me.myLayoutControl1
			Me.textEdit2.TabIndex = 5
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(96, 76)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(133, 20)
			Me.textEdit1.StyleController = Me.myLayoutControl1
			Me.textEdit1.TabIndex = 4
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlGroup1})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(488, 306)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' myLayoutControlGroup1
			' 
			Me.myLayoutControlGroup1.CustomizationFormText = "MyLayoutControlGroup"
			Me.myLayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlGroup3, Me.myLayoutControlGroup2})
			Me.myLayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlGroup1.Name = "myLayoutControlGroup1"
			Me.myLayoutControlGroup1.Size = New System.Drawing.Size(468, 286)
			Me.myLayoutControlGroup1.Text = "3:03:39 AM"
			' 
			' myLayoutControlGroup3
			' 
			Me.myLayoutControlGroup3.CustomizationFormText = "2:04 AM"
			Me.myLayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlItem1})
			Me.myLayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlGroup3.Name = "myLayoutControlGroup3"
			Me.myLayoutControlGroup3.Size = New System.Drawing.Size(221, 242)
			Me.myLayoutControlGroup3.Text = "3:03:39 AM"
			' 
			' myLayoutControlItem1
			' 
			Me.myLayoutControlItem1.Control = Me.textEdit1
			Me.myLayoutControlItem1.CustomizationFormText = "3:02:21 AM"
			Me.myLayoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlItem1.Name = "myLayoutControlItem1"
			Me.myLayoutControlItem1.Size = New System.Drawing.Size(197, 198)
			Me.myLayoutControlItem1.Text = "3:03:39 AM"
			Me.myLayoutControlItem1.TextSize = New System.Drawing.Size(56, 13)
			' 
			' myLayoutControlGroup2
			' 
			Me.myLayoutControlGroup2.CustomizationFormText = "2:04 AM"
			Me.myLayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.myLayoutControlItem2})
			Me.myLayoutControlGroup2.Location = New System.Drawing.Point(221, 0)
			Me.myLayoutControlGroup2.Name = "myLayoutControlGroup2"
			Me.myLayoutControlGroup2.Size = New System.Drawing.Size(223, 242)
			Me.myLayoutControlGroup2.Text = "3:03:39 AM"
			' 
			' myLayoutControlItem2
			' 
			Me.myLayoutControlItem2.Control = Me.textEdit2
			Me.myLayoutControlItem2.CustomizationFormText = "3:02:21 AM"
			Me.myLayoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.myLayoutControlItem2.Name = "myLayoutControlItem2"
			Me.myLayoutControlItem2.Size = New System.Drawing.Size(199, 198)
			Me.myLayoutControlItem2.Text = "3:03:39 AM"
			Me.myLayoutControlItem2.TextSize = New System.Drawing.Size(56, 13)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(488, 306)
			Me.Controls.Add(Me.myLayoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.myLayoutControl1.ResumeLayout(False)
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myLayoutControl1 As MyLayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private myLayoutControlGroup1 As MyLayoutControlGroup
		Private myLayoutControlGroup3 As MyLayoutControlGroup
		Private myLayoutControlGroup2 As MyLayoutControlGroup
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private myLayoutControlItem1 As MyLayoutControlItem
		Private myLayoutControlItem2 As MyLayoutControlItem


	End Class
End Namespace

