Option Strict Off
Option Explicit On
Imports System.Threading.Tasks

Friend Class frmVMSettings
    Inherits System.Windows.Forms.Form
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close() 'Saves nothing and closes the dialog
    End Sub
    Dim editsready As Integer = 0
    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
SaveSettings:
        'Save settings in a file
        Try
            If Not frmMain.MacToEdit = machinenameTextBox.Text Then
                Dim lines() As String = System.IO.File.ReadAllLines(frmMain.MacToEditPath)
                For i As Integer = 0 To lines.Length - 1
                    If lines(i).StartsWith("name=") Then lines(i) = "name=" & machinenameTextBox.Text
                Next
                System.IO.File.WriteAllLines(frmMain.MacToEditPath, lines)
            End If
        Catch ex As Exception
            MsgBox("Error saving the file.", MsgBoxStyle.Critical)
        End Try
        Try
            For Each item As String In My.Settings.MacList
                If frmMain.Before(item, ",").Trim(Chr(34)) = frmMain.MacToEdit Then
                    queueseddit(My.Settings.MacList.IndexOf(item), item.Replace("""" & frmMain.Before(item, ",").Trim(Chr(34)) & """" & ",", """" & machinenameTextBox.Text & ""","))
                End If
            Next
        Catch ex As Exception
        End Try
        editsready = 1
        For Each item As ListViewItem In frmMain.VMListnew.Items
            frmMain.VMListnew.Items.Item(frmMain.VMListnew.Items.IndexOf(item)).Text = item.Text.Replace(item.Text.Replace("Not running", "").TrimEnd(" "), machinenameTextBox.Text)
        Next
        Me.Close()
    End Sub
    Sub queueseddit(index As Integer, newdata As String)
        editsready = 0
        Dim t As New Task(New Action(Sub()
                                         Try
                                             Do Until editsready = 1
                                             Loop
                                             My.Settings.MacList.Item(index) = newdata
                                             My.Settings.Save()
                                         Catch ex As Exception
                                             Me.Invoke(Sub()
                                                           MsgBox(ex.Message)
                                                       End Sub)
                                         End Try
                                     End Sub))
        t.Start()
    End Sub
    Private Sub frmVMSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MachineName.Dock = DockStyle.Fill
        Me.Text = "Settings for " + frmMain.MacToEdit
        Try
            For Each line As String In IO.File.ReadAllLines(frmMain.MacToEditPath)
                If line.StartsWith("name=") Then machinenameTextBox.Text = line.Remove(0, 5)
            Next
        Catch ex As Exception
            MsgBox("Cant edit settings for inaccessible machine.", MsgBoxStyle.Critical)
            Me.Close()
        End Try
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Label2.Hide()
            If ListView1.SelectedItems(0).Text = "Machine Name" Then
                MachineName.Show()
            Else
                MachineName.Hide()
                Label2.Show()
            End If
        End If
    End Sub
End Class