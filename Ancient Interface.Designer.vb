<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        purplesquarebox = New TextBox()
        goldenrhombusbox = New TextBox()
        greensquarebox = New TextBox()
        BindingSource1 = New BindingSource(components)
        greensquare = New PictureBox()
        purplesquare = New PictureBox()
        PictureBox3 = New PictureBox()
        goldenrhombus = New PictureBox()
        Label1 = New Label()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        CType(greensquare, ComponentModel.ISupportInitialize).BeginInit()
        CType(purplesquare, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(goldenrhombus, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(301, 355)
        Button1.Name = "Button1"
        Button1.Size = New Size(201, 44)
        Button1.TabIndex = 0
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' purplesquarebox
        ' 
        purplesquarebox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        purplesquarebox.Location = New Point(170, 250)
        purplesquarebox.Name = "purplesquarebox"
        purplesquarebox.Size = New Size(57, 34)
        purplesquarebox.TabIndex = 1
        purplesquarebox.TextAlign = HorizontalAlignment.Right
        ' 
        ' goldenrhombusbox
        ' 
        goldenrhombusbox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        goldenrhombusbox.Location = New Point(373, 250)
        goldenrhombusbox.Name = "goldenrhombusbox"
        goldenrhombusbox.Size = New Size(57, 34)
        goldenrhombusbox.TabIndex = 2
        goldenrhombusbox.TextAlign = HorizontalAlignment.Right
        ' 
        ' greensquarebox
        ' 
        greensquarebox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        greensquarebox.Location = New Point(578, 250)
        greensquarebox.Name = "greensquarebox"
        greensquarebox.Size = New Size(57, 34)
        greensquarebox.TabIndex = 3
        greensquarebox.TextAlign = HorizontalAlignment.Right
        ' 
        ' greensquare
        ' 
        greensquare.BorderStyle = BorderStyle.Fixed3D
        greensquare.Image = CType(resources.GetObject("greensquare.Image"), Image)
        greensquare.Location = New Point(544, 60)
        greensquare.Name = "greensquare"
        greensquare.Size = New Size(125, 125)
        greensquare.TabIndex = 4
        greensquare.TabStop = False
        ' 
        ' purplesquare
        ' 
        purplesquare.BorderStyle = BorderStyle.Fixed3D
        purplesquare.Image = CType(resources.GetObject("purplesquare.Image"), Image)
        purplesquare.Location = New Point(134, 60)
        purplesquare.Name = "purplesquare"
        purplesquare.Size = New Size(125, 125)
        purplesquare.TabIndex = 5
        purplesquare.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(109, 105)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(0, 0)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' goldenrhombus
        ' 
        goldenrhombus.Image = CType(resources.GetObject("goldenrhombus.Image"), Image)
        goldenrhombus.Location = New Point(333, 12)
        goldenrhombus.Name = "goldenrhombus"
        goldenrhombus.Size = New Size(139, 199)
        goldenrhombus.TabIndex = 7
        goldenrhombus.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(301, 402)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(goldenrhombus)
        Controls.Add(PictureBox3)
        Controls.Add(purplesquare)
        Controls.Add(greensquare)
        Controls.Add(greensquarebox)
        Controls.Add(goldenrhombusbox)
        Controls.Add(purplesquarebox)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Ancient Interface"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        CType(greensquare, ComponentModel.ISupportInitialize).EndInit()
        CType(purplesquare, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(goldenrhombus, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents purplesquarebox As TextBox
    Friend WithEvents goldenrhombusbox As TextBox
    Friend WithEvents greensquarebox As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents greensquare As PictureBox
    Friend WithEvents purplesquare As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents goldenrhombus As PictureBox
    Friend WithEvents Label1 As Label

End Class
