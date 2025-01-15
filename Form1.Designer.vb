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
        TextISBN = New TextBox()
        TextTitre = New TextBox()
        TextAuteur = New TextBox()
        ButtonAfficher = New Button()
        ButtonAjouter = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' TextISBN
        ' 
        TextISBN.BackColor = SystemColors.HighlightText
        TextISBN.Location = New Point(235, 77)
        TextISBN.Name = "TextISBN"
        TextISBN.Size = New Size(125, 27)
        TextISBN.TabIndex = 0
        ' 
        ' TextTitre
        ' 
        TextTitre.Location = New Point(235, 156)
        TextTitre.Name = "TextTitre"
        TextTitre.Size = New Size(125, 27)
        TextTitre.TabIndex = 1
        ' 
        ' TextAuteur
        ' 
        TextAuteur.Location = New Point(235, 234)
        TextAuteur.Name = "TextAuteur"
        TextAuteur.Size = New Size(125, 27)
        TextAuteur.TabIndex = 2
        ' 
        ' ButtonAfficher
        ' 
        ButtonAfficher.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonAfficher.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAfficher.Location = New Point(459, 302)
        ButtonAfficher.Name = "ButtonAfficher"
        ButtonAfficher.Size = New Size(195, 61)
        ButtonAfficher.TabIndex = 3
        ButtonAfficher.Text = "afficher"
        ButtonAfficher.UseVisualStyleBackColor = False
        ' 
        ' ButtonAjouter
        ' 
        ButtonAjouter.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ButtonAjouter.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAjouter.ForeColor = SystemColors.ActiveCaptionText
        ButtonAjouter.Location = New Point(194, 302)
        ButtonAjouter.Name = "ButtonAjouter"
        ButtonAjouter.Size = New Size(199, 61)
        ButtonAjouter.TabIndex = 4
        ButtonAjouter.Text = "ajouter"
        ButtonAjouter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(134, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 35)
        Label1.TabIndex = 5
        Label1.Text = "ISBN:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.Coral
        Label2.Location = New Point(137, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 35)
        Label2.TabIndex = 6
        Label2.Text = "Titre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.Coral
        Label3.Location = New Point(129, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 35)
        Label3.TabIndex = 7
        Label3.Text = "Auteur:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonAjouter)
        Controls.Add(ButtonAfficher)
        Controls.Add(TextAuteur)
        Controls.Add(TextTitre)
        Controls.Add(TextISBN)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextISBN As TextBox
    Friend WithEvents TextTitre As TextBox
    Friend WithEvents TextAuteur As TextBox
    Friend WithEvents ButtonAfficher As Button
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
