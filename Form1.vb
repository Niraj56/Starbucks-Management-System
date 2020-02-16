Public Class Form1


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()

        txtchai.Text = "0"
        txtmores.Text = "0"
        txtCaramel.Text = "0"
        txtgreen.Text = "0"
        txtregc.Text = "0"
        txtIcemocha.Text = "0"
        txtBean.Text = "0"
        txtVelvet.Text = "0"
        txtBlue.Text = "0"
        txtcmarble.Text = "0"
        txtspcake.Text = "0"
        txtcreme.Text = "0"
        txtcoco.Text = "0"
        txtbanof.Text = "0"
        txtmarble.Text = "0"
        txtMango.Text = "0"
        txtBean.Text = "0"
        lblCostDrink.Text = "0"
        lblCostCake.Text = "0"
        lblService.Text = "0"


        txtchai.Enabled = False
        txtmores.Enabled = False
        txtVelvet.Enabled = False
        txtBlue.Enabled = False
        txtCaramel.Enabled = False
        txtcmarble.Enabled = False
        txtspcake.Enabled = False
        txtgreen.Enabled = False
        txtregc.Enabled = False
        txtIcemocha.Enabled = False
        txtcoco.Enabled = False
        txtbanof.Enabled = False
        txtcreme.Enabled = False
        txtmarble.Enabled = False
        txtMango.Enabled = False
        txtBean.Enabled = False

        rtfReceipt.Clear()

        csocm.Checked = False
        cmcsm.Checked = False
        chkvelvets.Checked = False
        chkblue.Checked = False
        chkCapp.Checked = False
        chkCacake.Checked = False
        chkstbspecial.Checked = False
        chkgreen.Checked = False
        chkrcc.Checked = False
        chkIce.Checked = False
        chkcoco.Checked = False
        chkbafos.Checked = False
        chkcreme.Checked = False
        chkmcake.Checked = False
        chkmango.Checked = False
        chkVales.Checked = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        lblSubtotal.Text = "0"
        lbltax.Text = "0"
        lblTotal.Text = "0"

        txtchai.Text = "0"
        txtmores.Text = "0"
        txtCaramel.Text = "0"
        txtgreen.Text = "0"
        txtregc.Text = "0"
        txtIcemocha.Text = "0"
        txtBean.Text = "0"
        txtVelvet.Text = "0"
        txtBlue.Text = "0"
        txtcmarble.Text = "0"
        txtspcake.Text = "0"
        txtcreme.Text = "0"
        txtcoco.Text = "0"
        txtbanof.Text = "0"
        txtmarble.Text = "0"
        txtMango.Text = "0"
        txtBean.Text = "0"
        lblCostDrink.Text = "0"
        lblCostCake.Text = "0"
        lblService.Text = "0"


        txtchai.Enabled = False
        txtmores.Enabled = False
        txtVelvet.Enabled = False
        txtBlue.Enabled = False
        txtCaramel.Enabled = False
        txtcmarble.Enabled = False
        txtspcake.Enabled = False
        txtgreen.Enabled = False
        txtregc.Enabled = False
        txtIcemocha.Enabled = False
        txtcoco.Enabled = False
        txtbanof.Enabled = False
        txtcreme.Enabled = False
        txtmarble.Enabled = False
        txtMango.Enabled = False
        txtBean.Enabled = False

        rtfReceipt.Clear()

        csocm.Checked = False
        cmcsm.Checked = False
        chkvelvets.Checked = False
        chkblue.Checked = False
        chkCapp.Checked = False
        chkCacake.Checked = False
        chkstbspecial.Checked = False
        chkgreen.Checked = False
        chkrcc.Checked = False
        chkIce.Checked = False
        chkcoco.Checked = False
        chkbafos.Checked = False
        chkcreme.Checked = False
        chkmcake.Checked = False
        chkmango.Checked = False
        chkVales.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        rtfReceipt.Clear()

        rtfReceipt.AppendText(vbTab + vbTab + vbTab + "Starbuks" + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "---------------------------------------------------------------------------" + Environment.NewLine)

        rtfReceipt.AppendText(vbTab + "C.Marble Cake" + vbTab + vbTab + txtmarble.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Ch. Marble Cake" + vbTab + vbTab + txtcmarble.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Coconut Cake" + vbTab + vbTab + vbTab + txtcoco.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Banoffee Cake" + vbTab + vbTab + vbTab + txtbanof.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Blueberry Cheesecake" + vbTab + vbTab + vbTab + txtBlue.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Red Velvet Cake" + vbTab + vbTab + vbTab + txtVelvet.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "M. Yoghurt Cake" + vbTab + vbTab + vbTab + vbTab + txtMango.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Sb. Birthday Cake" + vbTab + vbTab + vbTab + vbTab + txtspcake.Text + Environment.NewLine)

        rtfReceipt.AppendText(vbTab + "R.Coffee Drink" + vbTab + vbTab + vbTab + vbTab + txtregc.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "S Mores" + vbTab + vbTab + vbTab + vbTab + txtmores.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "O.Cinnamon Chai" + vbTab + vbTab + vbTab + vbTab + txtchai.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Vanilla Bean" + vbTab + vbTab + vbTab + vbTab + txtCaramel.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Caramel" + vbTab + vbTab + vbTab + vbTab + txtBean.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Iced Mocha" + vbTab + vbTab + vbTab + vbTab + txtIcemocha.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Green Tea" + vbTab + vbTab + vbTab + vbTab + txtgreen.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "S.Creme" + vbTab + vbTab + vbTab + vbTab + vbTab + txtcreme.Text + Environment.NewLine)

        rtfReceipt.AppendText(vbTab + "-----------------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Service Charge" + vbTab + vbTab + vbTab + vbTab + lblService.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "-----------------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Tax" + vbTab + vbTab + vbTab + vbTab + vbTab + lbltax.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Sub Total" + vbTab + vbTab + vbTab + vbTab + lblSubtotal.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "Total Cost" + vbTab + vbTab + vbTab + vbTab + lblTotal.Text + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + "-----------------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + lblTime.Text + vbTab + vbTab + vbTab + lblDate.Text)
    End Sub

    Private Sub chkIced_CheckedChanged(sender As Object, e As EventArgs) Handles chkrcc.CheckedChanged
        If (chkrcc.Checked = True) Then
            txtregc.Enabled = True
        End If

        If (chkrcc.Checked = False) Then
            txtregc.Enabled = False
        End If
    End Sub

    Private Sub txtIced_Click(sender As Object, e As EventArgs) Handles txtregc.Click
        txtregc.Text = ""
        txtregc.Focus()
    End Sub

    Private Sub chkAmerican_CheckedChanged(sender As Object, e As EventArgs) Handles cmcsm.CheckedChanged
        If (cmcsm.Checked = True) Then
            txtmores.Enabled = True
        End If

        If (cmcsm.Checked = False) Then
            txtmores.Enabled = False
        End If
    End Sub

    Private Sub txtAmerican_Click(sender As Object, e As EventArgs) Handles txtmores.Click
        txtmores.Text = ""
        txtmores.Focus()
    End Sub

    Private Sub chkAfrican_CheckedChanged(sender As Object, e As EventArgs) Handles csocm.CheckedChanged
        If (csocm.Checked = True) Then
            txtchai.Enabled = True
        End If

        If (csocm.Checked = False) Then
            txtchai.Enabled = False
        End If
    End Sub

    Private Sub txtAfrican_Click(sender As Object, e As EventArgs) Handles txtchai.Click
        txtchai.Text = ""
        txtchai.Focus()
    End Sub

    Private Sub chkVales_CheckedChanged(sender As Object, e As EventArgs) Handles chkVales.CheckedChanged
        If (chkVales.Checked = True) Then
            txtBean.Enabled = True
        End If

        If (chkVales.Checked = False) Then
            txtBean.Enabled = False
        End If
    End Sub

    Private Sub txtVales_Click(sender As Object, e As EventArgs) Handles txtBean.Click
        txtBean.Text = ""
        txtBean.Focus()
    End Sub

    Private Sub chkCappucino_CheckedChanged(sender As Object, e As EventArgs) Handles chkCapp.CheckedChanged
        If (chkCapp.Checked = True) Then
            txtCaramel.Enabled = True
        End If

        If (chkCapp.Checked = False) Then
            txtCaramel.Enabled = False
        End If
    End Sub

    Private Sub txtCappucino_Click(sender As Object, e As EventArgs) Handles txtCaramel.Click
        txtCaramel.Text = ""
        txtCaramel.Focus()
    End Sub

    Private Sub chkIceLatte_CheckedChanged(sender As Object, e As EventArgs) Handles chkIce.CheckedChanged
        If (chkIce.Checked = True) Then
            txtIcemocha.Enabled = True
        End If

        If (chkIce.Checked = False) Then
            txtIcemocha.Enabled = False
        End If
    End Sub

    Private Sub txtIceLatte_Click(sender As Object, e As EventArgs) Handles txtIcemocha.Click
        txtIcemocha.Text = ""
        txtIcemocha.Focus()
    End Sub

    Private Sub chkEspresso_CheckedChanged(sender As Object, e As EventArgs) Handles chkgreen.CheckedChanged
        If (chkgreen.Checked = True) Then
            txtgreen.Enabled = True
        End If

        If (chkgreen.Checked = False) Then
            txtgreen.Enabled = False
        End If
    End Sub

    Private Sub txtEspresso_Click(sender As Object, e As EventArgs) Handles txtgreen.Click
        txtgreen.Text = ""
        txtgreen.Focus()
    End Sub

    Private Sub chkLatte_CheckedChanged(sender As Object, e As EventArgs) Handles chkcreme.CheckedChanged
        If (chkcreme.Checked = True) Then
            txtcreme.Enabled = True
        End If

        If (chkcreme.Checked = False) Then
            txtcreme.Enabled = False
        End If
    End Sub

    Private Sub txtLatte_Click(sender As Object, e As EventArgs) Handles txtcreme.Click
        txtcreme.Text = ""
        txtcreme.Focus()
    End Sub

    Private Sub chkQueen_CheckedChanged(sender As Object, e As EventArgs) Handles chkmcake.CheckedChanged
        If (chkmcake.Checked = True) Then
            txtmarble.Enabled = True
        End If

        If (chkmcake.Checked = False) Then
            txtmarble.Enabled = False
        End If
    End Sub

    Private Sub txtQueen_Click(sender As Object, e As EventArgs) Handles txtmarble.Click
        txtmarble.Text = ""
        txtmarble.Focus()
    End Sub

    Private Sub chkCarlton_CheckedChanged(sender As Object, e As EventArgs) Handles chkCacake.CheckedChanged
        If (chkCacake.Checked = True) Then
            txtcmarble.Enabled = True
        End If

        If (chkCacake.Checked = False) Then
            txtcmarble.Enabled = False
        End If
    End Sub

    Private Sub txtCharlton_Click(sender As Object, e As EventArgs) Handles txtcmarble.Click
        txtcmarble.Text = ""
        txtcmarble.Focus()
    End Sub

    Private Sub chkKilburn_CheckedChanged(sender As Object, e As EventArgs) Handles chkcoco.CheckedChanged
        If (chkcoco.Checked = True) Then
            txtcoco.Enabled = True
        End If

        If (chkcoco.Checked = False) Then
            txtcoco.Enabled = False
        End If
    End Sub

    Private Sub txtKilburn_Click(sender As Object, e As EventArgs) Handles txtcoco.Click
        txtcoco.Text = ""
        txtcoco.Focus()
    End Sub

    Private Sub chkLagos_CheckedChanged(sender As Object, e As EventArgs) Handles chkbafos.CheckedChanged
        If (chkbafos.Checked = True) Then
            txtbanof.Enabled = True
        End If

        If (chkbafos.Checked = False) Then
            txtbanof.Enabled = False
        End If
    End Sub

    Private Sub txtLagos_Click(sender As Object, e As EventArgs) Handles txtbanof.Click
        txtbanof.Text = ""
        txtcoco.Focus()
    End Sub

    Private Sub chkBostom_CheckedChanged(sender As Object, e As EventArgs) Handles chkblue.CheckedChanged
        If (chkblue.Checked = True) Then
            txtBlue.Enabled = True
        End If

        If (chkblue.Checked = False) Then
            txtBlue.Enabled = False
        End If
    End Sub

    Private Sub txtBostom_Click(sender As Object, e As EventArgs) Handles txtBlue.Click
        txtBlue.Text = ""
        txtBlue.Focus()
    End Sub

    Private Sub chkBlackForest_CheckedChanged(sender As Object, e As EventArgs) Handles chkvelvets.CheckedChanged
        If (chkvelvets.Checked = True) Then
            txtVelvet.Enabled = True
        End If

        If (chkvelvets.Checked = False) Then
            txtVelvet.Enabled = False
        End If
    End Sub

    Private Sub txtBlackForest_Click(sender As Object, e As EventArgs) Handles txtVelvet.Click
        txtVelvet.Text = ""
        txtVelvet.Focus()
    End Sub

    Private Sub chkRed_CheckedChanged(sender As Object, e As EventArgs) Handles chkmango.CheckedChanged
        If (chkmango.Checked = True) Then
            txtMango.Enabled = True
        End If

        If (chkmango.Checked = False) Then
            txtMango.Enabled = False
        End If
    End Sub

    Private Sub txtRed_Click(sender As Object, e As EventArgs) Handles txtMango.Click
        txtMango.Text = ""
        txtMango.Focus()
    End Sub

    Private Sub chkCoffeCake_CheckedChanged(sender As Object, e As EventArgs) Handles chkstbspecial.CheckedChanged
        If (chkstbspecial.Checked = True) Then
            txtspcake.Enabled = True
        End If

        If (chkstbspecial.Checked = False) Then
            txtspcake.Enabled = False
        End If
    End Sub

    Private Sub txtCoffeCake_Click(sender As Object, e As EventArgs) Handles txtspcake.Click
        txtspcake.Text = ""
        txtspcake.Focus()
    End Sub

    Private Sub txtNumbersOnly(sender As Object, e As KeyPressEventArgs) Handles txtBean.KeyPress, txtMango.KeyPress, txtmarble.KeyPress, txtcreme.KeyPress, txtcoco.KeyPress, txtIcemocha.KeyPress, txtregc.KeyPress, txtgreen.KeyPress, txtspcake.KeyPress, txtcmarble.KeyPress, txtCaramel.KeyPress, txtBlue.KeyPress, txtVelvet.KeyPress, txtmores.KeyPress, txtchai.KeyPress, txtbanof.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Please enter valid number", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub pasteToolStripButton_Click(sender As Object, e As EventArgs) Handles pasteToolStripButton.Click
        rtfReceipt.Paste()
    End Sub

    Private Sub copyToolStripButton1_Click(sender As Object, e As EventArgs) Handles copyToolStripButton1.Click
        rtfReceipt.Copy()
    End Sub
    Private Sub cutToolStripButton1_Click(sender As Object, e As EventArgs) Handles cutToolStripButton1.Click
        rtfReceipt.Cut()
    End Sub

    Private Sub printToolStripButton2_Click(sender As Object, e As EventArgs) Handles printToolStripButton2.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(rtfReceipt.Text, New Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        rtfReceipt.Clear()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ' This code will Open Text Files
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*"
        If (OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            rtfReceipt.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub saveToolStripButton1_Click(sender As Object, e As EventArgs) Handles saveToolStripButton1.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt)|*.txt"
#Disable Warning BC30456
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
#Enable Warning BC30456
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, rtfReceipt.Text, True)
        End If
    End Sub

    Private Sub helpToolStripButton1_Click(sender As Object, e As EventArgs) Handles helpToolStripButton1.Click
