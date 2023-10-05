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
        lbl_name = New Label()
        lbl_age = New Label()
        txtb_name = New TextBox()
        txtb_age = New TextBox()
        lbl_occupation = New Label()
        txtb_occupation = New TextBox()
        btn_saveData = New Button()
        SuspendLayout()
        ' 
        ' lbl_name
        ' 
        lbl_name.AutoSize = True
        lbl_name.Location = New Point(30, 37)
        lbl_name.Name = "lbl_name"
        lbl_name.Size = New Size(42, 15)
        lbl_name.TabIndex = 0
        lbl_name.Text = "Name:"
        ' 
        ' lbl_age
        ' 
        lbl_age.AutoSize = True
        lbl_age.Location = New Point(30, 75)
        lbl_age.Name = "lbl_age"
        lbl_age.Size = New Size(31, 15)
        lbl_age.TabIndex = 1
        lbl_age.Text = "Age:"
        ' 
        ' txtb_name
        ' 
        txtb_name.Location = New Point(120, 34)
        txtb_name.Name = "txtb_name"
        txtb_name.Size = New Size(183, 23)
        txtb_name.TabIndex = 2
        ' 
        ' txtb_age
        ' 
        txtb_age.Location = New Point(120, 72)
        txtb_age.Name = "txtb_age"
        txtb_age.Size = New Size(100, 23)
        txtb_age.TabIndex = 3
        ' 
        ' lbl_occupation
        ' 
        lbl_occupation.AutoSize = True
        lbl_occupation.Location = New Point(30, 112)
        lbl_occupation.Name = "lbl_occupation"
        lbl_occupation.Size = New Size(69, 15)
        lbl_occupation.TabIndex = 4
        lbl_occupation.Text = "Occupation"
        ' 
        ' txtb_occupation
        ' 
        txtb_occupation.Location = New Point(120, 109)
        txtb_occupation.Name = "txtb_occupation"
        txtb_occupation.Size = New Size(183, 23)
        txtb_occupation.TabIndex = 5
        ' 
        ' btn_saveData
        ' 
        btn_saveData.Location = New Point(30, 161)
        btn_saveData.Name = "btn_saveData"
        btn_saveData.Size = New Size(273, 23)
        btn_saveData.TabIndex = 6
        btn_saveData.Text = "Save data"
        btn_saveData.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(346, 226)
        Controls.Add(btn_saveData)
        Controls.Add(txtb_occupation)
        Controls.Add(lbl_occupation)
        Controls.Add(txtb_age)
        Controls.Add(txtb_name)
        Controls.Add(lbl_age)
        Controls.Add(lbl_name)
        Name = "Form1"
        Text = "2 Dimensional Array"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_age As Label
    Friend WithEvents txtb_name As TextBox
    Friend WithEvents txtb_age As TextBox
    Friend WithEvents lbl_occupation As Label
    Friend WithEvents txtb_occupation As TextBox
    Friend WithEvents btn_saveData As Button
End Class
