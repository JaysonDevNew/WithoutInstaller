Imports Guna.UI.WinForms
Imports MySql.Data.MySqlClient

Public Class AddProductListForm
    Private Sub AddProductListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategoryToComboBox()
        LoadBrandToComboBox()
        LoadProductToComboBox()
    End Sub

    Private Sub LoadCategoryToComboBox()
        Dim conStr As String = "server=localhost;user id=root;password=;database=gymxfit_database"
        Dim query As String = "SELECT category FROM tblcategory"

        cmbCategory.Items.Clear()
        cmbCategory.Items.Add("-- Select Category --") ' 👈 Add placeholder first

        Using con As New MySqlConnection(conStr)
            Try
                con.Open()
                Dim cmd As New MySqlCommand(query, con)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    cmbCategory.Items.Add(dr("category").ToString())
                End While

                cmbCategory.SelectedIndex = 0 ' 👈 Select the placeholder

            Catch ex As Exception
                MessageBox.Show("Error loading categories: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadBrandToComboBox()
        Dim conStr As String = "server=localhost;user id=root;password=;database=gymxfit_database"
        Dim query As String = "SELECT brandname FROM tblbrandname"

        cmbBrandname.Items.Clear()
        cmbBrandname.Items.Add("-- Select Brand Name --") ' 👈 Add placeholder

        Using con As New MySqlConnection(conStr)
            Try
                con.Open()
                Dim cmd As New MySqlCommand(query, con)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    cmbBrandname.Items.Add(dr("brandname").ToString())
                End While

                cmbBrandname.SelectedIndex = 0

            Catch ex As Exception
                MessageBox.Show("Error loading brand names: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadProductToComboBox()
        Dim conStr As String = "server=localhost;user id=root;password=;database=gymxfit_database"
        Dim query As String = "SELECT productname FROM tblproductname"

        cmbProductname.Items.Clear()
        cmbProductname.Items.Add("-- Select Product Name --") ' 👈 Add placeholder

        Using con As New MySqlConnection(conStr)
            Try
                con.Open()
                Dim cmd As New MySqlCommand(query, con)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                While dr.Read()
                    cmbProductname.Items.Add(dr("productname").ToString())
                End While

                cmbProductname.SelectedIndex = 0

            Catch ex As Exception
                MessageBox.Show("Error loading product names: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            ' Validation: Ensure all fields are filled
            If cmbBrandname.SelectedIndex = -1 Or
   cmbProductname.SelectedIndex = -1 Or
   cmbCategory.SelectedIndex = -1 Or
   String.IsNullOrWhiteSpace(txtPrice.Text) Or
   String.IsNullOrWhiteSpace(txtQTY.Text) Then

                MessageBox.Show("Please complete all fields.", "Incomplete Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            openConn() ' Open database connection

            ' SQL Query to Insert Product
            Dim sql As String = "INSERT INTO tblproducts (brandname, productname, pcategory, price, stock) VALUES (@brandname, @productname, @pcategory, @price, @qty)"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@brandname", cmbBrandname.Text)
            cmd.Parameters.AddWithValue("@productname", cmbProductname.Text)
            cmd.Parameters.AddWithValue("@pcategory", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@qty", txtQTY.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Product has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clearbox()
                ProductForm.LoadProducts()
            Else
                MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    ' Function to Clear Input Fields
    Public Sub Clearbox()
        txtPrice.Clear()
        txtQTY.Clear()
        cmbCategory.SelectedIndex = -1
        cmbBrandname.SelectedIndex = -1
        cmbProductname.SelectedIndex = -1
    End Sub

    Private Sub btnCancelProduct_Click(sender As Object, e As EventArgs) Handles btnCancelProduct.Click
        Clearbox()
    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        ' Format price when the user exits the textbox
        If Not String.IsNullOrWhiteSpace(txtPrice.Text) Then
            Dim price As Decimal
            If Decimal.TryParse(txtPrice.Text, price) Then
                txtPrice.Text = price.ToString("N2") ' Format to 2 decimal places with commas
            Else
                MessageBox.Show("Invalid price format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPrice.Clear()
                txtPrice.Focus()
            End If
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' Allow only numbers, backspace, and one decimal point
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = ChrW(Keys.Back)) Then
            e.Handled = True
        End If

        ' Ensure only one decimal point is allowed
        If e.KeyChar = "." AndAlso txtPrice.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Try
            ' Validation: Ensure all fields are filled
            If String.IsNullOrWhiteSpace(cmbBrandname.Text) Or
               String.IsNullOrWhiteSpace(cmbProductname.Text) Or
               String.IsNullOrWhiteSpace(cmbCategory.Text) Or
               String.IsNullOrWhiteSpace(txtPrice.Text) Or
               String.IsNullOrWhiteSpace(txtQTY.Text) Then

                MessageBox.Show("Please complete all fields.", "Incomplete Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            openConn() ' Open database connection

            ' SQL Query to Update Product
            Dim sql As String = "UPDATE tblproducts SET brandname = @brandname, productname = @productname, pcategory = @pcategory, price = @price, stock = @qty WHERE id = @id"

            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@brandname", cmbBrandname.Text)
            cmd.Parameters.AddWithValue("@productname", cmbProductname.Text)
            cmd.Parameters.AddWithValue("@pcategory", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@price", txtPrice.Text)
            cmd.Parameters.AddWithValue("@qty", txtQTY.Text)
            cmd.Parameters.AddWithValue("@id", txtID.Text) ' Replace with your actual ID variable


            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProductForm.LoadProducts() ' Refresh product list in main form
                Me.Close() ' Close the update form
            Else
                MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
        End Try
    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged

    End Sub

    Private Sub txtQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQTY.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If

        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If
    End Sub

    Private Sub cmbProductname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductname.SelectedIndexChanged

    End Sub

    Private Sub cmbProductname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProductname.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If

        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If
    End Sub

    Private Sub cmbBrandname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrandname.SelectedIndexChanged

    End Sub

    Private Sub cmbBrandname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBrandname.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If

        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

    End Sub

    Private Sub cmbCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If

        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        If txtPrice.Text = "" Then Exit Sub

        Dim value As Decimal = 0
        If Decimal.TryParse(txtPrice.Text, value) Then
            If value > 1000 Then
                ' If user somehow exceeds 1000, correct it immediately
                txtPrice.Text = "1000"
                txtPrice.SelectionStart = txtPrice.Text.Length ' Move cursor to end
            End If
        Else
            ' If invalid input, reset
            txtPrice.Text = "0"
            txtPrice.SelectionStart = txtPrice.Text.Length
        End If
    End Sub


    Private Sub txtPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If

        If e.KeyCode = Keys.Enter Then
            btnUpdateProduct.PerformClick()
            e.SuppressKeyPress = True ' Optional: prevents ding sound
        End If
    End Sub
End Class
