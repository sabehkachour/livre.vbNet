<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher3
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
        dgv_livre = New DataGridView()
        ISBN = New DataGridViewTextBoxColumn()
        Titre = New DataGridViewTextBoxColumn()
        Auteur = New DataGridViewTextBoxColumn()
        CType(dgv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_livre
        ' 
        dgv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_livre.Columns.AddRange(New DataGridViewColumn() {ISBN, Titre, Auteur})
        dgv_livre.Location = New Point(64, 100)
        dgv_livre.Name = "dgv_livre"
        dgv_livre.RowHeadersWidth = 51
        dgv_livre.Size = New Size(386, 83)
        dgv_livre.TabIndex = 0
        ' 
        ' ISBN
        ' 
        ISBN.HeaderText = "isbn"
        ISBN.MinimumWidth = 6
        ISBN.Name = "ISBN"
        ISBN.Width = 125
        ' 
        ' Titre
        ' 
        Titre.HeaderText = "titre"
        Titre.MinimumWidth = 6
        Titre.Name = "Titre"
        Titre.Width = 125
        ' 
        ' Auteur
        ' 
        Auteur.HeaderText = "auteur"
        Auteur.MinimumWidth = 6
        Auteur.Name = "Auteur"
        Auteur.Width = 125
        ' 
        ' frm_afficher3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 450)
        Controls.Add(dgv_livre)
        Name = "frm_afficher3"
        Text = "frm_afficher3"
        CType(dgv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_livre As DataGridView
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Titre As DataGridViewTextBoxColumn
    Friend WithEvents Auteur As DataGridViewTextBoxColumn
End Class
