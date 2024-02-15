<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calcolatore Preventivo Auto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Preventivo Auto</h1>

            <asp:DropDownList ID="ddlAuto" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAuto_SelectedIndexChanged">
                <asp:ListItem Text="Fiat Panda" Value="FiatPanda" />
                <asp:ListItem Text="Ford Fiesta" Value="FordFiesta" />
                <asp:ListItem Text="Audi Q3" Value="AudiQ3" />
                <asp:ListItem Text="Lamborghini Urus" Value="LamborghiniUrus" />
            </asp:DropDownList>

            <br />

            <asp:Image ID="imgAuto" runat="server" Width="200px" Height="150px" />

            <br />

            <h3>Optional:</h3>
            <asp:CheckBox ID="chkFinestrini" runat="server" Text="Finestrini automatici (EUR 100)" />
            <br />
            <asp:CheckBox ID="chkCerchi" runat="server" Text="Cerchi in lega (EUR 250)" />
            <br />
            <asp:CheckBox ID="chkStereo" runat="server" Text="Stereo integrato (EUR 500)" />

            <br />
            <br />

            <h3>Garanzia (EUR 120/anno):</h3>
            <asp:TextBox ID="txtGaranzia" runat="server"></asp:TextBox> anni

            <br />
            <br />

            <asp:Button ID="btnCalcola" runat="server" Text="Calcola Preventivo" OnClick="btnCalcola_Click" />

            <br />
            <br />

            <h3>Risultati:</h3>
            <p>Prezzo di base: <asp:Label ID="lblPrezzoBase" runat="server" Text=""></asp:Label></p>
            <p>Totale Optional: <asp:Label ID="lblTotaleOptional" runat="server" Text=""></asp:Label></p>
            <p>Totale Garanzia: <asp:Label ID="lblTotaleGaranzia" runat="server" Text=""></asp:Label></p>
            <p>Totale Complessivo: <asp:Label ID="lblTotaleComplessivo" runat="server" Text=""></asp:Label></p>

        </div>
    </form>
</body>
</html>

