
''' <summary>
''' xucFondoFijo JC 2019/06/13
''' </summary>
''' <remarks></remarks>
Public Class xucFondoFijo

    Public Property listaFondoFijo As List(Of Business.FondoFijo)

    Public Property FondoFijoSeleccionado As Business.FondoFijo

    Public Property KeepSelectedItemVisible As Boolean = True

    Public Property EnableSearch As Boolean = True

    Public Event FondoFijoGotFocus()
    Public Event FondoFijoLostFocus()
    Public Event FondoFijoSeleccionadoEvent()

    Private EnterPressed As Boolean = False


    Private Sub PopupContainerEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles PopupContainerEdit1.ButtonClick
        Try
            Me.PopupContainerEdit1.EditValue = Nothing
            Me.FondoFijoSeleccionado = Nothing
            Me.FondoFijoBindingSource.Clear()
            RaiseEvent FondoFijoSeleccionadoEvent()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PopupContainerEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PopupContainerEdit1.EditValueChanged

    End Sub

    Private Sub PopupContainerEdit1_GotFocus(sender As Object, e As EventArgs) Handles PopupContainerEdit1.GotFocus
        RaiseEvent FondoFijoGotFocus()
    End Sub

    Private Sub PopupContainerEdit1_LostFocus(sender As Object, e As EventArgs) Handles PopupContainerEdit1.LostFocus
        RaiseEvent FondoFijoLostFocus()
    End Sub

    Private Sub PopupContainerEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles PopupContainerEdit1.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Down
                    e.Handled = True
                    If FondoFijoBindingSource.Count > 0 Then
                        Me.GridView1.Focus()
                        Me.GridView1.FocusedRowHandle = 0
                    End If
                Case Keys.Enter
                    Try
                        e.Handled = True
                        EnterPressed = True
                        If PopupContainerEdit1.Text.ToString.Length >= 3 Then
                            If Not BackgroundWorker1.IsBusy Then
                                BackgroundWorker1.RunWorkerAsync()
                            Else
                                While BackgroundWorker1.IsBusy
                                    BackgroundWorker1.CancelAsync()
                                End While
                                BackgroundWorker1.RunWorkerAsync()
                            End If
                        Else
                            Me.PopupContainerEdit1.ClosePopup()
                        End If
                    Catch ex As Exception
                    End Try
            End Select
        Catch ex As Exception
        End Try
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            If EnableSearch Then
                listaFondoFijo = New Business.FondoFijoDAO().getAllBusquedaFondoFijo(PopupContainerEdit1.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            Me.FondoFijoBindingSource.DataSource = listaFondoFijo
            If FondoFijoBindingSource.Count = 1 Then
                If EnterPressed AndAlso listaFondoFijo(0).Descripcion = PopupContainerEdit1.EditValue Then
                    Me.GridView1.FocusedRowHandle = 0
                    Me.FondoFijoSeleccionado = CType(FondoFijoBindingSource.Current, Business.FondoFijo)
                    If Not KeepSelectedItemVisible Then
                        Me.PopupContainerEdit1.EditValue = Nothing
                    Else
                        EnableSearch = True
                        Me.PopupContainerEdit1.EditValue = Me.FondoFijoSeleccionado.Descripcion
                    End If
                    Me.PopupContainerEdit1.ClosePopup()
                    RaiseEvent FondoFijoSeleccionadoEvent()
                    Application.DoEvents()
                    EnableSearch = True
                Else
                    If Not PopupContainerEdit1.IsPopupOpen Then
                        Me.PopupContainerEdit1.ShowPopup()
                    End If
                    Me.GridView1.BestFitColumns()
                    Me.PopupContainerEdit1.Focus()
                End If
            ElseIf FondoFijoBindingSource.Count > 1 Then
                If Not PopupContainerEdit1.IsPopupOpen Then
                    Me.PopupContainerEdit1.ShowPopup()
                End If
                Me.GridView1.BestFitColumns()
                Me.PopupContainerEdit1.Focus()
            End If
            EnterPressed = True
        Catch ex As Exception
        End Try
    End Sub


    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    e.Handled = True
                    Try
                        Me.FondoFijoSeleccionado = CType(FondoFijoBindingSource.Current, Business.FondoFijo)
                        If Not KeepSelectedItemVisible Then
                            Me.PopupContainerEdit1.Text = Nothing
                        Else
                            EnableSearch = True
                            Me.PopupContainerEdit1.Text = Me.FondoFijoSeleccionado.Descripcion
                        End If

                        RaiseEvent FondoFijoSeleccionadoEvent()
                        Application.DoEvents()
                        EnableSearch = True
                        Me.PopupContainerEdit1.ClosePopup()
                        PopupContainerEdit1.SelectAll()
                        Application.DoEvents()
                    Catch ex As Exception
                    End Try
            End Select
        Catch ex As Exception
        End Try
    End Sub



End Class
