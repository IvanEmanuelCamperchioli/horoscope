<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAstrologicalChartResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAstrologicalChartResult))
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LblProcessing = New System.Windows.Forms.Label()
        Me.TableLayoutProcessing = New System.Windows.Forms.TableLayoutPanel()
        Me.TimerProcessing = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutReport = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBoxUserData = New System.Windows.Forms.GroupBox()
        Me.LblCoordinates = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblUserLocation = New System.Windows.Forms.Label()
        Me.LblBirthDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblCurrentDate = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblSunSign = New System.Windows.Forms.Label()
        Me.LblAscendant = New System.Windows.Forms.Label()
        Me.LblDescendant = New System.Windows.Forms.Label()
        Me.LblMoonSign = New System.Windows.Forms.Label()
        Me.LblMidheaven = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblMethod = New System.Windows.Forms.Label()
        Me.LblAstrologicalReportTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutAstrologicalReportIntro = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutReportSignInterpretations = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanelSunOn = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblSunOnSign = New System.Windows.Forms.Label()
        Me.LblSunInterpretation = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LblMoonOnSign = New System.Windows.Forms.Label()
        Me.LblMoonInterpretation = New System.Windows.Forms.Label()
        Me.TableLayoutProcessing.SuspendLayout()
        Me.TableLayoutReport.SuspendLayout()
        Me.GroupBoxUserData.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutAstrologicalReportIntro.SuspendLayout()
        Me.TableLayoutReportSignInterpretations.SuspendLayout()
        Me.FlowLayoutPanelSunOn.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar.ForeColor = System.Drawing.Color.LawnGreen
        Me.ProgressBar.Location = New System.Drawing.Point(3, 35)
        Me.ProgressBar.MarqueeAnimationSpeed = 25
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(434, 19)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 0
        '
        'LblProcessing
        '
        Me.LblProcessing.AutoSize = True
        Me.LblProcessing.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblProcessing.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProcessing.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblProcessing.Location = New System.Drawing.Point(3, 6)
        Me.LblProcessing.Name = "LblProcessing"
        Me.LblProcessing.Size = New System.Drawing.Size(434, 26)
        Me.LblProcessing.TabIndex = 1
        Me.LblProcessing.Text = "Procesando"
        Me.LblProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutProcessing
        '
        Me.TableLayoutProcessing.ColumnCount = 1
        Me.TableLayoutProcessing.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutProcessing.Controls.Add(Me.ProgressBar, 0, 1)
        Me.TableLayoutProcessing.Controls.Add(Me.LblProcessing, 0, 0)
        Me.TableLayoutProcessing.Location = New System.Drawing.Point(173, 169)
        Me.TableLayoutProcessing.Name = "TableLayoutProcessing"
        Me.TableLayoutProcessing.RowCount = 2
        Me.TableLayoutProcessing.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutProcessing.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutProcessing.Size = New System.Drawing.Size(440, 65)
        Me.TableLayoutProcessing.TabIndex = 2
        '
        'TimerProcessing
        '
        Me.TimerProcessing.Enabled = True
        Me.TimerProcessing.Interval = 3500
        '
        'TableLayoutReport
        '
        Me.TableLayoutReport.ColumnCount = 2
        Me.TableLayoutReport.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.52062!))
        Me.TableLayoutReport.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.47938!))
        Me.TableLayoutReport.Controls.Add(Me.GroupBoxUserData, 0, 0)
        Me.TableLayoutReport.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutReport.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutReport.Location = New System.Drawing.Point(12, 147)
        Me.TableLayoutReport.Name = "TableLayoutReport"
        Me.TableLayoutReport.RowCount = 2
        Me.TableLayoutReport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutReport.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutReport.Size = New System.Drawing.Size(776, 269)
        Me.TableLayoutReport.TabIndex = 3
        Me.TableLayoutReport.Visible = False
        '
        'GroupBoxUserData
        '
        Me.GroupBoxUserData.Controls.Add(Me.LblCoordinates)
        Me.GroupBoxUserData.Controls.Add(Me.Label6)
        Me.GroupBoxUserData.Controls.Add(Me.LblUserLocation)
        Me.GroupBoxUserData.Controls.Add(Me.LblBirthDate)
        Me.GroupBoxUserData.Controls.Add(Me.Label4)
        Me.GroupBoxUserData.Controls.Add(Me.LblCurrentDate)
        Me.GroupBoxUserData.Controls.Add(Me.LblUserName)
        Me.GroupBoxUserData.Controls.Add(Me.Label1)
        Me.GroupBoxUserData.Location = New System.Drawing.Point(3, 3)
        Me.GroupBoxUserData.Name = "GroupBoxUserData"
        Me.GroupBoxUserData.Size = New System.Drawing.Size(386, 121)
        Me.GroupBoxUserData.TabIndex = 0
        Me.GroupBoxUserData.TabStop = False
        Me.GroupBoxUserData.Text = "GroupBox1"
        Me.GroupBoxUserData.Visible = False
        '
        'LblCoordinates
        '
        Me.LblCoordinates.AutoSize = True
        Me.LblCoordinates.Location = New System.Drawing.Point(85, 83)
        Me.LblCoordinates.Name = "LblCoordinates"
        Me.LblCoordinates.Size = New System.Drawing.Size(0, 13)
        Me.LblCoordinates.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Coordenadas:"
        '
        'LblUserLocation
        '
        Me.LblUserLocation.AutoSize = True
        Me.LblUserLocation.Location = New System.Drawing.Point(6, 67)
        Me.LblUserLocation.Name = "LblUserLocation"
        Me.LblUserLocation.Size = New System.Drawing.Size(0, 13)
        Me.LblUserLocation.TabIndex = 6
        '
        'LblBirthDate
        '
        Me.LblBirthDate.AutoSize = True
        Me.LblBirthDate.Location = New System.Drawing.Point(108, 49)
        Me.LblBirthDate.Name = "LblBirthDate"
        Me.LblBirthDate.Size = New System.Drawing.Size(0, 13)
        Me.LblBirthDate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hora de nacimiento: "
        '
        'LblCurrentDate
        '
        Me.LblCurrentDate.AutoSize = True
        Me.LblCurrentDate.Location = New System.Drawing.Point(6, 32)
        Me.LblCurrentDate.Name = "LblCurrentDate"
        Me.LblCurrentDate.Size = New System.Drawing.Size(0, 13)
        Me.LblCurrentDate.TabIndex = 3
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Location = New System.Drawing.Point(6, 16)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(0, 13)
        Me.LblUserName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de usuario"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.16067!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.83933!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblSunSign, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblAscendant, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDescendant, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblMoonSign, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblMidheaven, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 137)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(361, 100)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Signo Solar: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ascendente: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Signo Lunar: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Descendente: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Medio Cielo: "
        '
        'LblSunSign
        '
        Me.LblSunSign.AutoSize = True
        Me.LblSunSign.Location = New System.Drawing.Point(83, 0)
        Me.LblSunSign.Name = "LblSunSign"
        Me.LblSunSign.Size = New System.Drawing.Size(0, 13)
        Me.LblSunSign.TabIndex = 5
        '
        'LblAscendant
        '
        Me.LblAscendant.AutoSize = True
        Me.LblAscendant.Location = New System.Drawing.Point(83, 20)
        Me.LblAscendant.Name = "LblAscendant"
        Me.LblAscendant.Size = New System.Drawing.Size(0, 13)
        Me.LblAscendant.TabIndex = 6
        '
        'LblDescendant
        '
        Me.LblDescendant.AutoSize = True
        Me.LblDescendant.Location = New System.Drawing.Point(83, 40)
        Me.LblDescendant.Name = "LblDescendant"
        Me.LblDescendant.Size = New System.Drawing.Size(0, 13)
        Me.LblDescendant.TabIndex = 7
        '
        'LblMoonSign
        '
        Me.LblMoonSign.AutoSize = True
        Me.LblMoonSign.Location = New System.Drawing.Point(83, 60)
        Me.LblMoonSign.Name = "LblMoonSign"
        Me.LblMoonSign.Size = New System.Drawing.Size(0, 13)
        Me.LblMoonSign.TabIndex = 8
        '
        'LblMidheaven
        '
        Me.LblMidheaven.AutoSize = True
        Me.LblMidheaven.Location = New System.Drawing.Point(83, 80)
        Me.LblMidheaven.Name = "LblMidheaven"
        Me.LblMidheaven.Size = New System.Drawing.Size(0, 13)
        Me.LblMidheaven.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LblMethod, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(558, 233)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(215, 33)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Método: "
        '
        'LblMethod
        '
        Me.LblMethod.AutoSize = True
        Me.LblMethod.Location = New System.Drawing.Point(58, 0)
        Me.LblMethod.Name = "LblMethod"
        Me.LblMethod.Size = New System.Drawing.Size(0, 13)
        Me.LblMethod.TabIndex = 9
        '
        'LblAstrologicalReportTitle
        '
        Me.LblAstrologicalReportTitle.AutoSize = True
        Me.LblAstrologicalReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAstrologicalReportTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblAstrologicalReportTitle.Location = New System.Drawing.Point(289, 9)
        Me.LblAstrologicalReportTitle.Name = "LblAstrologicalReportTitle"
        Me.LblAstrologicalReportTitle.Size = New System.Drawing.Size(221, 29)
        Me.LblAstrologicalReportTitle.TabIndex = 4
        Me.LblAstrologicalReportTitle.Text = "Informe Astrológico"
        Me.LblAstrologicalReportTitle.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 90)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'FlowLayoutAstrologicalReportIntro
        '
        Me.FlowLayoutAstrologicalReportIntro.Controls.Add(Me.Label2)
        Me.FlowLayoutAstrologicalReportIntro.Location = New System.Drawing.Point(140, 41)
        Me.FlowLayoutAstrologicalReportIntro.Name = "FlowLayoutAstrologicalReportIntro"
        Me.FlowLayoutAstrologicalReportIntro.Size = New System.Drawing.Size(506, 100)
        Me.FlowLayoutAstrologicalReportIntro.TabIndex = 5
        Me.FlowLayoutAstrologicalReportIntro.Visible = False
        '
        'TableLayoutReportSignInterpretations
        '
        Me.TableLayoutReportSignInterpretations.ColumnCount = 1
        Me.TableLayoutReportSignInterpretations.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutReportSignInterpretations.Controls.Add(Me.FlowLayoutPanelSunOn, 0, 0)
        Me.TableLayoutReportSignInterpretations.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutReportSignInterpretations.Location = New System.Drawing.Point(12, 422)
        Me.TableLayoutReportSignInterpretations.Name = "TableLayoutReportSignInterpretations"
        Me.TableLayoutReportSignInterpretations.RowCount = 2
        Me.TableLayoutReportSignInterpretations.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.17065!))
        Me.TableLayoutReportSignInterpretations.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.82935!))
        Me.TableLayoutReportSignInterpretations.Size = New System.Drawing.Size(776, 293)
        Me.TableLayoutReportSignInterpretations.TabIndex = 6
        Me.TableLayoutReportSignInterpretations.Visible = False
        '
        'FlowLayoutPanelSunOn
        '
        Me.FlowLayoutPanelSunOn.Controls.Add(Me.LblSunOnSign)
        Me.FlowLayoutPanelSunOn.Controls.Add(Me.LblSunInterpretation)
        Me.FlowLayoutPanelSunOn.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanelSunOn.Name = "FlowLayoutPanelSunOn"
        Me.FlowLayoutPanelSunOn.Size = New System.Drawing.Size(770, 120)
        Me.FlowLayoutPanelSunOn.TabIndex = 4
        '
        'LblSunOnSign
        '
        Me.LblSunOnSign.AutoSize = True
        Me.LblSunOnSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSunOnSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSunOnSign.Location = New System.Drawing.Point(3, 0)
        Me.LblSunOnSign.Name = "LblSunOnSign"
        Me.LblSunOnSign.Size = New System.Drawing.Size(68, 17)
        Me.LblSunOnSign.TabIndex = 4
        Me.LblSunOnSign.Text = "El Sol en "
        '
        'LblSunInterpretation
        '
        Me.LblSunInterpretation.AutoSize = True
        Me.LblSunInterpretation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSunInterpretation.Location = New System.Drawing.Point(77, 6)
        Me.LblSunInterpretation.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.LblSunInterpretation.Name = "LblSunInterpretation"
        Me.LblSunInterpretation.Size = New System.Drawing.Size(0, 13)
        Me.LblSunInterpretation.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.LblMoonOnSign)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblMoonInterpretation)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 150)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(765, 126)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'LblMoonOnSign
        '
        Me.LblMoonOnSign.AutoSize = True
        Me.LblMoonOnSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoonOnSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMoonOnSign.Location = New System.Drawing.Point(3, 0)
        Me.LblMoonOnSign.Name = "LblMoonOnSign"
        Me.LblMoonOnSign.Size = New System.Drawing.Size(84, 17)
        Me.LblMoonOnSign.TabIndex = 6
        Me.LblMoonOnSign.Text = "La Luna en "
        '
        'LblMoonInterpretation
        '
        Me.LblMoonInterpretation.AutoSize = True
        Me.LblMoonInterpretation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMoonInterpretation.Location = New System.Drawing.Point(93, 6)
        Me.LblMoonInterpretation.Margin = New System.Windows.Forms.Padding(3, 6, 3, 0)
        Me.LblMoonInterpretation.Name = "LblMoonInterpretation"
        Me.LblMoonInterpretation.Size = New System.Drawing.Size(0, 13)
        Me.LblMoonInterpretation.TabIndex = 7
        '
        'FormAstrologicalChartResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(829, 749)
        Me.Controls.Add(Me.TableLayoutReportSignInterpretations)
        Me.Controls.Add(Me.FlowLayoutAstrologicalReportIntro)
        Me.Controls.Add(Me.LblAstrologicalReportTitle)
        Me.Controls.Add(Me.TableLayoutReport)
        Me.Controls.Add(Me.TableLayoutProcessing)
        Me.Name = "FormAstrologicalChartResult"
        Me.TableLayoutProcessing.ResumeLayout(False)
        Me.TableLayoutProcessing.PerformLayout()
        Me.TableLayoutReport.ResumeLayout(False)
        Me.GroupBoxUserData.ResumeLayout(False)
        Me.GroupBoxUserData.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutAstrologicalReportIntro.ResumeLayout(False)
        Me.FlowLayoutAstrologicalReportIntro.PerformLayout()
        Me.TableLayoutReportSignInterpretations.ResumeLayout(False)
        Me.FlowLayoutPanelSunOn.ResumeLayout(False)
        Me.FlowLayoutPanelSunOn.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents LblProcessing As Label
    Friend WithEvents TableLayoutProcessing As TableLayoutPanel
    Friend WithEvents TimerProcessing As Timer
    Friend WithEvents TableLayoutReport As TableLayoutPanel
    Friend WithEvents LblAstrologicalReportTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutAstrologicalReportIntro As FlowLayoutPanel
    Friend WithEvents GroupBoxUserData As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblCurrentDate As Label
    Friend WithEvents LblBirthDate As Label
    Friend WithEvents LblUserLocation As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblCoordinates As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblSunSign As Label
    Friend WithEvents LblAscendant As Label
    Friend WithEvents LblDescendant As Label
    Friend WithEvents LblMoonSign As Label
    Friend WithEvents LblMidheaven As Label
    Friend WithEvents TableLayoutReportSignInterpretations As TableLayoutPanel
    Friend WithEvents LblSunInterpretation As Label
    Friend WithEvents FlowLayoutPanelSunOn As FlowLayoutPanel
    Friend WithEvents LblSunOnSign As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LblMoonOnSign As Label
    Friend WithEvents LblMoonInterpretation As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents LblMethod As Label
End Class
