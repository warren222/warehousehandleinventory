Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1
    Dim bgw As New BackgroundWorker
    Dim action As String
    Dim bs As New BindingSource
    Dim ds As New DataSet
    Dim sql As New sql
    Dim condition As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        AddHandler bgw.DoWork, AddressOf bgw_DoWork

        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        gv.DataSource = bs
        CBXcolumn.SelectedIndex = 0
        condition = CBXcolumn.Text + " like " + "'%" & TBOXkey.Text & "%'"
        starter("SEARCH")
    End Sub
    Private Sub starter(act As String)
        If Not bgw.IsBusy = True Then
            action = act
            LoadingPBOX.Visible = True
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show(Me, "i am busy try again later", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "SEARCH"
                queries(action)
                bgw.ReportProgress(0)

        End Select
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "SEARCH"
                LoadingPBOX.Visible = False
        End Select
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "SEARCH"
                bs.DataSource = ds
                bs.DataMember = "HANDLEINVENTORY"
        End Select
    End Sub
    Private Sub buttonclick(sender As Object, e As EventArgs) Handles BTNreload.Click, BTNfind.Click
        Select Case sender.name
            Case "BTNreload"
                condition = CBXcolumn.Text + " like " + "'%" & TBOXkey.Text & "%'"
                starter("SEARCH")
            Case "BTNfind"
                condition = CBXcolumn.Text + " like " + "'%" & TBOXkey.Text & "%'"
                starter("SEARCH")
        End Select
    End Sub
    Public Sub queries(ByVal command As String)
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlconstr)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                Try
                    sqlcon.Open()
                    With sqlcmd
                        .CommandText = "[WAREHOUSE_handleinventoryFRM]"
                        .CommandType = CommandType.StoredProcedure
                        .CommandTimeout = 30000
                        .Parameters.AddWithValue("@command", command)
                        .Parameters.AddWithValue("@val", "")
                        .Parameters.AddWithValue("@condition", condition)
                    End With
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        With da
                            .SelectCommand = sqlcmd
                            .Fill(ds, "HANDLEINVENTORY")
                        End With
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub


End Class
