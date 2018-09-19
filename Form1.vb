Imports System.Data.SqlClient
Public Class Form1

    Private _sqlConnection As SqlConnection

    Private Property SqlConnection(p1 As String) As SqlConnection
        Get
            Return _sqlConnection
        End Get
        Set(value As SqlConnection)
            _sqlConnection = value
        End Set
    End Property

    Private Sub DataGridViewDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '建立连接
        Dim conn As SqlConnection = SqlConnection("Data source = localhost; Initial Catalog = Haier;Integrated Security = SSPI")
        '创建适配对象
        Dim adapter As SqlDataAdapter = New SqlDataAdapter("select * from UserDetail", conn)
        '创建数据集
        Dim ds As DataSet = New DataSet
        '使用适配器填充数据集
        adapter.Fill(ds, "User")
        '设置DataGridView
        DataGridView1.DataSource = ds.Tables("User")
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub
End Class
