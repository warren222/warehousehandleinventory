<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNfind = New System.Windows.Forms.Button()
        Me.CBXcolumn = New System.Windows.Forms.ComboBox()
        Me.TBOXkey = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadingPBOX = New System.Windows.Forms.PictureBox()
        Me.BTNreload = New System.Windows.Forms.Button()
        Me.gv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTNfind)
        Me.Panel1.Controls.Add(Me.CBXcolumn)
        Me.Panel1.Controls.Add(Me.TBOXkey)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LoadingPBOX)
        Me.Panel1.Controls.Add(Me.BTNreload)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(868, 142)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 623
        Me.Label3.Text = "select column"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 622
        Me.Label2.Text = "Enter text to find"
        '
        'BTNfind
        '
        Me.BTNfind.Location = New System.Drawing.Point(431, 98)
        Me.BTNfind.Name = "BTNfind"
        Me.BTNfind.Size = New System.Drawing.Size(75, 23)
        Me.BTNfind.TabIndex = 621
        Me.BTNfind.Text = "Find"
        Me.BTNfind.UseVisualStyleBackColor = True
        '
        'CBXcolumn
        '
        Me.CBXcolumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBXcolumn.FormattingEnabled = True
        Me.CBXcolumn.Items.AddRange(New Object() {"DATED", "PROJECT", "[ADDRESS]", "CLNO", "KNO", "LOCATION", "COLOR", "QTY", "HANDLETYPE", "ADDITIONAL", "[DESCRIPTION]", "RELEASED", "DATERELEASED", "RECEIVEDBY", "CTRLNO"})
        Me.CBXcolumn.Location = New System.Drawing.Point(19, 97)
        Me.CBXcolumn.Name = "CBXcolumn"
        Me.CBXcolumn.Size = New System.Drawing.Size(121, 24)
        Me.CBXcolumn.TabIndex = 620
        '
        'TBOXkey
        '
        Me.TBOXkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOXkey.Location = New System.Drawing.Point(146, 97)
        Me.TBOXkey.Name = "TBOXkey"
        Me.TBOXkey.Size = New System.Drawing.Size(279, 23)
        Me.TBOXkey.TabIndex = 619
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(619, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 618
        Me.Button2.Text = "new"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(700, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 617
        Me.Button1.Text = "edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 39)
        Me.Label1.TabIndex = 616
        Me.Label1.Text = "Handle's Inventory"
        '
        'LoadingPBOX
        '
        Me.LoadingPBOX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPBOX.Image = CType(resources.GetObject("LoadingPBOX.Image"), System.Drawing.Image)
        Me.LoadingPBOX.Location = New System.Drawing.Point(774, 12)
        Me.LoadingPBOX.Name = "LoadingPBOX"
        Me.LoadingPBOX.Size = New System.Drawing.Size(82, 35)
        Me.LoadingPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPBOX.TabIndex = 615
        Me.LoadingPBOX.TabStop = False
        Me.LoadingPBOX.Visible = False
        '
        'BTNreload
        '
        Me.BTNreload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNreload.Location = New System.Drawing.Point(781, 71)
        Me.BTNreload.Name = "BTNreload"
        Me.BTNreload.Size = New System.Drawing.Size(75, 23)
        Me.BTNreload.TabIndex = 0
        Me.BTNreload.Text = "reload"
        Me.BTNreload.UseVisualStyleBackColor = True
        '
        'gv
        '
        Me.gv.AllowUserToAddRows = False
        Me.gv.AllowUserToDeleteRows = False
        Me.gv.AllowUserToOrderColumns = True
        Me.gv.AllowUserToResizeRows = False
        Me.gv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.gv.ColumnHeadersHeight = 32
        Me.gv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gv.Location = New System.Drawing.Point(0, 0)
        Me.gv.Name = "gv"
        Me.gv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.gv.RowHeadersWidth = 30
        Me.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gv.Size = New System.Drawing.Size(868, 338)
        Me.gv.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.gv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gv.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.gv.StateCommon.DataCell.Border.Width = 0
        Me.gv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.gv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.gv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.gv.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.gv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.gv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.gv.TabIndex = 555
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gv)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 338)
        Me.Panel2.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 480)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadingPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents gv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTNreload As Button
    Friend WithEvents LoadingPBOX As PictureBox
    Friend WithEvents CBXcolumn As ComboBox
    Friend WithEvents TBOXkey As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNfind As Button
End Class
