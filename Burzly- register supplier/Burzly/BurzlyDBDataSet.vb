Partial Class BurzlyDBDataSet
    Partial Class PaymentDataTable

        Private Sub PaymentDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.paymentIdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class SupplierDataTable

        Private Sub SupplierDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.supIdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class EmployeeDataTable

        Private Sub EmployeeDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.empIdColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
