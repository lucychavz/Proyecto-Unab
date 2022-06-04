Imports System.Drawing.Printing
Public Class Form2
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim item As Integer
    Dim ReciptID As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Indicador que empiece desde cero categoria,tipo de documento y producto y muestre fecha del sistema

        Label5.Text = Now.Date 'Mostrar la fecha del sistema
        Label2.Text = DateTime.Now.ToShortTimeString

        ComboBox2.SelectedIndex = 0 ' categoria



    End Sub

    'EMPIEZA GROUPBOX 1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress 'Nombre
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Ingrese solo letras",, "aviso")

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()

    End Sub


    'Bloqueado letras y que se salte los datos
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs)
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8)) Then
            e.Handled = True
            MsgBox("Error solo requiere numeros")
            TextBox4.Text = vbNullChar

        End If
    End Sub

    'FINALIZA GROUPBOX1 

    'EMPIEZA GROUPBOX 2  'Categorias de productos
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim pos As Integer
        pos = ComboBox2.SelectedIndex
        llenarcolumna()

        Select Case (pos)
            Case 0
            Case 1 : LLenarlacteos()
            Case 2 : LlenarDetergentes()
            Case 3 : LlenarCarnesyembutidos()
            Case 4 : LlenarBebedias()
        End Select

    End Sub
    Private Sub llenarcolumna()

        '  DataGridView1.Columns.Add("ITEM", "items")
        DataGridView1.Columns.Add("items", "ITEM")
        DataGridView1.Columns.Add("productos", "PRODUCTOS")
        DataGridView1.Columns.Add("cantidad", "CANTIDAD")
        DataGridView1.Columns.Add("precio", "PRECIOS")
        DataGridView1.Columns.Add("subtotal", "sub total")
    End Sub

    Private Sub LLenarlacteos()
        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("Leche") 'Ejemplo para rellenar campo de productos
        ComboBox3.Items.Add("Crema")
        ComboBox3.Items.Add("Queso Duro")
        ComboBox3.Items.Add("Queso Freso")
        ComboBox3.Items.Add("Cuajada")
        ComboBox3.Items.Add("Yogurt")
        ComboBox3.Items.Add("Queso Crema")
        ComboBox3.Items.Add("Quesillo")
        ComboBox3.Items.Add("Requesón")
        ComboBox3.Items.Add("Queso con Loroco")
    End Sub

    Private Sub LlenarDetergentes()
        ComboBox3.Items.Clear()
        'Agregue productos
        ComboBox3.Items.Add("Blanqueador")
        ComboBox3.Items.Add("Detergente en Polvo")
        ComboBox3.Items.Add("Detergente Liquído")
        ComboBox3.Items.Add("Suavizante")
        ComboBox3.Items.Add("Jabón")
        ComboBox3.Items.Add("Desifectante")
        ComboBox3.Items.Add("Aromantizante")

    End Sub

    Private Sub LlenarCarnesyembutidos()
        ComboBox3.Items.Clear()
        'Agregue productos
        ComboBox3.Items.Add("Carne de Res")
        ComboBox3.Items.Add("Carne de Cerdo")
        ComboBox3.Items.Add("Pollo")
        ComboBox3.Items.Add("Jamón")
        ComboBox3.Items.Add("Salchichas")
        ComboBox3.Items.Add("Chorizo")
        ComboBox3.Items.Add("Filete de Pescado")
        ComboBox3.Items.Add("Salmón")
        ComboBox3.Items.Add("Tocino")
        ComboBox3.Items.Add("Peperoni")

    End Sub

    Private Sub LlenarBebedias()
        'Agregue productos
        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("Agua")
        ComboBox3.Items.Add("Gaseosas")
        ComboBox3.Items.Add("Jugos")
        ComboBox3.Items.Add("Cervezas")
        ComboBox3.Items.Add("FRUTTI-FRESH")
        ComboBox3.Items.Add("Agua Mineral")
        ComboBox3.Items.Add("Aloe Vera")
        ComboBox3.Items.Add("Bebida Energizante")
        ComboBox3.Items.Add("Bebida Alcoholica")
        ComboBox3.Items.Add("Café")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'BOTON DE LIMPIAR 
        'arregle error de limpiar datos de producto
        TextBox3.Text = ""
        TextBox4.Text = ""

        ComboBox3.SelectedIndex = -1
    End Sub

    'PRECIOS DE PRODUCTOS
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

        'agregue los precios de los productos
        '
        If (ComboBox2.SelectedIndex = 1) Then
            If (ComboBox3.SelectedIndex = 0) Then
                TextBox3.Text = 2.5.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 1) Then
                TextBox3.Text = 1.5.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 2) Then
                TextBox3.Text = 2.75.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 3) Then
                TextBox3.Text = 3.25.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 4) Then
                TextBox3.Text = 4.5.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 5) Then
                TextBox3.Text = 0.58.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 6) Then
                TextBox3.Text = 3.8.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 7) Then
                TextBox3.Text = 2.75.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 8) Then
                TextBox3.Text = 2.5.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 9) Then
                TextBox3.Text = 2.5.ToString("C")
            End If
        End If
        If (ComboBox2.SelectedIndex = 2) Then
            If (ComboBox3.SelectedIndex = 0) Then
                TextBox3.Text = 1.5.ToString("c")
            ElseIf (ComboBox3.SelectedIndex = 1) Then
                TextBox3.Text = 1.0.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 2) Then
                TextBox3.Text = 1.55.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 3) Then
                TextBox3.Text = 2.4.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 4) Then
                TextBox3.Text = 2.99.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 5) Then
                TextBox3.Text = 1.8.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 6) Then
                TextBox3.Text = 1.9.ToString("C")
            End If
        End If
        If (ComboBox2.SelectedIndex = 3) Then
            If (ComboBox3.SelectedIndex = 0) Then
                TextBox3.Text = 3.55.ToString("c")
            ElseIf (ComboBox3.SelectedIndex = 1) Then
                TextBox3.Text = 3.2.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 2) Then
                TextBox3.Text = 2.85.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 3) Then
                TextBox3.Text = 2.9.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 4) Then
                TextBox3.Text = 1.55.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 5) Then
                TextBox3.Text = 2.85.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 6) Then
                TextBox3.Text = 5.95.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 7) Then
                TextBox3.Text = 5.45.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 8) Then
                TextBox3.Text = 3.25.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 9) Then
                TextBox3.Text = 4.6.ToString("C")
            End If
        End If
        If (ComboBox2.SelectedIndex = 4) Then
            If (ComboBox3.SelectedIndex = 0) Then
                TextBox3.Text = 0.35.ToString("c")
            ElseIf (ComboBox3.SelectedIndex = 1) Then
                TextBox3.Text = 0.6.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 2) Then
                TextBox3.Text = 0.55.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 3) Then
                TextBox3.Text = 1.5.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 4) Then
                TextBox3.Text = 1.35.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 5) Then
                TextBox3.Text = 1.05.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 6) Then
                TextBox3.Text = 2.25.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 7) Then
                TextBox3.Text = 0.85.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 8) Then
                TextBox3.Text = 2.15.ToString("C")
            ElseIf (ComboBox3.SelectedIndex = 9) Then
                TextBox3.Text = 2.8.ToString("C")
            End If

        End If
    End Sub

    'BOTON DE AGREGAR


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'DataGridView1.Rows.Add(TextBox3.Text, TextBox4.Text, ComboBox3.Text) 
        Dim pos As Integer
        pos = DataGridView1.Rows.Count - 1
        DataGridView1.Rows.Add()

        DataGridView1.Rows(pos).Cells(1).Value = ComboBox3.SelectedItem
        DataGridView1.Rows(pos).Cells(2).Value = TextBox4.Text
        DataGridView1.Rows(pos).Cells(3).Value = TextBox3.Text
        DataGridView1.Rows(pos).Cells(4).Value = "$" & Val(TextBox4.Text) * (TextBox3.Text)


    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'BOTON DE NUEVO
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Limpiando datos del cliente

        TextBox1.Clear()

        'LIMPIAR DATAGRIDVIEW
        DataGridView1.DataSource = ""

    End Sub

    'BOTON DE IMPRIMIR
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub
    Private Sub PD_beginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings

        pagesetup.PaperSize = New PaperSize("CUSTUM", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub




    Private Sub PD_Printpage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rigthmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

        'Alinamiento de la fuente

        Dim rigth As New StringFormat
        Dim center As New StringFormat
        Dim left As New StringFormat
        rigth.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center


        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        TextBox1.TextAlign = HorizontalAlignment.Center


        Dim line As String
        line = "-----------------------------------------------------------------------------------------------------------"

        e.Graphics.DrawString("SuperMarket", f14, Brushes.Black, centermargin, 5, center)

        e.Graphics.DrawString("San Salvador, 75 av, Norte", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel. 22200-9732", f8, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Date" & Date.Now, f8, Brushes.Black, 50, 90) 'ya

        e.Graphics.DrawString("Cliente:", f8, Brushes.Black, 0, 75) 'ya
        e.Graphics.DrawString(TextBox1.Text, f8, Brushes.Black, 70, 75) 'ya

        e.Graphics.DrawString(line, f8, Brushes.Black, 5, 100)





        Dim height As Integer 'DGV Position
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False



        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, 0, 100 + height) 'ya
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 25, 100 + height) 'ya

            'ya
            i = DataGridView1.Rows(row).Cells(4).Value
            DataGridView1.Rows(row).Cells(4).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f10, Brushes.Black, rigthmargin, 100 + height, rigth)
        Next

        Dim height2 As Integer
        height2 = 110 + height

        e.Graphics.DrawString("~ Gracias por comprar ~", f10, Brushes.Black, centermargin, 50 + height2, center) 'ya

        subtotal()

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height)
        e.Graphics.DrawString("Total: $" & Format(t_precio, "##,##0"), f10b, Brushes.Black, rigthmargin, 10 + height2, rigth) 'ya
        e.Graphics.DrawString("Total de items" & Format(t_qty, "##,##0"), f10b, Brushes.Black, leftmargin, 10 + height2, left) 'ya

    End Sub

    Dim t_precio As Long
    Dim itms As Long
    Dim t_qty As Long

    Sub subtotal()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice = countprice + DataGridView1.Rows(rowitem).Cells(4).Value 'DataGridView1.Rows(rowitem).Cells(4).Value)
        Next
        t_precio = countprice

        Dim countqty As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + DataGridView1.Rows(rowitem).Cells(2).Value
        Next
        t_qty = countqty
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)


    End Sub
End Class