#Disable Warning BC30203
        StarbucksManagement.Show()
#Enable Warning BC30203
    End Sub

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Dim tax As Double
        tax = 7
        Dim latte, espres, ilatte, vale, aCoff, amCoff, capp, iCapp As Double
        Dim cCake, rVel, bFor, cBos, cKilb, cCarl, cCqueen, cLag As Double
        ' coffee
        latte = 2.5
        espres = 3.75
        ilatte = 1.35
        vale = 7.5
        aCoff = 5.5
        amCoff = 4.95
        capp = 6
        iCapp = 9
        Dim latte_Coff As Double = Convert.ToDouble(txtcreme.Text)
        Dim espresson As Double = Convert.ToDouble(txtgreen.Text)
        Dim IcedLatte As Double = Convert.ToDouble(txtIcemocha.Text)
        Dim vale_Coff As Double = Convert.ToDouble(txtBean.Text)
        Dim Afri_Coff As Double = Convert.ToDouble(txtchai.Text)
        Dim Amer_Coff As Double = Convert.ToDouble(txtmores.Text)
        Dim Capp_Coff As Double = Convert.ToDouble(txtCaramel.Text)
        Dim iCapp_Coff As Double = Convert.ToDouble(txtregc.Text)

        'Cakes
        cCake = 25
        rVel = 75
        bFor = 40
        cBos = 90
        cLag = 80
        cKilb = 60
        cCarl = 82
        cCqueen = 78

        Dim c_Cakes As Double = Convert.ToDouble(txtspcake.Text)
        Dim vl_Cakes As Double = Convert.ToDouble(txtMango.Text)
        Dim bF_Cakes As Double = Convert.ToDouble(txtVelvet.Text)
        Dim cB_Cakes As Double = Convert.ToDouble(txtBlue.Text)
        Dim cL_Cakes As Double = Convert.ToDouble(txtbanof.Text)
        Dim cK_Cakes As Double = Convert.ToDouble(txtcoco.Text)
        Dim cC_Cakes As Double = Convert.ToDouble(txtcmarble.Text)
        Dim cQ_Cakes As Double = Convert.ToDouble(txtmarble.Text)
        '===================================================================
        Dim cost_of_drinks, service_charge, cost_of_cakes, iTax As Double
        cost_of_drinks = (latte_Coff * latte) + (espresson * espres) + (IcedLatte * ilatte) _
            + (vale * vale_Coff) + (aCoff * Afri_Coff) + (amCoff * Amer_Coff) _
            + (capp * Capp_Coff) + (iCapp * iCapp_Coff)
        lblCostDrink.Text = Convert.ToString(cost_of_drinks)
        cost_of_cakes = (cCake * c_Cakes) + (rVel * vl_Cakes) + (bFor * bF_Cakes) _
            + (cBos * cB_Cakes) + (cLag * cL_Cakes) + (cKilb * cK_Cakes) _
            + (cCarl * cC_Cakes) + (cCqueen * cQ_Cakes)
        lblCostCake.Text = Convert.ToString(cost_of_cakes)

        service_charge = Convert.ToDouble(lblService.Text)

        lblSubtotal.Text = Convert.ToString(cost_of_cakes + service_charge)
        lbltax.Text = Convert.ToString(((cost_of_cakes + cost_of_drinks + service_charge) * tax) / 100)
        iTax = Convert.ToDouble(lbltax.Text)
        lblTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + iTax + service_charge)

        lblCostCake.Text = FormatCurrency(cost_of_cakes)
        lblCostDrink.Text = FormatCurrency(cost_of_drinks)
        lblService.Text = FormatCurrency(service_charge)
        lblSubtotal.Text = FormatCurrency((cost_of_cakes + cost_of_drinks + service_charge))
        lbltax.Text = FormatCurrency(iTax)
        lblTotal.Text = FormatCurrency((cost_of_cakes + cost_of_drinks + service_charge + iTax))

    End Sub

    Private Sub lbl1tax_Click(sender As Object, e As EventArgs) Handles lbl1tax.Click

    End Sub

    Private Sub txtmarble_TextChanged(sender As Object, e As EventArgs) Handles txtmarble.TextChanged

    End Sub
End Class
