Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace CreateEditItem

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

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
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            barManager1 = New DevExpress.XtraBars.BarManager()
            barStandard = New DevExpress.XtraBars.Bar()
            barStatus = New DevExpress.XtraBars.Bar()
            barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType(barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {barStandard, barStatus})
            barManager1.DockControls.Add(barDockControlTop)
            barManager1.DockControls.Add(barDockControlBottom)
            barManager1.DockControls.Add(barDockControlLeft)
            barManager1.DockControls.Add(barDockControlRight)
            barManager1.Form = Me
            barManager1.MaxItemId = 0
            barManager1.StatusBar = barStatus
            ' 
            ' barStandard
            ' 
            barStandard.BarName = "Standard"
            barStandard.DockCol = 0
            barStandard.DockRow = 0
            barStandard.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            barStandard.Text = "Standard"
            ' 
            ' barStatus
            ' 
            barStatus.BarName = "Status bar"
            barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            barStatus.DockCol = 0
            barStatus.DockRow = 0
            barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            barStatus.OptionsBar.AllowQuickCustomization = False
            barStatus.OptionsBar.DrawDragBorder = False
            barStatus.OptionsBar.UseWholeRow = True
            barStatus.Text = "Status bar"
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(296, 178)
            Me.Controls.Add(barDockControlLeft)
            Me.Controls.Add(barDockControlRight)
            Me.Controls.Add(barDockControlBottom)
            Me.Controls.Add(barDockControlTop)
            Name = "Form1"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
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
