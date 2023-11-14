Imports System.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class Reporteporpais
    ' Declarar un objeto de tipo conexión fuera de cualquier procedimiento
    Private conexion As New conexion()

    Private Sub Libros_por_pais_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Cargar los datos de los países al ComboBox
        Dim SQL As String
        SQL = "CALL seleccionar_paises()"
        conexion.consulta(SQL)

        If conexion.ds.Tables(0).Rows.Count > 0 Then
            cbpais.DataSource = conexion.ds.Tables(0)
            cbpais.DisplayMember = "nombre_pais"
            cbpais.ValueMember = "cod_pais"
            cbpais.SelectedIndex = -1

        End If
    End Sub

    Private selectedCountry As String ' Variable para almacenar el país seleccionado

    Private Sub cbpais_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbpais.SelectedIndexChanged
        If cbpais.SelectedItem IsNot Nothing Then
            selectedCountry = cbpais.Text ' Almacena el nombre del país seleccionado
        End If
    End Sub

    Private Sub btbuscar_Click(sender As System.Object, e As System.EventArgs) Handles btbuscar.Click
        If Not String.IsNullOrEmpty(selectedCountry) Then
            Dim SQL As String = "CALL libros_por_pais('" & selectedCountry & "')" ' Pasa el nombre del país almacenado como argumento
            conexion.consulta(SQL)
            DataGridView1.DataSource = conexion.ds.Tables(0)
        Else
            MessageBox.Show("Por favor, seleccione un país antes de buscar.")
        End If
    End Sub


    Private Sub btexportar_Click(sender As System.Object, e As System.EventArgs) Handles btexportar.Click
        GridAExcel(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class