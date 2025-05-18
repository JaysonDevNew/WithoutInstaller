Public Class inventory
    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        MaintenanceForm.Show()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ProductForm.Show()
    End Sub

    Private Sub btnStockEntry_Click(sender As Object, e As EventArgs) Handles btnStockEntry.Click
        StockEntry.Show()
    End Sub

    Private Sub btnStockAdjust_Click(sender As Object, e As EventArgs) Handles btnStockAdjust.Click
        StockAdjustment.Show()
    End Sub
End Class