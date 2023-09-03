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
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_width = New System.Windows.Forms.Label()
        Me.lbl_depth = New System.Windows.Forms.Label()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.lbl_referencenumber = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_input = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.lbvl_costofliner = New System.Windows.Forms.Label()
        Me.lbl_typeofliner = New System.Windows.Forms.Label()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.txt_width = New System.Windows.Forms.TextBox()
        Me.txt_depth = New System.Windows.Forms.TextBox()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.txt_referencenumber = New System.Windows.Forms.TextBox()
        Me.txt_typeofliner = New System.Windows.Forms.TextBox()
        Me.txt_costofliner = New System.Windows.Forms.TextBox()
        Me.txt_area = New System.Windows.Forms.TextBox()
        Me.txt_View = New System.Windows.Forms.TextBox()
        Me.lbl_display = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_length.Location = New System.Drawing.Point(34, 149)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(65, 21)
        Me.lbl_length.TabIndex = 0
        Me.lbl_length.Text = "Length"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(616, 27)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(48, 16)
        Me.lbl_date.TabIndex = 7
        Me.lbl_date.Text = "Label8"
        '
        'lbl_width
        '
        Me.lbl_width.AutoSize = True
        Me.lbl_width.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_width.Location = New System.Drawing.Point(34, 211)
        Me.lbl_width.Name = "lbl_width"
        Me.lbl_width.Size = New System.Drawing.Size(56, 21)
        Me.lbl_width.TabIndex = 8
        Me.lbl_width.Text = "Width"
        '
        'lbl_depth
        '
        Me.lbl_depth.AutoSize = True
        Me.lbl_depth.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_depth.Location = New System.Drawing.Point(34, 270)
        Me.lbl_depth.Name = "lbl_depth"
        Me.lbl_depth.Size = New System.Drawing.Size(60, 21)
        Me.lbl_depth.TabIndex = 9
        Me.lbl_depth.Text = "Depth"
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.Location = New System.Drawing.Point(34, 333)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(138, 21)
        Me.lbl_customername.TabIndex = 10
        Me.lbl_customername.Text = "Customer Name"
        '
        'lbl_referencenumber
        '
        Me.lbl_referencenumber.AutoSize = True
        Me.lbl_referencenumber.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_referencenumber.Location = New System.Drawing.Point(34, 398)
        Me.lbl_referencenumber.Name = "lbl_referencenumber"
        Me.lbl_referencenumber.Size = New System.Drawing.Size(157, 21)
        Me.lbl_referencenumber.TabIndex = 11
        Me.lbl_referencenumber.Text = "Reference Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(275, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Outputs"
        '
        'lbl_input
        '
        Me.lbl_input.AutoSize = True
        Me.lbl_input.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input.Location = New System.Drawing.Point(34, 85)
        Me.lbl_input.Name = "lbl_input"
        Me.lbl_input.Size = New System.Drawing.Size(59, 21)
        Me.lbl_input.TabIndex = 14
        Me.lbl_input.Text = "Inputs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label9.Location = New System.Drawing.Point(33, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Pond-U-Like"
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_area.Location = New System.Drawing.Point(275, 149)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(49, 21)
        Me.lbl_area.TabIndex = 16
        Me.lbl_area.Text = "Area"
        '
        'lbvl_costofliner
        '
        Me.lbvl_costofliner.AutoSize = True
        Me.lbvl_costofliner.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbvl_costofliner.Location = New System.Drawing.Point(275, 204)
        Me.lbvl_costofliner.Name = "lbvl_costofliner"
        Me.lbvl_costofliner.Size = New System.Drawing.Size(104, 21)
        Me.lbvl_costofliner.TabIndex = 17
        Me.lbvl_costofliner.Text = "Cost of Liner"
        '
        'lbl_typeofliner
        '
        Me.lbl_typeofliner.AutoSize = True
        Me.lbl_typeofliner.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_typeofliner.Location = New System.Drawing.Point(275, 261)
        Me.lbl_typeofliner.Name = "lbl_typeofliner"
        Me.lbl_typeofliner.Size = New System.Drawing.Size(105, 21)
        Me.lbl_typeofliner.TabIndex = 18
        Me.lbl_typeofliner.Text = "Type of Liner"
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(539, 142)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(75, 39)
        Me.btn_calc.TabIndex = 19
        Me.btn_calc.Text = "Calculate"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(539, 189)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 39)
        Me.btn_save.TabIndex = 20
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Location = New System.Drawing.Point(539, 234)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(75, 39)
        Me.btn_view.TabIndex = 21
        Me.btn_view.Text = "View"
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'txt_length
        '
        Me.txt_length.Location = New System.Drawing.Point(36, 178)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(120, 20)
        Me.txt_length.TabIndex = 22
        '
        'txt_width
        '
        Me.txt_width.Location = New System.Drawing.Point(36, 242)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Size = New System.Drawing.Size(120, 20)
        Me.txt_width.TabIndex = 23
        '
        'txt_depth
        '
        Me.txt_depth.Location = New System.Drawing.Point(38, 304)
        Me.txt_depth.Name = "txt_depth"
        Me.txt_depth.Size = New System.Drawing.Size(120, 20)
        Me.txt_depth.TabIndex = 24
        '
        'txt_customername
        '
        Me.txt_customername.Location = New System.Drawing.Point(39, 366)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(120, 20)
        Me.txt_customername.TabIndex = 25
        '
        'txt_referencenumber
        '
        Me.txt_referencenumber.Location = New System.Drawing.Point(36, 433)
        Me.txt_referencenumber.Name = "txt_referencenumber"
        Me.txt_referencenumber.Size = New System.Drawing.Size(120, 20)
        Me.txt_referencenumber.TabIndex = 26
        '
        'txt_typeofliner
        '
        Me.txt_typeofliner.Location = New System.Drawing.Point(279, 300)
        Me.txt_typeofliner.Name = "txt_typeofliner"
        Me.txt_typeofliner.Size = New System.Drawing.Size(120, 20)
        Me.txt_typeofliner.TabIndex = 27
        '
        'txt_costofliner
        '
        Me.txt_costofliner.Location = New System.Drawing.Point(278, 236)
        Me.txt_costofliner.Name = "txt_costofliner"
        Me.txt_costofliner.Size = New System.Drawing.Size(120, 20)
        Me.txt_costofliner.TabIndex = 28
        '
        'txt_area
        '
        Me.txt_area.Location = New System.Drawing.Point(276, 176)
        Me.txt_area.Name = "txt_area"
        Me.txt_area.Size = New System.Drawing.Size(48, 20)
        Me.txt_area.TabIndex = 29
        '
        'txt_View
        '
        Me.txt_View.Location = New System.Drawing.Point(275, 382)
        Me.txt_View.Multiline = True
        Me.txt_View.Name = "txt_View"
        Me.txt_View.Size = New System.Drawing.Size(409, 173)
        Me.txt_View.TabIndex = 30
        '
        'lbl_display
        '
        Me.lbl_display.AutoSize = True
        Me.lbl_display.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display.Location = New System.Drawing.Point(274, 358)
        Me.lbl_display.Name = "lbl_display"
        Me.lbl_display.Size = New System.Drawing.Size(64, 21)
        Me.lbl_display.TabIndex = 31
        Me.lbl_display.Text = "Display"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(616, 43)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(48, 16)
        Me.lbl_time.TabIndex = 32
        Me.lbl_time.Text = "Label8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(324, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "m2"
        '
        'btn_quit
        '
        Me.btn_quit.Location = New System.Drawing.Point(539, 279)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(75, 39)
        Me.btn_quit.TabIndex = 34
        Me.btn_quit.Text = "Quit"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 567)
        Me.Controls.Add(Me.btn_quit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_display)
        Me.Controls.Add(Me.txt_View)
        Me.Controls.Add(Me.txt_area)
        Me.Controls.Add(Me.txt_costofliner)
        Me.Controls.Add(Me.txt_typeofliner)
        Me.Controls.Add(Me.txt_referencenumber)
        Me.Controls.Add(Me.txt_customername)
        Me.Controls.Add(Me.txt_depth)
        Me.Controls.Add(Me.txt_width)
        Me.Controls.Add(Me.txt_length)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.lbl_typeofliner)
        Me.Controls.Add(Me.lbvl_costofliner)
        Me.Controls.Add(Me.lbl_area)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_input)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_referencenumber)
        Me.Controls.Add(Me.lbl_customername)
        Me.Controls.Add(Me.lbl_depth)
        Me.Controls.Add(Me.lbl_width)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_length)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_length As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_width As Label
    Friend WithEvents lbl_depth As Label
    Friend WithEvents lbl_customername As Label
    Friend WithEvents lbl_referencenumber As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_input As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_area As Label
    Friend WithEvents lbvl_costofliner As Label
    Friend WithEvents lbl_typeofliner As Label
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_view As Button
    Friend WithEvents txt_length As TextBox
    Friend WithEvents txt_width As TextBox
    Friend WithEvents txt_depth As TextBox
    Friend WithEvents txt_customername As TextBox
    Friend WithEvents txt_referencenumber As TextBox
    Friend WithEvents txt_typeofliner As TextBox
    Friend WithEvents txt_costofliner As TextBox
    Friend WithEvents txt_area As TextBox
    Friend WithEvents txt_View As TextBox
    Friend WithEvents lbl_display As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_quit As Button
End Class
