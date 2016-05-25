<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AdS_Verbindung1 = New EBC_ADS_Bib.ADS_Verbindung()
        Me.Temperatursensor2 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor3 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor4 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor5 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor6 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor7 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor8 = New EBC_ADS_Bib.Temperatursensor()
        Me.DezimalAnzeige3 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Temperatursensor9 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor10 = New EBC_ADS_Bib.Temperatursensor()
        Me.Led1 = New EBC_ADS_Bib.LED()
        Me.Led2 = New EBC_ADS_Bib.LED()
        Me.Led3 = New EBC_ADS_Bib.LED()
        Me.Led4 = New EBC_ADS_Bib.LED()
        Me.Temperatursensor13 = New EBC_ADS_Bib.Temperatursensor()
        Me.Temperatursensor1 = New EBC_ADS_Bib.Temperatursensor()
        Me.DezimalAnzeige4 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige5 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige6 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige1 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige8 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige9 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige10 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige12 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.Temperatursensor15 = New EBC_ADS_Bib.Temperatursensor()
        Me.DezimalAnzeige7 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DezimalAnzeige2 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.DezimalAnzeige11 = New EBC_ADS_Bib.DezimalAnzeige()
        Me.SollWertEingabe1 = New EBC_ADS_Bib.SollWertEingabe()
        Me.SollWertEingabe2 = New EBC_ADS_Bib.SollWertEingabe()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdS_Verbindung1
        '
        Me.AdS_Verbindung1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdS_Verbindung1.Location = New System.Drawing.Point(37, 38)
        Me.AdS_Verbindung1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AdS_Verbindung1.Name = "AdS_Verbindung1"
        Me.AdS_Verbindung1.NetID = "5.33.15.132.1.1"
        Me.AdS_Verbindung1.Port = 851
        Me.AdS_Verbindung1.Size = New System.Drawing.Size(145, 68)
        Me.AdS_Verbindung1.TabIndex = 0
        '
        'Temperatursensor2
        '
        Me.Temperatursensor2.Aktuallisierungsrate = 1000
        Me.Temperatursensor2.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Links
        Me.Temperatursensor2.BackColor = System.Drawing.Color.White
        Me.Temperatursensor2.Bauform = Nothing
        Me.Temperatursensor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor2.Hinweis = Nothing
        Me.Temperatursensor2.Klasse = Nothing
        Me.Temperatursensor2.Location = New System.Drawing.Point(350, 177)
        Me.Temperatursensor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor2.Name = "Temperatursensor2"
        Me.Temperatursensor2.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor2.Symbolname = "GVL.Temp_VD_defrost_in.REAL_VAR"
        Me.Temperatursensor2.TabIndex = 5
        Me.Temperatursensor2.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor3
        '
        Me.Temperatursensor3.Aktuallisierungsrate = 1000
        Me.Temperatursensor3.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Rechts
        Me.Temperatursensor3.BackColor = System.Drawing.Color.White
        Me.Temperatursensor3.Bauform = Nothing
        Me.Temperatursensor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor3.Hinweis = Nothing
        Me.Temperatursensor3.Klasse = Nothing
        Me.Temperatursensor3.Location = New System.Drawing.Point(855, 80)
        Me.Temperatursensor3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor3.Name = "Temperatursensor3"
        Me.Temperatursensor3.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor3.Symbolname = "GVL.Temp_VF_in.REAL_VAR"
        Me.Temperatursensor3.TabIndex = 6
        Me.Temperatursensor3.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor4
        '
        Me.Temperatursensor4.Aktuallisierungsrate = 1000
        Me.Temperatursensor4.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Rechts
        Me.Temperatursensor4.BackColor = System.Drawing.Color.White
        Me.Temperatursensor4.Bauform = Nothing
        Me.Temperatursensor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor4.Hinweis = Nothing
        Me.Temperatursensor4.Klasse = Nothing
        Me.Temperatursensor4.Location = New System.Drawing.Point(855, 177)
        Me.Temperatursensor4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor4.Name = "Temperatursensor4"
        Me.Temperatursensor4.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor4.Symbolname = "GVL.Temp_VD_defrost_out.REAL_VAR"
        Me.Temperatursensor4.TabIndex = 7
        Me.Temperatursensor4.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor5
        '
        Me.Temperatursensor5.Aktuallisierungsrate = 1000
        Me.Temperatursensor5.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Links
        Me.Temperatursensor5.BackColor = System.Drawing.Color.White
        Me.Temperatursensor5.Bauform = Nothing
        Me.Temperatursensor5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor5.Hinweis = Nothing
        Me.Temperatursensor5.Klasse = Nothing
        Me.Temperatursensor5.Location = New System.Drawing.Point(37, 177)
        Me.Temperatursensor5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor5.Name = "Temperatursensor5"
        Me.Temperatursensor5.Size = New System.Drawing.Size(112, 45)
        Me.Temperatursensor5.Symbolname = "GVL.Temp_vor_EV_rev.REAL_VAR"
        Me.Temperatursensor5.TabIndex = 8
        Me.Temperatursensor5.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor6
        '
        Me.Temperatursensor6.Aktuallisierungsrate = 0
        Me.Temperatursensor6.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Links
        Me.Temperatursensor6.BackColor = System.Drawing.Color.White
        Me.Temperatursensor6.Bauform = Nothing
        Me.Temperatursensor6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor6.Hinweis = Nothing
        Me.Temperatursensor6.Klasse = Nothing
        Me.Temperatursensor6.Location = New System.Drawing.Point(37, 662)
        Me.Temperatursensor6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor6.Name = "Temperatursensor6"
        Me.Temperatursensor6.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor6.Symbolname = "GVL.Temp_vor_EV.REAL_VAR"
        Me.Temperatursensor6.TabIndex = 9
        Me.Temperatursensor6.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor7
        '
        Me.Temperatursensor7.Aktuallisierungsrate = 1000
        Me.Temperatursensor7.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Links
        Me.Temperatursensor7.BackColor = System.Drawing.Color.White
        Me.Temperatursensor7.Bauform = Nothing
        Me.Temperatursensor7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor7.Hinweis = Nothing
        Me.Temperatursensor7.Klasse = Nothing
        Me.Temperatursensor7.Location = New System.Drawing.Point(432, 664)
        Me.Temperatursensor7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor7.Name = "Temperatursensor7"
        Me.Temperatursensor7.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor7.Symbolname = "GVL.Temp_VD_out_rev.REAL_VAR"
        Me.Temperatursensor7.TabIndex = 10
        Me.Temperatursensor7.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor8
        '
        Me.Temperatursensor8.Aktuallisierungsrate = 1000
        Me.Temperatursensor8.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Links
        Me.Temperatursensor8.BackColor = System.Drawing.Color.White
        Me.Temperatursensor8.Bauform = Nothing
        Me.Temperatursensor8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor8.Hinweis = Nothing
        Me.Temperatursensor8.Klasse = Nothing
        Me.Temperatursensor8.Location = New System.Drawing.Point(434, 773)
        Me.Temperatursensor8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor8.Name = "Temperatursensor8"
        Me.Temperatursensor8.Size = New System.Drawing.Size(100, 36)
        Me.Temperatursensor8.Symbolname = "GVL.Temp_VD_in.REAL_VAR"
        Me.Temperatursensor8.TabIndex = 11
        Me.Temperatursensor8.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige3
        '
        Me.DezimalAnzeige3.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige3.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige3.Einheit = "Bar"
        Me.DezimalAnzeige3.Location = New System.Drawing.Point(37, 152)
        Me.DezimalAnzeige3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige3.Name = "DezimalAnzeige3"
        Me.DezimalAnzeige3.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige3.Symbolname = "GVL.PT_vor_EV_rev.rDruck"
        Me.DezimalAnzeige3.TabIndex = 18
        Me.DezimalAnzeige3.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1634, 860)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Temperatursensor9
        '
        Me.Temperatursensor9.Aktuallisierungsrate = 1000
        Me.Temperatursensor9.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Rechts
        Me.Temperatursensor9.BackColor = System.Drawing.Color.White
        Me.Temperatursensor9.Bauform = Nothing
        Me.Temperatursensor9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor9.Hinweis = Nothing
        Me.Temperatursensor9.Klasse = Nothing
        Me.Temperatursensor9.Location = New System.Drawing.Point(687, 774)
        Me.Temperatursensor9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor9.Name = "Temperatursensor9"
        Me.Temperatursensor9.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor9.Symbolname = "GVL.Temp_VD_out.REAL_VAR"
        Me.Temperatursensor9.TabIndex = 21
        Me.Temperatursensor9.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor10
        '
        Me.Temperatursensor10.Aktuallisierungsrate = 1000
        Me.Temperatursensor10.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Rechts
        Me.Temperatursensor10.BackColor = System.Drawing.Color.White
        Me.Temperatursensor10.Bauform = Nothing
        Me.Temperatursensor10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor10.Cursor = System.Windows.Forms.Cursors.No
        Me.Temperatursensor10.Hinweis = Nothing
        Me.Temperatursensor10.Klasse = Nothing
        Me.Temperatursensor10.Location = New System.Drawing.Point(687, 668)
        Me.Temperatursensor10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor10.Name = "Temperatursensor10"
        Me.Temperatursensor10.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor10.Symbolname = "GVL.Temp_VD_in_rev.REAL_VAR"
        Me.Temperatursensor10.TabIndex = 20
        Me.Temperatursensor10.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Led1
        '
        Me.Led1.Aktuallisierungsrate = 0
        Me.Led1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Led1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Led1.FarbeFalse = System.Drawing.Color.Empty
        Me.Led1.FarbeTrue = System.Drawing.Color.Empty
        Me.Led1.Location = New System.Drawing.Point(1119, 606)
        Me.Led1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Led1.Name = "Led1"
        Me.Led1.Size = New System.Drawing.Size(149, 59)
        Me.Led1.Symbolname = Nothing
        Me.Led1.TabIndex = 23
        Me.Led1.TextFalse = Nothing
        Me.Led1.TextTrue = Nothing
        Me.Led1.Wert = False
        '
        'Led2
        '
        Me.Led2.Aktuallisierungsrate = 0
        Me.Led2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Led2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Led2.FarbeFalse = System.Drawing.Color.Empty
        Me.Led2.FarbeTrue = System.Drawing.Color.Empty
        Me.Led2.Location = New System.Drawing.Point(1291, 606)
        Me.Led2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Led2.Name = "Led2"
        Me.Led2.Size = New System.Drawing.Size(149, 59)
        Me.Led2.Symbolname = Nothing
        Me.Led2.TabIndex = 24
        Me.Led2.TextFalse = Nothing
        Me.Led2.TextTrue = Nothing
        Me.Led2.Wert = False
        '
        'Led3
        '
        Me.Led3.Aktuallisierungsrate = 0
        Me.Led3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Led3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Led3.FarbeFalse = System.Drawing.Color.Empty
        Me.Led3.FarbeTrue = System.Drawing.Color.Empty
        Me.Led3.Location = New System.Drawing.Point(1119, 673)
        Me.Led3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Led3.Name = "Led3"
        Me.Led3.Size = New System.Drawing.Size(149, 59)
        Me.Led3.Symbolname = Nothing
        Me.Led3.TabIndex = 25
        Me.Led3.TextFalse = Nothing
        Me.Led3.TextTrue = Nothing
        Me.Led3.Wert = False
        '
        'Led4
        '
        Me.Led4.Aktuallisierungsrate = 0
        Me.Led4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Led4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Led4.FarbeFalse = System.Drawing.Color.Empty
        Me.Led4.FarbeTrue = System.Drawing.Color.Empty
        Me.Led4.Location = New System.Drawing.Point(1291, 673)
        Me.Led4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Led4.Name = "Led4"
        Me.Led4.Size = New System.Drawing.Size(149, 59)
        Me.Led4.Symbolname = Nothing
        Me.Led4.TabIndex = 26
        Me.Led4.TextFalse = Nothing
        Me.Led4.TextTrue = Nothing
        Me.Led4.Wert = False
        '
        'Temperatursensor13
        '
        Me.Temperatursensor13.Aktuallisierungsrate = 1000
        Me.Temperatursensor13.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Rechts
        Me.Temperatursensor13.BackColor = System.Drawing.Color.White
        Me.Temperatursensor13.Bauform = Nothing
        Me.Temperatursensor13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor13.Hinweis = Nothing
        Me.Temperatursensor13.Klasse = Nothing
        Me.Temperatursensor13.Location = New System.Drawing.Point(1340, 340)
        Me.Temperatursensor13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor13.Name = "Temperatursensor13"
        Me.Temperatursensor13.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor13.Symbolname = "GVL.Temp_KP_in.REAL_VAR"
        Me.Temperatursensor13.TabIndex = 28
        Me.Temperatursensor13.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor1
        '
        Me.Temperatursensor1.Aktuallisierungsrate = 1000
        Me.Temperatursensor1.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Links
        Me.Temperatursensor1.BackColor = System.Drawing.Color.White
        Me.Temperatursensor1.Bauform = Nothing
        Me.Temperatursensor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor1.Hinweis = Nothing
        Me.Temperatursensor1.Klasse = Nothing
        Me.Temperatursensor1.Location = New System.Drawing.Point(350, 80)
        Me.Temperatursensor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor1.Name = "Temperatursensor1"
        Me.Temperatursensor1.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor1.Symbolname = "GVL.Temp_VF_in.REAL_VAR"
        Me.Temperatursensor1.TabIndex = 29
        Me.Temperatursensor1.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige4
        '
        Me.DezimalAnzeige4.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige4.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige4.Einheit = "Bar"
        Me.DezimalAnzeige4.Location = New System.Drawing.Point(479, 89)
        Me.DezimalAnzeige4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige4.Name = "DezimalAnzeige4"
        Me.DezimalAnzeige4.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige4.Symbolname = "GVL.PT_VF_out.rDruck"
        Me.DezimalAnzeige4.TabIndex = 30
        Me.DezimalAnzeige4.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige5
        '
        Me.DezimalAnzeige5.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige5.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige5.Einheit = "Bar"
        Me.DezimalAnzeige5.Location = New System.Drawing.Point(477, 633)
        Me.DezimalAnzeige5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige5.Name = "DezimalAnzeige5"
        Me.DezimalAnzeige5.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige5.Symbolname = "GVL.PT_VD_in.rDruck"
        Me.DezimalAnzeige5.TabIndex = 32
        Me.DezimalAnzeige5.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige6
        '
        Me.DezimalAnzeige6.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige6.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige6.Einheit = "Bar"
        Me.DezimalAnzeige6.Location = New System.Drawing.Point(687, 638)
        Me.DezimalAnzeige6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige6.Name = "DezimalAnzeige6"
        Me.DezimalAnzeige6.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige6.Symbolname = "GVL.PT_VD_in.rDruck"
        Me.DezimalAnzeige6.TabIndex = 31
        Me.DezimalAnzeige6.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige1
        '
        Me.DezimalAnzeige1.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige1.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige1.Einheit = "Bar"
        Me.DezimalAnzeige1.Location = New System.Drawing.Point(37, 699)
        Me.DezimalAnzeige1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige1.Name = "DezimalAnzeige1"
        Me.DezimalAnzeige1.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige1.Symbolname = "GVL.PT_vor_EV.rDruck"
        Me.DezimalAnzeige1.TabIndex = 34
        Me.DezimalAnzeige1.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige8
        '
        Me.DezimalAnzeige8.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige8.Einheit = "%"
        Me.DezimalAnzeige8.Location = New System.Drawing.Point(182, 748)
        Me.DezimalAnzeige8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige8.Name = "DezimalAnzeige8"
        Me.DezimalAnzeige8.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige8.Symbolname = "GLV.EV.VentilOffnung"
        Me.DezimalAnzeige8.TabIndex = 35
        Me.DezimalAnzeige8.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige9
        '
        Me.DezimalAnzeige9.Aktuallisierungsrate = 0
        Me.DezimalAnzeige9.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige9.Einheit = Nothing
        Me.DezimalAnzeige9.Location = New System.Drawing.Point(812, 673)
        Me.DezimalAnzeige9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige9.Name = "DezimalAnzeige9"
        Me.DezimalAnzeige9.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige9.Symbolname = Nothing
        Me.DezimalAnzeige9.TabIndex = 36
        Me.DezimalAnzeige9.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige10
        '
        Me.DezimalAnzeige10.Aktuallisierungsrate = 0
        Me.DezimalAnzeige10.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige10.Einheit = Nothing
        Me.DezimalAnzeige10.Location = New System.Drawing.Point(812, 774)
        Me.DezimalAnzeige10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige10.Name = "DezimalAnzeige10"
        Me.DezimalAnzeige10.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige10.Symbolname = Nothing
        Me.DezimalAnzeige10.TabIndex = 37
        Me.DezimalAnzeige10.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige12
        '
        Me.DezimalAnzeige12.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige12.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige12.Einheit = "Bar"
        Me.DezimalAnzeige12.Location = New System.Drawing.Point(1385, 174)
        Me.DezimalAnzeige12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige12.Name = "DezimalAnzeige12"
        Me.DezimalAnzeige12.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige12.Symbolname = "GVL.PT_KP_out.rDruck"
        Me.DezimalAnzeige12.TabIndex = 39
        Me.DezimalAnzeige12.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Temperatursensor15
        '
        Me.Temperatursensor15.Aktuallisierungsrate = 1000
        Me.Temperatursensor15.Ausrichtung = EBC_ADS_Bib.Ausrichtung.Rechts
        Me.Temperatursensor15.BackColor = System.Drawing.Color.White
        Me.Temperatursensor15.Bauform = Nothing
        Me.Temperatursensor15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Temperatursensor15.Hinweis = Nothing
        Me.Temperatursensor15.Klasse = Nothing
        Me.Temperatursensor15.Location = New System.Drawing.Point(1340, 208)
        Me.Temperatursensor15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Temperatursensor15.Name = "Temperatursensor15"
        Me.Temperatursensor15.Size = New System.Drawing.Size(100, 35)
        Me.Temperatursensor15.Symbolname = "GVL.Temp_KP_out.REAL_VAR"
        Me.Temperatursensor15.TabIndex = 40
        Me.Temperatursensor15.Temperatur = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige7
        '
        Me.DezimalAnzeige7.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige7.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige7.Einheit = "Bar"
        Me.DezimalAnzeige7.Location = New System.Drawing.Point(709, 89)
        Me.DezimalAnzeige7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige7.Name = "DezimalAnzeige7"
        Me.DezimalAnzeige7.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige7.Symbolname = "GVL.PT_VF_in.rDruck"
        Me.DezimalAnzeige7.TabIndex = 41
        Me.DezimalAnzeige7.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 638)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(140, 100)
        Me.ListBox1.TabIndex = 42
        '
        'DezimalAnzeige2
        '
        Me.DezimalAnzeige2.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige2.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige2.Einheit = "mA"
        Me.DezimalAnzeige2.Location = New System.Drawing.Point(1219, 277)
        Me.DezimalAnzeige2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige2.Name = "DezimalAnzeige2"
        Me.DezimalAnzeige2.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige2.Symbolname = "REGLER.PID_KP.y"
        Me.DezimalAnzeige2.TabIndex = 43
        Me.DezimalAnzeige2.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DezimalAnzeige11
        '
        Me.DezimalAnzeige11.Aktuallisierungsrate = 1000
        Me.DezimalAnzeige11.BackColor = System.Drawing.Color.White
        Me.DezimalAnzeige11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DezimalAnzeige11.Einheit = "mA"
        Me.DezimalAnzeige11.Location = New System.Drawing.Point(581, 152)
        Me.DezimalAnzeige11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DezimalAnzeige11.Name = "DezimalAnzeige11"
        Me.DezimalAnzeige11.Size = New System.Drawing.Size(55, 26)
        Me.DezimalAnzeige11.Symbolname = "REGLER.PID_VF_Ventilator.y"
        Me.DezimalAnzeige11.TabIndex = 44
        Me.DezimalAnzeige11.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SollWertEingabe1
        '
        Me.SollWertEingabe1.Aktuallisierungsrate = 1000
        Me.SollWertEingabe1.Einheit = Nothing
        Me.SollWertEingabe1.Hinweis = Nothing
        Me.SollWertEingabe1.Location = New System.Drawing.Point(1119, 754)
        Me.SollWertEingabe1.manuellerModus = False
        Me.SollWertEingabe1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SollWertEingabe1.maxWert = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SollWertEingabe1.minWert = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SollWertEingabe1.Name = "SollWertEingabe1"
        Me.SollWertEingabe1.Size = New System.Drawing.Size(179, 20)
        Me.SollWertEingabe1.SollWertNeu = False
        Me.SollWertEingabe1.Symbolname = Nothing
        Me.SollWertEingabe1.TabIndex = 45
        Me.SollWertEingabe1.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SollWertEingabe2
        '
        Me.SollWertEingabe2.Aktuallisierungsrate = 0
        Me.SollWertEingabe2.Einheit = Nothing
        Me.SollWertEingabe2.Hinweis = Nothing
        Me.SollWertEingabe2.Location = New System.Drawing.Point(1119, 782)
        Me.SollWertEingabe2.manuellerModus = False
        Me.SollWertEingabe2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SollWertEingabe2.maxWert = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SollWertEingabe2.minWert = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SollWertEingabe2.Name = "SollWertEingabe2"
        Me.SollWertEingabe2.Size = New System.Drawing.Size(179, 20)
        Me.SollWertEingabe2.SollWertNeu = False
        Me.SollWertEingabe2.Symbolname = Nothing
        Me.SollWertEingabe2.TabIndex = 46
        Me.SollWertEingabe2.Wert = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1634, 860)
        Me.Controls.Add(Me.SollWertEingabe2)
        Me.Controls.Add(Me.SollWertEingabe1)
        Me.Controls.Add(Me.DezimalAnzeige11)
        Me.Controls.Add(Me.DezimalAnzeige2)
        Me.Controls.Add(Me.DezimalAnzeige7)
        Me.Controls.Add(Me.Temperatursensor15)
        Me.Controls.Add(Me.DezimalAnzeige12)
        Me.Controls.Add(Me.DezimalAnzeige10)
        Me.Controls.Add(Me.DezimalAnzeige9)
        Me.Controls.Add(Me.DezimalAnzeige8)
        Me.Controls.Add(Me.DezimalAnzeige1)
        Me.Controls.Add(Me.DezimalAnzeige5)
        Me.Controls.Add(Me.DezimalAnzeige6)
        Me.Controls.Add(Me.DezimalAnzeige4)
        Me.Controls.Add(Me.Temperatursensor1)
        Me.Controls.Add(Me.Temperatursensor13)
        Me.Controls.Add(Me.Led4)
        Me.Controls.Add(Me.Led3)
        Me.Controls.Add(Me.Led2)
        Me.Controls.Add(Me.Led1)
        Me.Controls.Add(Me.Temperatursensor9)
        Me.Controls.Add(Me.Temperatursensor10)
        Me.Controls.Add(Me.DezimalAnzeige3)
        Me.Controls.Add(Me.Temperatursensor8)
        Me.Controls.Add(Me.Temperatursensor7)
        Me.Controls.Add(Me.Temperatursensor6)
        Me.Controls.Add(Me.Temperatursensor5)
        Me.Controls.Add(Me.Temperatursensor4)
        Me.Controls.Add(Me.Temperatursensor3)
        Me.Controls.Add(Me.Temperatursensor2)
        Me.Controls.Add(Me.AdS_Verbindung1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdS_Verbindung1 As EBC_ADS_Bib.ADS_Verbindung
    Friend WithEvents Temperatursensor2 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor3 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor4 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor5 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor6 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor7 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor8 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents DezimalAnzeige3 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Temperatursensor9 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor10 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Led1 As EBC_ADS_Bib.LED
    Friend WithEvents Led2 As EBC_ADS_Bib.LED
    Friend WithEvents Led3 As EBC_ADS_Bib.LED
    Friend WithEvents Led4 As EBC_ADS_Bib.LED
    Friend WithEvents Temperatursensor13 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents Temperatursensor1 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents DezimalAnzeige4 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige5 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige6 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige1 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige8 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige9 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige10 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige12 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents Temperatursensor15 As EBC_ADS_Bib.Temperatursensor
    Friend WithEvents DezimalAnzeige7 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DezimalAnzeige2 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents DezimalAnzeige11 As EBC_ADS_Bib.DezimalAnzeige
    Friend WithEvents SollWertEingabe1 As EBC_ADS_Bib.SollWertEingabe
    Friend WithEvents SollWertEingabe2 As EBC_ADS_Bib.SollWertEingabe

End Class
