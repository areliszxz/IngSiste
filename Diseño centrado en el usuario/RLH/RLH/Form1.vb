Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox_Nmesero.Text = InputBox("Numero de mesero", "Mesero", 1)
        TextBox_Nmesa.Text = InputBox("Numero de mesa", "Mesa", 1)
    End Sub

    Private Sub ListBox_cuenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListBox_cuenta.Items.Remove(ListBox_cuenta.SelectedItem)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub AlimentosView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlimentosView.SelectedIndexChanged
        For Each lvi As ListViewItem In AlimentosView.SelectedItems
            ListBox_cuenta.Items.Add(lvi.Text)
            lvi.Selected = False
        Next
    End Sub

    Private Sub bebidasView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bebidasView.SelectedIndexChanged
        For Each lvi As ListViewItem In bebidasView.SelectedItems
            ListBox_cuenta.Items.Add(lvi.Text)
            lvi.Selected = False
        Next
    End Sub


    Private Sub Button_total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_total.Click
        Dim count, sumatoria As Integer
        Dim producto As String
        For count = 0 To ListBox_cuenta.Items.Count - 1
            producto = ListBox_cuenta.Items(count)
            producto = producto.Substring(producto.Length - 2)
            sumatoria = sumatoria + Int(producto)
        Next count
        TextBox_total.Text = sumatoria
    End Sub
End Class
