<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kasMasuk = New System.Windows.Forms.Button()
        Me.kasKeluar = New System.Windows.Forms.Button()
        Me.rekapitulasi = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.masuk = New System.Windows.Forms.TextBox()
        Me.keluar = New System.Windows.Forms.TextBox()
        Me.saldo = New System.Windows.Forms.TextBox()
        Me.data = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Std Black", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Klinik Dr. Indra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kasMasuk
        '
        Me.kasMasuk.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kasMasuk.Location = New System.Drawing.Point(613, 155)
        Me.kasMasuk.Name = "kasMasuk"
        Me.kasMasuk.Size = New System.Drawing.Size(133, 46)
        Me.kasMasuk.TabIndex = 1
        Me.kasMasuk.Text = "Kas Masuk"
        Me.kasMasuk.UseVisualStyleBackColor = True
        '
        'kasKeluar
        '
        Me.kasKeluar.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kasKeluar.Location = New System.Drawing.Point(613, 229)
        Me.kasKeluar.Name = "kasKeluar"
        Me.kasKeluar.Size = New System.Drawing.Size(133, 46)
        Me.kasKeluar.TabIndex = 2
        Me.kasKeluar.Text = "Kas Keluar"
        Me.kasKeluar.UseVisualStyleBackColor = True
        '
        'rekapitulasi
        '
        Me.rekapitulasi.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rekapitulasi.Location = New System.Drawing.Point(613, 302)
        Me.rekapitulasi.Name = "rekapitulasi"
        Me.rekapitulasi.Size = New System.Drawing.Size(133, 46)
        Me.rekapitulasi.TabIndex = 3
        Me.rekapitulasi.Text = "Rekapitulasi"
        Me.rekapitulasi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Kas Masuk         :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Kas Keluar        :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Saldo                 :"
        '
        'masuk
        '
        Me.masuk.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masuk.Location = New System.Drawing.Point(259, 154)
        Me.masuk.Name = "masuk"
        Me.masuk.ReadOnly = True
        Me.masuk.Size = New System.Drawing.Size(260, 26)
        Me.masuk.TabIndex = 7
        '
        'keluar
        '
        Me.keluar.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluar.Location = New System.Drawing.Point(259, 226)
        Me.keluar.Name = "keluar"
        Me.keluar.ReadOnly = True
        Me.keluar.Size = New System.Drawing.Size(260, 26)
        Me.keluar.TabIndex = 8
        '
        'saldo
        '
        Me.saldo.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saldo.Location = New System.Drawing.Point(259, 295)
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.Size = New System.Drawing.Size(260, 26)
        Me.saldo.TabIndex = 9
        '
        'data
        '
        Me.data.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.data.Location = New System.Drawing.Point(79, 362)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(133, 46)
        Me.data.TabIndex = 10
        Me.data.Text = "Tampil Data"
        Me.data.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.saldo)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.masuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rekapitulasi)
        Me.Controls.Add(Me.kasKeluar)
        Me.Controls.Add(Me.kasMasuk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Home"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents kasMasuk As Button
    Friend WithEvents kasKeluar As Button
    Friend WithEvents rekapitulasi As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents masuk As TextBox
    Friend WithEvents keluar As TextBox
    Friend WithEvents saldo As TextBox
    Friend WithEvents data As Button
End Class
