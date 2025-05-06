<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAstrologicalChart
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblLocationSelectedMsg = New System.Windows.Forms.Label()
        Me.CBoxLocations = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.TxtBoxLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnClean = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TooltipFirstName = New System.Windows.Forms.ToolTip(Me.components)
        Me.CBoxHours = New System.Windows.Forms.ComboBox()
        Me.MiddleHourPoints = New System.Windows.Forms.TextBox()
        Me.LblLocality = New System.Windows.Forms.Label()
        Me.CBoxLocalities = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LblLatLonMsg = New System.Windows.Forms.Label()
        Me.TooltipLastName = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLocationSelectedMsg
        '
        Me.LblLocationSelectedMsg.AutoSize = True
        Me.LblLocationSelectedMsg.Location = New System.Drawing.Point(145, 384)
        Me.LblLocationSelectedMsg.Name = "LblLocationSelectedMsg"
        Me.LblLocationSelectedMsg.Size = New System.Drawing.Size(0, 13)
        Me.LblLocationSelectedMsg.TabIndex = 8
        '
        'CBoxLocations
        '
        Me.CBoxLocations.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBoxLocations.FormattingEnabled = True
        Me.CBoxLocations.Location = New System.Drawing.Point(145, 269)
        Me.CBoxLocations.Name = "CBoxLocations"
        Me.CBoxLocations.Size = New System.Drawing.Size(167, 21)
        Me.CBoxLocations.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 43)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese sus Datos Personales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Lugar de nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombres"
        '
        'TxtBoxFirstName
        '
        Me.TxtBoxFirstName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtBoxFirstName.Location = New System.Drawing.Point(148, 118)
        Me.TxtBoxFirstName.Name = "TxtBoxFirstName"
        Me.TxtBoxFirstName.Size = New System.Drawing.Size(164, 20)
        Me.TxtBoxFirstName.TabIndex = 12
        Me.TxtBoxFirstName.TabStop = False
        '
        'TxtBoxLastName
        '
        Me.TxtBoxLastName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TxtBoxLastName.Location = New System.Drawing.Point(390, 120)
        Me.TxtBoxLastName.Name = "TxtBoxLastName"
        Me.TxtBoxLastName.Size = New System.Drawing.Size(167, 20)
        Me.TxtBoxLastName.TabIndex = 13
        Me.TxtBoxLastName.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(145, 195)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(167, 21)
        Me.DateTimePicker.TabIndex = 16
        Me.DateTimePicker.Value = New Date(2024, 10, 23, 23, 30, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(387, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Hora de nacimiento"
        '
        'BtnClean
        '
        Me.BtnClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClean.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BtnClean.Location = New System.Drawing.Point(145, 438)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(75, 23)
        Me.BtnClean.TabIndex = 19
        Me.BtnClean.Text = "Limpiar"
        Me.BtnClean.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BtnSubmit.Location = New System.Drawing.Point(237, 438)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 20
        Me.BtnSubmit.Text = "Enviar"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'TooltipFirstName
        '
        Me.TooltipFirstName.AutoPopDelay = 10000
        Me.TooltipFirstName.InitialDelay = 200
        Me.TooltipFirstName.ReshowDelay = 100
        '
        'CBoxHours
        '
        Me.CBoxHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxHours.FormattingEnabled = True
        Me.CBoxHours.Location = New System.Drawing.Point(0, 0)
        Me.CBoxHours.Margin = New System.Windows.Forms.Padding(0)
        Me.CBoxHours.Name = "CBoxHours"
        Me.CBoxHours.Size = New System.Drawing.Size(76, 21)
        Me.CBoxHours.TabIndex = 23
        '
        'MiddleHourPoints
        '
        Me.MiddleHourPoints.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MiddleHourPoints.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MiddleHourPoints.Dock = System.Windows.Forms.DockStyle.Right
        Me.MiddleHourPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleHourPoints.Location = New System.Drawing.Point(79, 0)
        Me.MiddleHourPoints.Margin = New System.Windows.Forms.Padding(0)
        Me.MiddleHourPoints.Name = "MiddleHourPoints"
        Me.MiddleHourPoints.Size = New System.Drawing.Size(10, 19)
        Me.MiddleHourPoints.TabIndex = 24
        Me.MiddleHourPoints.Text = ":"
        '
        'LblLocality
        '
        Me.LblLocality.AutoSize = True
        Me.LblLocality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocality.Location = New System.Drawing.Point(142, 321)
        Me.LblLocality.Name = "LblLocality"
        Me.LblLocality.Size = New System.Drawing.Size(61, 15)
        Me.LblLocality.TabIndex = 26
        Me.LblLocality.Text = "Localidad"
        Me.LblLocality.Visible = False
        '
        'CBoxLocalities
        '
        Me.CBoxLocalities.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CBoxLocalities.FormattingEnabled = True
        Me.CBoxLocalities.Location = New System.Drawing.Point(145, 339)
        Me.CBoxLocalities.Name = "CBoxLocalities"
        Me.CBoxLocalities.Size = New System.Drawing.Size(167, 21)
        Me.CBoxLocalities.TabIndex = 25
        Me.CBoxLocalities.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.00285!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.994298!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.00285!))
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CBoxHours, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MiddleHourPoints, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(390, 195)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(167, 21)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'NumericUpDown
        '
        Me.NumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown.Location = New System.Drawing.Point(89, 0)
        Me.NumericUpDown.Margin = New System.Windows.Forms.Padding(0)
        Me.NumericUpDown.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(78, 21)
        Me.NumericUpDown.TabIndex = 29
        '
        'LblLatLonMsg
        '
        Me.LblLatLonMsg.AutoSize = True
        Me.LblLatLonMsg.Location = New System.Drawing.Point(145, 408)
        Me.LblLatLonMsg.Name = "LblLatLonMsg"
        Me.LblLatLonMsg.Size = New System.Drawing.Size(0, 13)
        Me.LblLatLonMsg.TabIndex = 29
        '
        'FormAstrologicalChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(702, 502)
        Me.Controls.Add(Me.LblLatLonMsg)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.LblLocality)
        Me.Controls.Add(Me.CBoxLocalities)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnClean)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBoxLastName)
        Me.Controls.Add(Me.TxtBoxFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBoxLocations)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblLocationSelectedMsg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "FormAstrologicalChart"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLocationSelectedMsg As System.Windows.Forms.Label
    Friend WithEvents CBoxLocations As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxFirstName As TextBox
    Friend WithEvents TxtBoxLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnClean As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TooltipFirstName As ToolTip
    Friend WithEvents CBoxHours As ComboBox
    Friend WithEvents MiddleHourPoints As TextBox
    Friend WithEvents LblLocality As Label
    Friend WithEvents CBoxLocalities As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NumericUpDown As NumericUpDown
    Friend WithEvents LblLatLonMsg As Label
    Friend WithEvents TooltipLastName As ToolTip
End Class
