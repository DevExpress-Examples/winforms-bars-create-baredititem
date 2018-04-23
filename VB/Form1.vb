Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace CreateEditItem
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barStandard As DevExpress.XtraBars.Bar
		Private barStatus As DevExpress.XtraBars.Bar
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.barManager1 = New DevExpress.XtraBars.BarManager()
			Me.barStandard = New DevExpress.XtraBars.Bar()
			Me.barStatus = New DevExpress.XtraBars.Bar()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.barStandard, Me.barStatus})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			Me.barManager1.StatusBar = Me.barStatus
			' 
			' barStandard
			' 
			Me.barStandard.BarName = "Standard"
			Me.barStandard.DockCol = 0
			Me.barStandard.DockRow = 0
			Me.barStandard.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.barStandard.Text = "Standard"
			' 
			' barStatus
			' 
			Me.barStatus.BarName = "Status bar"
			Me.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.barStatus.DockCol = 0
			Me.barStatus.DockRow = 0
			Me.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.barStatus.OptionsBar.AllowQuickCustomization = False
			Me.barStatus.OptionsBar.DrawDragBorder = False
			Me.barStatus.OptionsBar.UseWholeRow = True
			Me.barStatus.Text = "Status bar"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(296, 178)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim item As DevExpress.XtraBars.BarEditItem
			Dim combo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
			Dim progress As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

			barManager1.ForceInitialize()

			' create combo
			combo = TryCast(barManager1.RepositoryItems.Add("ComboBoxEdit"), DevExpress.XtraEditors.Repository.RepositoryItemComboBox)
			combo.Items.Add("Item A")
			combo.Items.Add("Item B")
			item = New DevExpress.XtraBars.BarEditItem(barManager1)
			item.Edit = combo
			item.EditValue = "[n/a]"
			item.Width = 100
			barStandard.AddItem(item)

			' create progress
			progress = TryCast(barManager1.RepositoryItems.Add("ProgressBarControl"), DevExpress.XtraEditors.Repository.RepositoryItemProgressBar)
			item = New DevExpress.XtraBars.BarEditItem(barManager1)
			item.Edit = progress
			item.EditValue = 26 ' 26%
			item.Width = 150
			barStatus.AddItem(item)
		End Sub
	End Class
End Namespace
