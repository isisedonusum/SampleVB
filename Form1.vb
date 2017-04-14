Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Client As ISISRIL.ReportInvoiceListClient
        Dim Request As ISISRIL.ContractsOutboundInvoiceListRequest
        Dim Result As List(Of ISISRIL.OutboxInvoiceHeader)
        Dim ea As ServiceModel.EndpointAddress
        Dim cb As ServiceModel.Channels.CustomBinding
        Dim transport As ServiceModel.Channels.HttpTransportBindingElement
        Dim textMessageEncoding As ServiceModel.Channels.TextMessageEncodingBindingElement

        TextBox5.Clear()

        ea = New ServiceModel.EndpointAddress(New Uri(txtURL.Text))
        cb = New ServiceModel.Channels.CustomBinding()

        textMessageEncoding = New ServiceModel.Channels.TextMessageEncodingBindingElement()
        textMessageEncoding.MessageVersion = ServiceModel.Channels.MessageVersion.Soap11
        cb.Elements.Add(textMessageEncoding)

        'HTTPS kontrolü
        If (txtURL.Text.Length > 5 And txtURL.Text.Substring(0, 5).ToLower() = "https") Then
            transport = New ServiceModel.Channels.HttpsTransportBindingElement()
        Else
            transport = New ServiceModel.Channels.HttpTransportBindingElement()
        End If
        transport.UseDefaultWebProxy = True
        transport.BypassProxyOnLocal = True

        If (txtPass.Text <> "") Then
            transport.AuthenticationScheme = Net.AuthenticationSchemes.Basic
        End If
        transport.MaxReceivedMessageSize = Integer.MaxValue

        cb.Elements.Add(transport)

        Client = New ISISRIL.ReportInvoiceListClient(cb, ea)
        If (txtPass.Text <> "") Then
            Client.ClientCredentials.UserName.UserName = txtUser.Text
            Client.ClientCredentials.UserName.Password = txtPass.Text
        End If

        Using scope As New ServiceModel.OperationContextScope(Client.InnerChannel)
            Dim httpRequestProperty As ServiceModel.Channels.HttpRequestMessageProperty

            httpRequestProperty = New ServiceModel.Channels.HttpRequestMessageProperty()

            httpRequestProperty.Headers(System.Net.HttpRequestHeader.Authorization) = "Basic " + _
            Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(Client.ClientCredentials.UserName.UserName + ":" + Client.ClientCredentials.UserName.Password))
            ServiceModel.OperationContext.Current.OutgoingMessageProperties(ServiceModel.Channels.HttpRequestMessageProperty.Name) = httpRequestProperty

            Request = New ISISRIL.ContractsOutboundInvoiceListRequest()
            Request.VKN = txtVKN.Text
            Request.Status = ISISRIL.EnumsOutboundStatus.ALL
            Request.BeginInvoiceDate = Date.Now.AddDays(-60)
            Request.EndInvoiceDate = Date.Now
            Request.BeginRecordDateTime = Date.Now.AddDays(-60)
            Request.EndRecordDateTime = Date.Now
            Request.RecordCount = 10
            Result = Client.OutboundInvoiceListByFilter(Request)

            TextBox5.AppendText(String.Format("{0} adet fatura bulundu.", Result.Count) & Environment.NewLine)
            For Each invoice In Result
                TextBox5.AppendText(invoice.ID & Environment.NewLine)
            Next

        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Client As ISISEA.ReceiverInvoicesClient
        Dim Request As List(Of ISISEA.Invoices)
        Dim Invoice As ISISEA.Invoices
        Dim Results As List(Of ISISEA.ReceiverInvoicesResult)
        Dim Result As ISISEA.ReceiverInvoicesResult
        Dim ea As ServiceModel.EndpointAddress
        Dim cb As ServiceModel.Channels.CustomBinding
        Dim transport As ServiceModel.Channels.HttpTransportBindingElement
        Dim textMessageEncoding As ServiceModel.Channels.TextMessageEncodingBindingElement

        TextBox5.Clear()

        ea = New ServiceModel.EndpointAddress(New Uri(txtURLeArchive.Text))
        cb = New ServiceModel.Channels.CustomBinding()

        textMessageEncoding = New ServiceModel.Channels.TextMessageEncodingBindingElement()
        textMessageEncoding.MessageVersion = ServiceModel.Channels.MessageVersion.Soap11
        cb.Elements.Add(textMessageEncoding)

        'HTTPS kontrolü
        If (txtURL.Text.Length > 5 And txtURL.Text.Substring(0, 5).ToLower() = "https") Then
            transport = New ServiceModel.Channels.HttpsTransportBindingElement()
        Else
            transport = New ServiceModel.Channels.HttpTransportBindingElement()
        End If
        transport.UseDefaultWebProxy = True
        transport.BypassProxyOnLocal = True

        If (txtPass.Text <> "") Then
            transport.AuthenticationScheme = Net.AuthenticationSchemes.Basic
        End If
        transport.MaxReceivedMessageSize = Integer.MaxValue

        cb.Elements.Add(transport)

        Client = New ISISEA.ReceiverInvoicesClient(cb, ea)
        If (txtPass.Text <> "") Then
            Client.ClientCredentials.UserName.UserName = txtUser.Text
            Client.ClientCredentials.UserName.Password = txtPass.Text
        End If

        Using scope As New ServiceModel.OperationContextScope(Client.InnerChannel)
            Dim httpRequestProperty As ServiceModel.Channels.HttpRequestMessageProperty

            httpRequestProperty = New ServiceModel.Channels.HttpRequestMessageProperty()

            httpRequestProperty.Headers(System.Net.HttpRequestHeader.Authorization) = "Basic " + _
            Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(Client.ClientCredentials.UserName.UserName + ":" + Client.ClientCredentials.UserName.Password))
            ServiceModel.OperationContext.Current.OutgoingMessageProperties(ServiceModel.Channels.HttpRequestMessageProperty.Name) = httpRequestProperty

            Request = New List(Of ISISEA.Invoices)

            Invoice = New ISISEA.Invoices()
            Invoice.ACParty = New ISISEA.Party() With {
                         .VKNTCKN = 11111111111L,
                         .Name = "Beyan Edilmedi"
                    }
            Invoice.SendType = "KAGIT"
            Invoice.CurrencyCode = "TRY"
            Invoice.InvoiceID = "GIB2017000000001"
            Invoice.InvoiceDateTime = Now

            Invoice.ReservedDate = Now

            Invoice.StatusProcessID = "C"

            Request.Add(Invoice)

            Results = Client.SendInvoices(txtVKN.Text, Request)

            TextBox5.AppendText(String.Format("{0} adet fatura gönderildi.", Results.Count) & Environment.NewLine)
            For Each Result In Results
                TextBox5.AppendText(Result.InvoiceID & Environment.NewLine)
            Next

        End Using

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Client As ISISEASY.EasyClient
        Dim Result As ISISEASY.ContractsResponseType
        Dim ea As ServiceModel.EndpointAddress
        Dim cb As ServiceModel.Channels.CustomBinding
        Dim transport As ServiceModel.Channels.HttpTransportBindingElement
        Dim textMessageEncoding As ServiceModel.Channels.TextMessageEncodingBindingElement
        Dim direction As ISISEASY.ContractsDirectionType


        TextBox5.Clear()

        ea = New ServiceModel.EndpointAddress(New Uri(txtURLEasy.Text))
        cb = New ServiceModel.Channels.CustomBinding()

        textMessageEncoding = New ServiceModel.Channels.TextMessageEncodingBindingElement()
        textMessageEncoding.MessageVersion = ServiceModel.Channels.MessageVersion.Soap11
        cb.Elements.Add(textMessageEncoding)

        'HTTPS kontrolü
        If (txtURL.Text.Length > 5 And txtURL.Text.Substring(0, 5).ToLower() = "https") Then
            transport = New ServiceModel.Channels.HttpsTransportBindingElement()
        Else
            transport = New ServiceModel.Channels.HttpTransportBindingElement()
        End If
        transport.UseDefaultWebProxy = True
        transport.BypassProxyOnLocal = True

        If (txtPass.Text <> "") Then
            transport.AuthenticationScheme = Net.AuthenticationSchemes.Basic
        End If
        transport.MaxReceivedMessageSize = Integer.MaxValue

        cb.Elements.Add(transport)

        Client = New ISISEASY.EasyClient(cb, ea)
        If (txtPass.Text <> "") Then
            Client.ClientCredentials.UserName.UserName = txtUser.Text
            Client.ClientCredentials.UserName.Password = txtPass.Text
        End If

        If (ComboBox1.SelectedText = "Gelen") Then
            direction = ISISEASY.ContractsDirectionType.INBOUND
        Else
            direction = ISISEASY.ContractsDirectionType.OUTBOUND
        End If

        Using scope As New ServiceModel.OperationContextScope(Client.InnerChannel)
            Dim httpRequestProperty As ServiceModel.Channels.HttpRequestMessageProperty

            httpRequestProperty = New ServiceModel.Channels.HttpRequestMessageProperty()

            httpRequestProperty.Headers(System.Net.HttpRequestHeader.Authorization) = "Basic " + _
            Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(Client.ClientCredentials.UserName.UserName + ":" + Client.ClientCredentials.UserName.Password))
            ServiceModel.OperationContext.Current.OutgoingMessageProperties(ServiceModel.Channels.HttpRequestMessageProperty.Name) = httpRequestProperty

            Result = Client.GetStatus(txtVKN.Text, direction, txtETTN.Text)

            TextBox5.AppendText(String.Format("Fatura {0} için:", txtETTN.Text) & Environment.NewLine)
            TextBox5.AppendText(String.Format("  Durumu: {0}", Result.Status.ToString()) & Environment.NewLine)
            TextBox5.AppendText(String.Format("  Fatura no: {0}", Result.ID) & Environment.NewLine)
            TextBox5.AppendText(String.Format("  Fatura türü: {0}", Result.Profile.ToString()) & Environment.NewLine)
            TextBox5.AppendText(String.Format("  Zarf no: {0}", Result.EnvelopeUUID) & Environment.NewLine)
            TextBox5.AppendText(String.Format("  Ticari cevap: {0}", Result.CommercialResponse) & Environment.NewLine)
            TextBox5.AppendText(String.Format("  Zarf GIB durumu: {0}", Result.GIBCode) & Environment.NewLine)
            TextBox5.AppendText("------------------------------")

        End Using
    End Sub
End Class
