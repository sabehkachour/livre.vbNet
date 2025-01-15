<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(65, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 42)
        Label1.TabIndex = 0
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Coral
        Label2.Location = New Point(261, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 42)
        Label2.TabIndex = 1
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Coral
        Label3.Location = New Point(453, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 42)
        Label3.TabIndex = 2
        Label3.Text = "Auteur"
        ' 
        ' lst_isbn
        ' 
        lst_isbn.BackColor = Color.SandyBrown
        lst_isbn.FormattingEnabled = True
        lst_isbn.Location = New Point(48, 107)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(138, 264)
        lst_isbn.TabIndex = 3
        ' 
        ' lst_titre
        ' 
        lst_titre.BackColor = Color.SandyBrown
        lst_titre.FormattingEnabled = True
        lst_titre.Location = New Point(238, 107)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(138, 264)
        lst_titre.TabIndex = 4
        ' 
        ' lst_auteur
        ' 
        lst_auteur.BackColor = Color.SandyBrown
        lst_auteur.FormattingEnabled = True
        lst_auteur.Location = New Point(443, 107)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(138, 264)
        lst_auteur.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.Location = New Point(528, 389)
        Button1.Name = "Button1"
        Button1.Size = New Size(216, 49)
        Button1.TabIndex = 6
        Button1.Text = "Afficher"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(945, 450)
        Controls.Add(Button1)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Auteur"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents Button1 As Button
End Class
