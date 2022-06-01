<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecipeGUI.aspx.cs" Inherits="GUI_Web.RecipeGUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous"/>
    <style type="text/css">
        .auto-style3 {
            width: 587px;
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

        .auto-style7 {
            width: 138px;
        }

    </style>
</head>
<body style="background-color: #83d8fe;">
    <nav class="navbar navbar-dark bg-dark">
        <ul >
            <li> <h4>SELL MANAGER</h4></li>
            <li ><a class="text" href="UserGUI.aspx">USER</a></li>
            <li ><a class="text" href="ProductGUI.aspx">PRODUCT</a></li>
            <li ><a class="text" href="RecipeGUI.aspx">RECIPE</a></li>
        </ul>        
    </nav>
    <form id="form1" runat="server" class="row g-3" style="max-width: 900px; margin: auto">
        <div class="row g-3">
            <div class="col">
                <asp:DropDownList ID="listUser" class="form-select" aria-label="Default select example" runat="server"></asp:DropDownList>
            </div>
            <div class="col">
                <asp:DropDownList ID="listProduct" class="form-select" aria-label="Default select example" runat="server"></asp:DropDownList>
            </div>          
        </div>
        <div class="row g-3 mb-4">
            <div class="col">
                <div class="form-floating" >
                  <asp:TextBox ID="txtAmount" runat="server" class="form-control" placeholder="Amount" style="max-height:50px" />
                  <label for="floatingInput">Amount</label>
                </div>
            </div>          
       </div>
             
           <div class="row ">
                <div class="col ">
                    <asp:Button ID="btnAdd" class="btn btn-success" style="padding:5px 30px; margin-left:15px" runat="server" Text="ADD" OnClick="btnAdd_Click"/>
                </div>                              
                <div class="col">
                  <asp:Button ID="btnDelete" class="btn btn-danger" style="padding:5px 30px; margin-left:15px" runat="server" Text="DELETE" OnClick="btnDelete_Click"/>
                </div>
               <div class="col">
                  <asp:Button ID="btnClear" class="btn btn-secondary" style="padding:5px 30px; margin-left:15px" runat="server" Text="CLEAR" OnClick="btnClear_Click"/>
                </div>
               <div class="col">
                  <asp:Button ID="btnFind" class="btn btn-secondary" style="padding:5px 30px; margin-left:15px" runat="server" Text="FIND" OnClick="btnFind_Click"/>
                </div>
          </div>   

        <div>
            <asp:Label ID="label" runat="server"></asp:Label>
        </div>
        
        <table style="width:100%;">
            <tr>
                <td class="auto-style7">                           
                    &nbsp;                         
                </td>
                <td class="auto-style3">           
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="RecipeId" HeaderText="ID" />
                            <asp:BoundField DataField="FullName" HeaderText="User Name" />
                            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                            <asp:BoundField DataField="Amounts" HeaderText="Amount" />
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" ForeColor="#003399" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SortedAscendingCellStyle BackColor="#EDF6F6" />
                        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                        <SortedDescendingCellStyle BackColor="#D6DFDF" />
                        <SortedDescendingHeaderStyle BackColor="#002876" />
                    </asp:GridView>
                </td>                
            </tr>            
        </table>
    </form>
</body>
</html>

