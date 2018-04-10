<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.StudentsTab = New System.Windows.Forms.TabPage()
        Me.EventsTab = New System.Windows.Forms.TabPage()
        Me.TabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabControl.SuspendLayout()
        Me.StudentsTab.SuspendLayout()
        Me.EventsTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.EventsTab)
        Me.TabControl.Controls.Add(Me.StudentsTab)
        Me.TabControl.Depth = 0
        Me.TabControl.Location = New System.Drawing.Point(-1, 111)
        Me.TabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1106, 521)
        Me.TabControl.TabIndex = 0
        '
        'StudentsTab
        '
        Me.StudentsTab.Controls.Add(Me.GroupBox1)
        Me.StudentsTab.Controls.Add(Me.DataGridView1)
        Me.StudentsTab.Location = New System.Drawing.Point(4, 22)
        Me.StudentsTab.Name = "StudentsTab"
        Me.StudentsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StudentsTab.Size = New System.Drawing.Size(1098, 495)
        Me.StudentsTab.TabIndex = 0
        Me.StudentsTab.Text = "Students"
        Me.StudentsTab.UseVisualStyleBackColor = True
        '
        'EventsTab
        '
        Me.EventsTab.Controls.Add(Me.DataGridView2)
        Me.EventsTab.Location = New System.Drawing.Point(4, 22)
        Me.EventsTab.Name = "EventsTab"
        Me.EventsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.EventsTab.Size = New System.Drawing.Size(1098, 495)
        Me.EventsTab.TabIndex = 1
        Me.EventsTab.Text = "Events"
        Me.EventsTab.UseVisualStyleBackColor = True
        '
        'TabSelector1
        '
        Me.TabSelector1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TabSelector1.BaseTabControl = Me.TabControl
        Me.TabSelector1.Depth = 0
        Me.TabSelector1.Location = New System.Drawing.Point(-1, 62)
        Me.TabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabSelector1.Name = "TabSelector1"
        Me.TabSelector1.Size = New System.Drawing.Size(1106, 43)
        Me.TabSelector1.TabIndex = 1
        Me.TabSelector1.Text = "MainTabSelector"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 483)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Controls.Add(Me.pic_user)
        Me.GroupBox1.Controls.Add(Me.MaterialDivider1)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 483)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'pic_user
        '
        Me.pic_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pic_user.Image = CType(resources.GetObject("pic_user.Image"), System.Drawing.Image)
        Me.pic_user.Location = New System.Drawing.Point(56, 28)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(59, 59)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 2
        Me.pic_user.TabStop = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(137, 28)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(104, 19)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "Student Name"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(33, 19)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(551, 118)
        Me.MaterialDivider1.TabIndex = 4
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(256, 188)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 635)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.TabSelector1)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Sizable = False
        Me.Text = "WIRES"
        Me.TabControl.ResumeLayout(False)
        Me.StudentsTab.ResumeLayout(False)
        Me.EventsTab.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents StudentsTab As TabPage
    Friend WithEvents EventsTab As TabPage
    Friend WithEvents TabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pic_user As PictureBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents DataGridView2 As DataGridView
End Class
