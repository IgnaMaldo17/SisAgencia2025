Imports System.Runtime.InteropServices
Public Class frmVisorReportes

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hWnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Const AW_HOR_POSITIVE As Integer = &H1
    Private Const AW_HOR_NEGATIVE As Integer = &H2
    Private Const AW_VER_POSITIVE As Integer = &H4
    Private Const AW_VER_NEGATIVE As Integer = &H8
    Private Const AW_BLEND As Integer = &H80000
    Private Const AW_SLIDE As Integer = &H40000

    Private Sub Limpiar()
        CodMonedaGlobal = 0
        CodTransGlobal = 0
        CodMedPagoGlobal = 0
        CodMedPago = 0
        CodTrans = 0
        CodMoneda = 0
        ComboBox1.SelectedIndex = -1
    End Sub

    ' Usar el evento Load del formulario para iniciar la animación de entrada
    Private Sub frmVisorReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        AnimateWindow(Me.Handle, 500, AW_BLEND Or AW_SLIDE Or AW_HOR_POSITIVE) ' Animación de entrada
    End Sub

    ' Método para ocultar el formulario con animación de salida
    Public Sub HideWithAnimation()
        AnimateWindow(Me.Handle, 500, AW_BLEND Or AW_SLIDE Or AW_HOR_NEGATIVE) ' Animación de salida
        Me.Hide()
    End Sub




    Private Sub ckbVeh_Click(sender As Object, e As EventArgs) Handles ckbVeh.Click
        MonedaEst = True
        ckbVeh.Checked = True
        CheckBox6.Checked = False
        ckbUsu.Checked = False
        ckbEmp.Checked = False
        CodMoneda = 6
    End Sub

    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        MonedaEst = True
        ckbVeh.Checked = False
        CheckBox6.Checked = True
        ckbUsu.Checked = False
        ckbEmp.Checked = False
        CodMoneda = 3
    End Sub

    Private Sub ckbUsu_Click(sender As Object, e As EventArgs) Handles ckbUsu.Click
        MonedaEst = True
        ckbVeh.Checked = False
        CheckBox6.Checked = False
        ckbUsu.Checked = True
        ckbEmp.Checked = False
        CodMoneda = 4
    End Sub

    Private Sub ckbEmp_Click(sender As Object, e As EventArgs) Handles ckbEmp.Click
        MonedaEst = True
        ckbVeh.Checked = False
        CheckBox6.Checked = False
        ckbUsu.Checked = False
        ckbEmp.Checked = True
        CodMoneda = 2
    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        MedioPagoEst = True
        CheckBox3.Checked = True
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        TarjetaTrue()
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        MedioPagoEst = True
        CheckBox3.Checked = False
        CheckBox2.Checked = True
        CheckBox1.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        TarjetaTrue()
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        MedioPagoEst = True
        CheckBox3.Checked = False
        CheckBox2.Checked = False
        CheckBox1.Checked = True
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        TarjetaTrue()
    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        MedioPagoEst = True
        CheckBox3.Checked = False
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        CheckBox4.Checked = True
        CheckBox5.Checked = False
        TarjetaFalse()
        MercadoTrue()
    End Sub

    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        MedioPagoEst = True
        CheckBox3.Checked = False
        CheckBox2.Checked = False
        CheckBox1.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = True
        TarjetaFalse()
        MercadoFalse()
    End Sub

    Public Sub TarjetaTrue()
        lblPpal.Text = "Seleccionar tipo de tarjeta:"
        lblPpal.Visible = True
        ComboBox1.Visible = True
        TextBox1.Visible = False
    End Sub

    Public Sub MercadoTrue()
        lblPpal.Text = "Escribir número de transferencia:"
        lblPpal.Visible = True
        TextBox1.Visible = True
        ComboBox1.Visible = False
    End Sub

    Public Sub MercadoFalse()
        lblPpal.Text = ""
        lblPpal.Visible = False
        TextBox1.Visible = False
        ComboBox1.Visible = False
    End Sub

    Public Sub TarjetaFalse()
        lblPpal.Text = ""
        lblPpal.Visible = False
        ComboBox1.Visible = False
        TextBox1.Visible = False
    End Sub

    Dim MonedaEst As Boolean = False
    Dim MedioPagoEst As Boolean = False
    Dim CodMedPago As Integer = 0
    Dim CodTrans As String = ""
    Dim CodMoneda As Integer = 0

    Private Sub btnSelFav_Click(sender As Object, e As EventArgs) Handles btnSelFav.Click
        CodMedPago = 0
        CodTrans = ""
        'CodMoneda = 0

        If MonedaEst = False Then
            ep.SetError(Label5, "Debe seleccionar un tipo de moneda.")
            Return
        End If

        If MedioPagoEst = False Then
            ep.SetError(Label1, "Debe seleccionar un medio de pago.")
            Return
        End If

        If ComboBox1.Visible = True Then
            If ComboBox1.SelectedIndex <> 0 And ComboBox1.SelectedIndex <> 1 Then
                ep.SetError(ComboBox1, "Debe seleccionar un tipo de tarjeta.")
                Return
            End If

            If CheckBox1.Checked Then
                If ComboBox1.SelectedIndex = 0 Then
                    CodMedPago = 8
                Else
                    CodMedPago = 9
                End If
            ElseIf CheckBox2.Checked Then
                If ComboBox1.SelectedIndex = 0 Then
                    CodMedPago = 1
                Else
                    CodMedPago = 2
                End If
            ElseIf CheckBox3.Checked Then
                If ComboBox1.SelectedIndex = 0 Then
                    CodMedPago = 3
                Else
                    CodMedPago = 4
                End If
            End If

        ElseIf TextBox1.Visible = True Then
            If TextBox1.Text = "" Then
                ep.SetError(TextBox1, "Debe escribir el número de transferencia.")
                Return
            End If

            If CheckBox4.Checked Then
                CodMedPago = 5
                CodTrans = TextBox1.Text
            End If

        End If

        If CheckBox5.Checked Then
            CodMedPago = 7
        End If

        CodMonedaGlobal = CodMoneda
        CodTransGlobal = CodTrans
        CodMedPagoGlobal = CodMedPago
        Me.Hide()
        frmAgrVent.Vender()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar esta ventana?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Limpiar()
            Me.Close()
        End If
    End Sub
End Class