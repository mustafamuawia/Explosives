Partial Class dsExplosives
    Partial Class ImportPermissionDetailsDataTable

        Private Sub ImportPermissionDetailsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ImportPermissionsDetailIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class


End Class


Namespace dsExplosivesTableAdapters
    
    Partial Class FireworksRequestsTableAdapter

    End Class

    Partial Public Class PERMISSIONSTableAdapter
    End Class
End Namespace
