<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductGUI.aspx.cs" Inherits="GUI_Web.ProductGUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <style type="text/css">
        .auto-style3 {
            width: 587px;
        }
        .auto-style4 {
            width: 553px;
        }

        li {
            color:#ffffff; 
            display:inline-block;
            margin-top: 15px;
            margin-left:50px;
        }

        a {
            color:#ffffff; 
            text-decoration:none;
        }

    </style>
</head>
<body style="background-color: #83d8fe;">
    <nav class="navbar navbar-dark bg-dark">
        <ul >
            <li> <h4>SELL MANAGER</h4></li>
            <li ><a class="text" href="UserGUI.aspx">USER</a></li>
            <li ><a class="text" href="RecipeGUI.aspx">RECIPE</a></li>
        </ul>        
    </nav>
    <form id="form1" runat="server" class="row g-3" style="max-width: 900px; margin: auto">
        <div class="row g-3">
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtProductName" runat="server" class="form-control" placeholder="Product Name" style="max-height:50px" />
                  <label for="floatingInput">Product Name</label>
                </div>
            </div>
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtOrigin" runat="server" class="form-control" placeholder="Origin" style="max-height:50px" />
                  <label for="floatingInput">Origin</label>
                </div>
            </div>
        </div>
        <div class="row g-3 mb-4">
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtAmount" runat="server" class="form-control" placeholder="Amount" style="max-height:50px" />
                  <label for="floatingInput">Amount</label>
                </div>
            </div>
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtPrice" runat="server" class="form-control" placeholder="Price" style="max-height:50px" />
                  <label for="floatingInput">Price</label>
                </div>
            </div>
       </div>                      
       
           <div class="row ">
                <div class="col ">
                    <asp:Button ID="btnAdd" class="btn btn-success" style="padding:5px 30px; margin-left:15px" runat="server" Text="ADD" OnClick="btnAdd_Click1" />
                </div>
                <div class="col">
                    <asp:Button ID="btnEdit" class="btn btn-warning" style="padding:5px 30px; margin-left:15px" runat="server" Text="EDIT" OnClick="btnEdit_Click1" />
                </div>
                <div class="col">
                  <asp:Button ID="btnDelete" class="btn btn-danger" style="padding:5px 30px; margin-left:15px" runat="server" Text="DELETE" OnClick="btnDelete_Click1"/>
                </div>
               <div class="col">
                  <asp:Button ID="btnClear" class="btn btn-secondary" style="padding:5px 30px; margin-left:15px" runat="server" Text="CLEAR" OnClick="btnClear_Click1" />
                </div>
               <div class="col">
                  <asp:Button ID="btnFind" class="btn btn-info" style="padding:5px 30px; margin-left:15px" runat="server" Text="FIND" OnClick="btnFind_Click1" />
                </div>
          </div>   

        <div>
            <asp:Label ID="label" runat="server"></asp:Label>
        </div>
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">   
      
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:BoundField DataField="ProductID" HeaderText="ID" />
                            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                            <asp:BoundField DataField="Origin" HeaderText="Origin" />
                            <asp:BoundField DataField="Amount" HeaderText="Amount" />
                            <asp:BoundField DataField="Price" HeaderText="Price" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
      
                </td>
                <td class="auto-style3">           
                    &nbsp;
                </td>                
            </tr>            
        </table>
    </form>
</body>
</html>
