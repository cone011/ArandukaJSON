Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
            saveFileDialog1.Filter = "Texto|*.txt"
            saveFileDialog1.Title = "Guardar Archivo"
            Dim resultado = saveFileDialog1.ShowDialog(Me)
            If resultado = Windows.Forms.DialogResult.OK Then
                ''Guarda el camino donde va a ser creado el archivo txt
                Dim filepath As String = saveFileDialog1.FileName
                If Not System.IO.File.Exists(filepath) Then
                    System.IO.File.Create(filepath).Dispose()
                End If
                'Dim file As New System.IO.StreamWriter(filepath, True, System.Text.Encoding.ASCII)  --Para el banco es UTF-8
                'Dim file As New System.IO.StreamWriter(filepath, True, System.Text.Encoding.Default)
                'file = My.Computer.FileSystem.OpenTextFileWriter(filepath, True)

                ''Que tipo de planilla se va a generar en txt
                Select Case TipoOperacionInforme
                    Case TI_RECURSOSHUMANOS
                        Select Case TipoInforme
                            Case RECURSOSHUMANOS_PLANILLA_ACREDITACION_SALARIO
                                Dim listaAcreditacionSalario As List(Of Business.InformePlanillaAcreditacionSalario) = BindingSource1.DataSource
                                For Each objetoAuxiliar As Business.InformePlanillaAcreditacionSalario In listaAcreditacionSalario
                                    Dim file As New System.IO.StreamWriter(filepath, True, System.Text.Encoding.ASCII)
                                    file.WriteLine(objetoAuxiliar.CuentaBancaria + objetoAuxiliar.ImporteNeto + objetoAuxiliar.Tipo + objetoAuxiliar.FechaAcreditacion)
                                    file.Close()
                                Next
                            Case RECURSOSHUMANOS_PLANILLA_IPS_INFORMADO
                                Dim listaPlanillaIps As List(Of Business.InformePlanillaIps) = BindingSource1.DataSource
                                For Each objetoAuxiliar As Business.InformePlanillaIps In listaPlanillaIps
                                    Dim file As New System.IO.StreamWriter(filepath, True, System.Text.Encoding.Default)
                                    file.WriteLine(objetoAuxiliar.NroPatronalFormateado + objetoAuxiliar.NroAseguradoFormateado + objetoAuxiliar.CedulaFormateado + objetoAuxiliar.ApellidosFormateado + objetoAuxiliar.NombresFormateado + objetoAuxiliar.Categoria + objetoAuxiliar.DiasTrabajadosFormato + objetoAuxiliar.SalarioImponibleFormateado + objetoAuxiliar.MesAñoFormateado + objetoAuxiliar.CodigoActividadFormateado + objetoAuxiliar.SalarioRealFormateado)
                                    file.Close()
                                Next

                        End Select
                End Select