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
        lblTitle = New Label()
        lblInstructions = New Label()
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnFour = New Button()
        btnFive = New Button()
        btnExit = New Button()
        lblFrench = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(28, 88)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(566, 24)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Do you know the french words for the numbers 1 through 5?"
        ' 
        ' lblInstructions
        ' 
        lblInstructions.AutoSize = True
        lblInstructions.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstructions.Location = New Point(175, 129)
        lblInstructions.Name = "lblInstructions"
        lblInstructions.Size = New Size(264, 22)
        lblInstructions.TabIndex = 1
        lblInstructions.Text = "Click the buttons to see them. "
        ' 
        ' btnOne
        ' 
        btnOne.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOne.Location = New Point(44, 191)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(84, 43)
        btnOne.TabIndex = 2
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTwo.Location = New Point(158, 191)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(84, 43)
        btnTwo.TabIndex = 3
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnThree.Location = New Point(272, 191)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(84, 43)
        btnThree.TabIndex = 4
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFour.Location = New Point(389, 191)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(84, 43)
        btnFour.TabIndex = 5
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' btnFive
        ' 
        btnFive.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFive.Location = New Point(501, 191)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(84, 43)
        btnFive.TabIndex = 6
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(272, 347)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(84, 43)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblFrench
        ' 
        lblFrench.AutoSize = True
        lblFrench.BackColor = Color.Lime
        lblFrench.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFrench.ForeColor = Color.MediumBlue
        lblFrench.Location = New Point(281, 277)
        lblFrench.Name = "lblFrench"
        lblFrench.Size = New Size(40, 27)
        lblFrench.TabIndex = 8
        lblFrench.Text = "un"
        lblFrench.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(606, 450)
        Controls.Add(lblFrench)
        Controls.Add(btnExit)
        Controls.Add(btnFive)
        Controls.Add(btnFour)
        Controls.Add(btnThree)
        Controls.Add(btnTwo)
        Controls.Add(btnOne)
        Controls.Add(lblInstructions)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "French Numbers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFrench As Label

End Class
