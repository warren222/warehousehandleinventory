Imports System.Data.SqlClient

Public Class sql
    Public sqlcon As New SqlConnection With {.ConnectionString = "data source = '121.58.229.248,49107';initial catalog='kmdidata';user id='kmdiadmin';password='kmdiadmin';network library='dbmssocn';"}
    Public sqlconstr As String = sqlcon.ConnectionString.ToString
End Class
