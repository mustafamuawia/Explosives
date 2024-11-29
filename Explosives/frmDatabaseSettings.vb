Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Configuration
Imports System.Reflection

Public Class frmDatabaseSettings

    Private Sub btnConnectionTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnectionTest.Click
        If comboBox1.SelectedIndex = 0 Then


            My.MySettings.Default.Server = cbServerName.Text
            My.MySettings.Default.Database = cbDataBases.Text
            My.MySettings.Default.Auth = "Windows"
            My.MySettings.Default.explosivesConnectionString = "data source=" + cbServerName.Text + ";initial catalog=" + cbDataBases.Text + ";integrated security=SSPI"

        Else

            My.MySettings.Default.Server = cbServerName.Text
            My.MySettings.Default.Database = cbDataBases.Text
            My.MySettings.Default.Auth = "SQL"
            My.MySettings.Default.SQLUser = txtSQLUser.Text
            My.MySettings.Default.Password = txtSQLPassword.Text
            My.MySettings.Default.explosivesConnectionString = "data source=" + cbServerName.Text + ";initial catalog=" + cbDataBases.Text + ";user id=" + txtSQLUser.Text + ";password=" + txtSQLPassword.Text + ""
        End If
        Dim connection As New SqlConnection(My.MySettings.Default.explosivesConnectionString)
        Try
            connection.Open()
            MessageBox.Show("اتصال ناجح!")
        Catch
            MessageBox.Show("فشل في الاتصال")
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If comboBox1.SelectedIndex = 0 Then

            My.MySettings.Default.Server = cbServerName.Text
            My.MySettings.Default.Database = cbDataBases.Text
            My.MySettings.Default.Auth = "Windows"
            My.MySettings.Default.explosivesConnectionString = "data source=" + cbServerName.Text + ";initial catalog=" + cbDataBases.Text + ";integrated security=SSPI"

        Else

            My.MySettings.Default.Server = cbServerName.Text
            My.MySettings.Default.Database = cbDataBases.Text
            My.MySettings.Default.Auth = "SQL"
            My.MySettings.Default.SQLUser = txtSQLUser.Text
            My.MySettings.Default.Password = txtSQLPassword.Text
            My.MySettings.Default.explosivesConnectionString = "data source=" + cbServerName.Text + ";initial catalog=" + cbDataBases.Text + ";user id=" + txtSQLUser.Text + ";password=" + txtSQLPassword.Text + ""

            My.MySettings.Default.Save()
        End If

    End Sub

    Private Sub frmDatabaseMySettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.MySettings.Default.Auth = "Windows" Then

            comboBox1.SelectedIndex = 0
            cbServerName.Text = My.MySettings.Default.Server
            cbDataBases.Text = My.MySettings.Default.Database
            


        Else
            comboBox1.SelectedIndex = 1
            cbServerName.Text = My.MySettings.Default.Server
            cbDataBases.Text = My.MySettings.Default.Database
            txtSQLUser.Text = My.MySettings.Default.SQLUser
            txtSQLPassword.Text = My.MySettings.Default.Password

        End If


        MessageBox.Show(My.MySettings.Default.explosivesConnectionString)
    End Sub

    Private Sub frmDatabaseSettings_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Leave

    End Sub
End Class