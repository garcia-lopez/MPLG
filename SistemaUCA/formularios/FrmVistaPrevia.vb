Public Class FrmVistaPrevia
    Private Sub FrmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PruebaDS.Ciudad' Puede moverla o quitarla según sea necesario.
        Me.CiudadTableAdapter.Fill(Me.PruebaDS.Ciudad)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class