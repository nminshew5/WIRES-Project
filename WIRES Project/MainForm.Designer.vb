﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.StudentsTab = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblName = New MaterialSkin.Controls.MaterialLabel()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Events = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMajor = New MaterialSkin.Controls.MaterialLabel()
        Me.lblGradDate = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMinor = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Major = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grad_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl.SuspendLayout()
        Me.StudentsTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Events.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.StudentsTab)
        Me.TabControl.Controls.Add(Me.Events)
        Me.TabControl.Depth = 0
        Me.TabControl.Location = New System.Drawing.Point(-1, 111)
        Me.TabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1191, 621)
        Me.TabControl.TabIndex = 0
        '
        'StudentsTab
        '
        Me.StudentsTab.Controls.Add(Me.GroupBox1)
        Me.StudentsTab.Controls.Add(Me.DataGridView1)
        Me.StudentsTab.Location = New System.Drawing.Point(4, 22)
        Me.StudentsTab.Name = "StudentsTab"
        Me.StudentsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StudentsTab.Size = New System.Drawing.Size(1183, 595)
        Me.StudentsTab.TabIndex = 0
        Me.StudentsTab.Text = "Students"
        Me.StudentsTab.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialLabel6)
        Me.GroupBox1.Controls.Add(Me.MaterialDivider2)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel5)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel4)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.lblMinor)
        Me.GroupBox1.Controls.Add(Me.lblGradDate)
        Me.GroupBox1.Controls.Add(Me.lblMajor)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox1.Controls.Add(Me.DataGridView4)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox1.Controls.Add(Me.DataGridView3)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.pic_user)
        Me.GroupBox1.Controls.Add(Me.MaterialDivider1)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 583)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblName.Depth = 0
        Me.lblName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(121, 28)
        Me.lblName.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(104, 19)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Student Name"
        '
        'pic_user
        '
        Me.pic_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pic_user.Image = CType(resources.GetObject("pic_user.Image"), System.Drawing.Image)
        Me.pic_user.Location = New System.Drawing.Point(56, 28)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(59, 57)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 2
        Me.pic_user.TabStop = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(33, 19)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(654, 159)
        Me.MaterialDivider1.TabIndex = 4
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstName, Me.Last_Name, Me.Major, Me.Grad_Date})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 583)
        Me.DataGridView1.TabIndex = 0
        '
        'TabSelector1
        '
        Me.TabSelector1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TabSelector1.BaseTabControl = Me.TabControl
        Me.TabSelector1.Depth = 0
        Me.TabSelector1.Location = New System.Drawing.Point(-1, 62)
        Me.TabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabSelector1.Name = "TabSelector1"
        Me.TabSelector1.Size = New System.Drawing.Size(1191, 43)
        Me.TabSelector1.TabIndex = 1
        Me.TabSelector1.Text = "MainTabSelector"
        '
        'Events
        '
        Me.Events.Controls.Add(Me.DataGridView2)
        Me.Events.Location = New System.Drawing.Point(4, 22)
        Me.Events.Name = "Events"
        Me.Events.Padding = New System.Windows.Forms.Padding(3)
        Me.Events.Size = New System.Drawing.Size(1098, 495)
        Me.Events.TabIndex = 1
        Me.Events.Text = "Events"
        Me.Events.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(9, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(398, 483)
        Me.DataGridView2.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(33, 311)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(654, 116)
        Me.DataGridView3.TabIndex = 5
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(25, 289)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(54, 19)
        Me.MaterialLabel2.TabIndex = 6
        Me.MaterialLabel2.Text = "Events"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(33, 455)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(654, 122)
        Me.DataGridView4.TabIndex = 7
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(29, 433)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(89, 19)
        Me.MaterialLabel3.TabIndex = 8
        Me.MaterialLabel3.Text = "Interactions"
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMajor.Depth = 0
        Me.lblMajor.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMajor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMajor.Location = New System.Drawing.Point(52, 92)
        Me.lblMajor.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(52, 19)
        Me.lblMajor.TabIndex = 9
        Me.lblMajor.Text = "Major:"
        '
        'lblGradDate
        '
        Me.lblGradDate.AutoSize = True
        Me.lblGradDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblGradDate.Depth = 0
        Me.lblGradDate.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblGradDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGradDate.Location = New System.Drawing.Point(52, 150)
        Me.lblGradDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblGradDate.Name = "lblGradDate"
        Me.lblGradDate.Size = New System.Drawing.Size(117, 19)
        Me.lblGradDate.TabIndex = 10
        Me.lblGradDate.Text = "GraduationDate:"
        '
        'lblMinor
        '
        Me.lblMinor.AutoSize = True
        Me.lblMinor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMinor.Depth = 0
        Me.lblMinor.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMinor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMinor.Location = New System.Drawing.Point(52, 121)
        Me.lblMinor.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMinor.Name = "lblMinor"
        Me.lblMinor.Size = New System.Drawing.Size(52, 19)
        Me.lblMinor.TabIndex = 11
        Me.lblMinor.Text = "Minor:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(403, 92)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel1.TabIndex = 12
        Me.MaterialLabel1.Text = "Email:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(403, 121)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(55, 19)
        Me.MaterialLabel4.TabIndex = 13
        Me.MaterialLabel4.Text = "Phone:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(403, 150)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(80, 19)
        Me.MaterialLabel5.TabIndex = 14
        Me.MaterialLabel5.Text = "Interested:"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(33, 220)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(654, 66)
        Me.MaterialDivider2.TabIndex = 15
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(29, 198)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(50, 19)
        Me.MaterialLabel6.TabIndex = 16
        Me.MaterialLabel6.Text = "Notes"
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        '
        'Last_Name
        '
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        '
        'Major
        '
        Me.Major.HeaderText = "Major"
        Me.Major.Name = "Major"
        '
        'Grad_Date
        '
        Me.Grad_Date.HeaderText = "Grad Date"
        Me.Grad_Date.Name = "Grad_Date"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 735)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.TabSelector1)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Sizable = False
        Me.Text = "WIRES"
        Me.TabControl.ResumeLayout(False)
        Me.StudentsTab.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Events.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents StudentsTab As TabPage
    Friend WithEvents TabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pic_user As PictureBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Events As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents lblGradDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMajor As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMinor As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
    Friend WithEvents Major As DataGridViewTextBoxColumn
    Friend WithEvents Grad_Date As DataGridViewTextBoxColumn
End Class
