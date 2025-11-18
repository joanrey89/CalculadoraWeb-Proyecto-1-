<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WeBcalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Calculadora</title>
    <link href="css/Estilo1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="disenodemarco"> 
        <div>
            <h1>Calculadora</h1>
        </div>

        
        <div >
             <asp:Label ID="lresultado" runat="server" Font-Size="XX-Large" ForeColor="#b384b8"></asp:Label>
            <br />
            <asp:Button ID="b7" class="button button2" Text="7" runat="server" OnClick="b7_Click" />
            <asp:Button ID="b8" class="button button2" Text="8" runat="server" OnClick="b8_Click" />
            <asp:Button ID="b9" class="button button2" Text="9" runat="server" OnClick="b9_Click" />

        </div>
         
        <div >
            <asp:Button ID="b4" class="button button2" Text="4" runat="server" OnClick="b4_Click" />
            <asp:Button ID="b5" class="button button2" Text="5" runat="server" OnClick="b5_Click" />
            <asp:Button ID="b6" class="button button2" Text="6" runat="server" OnClick="b6_Click" />
        </div>
            <div >
            <asp:Button ID="b1" class="button button2" Text="1" runat="server" OnClick="b1_Click" />
            <asp:Button ID="b2" class="button button2" Text="2" runat="server" OnClick="b2_Click" />
            <asp:Button ID="b3" class="button button2" Text="3" runat="server" OnClick="b3_Click" />

        </div>
            <asp:Button ID="bclear" class="button button5" Text="C" runat="server" OnClick="bclear_Click" />
            <asp:Button ID="Button1" class="button button2" Text="0" runat="server" OnClick="b0_Click" />
            <asp:Button ID="bresultado" class="button button4" Text="=" runat="server" OnClick="bresultado_Click" />
        </div>
        </div>
           
        <div>
            <asp:Button ID="bsuma" class="button button3" Text="+" runat="server" OnClick="bsuma_Click" Width="90px"/>
            <asp:Button ID="bresta"  class="button button3" Text="-" runat="server" OnClick="bresta_Click" Width="82px" />
            <asp:Button ID="bmulti" class="button button3" Text="x" runat="server" OnClick="bmulti_Click" Width="89px" />
            <asp:Button ID="bdivi"  class="button button3" Text="/" runat="server" OnClick="bdivi_Click" Width="88px"/>
            

        </div>
        <div>
            <asp:Button ID="bpotencia2" class="button button3" Text="2^" runat="server" OnClick="bpotencia2_Click"/>
            <asp:Button ID="bpotencia3"  class="button button3" Text="3^" runat="server" OnClick="bpotencia3_Click" />
            <asp:Button ID="braiz" class="button button3" Text="√" runat="server" OnClick="braiz_Click"/>
            <asp:Button ID="bfactorial" class="button button3" Text="n!" runat="server" OnClick="bfactorial_Click"/>

        </div>
        <div>
            <asp:Button ID="bfibonachi" class="button button3" Text="Fⁿ" runat="server" OnClick="bfibonachi_Click"/>
        </div>
         

            </div>





    </form>
</body>
</html>
